using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Simple_ABX_test.Helper;
using Simple_ABX_test.Objects;

namespace Simple_ABX_test.Forms
{
    public partial class ShowResults : Form
    {
        public SortableBindingList<Result> Results = new SortableBindingList<Result>();
        private List<Result> _resultList = new List<Result>();
        private List<string> _resultFiles = new List<string>();

        public ShowResults()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            _resultList = new List<Result>();
            _resultFiles = new List<string>();
            _resultList = GetResultListFromFiles();

            RefreshSortableBindingList();
        }

        public void RefreshSortableBindingList()
        {
            if (!_resultList.Any())
            {
                MessageBox.Show("Es wurden keine Ergebnisse gefunden!");
                return;
            }
            var filteredResults = _resultList;
            if (!string.IsNullOrEmpty(textBoxFilter.Text))
                filteredResults = _resultList.Where(res => res.Proband != null && res.Proband.ToUpper().Contains(textBoxFilter.Text.ToUpper())).ToList();

            Results = new SortableBindingList<Result>(filteredResults);
            var source = new BindingSource(Results, null);
            dataGridResults.DataSource = source;

            decimal score = filteredResults.Count(c => c.Passed);
            decimal count = filteredResults.Count();
            decimal totalScore = 0;

            if (count > 0)
                totalScore = score / count;

            textBoxCountTests.Text = count.ToString();
            textBoxCountCorrect.Text = score.ToString();
            textBoxResult.Text = string.Format("{0:0.##}%", totalScore * 100);
        }

        public List<Result> GetResultListFromFiles()
        {
            var resultList = new List<Result>();
            string directory = Program.Settings.GetResultDirectory;
            foreach (var resultFile in Directory.GetFiles(directory))
            {
                if (resultFile.Contains(".xml"))
                {
                    _resultFiles.Add(resultFile);
                    resultList.AddRange(XMLHelper.ReadResultList(resultFile));
                }
            }
            return resultList;
        }

        private void buttonAddResultFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string targetFile = openFileDialog.FileName;

                    string directory = Program.Settings.GetResultDirectory;
                    string resultFileToAdd = Path.Combine(directory, Path.GetFileName(targetFile));

                    if (_resultFiles.Any(r => r == resultFileToAdd))
                        return;

                    File.Copy(targetFile, resultFileToAdd);

                    var result = XMLHelper.ReadResultList(resultFileToAdd);
                    _resultList.AddRange(result);
                    RefreshSortableBindingList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshSortableBindingList();
        }

        private void buttonExportList_Click(object sender, EventArgs e)
        {
            if (!Results.Any())
            {
                MessageBox.Show("Es wurden keine Ergebnisse gefunden!");
                return;
            }
            try
            {
                var csv = new StringBuilder();
                csv.Append(string.Format("Name;Nr.;Auswahl;X=;Kongruent?{0}", Environment.NewLine));

                foreach (var result in Results)
                {
                    var newLine = string.Format("{0};{1};{2};{3};{4}{5}", result.RowName, result.TestNumber, result.CorrectAnswer, result.SelectedAnswer, result.Passed, Environment.NewLine);
                    csv.Append(newLine);
                }
                csv.Append(string.Format("Anzahl der Tests;{0}; ; ;{1}", textBoxCountTests.Text, Environment.NewLine));
                csv.Append(string.Format("Anzal der Üebereinstimmungen;{0}; ; ;{1}", textBoxCountCorrect.Text, Environment.NewLine));
                csv.Append(string.Format("Ergebnis;{0}; ; ;{1}", textBoxResult.Text, Environment.NewLine));

                saveFileDialog.FileName = string.Format("{0}_ABX_Ergebnisse.csv", DateTime.Now.ToString("yyyy.MM.dd"));
                saveFileDialog.Filter = "csv Dateien (*.csv)|*.csv|All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, csv.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
