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
        public SortableBindingList<Result> Results = new SortableBindingList<Result>();

        public ShowResult()
        {
            InitializeComponent();
        }

        public void UpdateList(AbxTest abxTest)
        {
            var resultList = abxTest.Results.OrderBy(res => res.TestNumber).ToList();
            Results = new SortableBindingList<Result>(resultList);
            var source = new BindingSource(Results, null);
            dataGridResults.DataSource = source;

            labelName.Text = abxTest.SubjectName;
            labelScore.Text = string.Format("{0}%", abxTest.Score* 100);
        }
    }
}
