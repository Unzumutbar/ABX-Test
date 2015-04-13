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
            ShowAllButtons(false);
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

        private void buttonPlayA_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Stop();
            _mediaPlayer.Close();
            _mediaPlayer.Open(_soundFileA);
            _mediaPlayer.Play();
        }

        private void buttonPlayB_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Stop();
            _mediaPlayer.Close();
            _mediaPlayer.Open(_soundFileB);
            _mediaPlayer.Play();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Stop();
            _mediaPlayer.Close();
            _mediaPlayer.Open(_currentSoundFile);
            _mediaPlayer.Play();

            EnableSelectButtons(true);
        }


        private void buttonSelectA_Click(object sender, EventArgs e)
        {
            TestAnswerSelected("A");
        }

        private void buttonSelectB_Click(object sender, EventArgs e)
        {
            TestAnswerSelected("B");
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

            if (_currentTestNumber < Program.Settings.NumberOfTests)
                NextTest();
            else
            {
                buttonNewTest.Enabled = true;
                ShowAllButtons(false);
                ShowResults();
            }
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

        private void NextTest()
        {
            _currentTestNumber++;
            labelTestNumber.Text = string.Format("TestNr. {0} / {1}", _currentTestNumber, Program.Settings.NumberOfTests);
            EnableSelectButtons(false);
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
            CreateNewTest();
        }

        private void CreateNewTest()
        {
            if (string.IsNullOrEmpty(Program.Settings.SoundFileOne) || !File.Exists(Program.Settings.SoundFileOne) ||
                string.IsNullOrEmpty(Program.Settings.SoundFileTwo) || !File.Exists(Program.Settings.SoundFileTwo))
            {
                ShowFileNotFoundMessage();
                return;
            }

            _mediaPlayer.Stop();
            _mediaPlayer.Close();
            _mediaPlayer.Repeat = false;
            _currentTestNumber = 0;
            _currentSoundFile = string.Empty;
            _currentResultFile = string.Empty;
            _probandName = PromptHelper.ShowDialog("Bitte geben sie Ihren Namen ein", "Namen eingeben");

            EnableMenuBar(false);

            ShuffleSoundFiles();
            testResults = new List<TestResult>();
            _currentResultFile = XMLHelper.CreateResultsFile(_probandName);
            ShowAllButtons(true);

            NextTest();
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

        private void EnableMenuBar(bool isEnabled)
        {
            buttonShowResults.Enabled = isEnabled;
            buttonShowSettings.Enabled = isEnabled;
            buttonNewTest.Enabled = isEnabled;
            buttonToggleLock.Visible = !isEnabled;
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

        private void ShowAllButtons(bool isVisible)
        {
            buttonPlayA.Visible = isVisible;
            buttonPlayB.Visible = isVisible;
            buttonPlayX.Visible = isVisible;

            buttonSelectB.Visible = isVisible;
            buttonSelectA.Visible = isVisible;

            labelPlayA.Visible = isVisible;
            labelPlayB.Visible = isVisible;
            labelPlayX.Visible = isVisible;
            labelTestNumber.Visible = isVisible;
        }

        private void EnableSelectButtons (bool isEnabled)
        {
            buttonSelectA.Enabled = isEnabled;
            buttonSelectB.Enabled = isEnabled;
        }
    }
}
