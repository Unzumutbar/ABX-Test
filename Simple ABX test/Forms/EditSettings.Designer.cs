namespace Simple_ABX_test
{
    partial class EditSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSettings));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSoundFileOne = new System.Windows.Forms.TextBox();
            this.labelSoundFileOne = new System.Windows.Forms.Label();
            this.labelSoundFileTwo = new System.Windows.Forms.Label();
            this.labelResultsFile = new System.Windows.Forms.Label();
            this.labelAdminPassword = new System.Windows.Forms.Label();
            this.textBoxSoundFileTwo = new System.Windows.Forms.TextBox();
            this.textBoxResultsFile = new System.Windows.Forms.TextBox();
            this.textBoxAdminPassword = new System.Windows.Forms.TextBox();
            this.labelLoopSound = new System.Windows.Forms.Label();
            this.checkBoxLoopSound = new System.Windows.Forms.CheckBox();
            this.labelNumberOfTests = new System.Windows.Forms.Label();
            this.textBoxNumberOfTests = new System.Windows.Forms.TextBox();
            this.buttonSearchSoundOne = new System.Windows.Forms.Button();
            this.buttonSearchSoundTwo = new System.Windows.Forms.Button();
            this.buttonSearchResultsDirectory = new System.Windows.Forms.Button();
            this.pictureAlertSoundOne = new System.Windows.Forms.PictureBox();
            this.pictureAlertSoundTwo = new System.Windows.Forms.PictureBox();
            this.pictureAlertResultsDirectory = new System.Windows.Forms.PictureBox();
            this.pictureAlertTestCount = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertSoundOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertSoundTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertResultsDirectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertTestCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(492, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.Image = global::Simple_ABX_test.Properties.Resources.checkmark;
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.saveSettingsToolStripMenuItem.Text = "Speichern";
            this.saveSettingsToolStripMenuItem.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxSoundFileOne, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSoundFileOne, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSoundFileTwo, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelResultsFile, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelAdminPassword, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSoundFileTwo, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxResultsFile, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAdminPassword, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelLoopSound, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxLoopSound, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelNumberOfTests, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNumberOfTests, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonSearchSoundOne, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSearchSoundTwo, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSearchResultsDirectory, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureAlertSoundOne, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureAlertSoundTwo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureAlertResultsDirectory, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureAlertTestCount, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 181);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBoxSoundFileOne
            // 
            this.textBoxSoundFileOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSoundFileOne.Location = new System.Drawing.Point(142, 8);
            this.textBoxSoundFileOne.Name = "textBoxSoundFileOne";
            this.textBoxSoundFileOne.Size = new System.Drawing.Size(316, 20);
            this.textBoxSoundFileOne.TabIndex = 0;
            // 
            // labelSoundFileOne
            // 
            this.labelSoundFileOne.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSoundFileOne.AutoSize = true;
            this.labelSoundFileOne.Location = new System.Drawing.Point(20, 11);
            this.labelSoundFileOne.Name = "labelSoundFileOne";
            this.labelSoundFileOne.Size = new System.Drawing.Size(70, 13);
            this.labelSoundFileOne.TabIndex = 1;
            this.labelSoundFileOne.Text = "Sounddatei 1";
            this.labelSoundFileOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoundFileTwo
            // 
            this.labelSoundFileTwo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSoundFileTwo.AutoSize = true;
            this.labelSoundFileTwo.Location = new System.Drawing.Point(20, 37);
            this.labelSoundFileTwo.Name = "labelSoundFileTwo";
            this.labelSoundFileTwo.Size = new System.Drawing.Size(70, 13);
            this.labelSoundFileTwo.TabIndex = 2;
            this.labelSoundFileTwo.Text = "Sounddatei 2";
            // 
            // labelResultsFile
            // 
            this.labelResultsFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResultsFile.AutoSize = true;
            this.labelResultsFile.Location = new System.Drawing.Point(20, 73);
            this.labelResultsFile.Name = "labelResultsFile";
            this.labelResultsFile.Size = new System.Drawing.Size(116, 13);
            this.labelResultsFile.TabIndex = 4;
            this.labelResultsFile.Text = "Speicherort Ergebnisse";
            // 
            // labelAdminPassword
            // 
            this.labelAdminPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAdminPassword.AutoSize = true;
            this.labelAdminPassword.Location = new System.Drawing.Point(20, 155);
            this.labelAdminPassword.Name = "labelAdminPassword";
            this.labelAdminPassword.Size = new System.Drawing.Size(82, 13);
            this.labelAdminPassword.TabIndex = 5;
            this.labelAdminPassword.Text = "Admin Passwort";
            // 
            // textBoxSoundFileTwo
            // 
            this.textBoxSoundFileTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSoundFileTwo.Location = new System.Drawing.Point(142, 34);
            this.textBoxSoundFileTwo.Name = "textBoxSoundFileTwo";
            this.textBoxSoundFileTwo.Size = new System.Drawing.Size(316, 20);
            this.textBoxSoundFileTwo.TabIndex = 6;
            // 
            // textBoxResultsFile
            // 
            this.textBoxResultsFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResultsFile.Location = new System.Drawing.Point(142, 70);
            this.textBoxResultsFile.Name = "textBoxResultsFile";
            this.textBoxResultsFile.Size = new System.Drawing.Size(316, 20);
            this.textBoxResultsFile.TabIndex = 8;
            // 
            // textBoxAdminPassword
            // 
            this.textBoxAdminPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAdminPassword.Location = new System.Drawing.Point(142, 152);
            this.textBoxAdminPassword.Name = "textBoxAdminPassword";
            this.textBoxAdminPassword.Size = new System.Drawing.Size(316, 20);
            this.textBoxAdminPassword.TabIndex = 9;
            // 
            // labelLoopSound
            // 
            this.labelLoopSound.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLoopSound.AutoSize = true;
            this.labelLoopSound.Location = new System.Drawing.Point(20, 122);
            this.labelLoopSound.Name = "labelLoopSound";
            this.labelLoopSound.Size = new System.Drawing.Size(98, 13);
            this.labelLoopSound.TabIndex = 10;
            this.labelLoopSound.Text = "Sound wiederholen";
            // 
            // checkBoxLoopSound
            // 
            this.checkBoxLoopSound.AutoSize = true;
            this.checkBoxLoopSound.Location = new System.Drawing.Point(142, 122);
            this.checkBoxLoopSound.Name = "checkBoxLoopSound";
            this.checkBoxLoopSound.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLoopSound.TabIndex = 11;
            this.checkBoxLoopSound.UseVisualStyleBackColor = true;
            // 
            // labelNumberOfTests
            // 
            this.labelNumberOfTests.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNumberOfTests.AutoSize = true;
            this.labelNumberOfTests.Location = new System.Drawing.Point(20, 99);
            this.labelNumberOfTests.Name = "labelNumberOfTests";
            this.labelNumberOfTests.Size = new System.Drawing.Size(59, 13);
            this.labelNumberOfTests.TabIndex = 12;
            this.labelNumberOfTests.Text = "Testanzahl";
            // 
            // textBoxNumberOfTests
            // 
            this.textBoxNumberOfTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNumberOfTests.Location = new System.Drawing.Point(142, 96);
            this.textBoxNumberOfTests.Name = "textBoxNumberOfTests";
            this.textBoxNumberOfTests.Size = new System.Drawing.Size(316, 20);
            this.textBoxNumberOfTests.TabIndex = 13;
            // 
            // buttonSearchSoundOne
            // 
            this.buttonSearchSoundOne.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearchSoundOne.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSearchSoundOne.FlatAppearance.BorderSize = 0;
            this.buttonSearchSoundOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchSoundOne.Image = global::Simple_ABX_test.Properties.Resources.search_small;
            this.buttonSearchSoundOne.Location = new System.Drawing.Point(464, 8);
            this.buttonSearchSoundOne.Name = "buttonSearchSoundOne";
            this.buttonSearchSoundOne.Size = new System.Drawing.Size(20, 20);
            this.buttonSearchSoundOne.TabIndex = 14;
            this.buttonSearchSoundOne.UseVisualStyleBackColor = false;
            this.buttonSearchSoundOne.Click += new System.EventHandler(this.buttonSearchSoundOne_Click);
            // 
            // buttonSearchSoundTwo
            // 
            this.buttonSearchSoundTwo.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearchSoundTwo.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSearchSoundTwo.FlatAppearance.BorderSize = 0;
            this.buttonSearchSoundTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchSoundTwo.Image = global::Simple_ABX_test.Properties.Resources.search_small;
            this.buttonSearchSoundTwo.Location = new System.Drawing.Point(464, 34);
            this.buttonSearchSoundTwo.Name = "buttonSearchSoundTwo";
            this.buttonSearchSoundTwo.Size = new System.Drawing.Size(20, 20);
            this.buttonSearchSoundTwo.TabIndex = 15;
            this.buttonSearchSoundTwo.UseVisualStyleBackColor = false;
            this.buttonSearchSoundTwo.Click += new System.EventHandler(this.buttonSearchSoundTwo_Click);
            // 
            // buttonSearchResultsDirectory
            // 
            this.buttonSearchResultsDirectory.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearchResultsDirectory.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSearchResultsDirectory.FlatAppearance.BorderSize = 0;
            this.buttonSearchResultsDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchResultsDirectory.Image = global::Simple_ABX_test.Properties.Resources.search_small;
            this.buttonSearchResultsDirectory.Location = new System.Drawing.Point(464, 70);
            this.buttonSearchResultsDirectory.Name = "buttonSearchResultsDirectory";
            this.buttonSearchResultsDirectory.Size = new System.Drawing.Size(20, 20);
            this.buttonSearchResultsDirectory.TabIndex = 16;
            this.buttonSearchResultsDirectory.UseVisualStyleBackColor = false;
            this.buttonSearchResultsDirectory.Click += new System.EventHandler(this.buttonSearchResultsDirectory_Click);
            // 
            // pictureAlertSoundOne
            // 
            this.pictureAlertSoundOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureAlertSoundOne.Image = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertSoundOne.InitialImage = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertSoundOne.Location = new System.Drawing.Point(8, 8);
            this.pictureAlertSoundOne.Name = "pictureAlertSoundOne";
            this.pictureAlertSoundOne.Size = new System.Drawing.Size(6, 20);
            this.pictureAlertSoundOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureAlertSoundOne.TabIndex = 17;
            this.pictureAlertSoundOne.TabStop = false;
            this.pictureAlertSoundOne.Visible = false;
            // 
            // pictureAlertSoundTwo
            // 
            this.pictureAlertSoundTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureAlertSoundTwo.Image = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertSoundTwo.InitialImage = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertSoundTwo.Location = new System.Drawing.Point(8, 34);
            this.pictureAlertSoundTwo.Name = "pictureAlertSoundTwo";
            this.pictureAlertSoundTwo.Size = new System.Drawing.Size(6, 20);
            this.pictureAlertSoundTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureAlertSoundTwo.TabIndex = 18;
            this.pictureAlertSoundTwo.TabStop = false;
            this.pictureAlertSoundTwo.Visible = false;
            // 
            // pictureAlertResultsDirectory
            // 
            this.pictureAlertResultsDirectory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureAlertResultsDirectory.Image = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertResultsDirectory.InitialImage = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertResultsDirectory.Location = new System.Drawing.Point(8, 70);
            this.pictureAlertResultsDirectory.Name = "pictureAlertResultsDirectory";
            this.pictureAlertResultsDirectory.Size = new System.Drawing.Size(6, 20);
            this.pictureAlertResultsDirectory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureAlertResultsDirectory.TabIndex = 19;
            this.pictureAlertResultsDirectory.TabStop = false;
            this.pictureAlertResultsDirectory.Visible = false;
            // 
            // pictureAlertTestCount
            // 
            this.pictureAlertTestCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureAlertTestCount.Image = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertTestCount.InitialImage = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertTestCount.Location = new System.Drawing.Point(8, 96);
            this.pictureAlertTestCount.Name = "pictureAlertTestCount";
            this.pictureAlertTestCount.Size = new System.Drawing.Size(6, 20);
            this.pictureAlertTestCount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureAlertTestCount.TabIndex = 20;
            this.pictureAlertTestCount.TabStop = false;
            this.pictureAlertTestCount.Visible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Sound Dateien|*.mp3; *.wav; *.ogg;";
            // 
            // EditSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 205);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "EditSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Einstellungen";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertSoundOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertSoundTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertResultsDirectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertTestCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxSoundFileOne;
        private System.Windows.Forms.Label labelSoundFileOne;
        private System.Windows.Forms.Label labelSoundFileTwo;
        private System.Windows.Forms.Label labelResultsFile;
        private System.Windows.Forms.Label labelAdminPassword;
        private System.Windows.Forms.TextBox textBoxSoundFileTwo;
        private System.Windows.Forms.TextBox textBoxResultsFile;
        private System.Windows.Forms.TextBox textBoxAdminPassword;
        private System.Windows.Forms.Label labelLoopSound;
        private System.Windows.Forms.CheckBox checkBoxLoopSound;
        private System.Windows.Forms.Label labelNumberOfTests;
        private System.Windows.Forms.TextBox textBoxNumberOfTests;
        private System.Windows.Forms.Button buttonSearchSoundOne;
        private System.Windows.Forms.Button buttonSearchSoundTwo;
        private System.Windows.Forms.Button buttonSearchResultsDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureAlertSoundOne;
        private System.Windows.Forms.PictureBox pictureAlertSoundTwo;
        private System.Windows.Forms.PictureBox pictureAlertResultsDirectory;
        private System.Windows.Forms.PictureBox pictureAlertTestCount;
    }
}