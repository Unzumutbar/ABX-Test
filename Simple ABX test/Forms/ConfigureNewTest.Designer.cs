namespace Simple_ABX_test.Forms
{
    partial class ConfigureNewTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigureNewTest));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.textBoxSubjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoundFileOne = new System.Windows.Forms.TextBox();
            this.buttonSearchSoundOne = new System.Windows.Forms.Button();
            this.buttonSearchSoundTwo = new System.Windows.Forms.Button();
            this.pictureAlertSoundOne = new System.Windows.Forms.PictureBox();
            this.pictureAlertSoundTwo = new System.Windows.Forms.PictureBox();
            this.pictureAlertSubjectName = new System.Windows.Forms.PictureBox();
            this.textBoxSoundFileTwo = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertSoundOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertSoundTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertSubjectName)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonContinue, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSubjectName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSoundFileOne, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSearchSoundOne, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSearchSoundTwo, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureAlertSoundOne, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureAlertSoundTwo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureAlertSubjectName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSoundFileTwo, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(439, 155);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sounddatei 1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sounddatei 2:";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(300, 116);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(105, 30);
            this.buttonContinue.TabIndex = 3;
            this.buttonContinue.Text = "ABX-Test starten";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // textBoxSubjectName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxSubjectName, 3);
            this.textBoxSubjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSubjectName.Location = new System.Drawing.Point(99, 8);
            this.textBoxSubjectName.Name = "textBoxSubjectName";
            this.textBoxSubjectName.Size = new System.Drawing.Size(332, 20);
            this.textBoxSubjectName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name:";
            // 
            // textBoxSoundFileOne
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxSoundFileOne, 2);
            this.textBoxSoundFileOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSoundFileOne.Location = new System.Drawing.Point(99, 44);
            this.textBoxSoundFileOne.Name = "textBoxSoundFileOne";
            this.textBoxSoundFileOne.Size = new System.Drawing.Size(306, 20);
            this.textBoxSoundFileOne.TabIndex = 1;
            // 
            // buttonSearchSoundOne
            // 
            this.buttonSearchSoundOne.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearchSoundOne.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonSearchSoundOne.FlatAppearance.BorderSize = 0;
            this.buttonSearchSoundOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchSoundOne.Image = global::Simple_ABX_test.Properties.Resources.search_small;
            this.buttonSearchSoundOne.Location = new System.Drawing.Point(411, 44);
            this.buttonSearchSoundOne.Name = "buttonSearchSoundOne";
            this.buttonSearchSoundOne.Size = new System.Drawing.Size(20, 20);
            this.buttonSearchSoundOne.TabIndex = 15;
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
            this.buttonSearchSoundTwo.Location = new System.Drawing.Point(411, 70);
            this.buttonSearchSoundTwo.Name = "buttonSearchSoundTwo";
            this.buttonSearchSoundTwo.Size = new System.Drawing.Size(20, 20);
            this.buttonSearchSoundTwo.TabIndex = 16;
            this.buttonSearchSoundTwo.UseVisualStyleBackColor = false;
            this.buttonSearchSoundTwo.Click += new System.EventHandler(this.buttonSearchSoundTwo_Click);
            // 
            // pictureAlertSoundOne
            // 
            this.pictureAlertSoundOne.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureAlertSoundOne.Image = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertSoundOne.InitialImage = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertSoundOne.Location = new System.Drawing.Point(8, 44);
            this.pictureAlertSoundOne.Name = "pictureAlertSoundOne";
            this.pictureAlertSoundOne.Size = new System.Drawing.Size(6, 20);
            this.pictureAlertSoundOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureAlertSoundOne.TabIndex = 18;
            this.pictureAlertSoundOne.TabStop = false;
            this.pictureAlertSoundOne.Visible = false;
            // 
            // pictureAlertSoundTwo
            // 
            this.pictureAlertSoundTwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureAlertSoundTwo.Image = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertSoundTwo.InitialImage = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertSoundTwo.Location = new System.Drawing.Point(8, 70);
            this.pictureAlertSoundTwo.Name = "pictureAlertSoundTwo";
            this.pictureAlertSoundTwo.Size = new System.Drawing.Size(6, 20);
            this.pictureAlertSoundTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureAlertSoundTwo.TabIndex = 19;
            this.pictureAlertSoundTwo.TabStop = false;
            this.pictureAlertSoundTwo.Visible = false;
            // 
            // pictureAlertSubjectName
            // 
            this.pictureAlertSubjectName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureAlertSubjectName.Image = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertSubjectName.InitialImage = global::Simple_ABX_test.Properties.Resources.alert_small;
            this.pictureAlertSubjectName.Location = new System.Drawing.Point(8, 8);
            this.pictureAlertSubjectName.Name = "pictureAlertSubjectName";
            this.pictureAlertSubjectName.Size = new System.Drawing.Size(6, 20);
            this.pictureAlertSubjectName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureAlertSubjectName.TabIndex = 20;
            this.pictureAlertSubjectName.TabStop = false;
            this.pictureAlertSubjectName.Visible = false;
            // 
            // textBoxSoundFileTwo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxSoundFileTwo, 2);
            this.textBoxSoundFileTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSoundFileTwo.Location = new System.Drawing.Point(99, 70);
            this.textBoxSoundFileTwo.Name = "textBoxSoundFileTwo";
            this.textBoxSoundFileTwo.Size = new System.Drawing.Size(306, 20);
            this.textBoxSoundFileTwo.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Sound Dateien|*.mp3; *.wav; *.ogg;";
            // 
            // ConfigureNewTest
            // 
            this.AcceptButton = this.buttonContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 155);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigureNewTest";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neuen ABX-Test starten";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertSoundOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertSoundTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlertSubjectName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.TextBox textBoxSubjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoundFileOne;
        private System.Windows.Forms.TextBox textBoxSoundFileTwo;
        private System.Windows.Forms.Button buttonSearchSoundOne;
        private System.Windows.Forms.Button buttonSearchSoundTwo;
        private System.Windows.Forms.PictureBox pictureAlertSoundOne;
        private System.Windows.Forms.PictureBox pictureAlertSoundTwo;
        private System.Windows.Forms.PictureBox pictureAlertSubjectName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}