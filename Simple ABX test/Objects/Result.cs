using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_ABX_test.Objects
{
    public class Result
    {
        public int TestNumber { get; set; }
        public string SelectedAnswer { get; set; }
        public string CorrectAnswer { get; set; }

        public bool Passed
        {
            get { return SelectedAnswer == CorrectAnswer; }
        }

        public string ProbandName { get; set; }
    }
}
