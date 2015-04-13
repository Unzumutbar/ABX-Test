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
using Simple_ABX_test.Objects;

namespace Simple_ABX_test.Forms
{
    public partial class ShowResults : Form
    {
        public SortableBindingList<TestResult> Results = new SortableBindingList<TestResult>();
        private List<TestResult> _resultList = new List<TestResult>();
        private List<string> _resultFiles = new List<string>();

        public ShowResults()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            _resultList = new List<TestResult>();
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

            Results = new SortableBindingList<TestResult>(_resultList);
            var source = new BindingSource(Results, null);
            dataGridResults.DataSource = source;

            decimal score = _resultList.Count(c => c.Passed);
            decimal count = _resultList.Count();
            decimal totalScore = score / count;

            textBoxCountTests.Text = count.ToString();
            textBoxCountCorrect.Text = score.ToString();
            textBoxResult.Text = string.Format("{0:0.##}%", totalScore * 100);
        }

        public List<TestResult> GetResultListFromFiles()
        {
            var resultList = new List<TestResult>();
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
    }
}
