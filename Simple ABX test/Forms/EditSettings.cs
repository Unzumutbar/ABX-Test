using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Simple_ABX_test.Helper;

namespace Simple_ABX_test
{
    public partial class EditSettings : Form
    {
        public EditSettings()
        {
            InitializeComponent();

            var currentSettings = Program.Settings;
            textBoxSoundFileOne.Text = currentSettings.SoundFileOne;
            textBoxSoundFileTwo.Text = currentSettings.SoundFileTwo;
            textBoxResultsFile.Text = currentSettings.ResultsDirectory;
            textBoxAdminPassword.Text = currentSettings.AdminPassword;
            textBoxNumberOfTests.Text = currentSettings.NumberOfTests.ToString();
        }

        public TestForm ParentForm
        {
            get
            {
                return (TestForm)this.Owner;
            }
        }

        private bool CanSave()
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

            if(!string.IsNullOrEmpty(textBoxResultsFile.Text) && !Directory.Exists(textBoxResultsFile.Text))
            {
                pictureAlertResultsDirectory.Visible = true;
                error = true;
            }

            int numberOfTest = 0;
            if (!Int32.TryParse(textBoxNumberOfTests.Text, out numberOfTest))
            {
                pictureAlertTestCount.Visible = true;
                error = true;
            }



            return !error;
        }

        private void HideAlerts()
        {
            pictureAlertSoundOne.Visible = false;
            pictureAlertSoundTwo.Visible = false;
            pictureAlertResultsDirectory.Visible = false;
            pictureAlertTestCount.Visible = false;
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            if (!CanSave())
                return;

            Program.Settings.SoundFileOne = textBoxSoundFileOne.Text;
            Program.Settings.SoundFileTwo = textBoxSoundFileTwo.Text;
            Program.Settings.ResultsDirectory = textBoxResultsFile.Text;
            Program.Settings.AdminPassword = textBoxAdminPassword.Text;

            int numberOfTest = 0;
            if (!Int32.TryParse(textBoxNumberOfTests.Text, out numberOfTest))
            {
                numberOfTest = 10;
                textBoxNumberOfTests.Text = numberOfTest.ToString();
            }

            Program.Settings.NumberOfTests = numberOfTest;

            XMLHelper.UpdateSettings(Program.Settings);
            this.Close();
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

        private void buttonSearchResultsDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                textBoxResultsFile.Text = folderBrowserDialog.SelectedPath;
        }
    }
}
