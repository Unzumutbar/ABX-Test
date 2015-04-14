using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Simple_ABX_test.Objects;

namespace Simple_ABX_test.Forms
{
    public partial class ConfigureNewTest : Form
    {
        public AbxTest newAbxTest = new AbxTest();

        public ConfigureNewTest()
        {
            InitializeComponent();
        }

        public ConfigureNewTest(AbxTest abxTest)
        {
            InitializeComponent();
            if (abxTest == null)
                return;

            newAbxTest.SoundFileA = abxTest.SoundFileA;
            newAbxTest.SoundFileB = abxTest.SoundFileB;
            textBoxSoundFileOne.Text = newAbxTest.SoundFileA;
            textBoxSoundFileTwo.Text = newAbxTest.SoundFileB;
        }

        private void buttonSearchSoundOne_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textBoxSoundFileOne.Text = openFileDialog.FileName;
        }

        private void buttonSearchSoundTwo_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                textBoxSoundFileTwo.Text = openFileDialog.FileName;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (!CanContinue())
                return;

            ShuffleSoundFiles();

            newAbxTest.SubjectName = textBoxSubjectName.Text;
            newAbxTest.SoundFileA = textBoxSoundFileOne.Text;
            newAbxTest.SoundFileB = textBoxSoundFileTwo.Text;
            newAbxTest.Date = DateTime.Now;
            newAbxTest.Results = new List<Result>();
            newAbxTest.Score = 0;

            newAbxTest.CreateFile();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void ShuffleSoundFiles()
        {
            Random rand = new Random();
            if (rand.Next(0, 2) == 0)
            {
                string switchSave = textBoxSoundFileOne.Text;
                textBoxSoundFileOne.Text = textBoxSoundFileTwo.Text;
                textBoxSoundFileTwo.Text = switchSave;
            }
        }

        private void HideAlerts()
        {
            pictureAlertSoundOne.Visible = false;
            pictureAlertSoundTwo.Visible = false;
            pictureAlertSubjectName.Visible = false;
        }

        private bool CanContinue()
        {
            bool error = false;
            HideAlerts();

            if (string.IsNullOrEmpty(textBoxSoundFileOne.Text) || !File.Exists(textBoxSoundFileOne.Text))
            {
                pictureAlertSoundOne.Visible = true;
                error = true;
            }

            if (string.IsNullOrEmpty(textBoxSoundFileTwo.Text) || !File.Exists(textBoxSoundFileTwo.Text))
            {
                pictureAlertSoundTwo.Visible = true;
                error = true;
            }

            if (string.IsNullOrEmpty(textBoxSubjectName.Text))
            {
                pictureAlertSubjectName.Visible = true;
                error = true;
            }

            return !error;
        }
    }
}
