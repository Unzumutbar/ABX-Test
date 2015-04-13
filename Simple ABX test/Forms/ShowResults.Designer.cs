﻿namespace Simple_ABX_test.Forms
{
    partial class ShowResults
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowResults));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.ProbandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelScoreLabel = new System.Windows.Forms.Label();
            this.labelCountTests = new System.Windows.Forms.Label();
            this.labelCountCorrect = new System.Windows.Forms.Label();
            this.textBoxCountTests = new System.Windows.Forms.TextBox();
            this.textBoxCountCorrect = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.buttonAddResultFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.testNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.testResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridResults, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelScoreLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelCountTests, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCountCorrect, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCountTests, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCountCorrect, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxResult, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 462);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridResults
            // 
            this.dataGridResults.AllowUserToAddRows = false;
            this.dataGridResults.AllowUserToDeleteRows = false;
            this.dataGridResults.AutoGenerateColumns = false;
            this.dataGridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridResults.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProbandName,
            this.testNumberDataGridViewTextBoxColumn,
            this.selectedAnswerDataGridViewTextBoxColumn,
            this.correctAnswerDataGridViewTextBoxColumn,
            this.passedDataGridViewCheckBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridResults, 2);
            this.dataGridResults.DataSource = this.testResultBindingSource;
            this.dataGridResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResults.Location = new System.Drawing.Point(8, 8);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.ReadOnly = true;
            this.dataGridResults.RowHeadersVisible = false;
            this.dataGridResults.Size = new System.Drawing.Size(580, 332);
            this.dataGridResults.TabIndex = 0;
            // 
            // ProbandName
            // 
            this.ProbandName.DataPropertyName = "ProbandName";
            this.ProbandName.HeaderText = "Name";
            this.ProbandName.Name = "ProbandName";
            this.ProbandName.ReadOnly = true;
            // 
            // labelScoreLabel
            // 
            this.labelScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelScoreLabel.AutoSize = true;
            this.labelScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreLabel.Location = new System.Drawing.Point(8, 435);
            this.labelScoreLabel.Name = "labelScoreLabel";
            this.labelScoreLabel.Size = new System.Drawing.Size(65, 16);
            this.labelScoreLabel.TabIndex = 1;
            this.labelScoreLabel.Text = "Ergebnis:";
            // 
            // labelCountTests
            // 
            this.labelCountTests.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCountTests.AutoSize = true;
            this.labelCountTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountTests.Location = new System.Drawing.Point(8, 369);
            this.labelCountTests.Name = "labelCountTests";
            this.labelCountTests.Size = new System.Drawing.Size(108, 16);
            this.labelCountTests.TabIndex = 2;
            this.labelCountTests.Text = "Anzahl der Tests";
            // 
            // labelCountCorrect
            // 
            this.labelCountCorrect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCountCorrect.AutoSize = true;
            this.labelCountCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountCorrect.Location = new System.Drawing.Point(8, 397);
            this.labelCountCorrect.Name = "labelCountCorrect";
            this.labelCountCorrect.Size = new System.Drawing.Size(185, 16);
            this.labelCountCorrect.TabIndex = 3;
            this.labelCountCorrect.Text = "Anzahl der richtigen Antworten";
            // 
            // textBoxCountTests
            // 
            this.textBoxCountTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCountTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountTests.Location = new System.Drawing.Point(301, 366);
            this.textBoxCountTests.Name = "textBoxCountTests";
            this.textBoxCountTests.ReadOnly = true;
            this.textBoxCountTests.Size = new System.Drawing.Size(287, 22);
            this.textBoxCountTests.TabIndex = 4;
            this.textBoxCountTests.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCountCorrect
            // 
            this.textBoxCountCorrect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCountCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCountCorrect.Location = new System.Drawing.Point(301, 394);
            this.textBoxCountCorrect.Name = "textBoxCountCorrect";
            this.textBoxCountCorrect.ReadOnly = true;
            this.textBoxCountCorrect.Size = new System.Drawing.Size(287, 22);
            this.textBoxCountCorrect.TabIndex = 5;
            this.textBoxCountCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.ForeColor = System.Drawing.Color.Red;
            this.textBoxResult.Location = new System.Drawing.Point(301, 432);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(287, 22);
            this.textBoxResult.TabIndex = 6;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAddResultFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(596, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // buttonAddResultFile
            // 
            this.buttonAddResultFile.Image = global::Simple_ABX_test.Properties.Resources.plus;
            this.buttonAddResultFile.Name = "buttonAddResultFile";
            this.buttonAddResultFile.Size = new System.Drawing.Size(143, 20);
            this.buttonAddResultFile.Text = "Ergebnis hinzufügen";
            this.buttonAddResultFile.Click += new System.EventHandler(this.buttonAddResultFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "XML-Dateien|*.xml";
            // 
            // testNumberDataGridViewTextBoxColumn
            // 
            this.testNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.testNumberDataGridViewTextBoxColumn.DataPropertyName = "TestNumber";
            this.testNumberDataGridViewTextBoxColumn.HeaderText = "Nr.";
            this.testNumberDataGridViewTextBoxColumn.Name = "testNumberDataGridViewTextBoxColumn";
            this.testNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.testNumberDataGridViewTextBoxColumn.Width = 46;
            // 
            // selectedAnswerDataGridViewTextBoxColumn
            // 
            this.selectedAnswerDataGridViewTextBoxColumn.DataPropertyName = "SelectedAnswer";
            this.selectedAnswerDataGridViewTextBoxColumn.HeaderText = "Auswahl";
            this.selectedAnswerDataGridViewTextBoxColumn.Name = "selectedAnswerDataGridViewTextBoxColumn";
            this.selectedAnswerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correctAnswerDataGridViewTextBoxColumn
            // 
            this.correctAnswerDataGridViewTextBoxColumn.DataPropertyName = "CorrectAnswer";
            this.correctAnswerDataGridViewTextBoxColumn.HeaderText = "Richtig";
            this.correctAnswerDataGridViewTextBoxColumn.Name = "correctAnswerDataGridViewTextBoxColumn";
            this.correctAnswerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passedDataGridViewCheckBoxColumn
            // 
            this.passedDataGridViewCheckBoxColumn.DataPropertyName = "Passed";
            this.passedDataGridViewCheckBoxColumn.HeaderText = "Bestanden?";
            this.passedDataGridViewCheckBoxColumn.Name = "passedDataGridViewCheckBoxColumn";
            this.passedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // testResultBindingSource
            // 
            this.testResultBindingSource.DataSource = typeof(Simple_ABX_test.Objects.TestResult);
            // 
            // ShowResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ergebnisse auswerten";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem buttonAddResultFile;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.BindingSource testResultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn testNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn passedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label labelScoreLabel;
        private System.Windows.Forms.Label labelCountTests;
        private System.Windows.Forms.Label labelCountCorrect;
        private System.Windows.Forms.TextBox textBoxCountTests;
        private System.Windows.Forms.TextBox textBoxCountCorrect;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}