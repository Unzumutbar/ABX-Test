using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using Simple_ABX_test.Objects;
using Simple_ABX_test.Helper;
using Simple_ABX_test.Forms;

namespace Simple_ABX_test
{
    public partial class TestForm : Form
    {
        private List<TestResult> testResults;
        private string _correctAnswer;
        private string _soundFileA;
        private string _soundFileB;
        private int _currentTestNumber = 0;
        private string _currentSoundFile;
        private string _currentResultFile;
        private string _probandName;

        private EditSettings EditSettingsForm;
        private ShowResult ShowResultForm;
        private ShowResults ShowResultsForm;
        private MediaControl.AudioPlayer _mediaPlayer = new MediaControl.AudioPlayer();

        public TestForm()
        {
            InitializeComponent();
        }

        public void ShuffleSoundFiles()
        {
            Random rand = new Random();
            if (rand.Next(0, 2) == 0)
            {
                _soundFileA = Program.Settings.SoundFileOne;
                _soundFileB = Program.Settings.SoundFileTwo;
            }
            else
            {
                _soundFileA = Program.Settings.SoundFileTwo;
                _soundFileB = Program.Settings.SoundFileOne;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if(_currentTestNumber == 0)
            {
                _mediaPlayer.Stop();
                _mediaPlayer.Close();
                _mediaPlayer.Open(_soundFileB);
                _mediaPlayer.Play();
            }
            else
                TestAnswerSelected("B");
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (_currentTestNumber == 0)
            {
                _mediaPlayer.Stop();
                _mediaPlayer.Close();
                _mediaPlayer.Open(_soundFileA);
                _mediaPlayer.Play();
            }
            else
                TestAnswerSelected("A");
        }

        private void TestAnswerSelected(string selectedAnswer)
        {
            _mediaPlayer.Stop();
            var testResult = new TestResult() {
                TestNumber = _currentTestNumber,
                SelectedAnswer = selectedAnswer,
                CorrectAnswer = _correctAnswer };
            testResults.Add(testResult);

            XMLHelper.AddResult(testResult, _currentResultFile);

            buttonNext.Visible = true;
            buttonA.Visible = false;
            buttonB.Visible = false;
            buttonReplay.Visible = false;
            labelSourceA.Visible = false;
            labelSourceB.Visible = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (_currentTestNumber < Program.Settings.NumberOfTests)
            {
                buttonNext.Visible = false;
                buttonA.Visible = true;
                buttonB.Visible = true;
                labelSourceA.Visible = true;
                labelSourceA.Text = "Sound A auswählen:";
                labelSourceB.Visible = true;
                labelSourceB.Text = "Sound B auswählen:";

                if (!Program.Settings.LoopSound)
                    buttonReplay.Visible = true;

                StartNextTest();
            }
            else
                ShowResults();
        }

        private void ShowResults()
        {
            decimal score = testResults.Count(c => c.Passed);
            decimal count = testResults.Count();
            score = score / count;
            XMLHelper.UpdateTestScore(score, _currentResultFile);

            if (ShowResultForm == null || (ShowResultForm.IsDisposed))
            {
                ShowResultForm = new ShowResult() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
            }
            ShowResultForm.UpdateList(_probandName, testResults, score);
            ShowResultForm.Show();
        }

        private void StartNextTest()
        {
            _currentTestNumber++;
            if (_currentTestNumber == Program.Settings.NumberOfTests)
                buttonNext.Text = "Ergebnis";
            else
                buttonNext.Text = "Weiter";

            Random rand = new Random();
            if (rand.Next(0, 2) == 0)
            {
                _currentSoundFile = _soundFileA;
                _correctAnswer = "A";
            }
            else
            {
                _currentSoundFile = _soundFileB;
                _correctAnswer = "B";
            }
            _mediaPlayer.Close();
            _mediaPlayer.Open(_currentSoundFile);
            _mediaPlayer.Play();

        }

        private void buttonShowSettings_Click(object sender, EventArgs e)
        {
            if (EditSettingsForm == null || (EditSettingsForm.IsDisposed))
            {
                EditSettingsForm = new EditSettings() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
            }
            EditSettingsForm.Show();
        }

        private void buttonNewTest_Click(object sender, EventArgs e)
        {
            ResetTest();
        }

        private void ResetTest()
        {
            if (string.IsNullOrEmpty(Program.Settings.SoundFileOne) || !File.Exists(Program.Settings.SoundFileOne) ||
                string.IsNullOrEmpty(Program.Settings.SoundFileTwo) || !File.Exists(Program.Settings.SoundFileTwo))
            {
                ShowFileNotFoundMessage();
                return;
            }

            _mediaPlayer.Stop();
            _mediaPlayer.Close();
            _mediaPlayer.Repeat = Program.Settings.LoopSound;
            _currentTestNumber = 0;
            _currentSoundFile = string.Empty;
            _currentResultFile = string.Empty;
            _probandName = PromptHelper.ShowDialog("Bitte geben sie Ihren Namen ein", "Namen eingeben");

            buttonNext.Visible = true;
            buttonA.Visible = true;
            buttonB.Visible = true;
            labelSourceA.Visible = true;
            labelSourceA.Text = "Sound A abspielen:";
            labelSourceB.Visible = true;
            labelSourceB.Text = "Sound B abspielen:";

            EnableMenuBar(false);

            buttonNext.Text = "Start";

            ShuffleSoundFiles();
            testResults = new List<TestResult>();
            _currentResultFile = XMLHelper.CreateResultsFile(_probandName);
        }

        private void ShowFileNotFoundMessage()
        {
            if ((string.IsNullOrEmpty(Program.Settings.SoundFileOne) || !File.Exists(Program.Settings.SoundFileOne)) &&
                (string.IsNullOrEmpty(Program.Settings.SoundFileTwo) || !File.Exists(Program.Settings.SoundFileTwo)))
                MessageBox.Show("Die Sounddateien konnten nicht gefunden werden.\n Bitte prüfen Sie unter Einstellungen ob die Pfade korrekt sind.", "Sounddateien nicht gefunden");

            else if (string.IsNullOrEmpty(Program.Settings.SoundFileOne) || !File.Exists(Program.Settings.SoundFileOne))
                MessageBox.Show("Die Sounddatei 1 konnten nicht gefunden werden.\n Bitte prüfen Sie unter Einstellungen ob der eingegebene Pfad korrekt ist.", "Sounddatei 1 nicht gefunden");

            else if (string.IsNullOrEmpty(Program.Settings.SoundFileTwo) || !File.Exists(Program.Settings.SoundFileTwo))
                MessageBox.Show("Die Sounddatei 2 konnten nicht gefunden werden.\n Bitte prüfen Sie unter Einstellungen ob der eingegebene Pfad korrekt ist.", "Sounddatei 2 nicht gefunden");
        }

        private void buttonReplay_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Stop();
            _mediaPlayer.Play();
        }

        private void EnableMenuBar(bool enable)
        {
            buttonShowResults.Enabled = enable;
            buttonShowSettings.Enabled = enable;
            buttonNewTest.Enabled = enable;
            buttonToggleLock.Visible = !enable;
        }

        private void buttonToggleLock_Click(object sender, EventArgs e)
        {
            if (PromptHelper.ShowPasswordDialog("Bitte Administrator-Passwort eingeben", "Passworteingabe") == Program.Settings.AdminPassword)
                EnableMenuBar(true);
        }

        private void buttonShowResults_Click(object sender, EventArgs e)
        {
            if (ShowResultsForm == null || (ShowResultsForm.IsDisposed))
            {
                ShowResultsForm = new ShowResults() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
            }
            ShowResultsForm.UpdateList();
            ShowResultsForm.Show();
        }
    }
}
