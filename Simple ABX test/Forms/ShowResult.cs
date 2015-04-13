using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Simple_ABX_test.Helper;
using Simple_ABX_test.Objects;

namespace Simple_ABX_test.Forms
{
    public partial class ShowResult : Form
    {
        public SortableBindingList<TestResult> Results = new SortableBindingList<TestResult>();

        public ShowResult()
        {
            InitializeComponent();
        }

        public void UpdateList(string name, List<TestResult> resultList, decimal score)
        {
            resultList = resultList.OrderBy(res => res.TestNumber).ToList();
            Results = new SortableBindingList<TestResult>(resultList);
            var source = new BindingSource(Results, null);
            dataGridResults.DataSource = source;

            labelName.Text = name;
            labelScore.Text = string.Format("{0}%", score*100);
        }
    }
}
