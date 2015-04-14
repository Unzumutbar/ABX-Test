using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple_ABX_test.Helper;

namespace Simple_ABX_test.Objects
{
    public class AbxTest
    {
        public string SubjectName { get; set; }
        public DateTime Date { get; set; }
        public string SoundFileA { get; set; }
        public string SoundFileB  { get; set; }
        public decimal Score { get; set; }
        public List<Result> Results { get; set; }

        public string File { get; set; }

        public void CreateFile()
        {
            this.File = XMLHelper.CreateResultFile(this);
        }

        public void AddResult(Result resultToAdd)
        {
            this.Results.Add(resultToAdd);
            XMLHelper.AddResult(resultToAdd, this);
        }

        public void UpdateTestScore(decimal score)
        {
            this.Score = score;
            XMLHelper.UpdateTestScore(this);
        }
    }
}
