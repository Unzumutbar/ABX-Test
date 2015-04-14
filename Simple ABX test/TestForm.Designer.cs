namespace Simple_ABX_test
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonNewTest = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonShowResults = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonShowSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToggleLock = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPlayA = new System.Windows.Forms.Button();
            this.buttonPlayB = new System.Windows.Forms.Button();
            this.labelPlayA = new System.Windows.Forms.Label();
            this.labelPlayB = new System.Windows.Forms.Label();
            this.buttonPlayX = new System.Windows.Forms.Button();
            this.labelPlayX = new System.Windows.Forms.Label();
            this.buttonSelectA = new System.Windows.Forms.Button();
            this.buttonSelectB = new System.Windows.Forms.Button();
            this.labelTestNumber = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonNewTest,
            this.buttonShowResults,
            this.buttonShowSettings,
            this.buttonToggleLock});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonNewTest
            // 
            this.buttonNewTest.Image = global::Simple_ABX_test.Properties.Resources.person_add;
            this.buttonNewTest.Name = "buttonNewTest";
            this.buttonNewTest.Size = new System.Drawing.Size(57, 20);
            this.buttonNewTest.Text = "Neu";
            this.buttonNewTest.ToolTipText = "Neuen ABX Test starten";
            this.buttonNewTest.Click += new System.EventHandler(this.buttonNewTest_Click);
            // 
            // buttonShowResults
            // 
            this.buttonShowResults.Image = global::Simple_ABX_test.Properties.Resources.clipboard;
            this.buttonShowResults.Name = "buttonShowResults";
            this.buttonShowResults.Size = new System.Drawing.Size(91, 20);
            this.buttonShowResults.Text = "Ergebnisse";
            this.buttonShowResults.ToolTipText = "Ergebnisse anzeigen und auswerten";
            this.buttonShowResults.Click += new System.EventHandler(this.buttonShowResults_Click);
            // 
            // buttonShowSettings
            // 
            this.buttonShowSettings.Image = global::Simple_ABX_test.Properties.Resources.wrench;
            this.buttonShowSettings.Name = "buttonShowSettings";
            this.buttonShowSettings.Size = new System.Drawing.Size(106, 20);
            this.buttonShowSettings.Text = "Einstellungen";
            this.buttonShowSettings.ToolTipText = "Einstellungen ändern";
            this.buttonShowSettings.Click += new System.EventHandler(this.buttonShowSettings_Click);
            // 
            // buttonToggleLock
            // 
            this.buttonToggleLock.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonToggleLock.Image = global::Simple_ABX_test.Properties.Resources.unlocked;
            this.buttonToggleLock.Name = "buttonToggleLock";
            this.buttonToggleLock.Size = new System.Drawing.Size(28, 20);
            this.buttonToggleLock.ToolTipText = "Schaltfläche entsperren";
            this.buttonToggleLock.Visible = false;
            this.buttonToggleLock.Click += new System.EventHandler(this.buttonToggleLock_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlayA, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlayB, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPlayA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPlayB, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlayX, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelPlayX, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectA, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectB, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelTestNumber, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 478);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1, 1);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonPlayA
            // 
            this.buttonPlayA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayA.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayA.Location = new System.Drawing.Point(3, 26);
            this.buttonPlayA.Name = "buttonPlayA";
            this.buttonPlayA.Size = new System.Drawing.Size(135, 135);
            this.buttonPlayA.TabIndex = 1;
            this.buttonPlayA.Text = "A";
            this.buttonPlayA.UseVisualStyleBackColor = true;
            this.buttonPlayA.Click += new System.EventHandler(this.buttonPlayA_Click);
            // 
            // buttonPlayB
            // 
            this.buttonPlayB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPlayB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayB.Location = new System.Drawing.Point(316, 26);
            this.buttonPlayB.Name = "buttonPlayB";
            this.buttonPlayB.Size = new System.Drawing.Size(135, 135);
            this.buttonPlayB.TabIndex = 2;
            this.buttonPlayB.Text = "B";
            this.buttonPlayB.UseVisualStyleBackColor = true;
            this.buttonPlayB.Click += new System.EventHandler(this.buttonPlayB_Click);
            // 
            // labelPlayA
            // 
            this.labelPlayA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPlayA.AutoSize = true;
            this.labelPlayA.Location = new System.Drawing.Point(21, 10);
            this.labelPlayA.Name = "labelPlayA";
            this.labelPlayA.Size = new System.Drawing.Size(99, 13);
            this.labelPlayA.TabIndex = 4;
            this.labelPlayA.Text = "Sound A abspielen:";
            // 
            // labelPlayB
            // 
            this.labelPlayB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPlayB.AutoSize = true;
            this.labelPlayB.Location = new System.Drawing.Point(334, 10);
            this.labelPlayB.Name = "labelPlayB";
            this.labelPlayB.Size = new System.Drawing.Size(99, 13);
            this.labelPlayB.TabIndex = 5;
            this.labelPlayB.Text = "Sound B abspielen:";
            // 
            // buttonPlayX
            // 
            this.buttonPlayX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonPlayX, 3);
            this.buttonPlayX.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayX.Location = new System.Drawing.Point(159, 342);
            this.buttonPlayX.Name = "buttonPlayX";
            this.buttonPlayX.Size = new System.Drawing.Size(135, 135);
            this.buttonPlayX.TabIndex = 7;
            this.buttonPlayX.Text = "X";
            this.buttonPlayX.UseVisualStyleBackColor = true;
            this.buttonPlayX.Click += new System.EventHandler(this.buttonPlayX_Click);
            // 
            // labelPlayX
            // 
            this.labelPlayX.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelPlayX.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelPlayX, 3);
            this.labelPlayX.Location = new System.Drawing.Point(177, 326);
            this.labelPlayX.Name = "labelPlayX";
            this.labelPlayX.Size = new System.Drawing.Size(99, 13);
            this.labelPlayX.TabIndex = 8;
            this.labelPlayX.Text = "Sound X abspielen:";
            // 
            // buttonSelectA
            // 
            this.buttonSelectA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectA.Location = new System.Drawing.Point(149, 192);
            this.buttonSelectA.Name = "buttonSelectA";
            this.buttonSelectA.Size = new System.Drawing.Size(70, 70);
            this.buttonSelectA.TabIndex = 10;
            this.buttonSelectA.Text = "X=A";
            this.buttonSelectA.UseVisualStyleBackColor = true;
            this.buttonSelectA.Click += new System.EventHandler(this.buttonSelectA_Click);
            // 
            // buttonSelectB
            // 
            this.buttonSelectB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectB.Location = new System.Drawing.Point(235, 192);
            this.buttonSelectB.Name = "buttonSelectB";
            this.buttonSelectB.Size = new System.Drawing.Size(70, 70);
            this.buttonSelectB.TabIndex = 11;
            this.buttonSelectB.Text = "X=B";
            this.buttonSelectB.UseVisualStyleBackColor = true;
            this.buttonSelectB.Click += new System.EventHandler(this.buttonSelectB_Click);
            // 
            // labelTestNumber
            // 
            this.labelTestNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelTestNumber.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelTestNumber, 3);
            this.labelTestNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestNumber.Location = new System.Drawing.Point(188, 171);
            this.labelTestNumber.Name = "labelTestNumber";
            this.labelTestNumber.Size = new System.Drawing.Size(78, 18);
            this.labelTestNumber.TabIndex = 9;
            this.labelTestNumber.Text = "TestNr. 1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 502);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TestForm";
            this.Text = "ABX-Test";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buttonShowSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPlayA;
        private System.Windows.Forms.Button buttonPlayB;
        private System.Windows.Forms.ToolStripMenuItem buttonNewTest;
        private System.Windows.Forms.ToolStripMenuItem buttonShowResults;
        private System.Windows.Forms.ToolStripMenuItem buttonToggleLock;
        private System.Windows.Forms.Label labelPlayA;
        private System.Windows.Forms.Label labelPlayB;
        private System.Windows.Forms.Button buttonPlayX;
        private System.Windows.Forms.Label labelPlayX;
        private System.Windows.Forms.Label labelTestNumber;
        private System.Windows.Forms.Button buttonSelectA;
        private System.Windows.Forms.Button buttonSelectB;
    }
}

