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
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelSourceA = new System.Windows.Forms.Label();
            this.labelSourceB = new System.Windows.Forms.Label();
            this.buttonReplay = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
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
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonA, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonB, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNext, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSourceA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSourceB, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonReplay, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 207);
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
            // buttonA
            // 
            this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.Location = new System.Drawing.Point(8, 33);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(135, 135);
            this.buttonA.TabIndex = 1;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Visible = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.Location = new System.Drawing.Point(300, 33);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(135, 135);
            this.buttonB.TabIndex = 2;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Visible = false;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(154, 50);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(135, 100);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Start";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelSourceA
            // 
            this.labelSourceA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSourceA.AutoSize = true;
            this.labelSourceA.Location = new System.Drawing.Point(26, 11);
            this.labelSourceA.Name = "labelSourceA";
            this.labelSourceA.Size = new System.Drawing.Size(99, 13);
            this.labelSourceA.TabIndex = 4;
            this.labelSourceA.Text = "Sound A abspielen:";
            this.labelSourceA.Visible = false;
            // 
            // labelSourceB
            // 
            this.labelSourceB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSourceB.AutoSize = true;
            this.labelSourceB.Location = new System.Drawing.Point(318, 11);
            this.labelSourceB.Name = "labelSourceB";
            this.labelSourceB.Size = new System.Drawing.Size(99, 13);
            this.labelSourceB.TabIndex = 5;
            this.labelSourceB.Text = "Sound B abspielen:";
            this.labelSourceB.Visible = false;
            // 
            // buttonReplay
            // 
            this.buttonReplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReplay.Location = new System.Drawing.Point(154, 174);
            this.buttonReplay.Name = "buttonReplay";
            this.buttonReplay.Size = new System.Drawing.Size(135, 25);
            this.buttonReplay.TabIndex = 6;
            this.buttonReplay.Text = "Erneut abspielen";
            this.buttonReplay.UseVisualStyleBackColor = true;
            this.buttonReplay.Visible = false;
            this.buttonReplay.Click += new System.EventHandler(this.buttonReplay_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 231);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TestForm";
            this.Text = "ABX Test";
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
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.ToolStripMenuItem buttonNewTest;
        private System.Windows.Forms.ToolStripMenuItem buttonShowResults;
        private System.Windows.Forms.ToolStripMenuItem buttonToggleLock;
        private System.Windows.Forms.Label labelSourceA;
        private System.Windows.Forms.Label labelSourceB;
        private System.Windows.Forms.Button buttonReplay;
    }
}

