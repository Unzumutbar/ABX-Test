using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Simple_ABX_test.Objects;
using Simple_ABX_test.Helper;
using Simple_ABX_test.Forms;
using MediaControl;

namespace Simple_ABX_test
{
    public partial class TestForm : Form
    {
        private AbxTest _currentAbxTest;
        private string _correctAnswer;
        private int _currentTestNumber;
        private string _currentSoundFile;

        private EditSettings EditSettingsForm;
        private ShowResult ShowResultForm;
        private ShowResults ShowResultsForm;
        private AudioPlayer _mediaPlayer = new AudioPlayer();

        public TestForm()
        {
            InitializeComponent();
            ShowAllButtons(false);
        }


        private void buttonPlayA_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Stop();
            _mediaPlayer.Close();
            _mediaPlayer.Open(_currentAbxTest.SoundFileA);
            _mediaPlayer.Play();
        }

        private void buttonPlayB_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Stop();
            _mediaPlayer.Close();
            _mediaPlayer.Open(_currentAbxTest.SoundFileB);
            _mediaPlayer.Play();
        }

        private void buttonPlayX_Click(object sender, EventArgs e)
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
            var testResult = new Result() {
                TestNumber = _currentTestNumber,
                SelectedAnswer = selectedAnswer,
                CorrectAnswer = _correctAnswer };

            _currentAbxTest.AddResult(testResult);

            if (_currentTestNumber < Program.Settings.NumberOfTests)
                NextTest();
            else
            {

                ShowAllButtons(false);
                EnableMenuBar(true);
                ShowResults();
            }
        }

        private void NextTest()
        {
            _currentTestNumber++;
            labelTestNumber.Text = string.Format("TestNr. {0} / {1}", _currentTestNumber, Program.Settings.NumberOfTests);
            EnableSelectButtons(false);
            Random rand = new Random();
            if (rand.Next(0, 2) == 0)
            {
                _currentSoundFile = _currentAbxTest.SoundFileA;
                _correctAnswer = "A";
            }
            else
            {
                _currentSoundFile = _currentAbxTest.SoundFileB;
                _correctAnswer = "B";
            }
            _mediaPlayer.Close();
            _mediaPlayer.Open(_currentSoundFile);
        }

        private void ShowResults()
        {
            decimal score = _currentAbxTest.Results.Count(c => c.Passed);
            decimal count = _currentAbxTest.Results.Count();
            _currentAbxTest.UpdateTestScore(score / count);

            if (ShowResultForm == null || (ShowResultForm.IsDisposed))
            {
                ShowResultForm = new ShowResult() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
            }
            ShowResultForm.UpdateList(_currentAbxTest);
            ShowResultForm.Show();
        }


        private void buttonNewTest_Click(object sender, EventArgs e)
        {
            CreateNewTest();
        }

        private void buttonShowSettings_Click(object sender, EventArgs e)
        {
            if (EditSettingsForm == null || (EditSettingsForm.IsDisposed))
            {
                EditSettingsForm = new EditSettings() { Owner = this, Location = new Point(this.Location.X + this.Width, this.Location.Y) };
            }
            EditSettingsForm.Show();
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

        private void buttonToggleLock_Click(object sender, EventArgs e)
        {
            if (PromptHelper.ShowPasswordDialog("Bitte Administrator-Passwort eingeben", "Passworteingabe") == Program.Settings.AdminPassword)
                EnableMenuBar(true);
        }


        private void CreateNewTest()
        {
            _mediaPlayer.Stop();
            _mediaPlayer.Close();

            var ConfigureTestDialog = new ConfigureNewTest(_currentAbxTest);
            if (ConfigureTestDialog.ShowDialog() != DialogResult.OK)
                return;

            _currentAbxTest = ConfigureTestDialog.newAbxTest;

            _mediaPlayer.Volume = 100;
            _mediaPlayer.Repeat = buttonLoop.Checked;
            _currentTestNumber = 0;
            _currentSoundFile = string.Empty;

            EnableMenuBar(false);
            ShowAllButtons(true);

            NextTest();
        }

        private void EnableMenuBar(bool isEnabled)
        {
            buttonShowResults.Enabled = isEnabled;
            buttonShowSettings.Enabled = isEnabled;
            buttonNewTest.Enabled = isEnabled;
            buttonToggleLock.Visible = !isEnabled;
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

            toolStrip.Visible = isVisible;
        }

        private void EnableSelectButtons (bool isEnabled)
        {
            buttonSelectA.Enabled = isEnabled;
            buttonSelectB.Enabled = isEnabled;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!buttonPlayX.Visible)
                return;

            Graphics g;
            g = e.Graphics;
            Pen myPen = new Pen(Color.LightGray);
            myPen.Width = 5;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var PointA = GetBottomMiddleOfButton(buttonPlayA);
            var PointB = GetBottomMiddleOfButton(buttonPlayB);
            var PointX = GetMiddleOfButton(buttonPlayX);

            g.DrawLine(myPen, PointA.X, PointA.Y, PointX.X, PointX.Y);
            g.DrawLine(myPen, PointB.X, PointB.Y, PointX.X, PointX.Y);
        }

        private Point GetBottomMiddleOfButton(Button button)
        {
            return new Point(button.Location.X + (button.Width / 2), button.Location.Y + (button.Height));
        }

        private Point GetTopMiddleOfButton(Button button)
        {
            return new Point(button.Location.X + (button.Width / 2), button.Location.Y);
        }

        private Point GetMiddleOfButton(Button button)
        {
            return new Point(button.Location.X + (button.Width / 2), button.Location.Y + (button.Height / 2));
        }

        private void buttonLoop_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Repeat = buttonLoop.Checked;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _mediaPlayer.Stop();
        }
    }
}
