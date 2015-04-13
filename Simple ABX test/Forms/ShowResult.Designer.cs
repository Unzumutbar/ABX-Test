namespace Simple_ABX_test.Forms
{
    partial class ShowResult
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNameLabel = new System.Windows.Forms.Label();
            this.labelScoreLabel = new System.Windows.Forms.Label();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.testNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.testResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelName = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.labelNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelScoreLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridResults, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelScore, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelNameLabel
            // 
            this.labelNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNameLabel.AutoSize = true;
            this.labelNameLabel.Location = new System.Drawing.Point(8, 11);
            this.labelNameLabel.Name = "labelNameLabel";
            this.labelNameLabel.Size = new System.Drawing.Size(38, 13);
            this.labelNameLabel.TabIndex = 1;
            this.labelNameLabel.Text = "Name:";
            // 
            // labelScoreLabel
            // 
            this.labelScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelScoreLabel.AutoSize = true;
            this.labelScoreLabel.Location = new System.Drawing.Point(8, 238);
            this.labelScoreLabel.Name = "labelScoreLabel";
            this.labelScoreLabel.Size = new System.Drawing.Size(51, 13);
            this.labelScoreLabel.TabIndex = 2;
            this.labelScoreLabel.Text = "Ergebnis:";
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
            this.testNumberDataGridViewTextBoxColumn,
            this.selectedAnswerDataGridViewTextBoxColumn,
            this.correctAnswerDataGridViewTextBoxColumn,
            this.passedDataGridViewCheckBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridResults, 2);
            this.dataGridResults.DataSource = this.testResultBindingSource;
            this.dataGridResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridResults.Location = new System.Drawing.Point(8, 33);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.ReadOnly = true;
            this.dataGridResults.RowHeadersVisible = false;
            this.dataGridResults.Size = new System.Drawing.Size(441, 196);
            this.dataGridResults.TabIndex = 3;
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
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(65, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "label1";
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(65, 238);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(35, 13);
            this.labelScore.TabIndex = 5;
            this.labelScore.Text = "label1";
            // 
            // ShowResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ShowResult";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ergebnisse";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelNameLabel;
        private System.Windows.Forms.Label labelScoreLabel;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn testNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAnswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn passedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource testResultBindingSource;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelScore;
    }
}