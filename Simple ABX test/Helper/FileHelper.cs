using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Simple_ABX_test.Objects;

namespace Simple_ABX_test.Helper
{
    public static class FileHelper
    {
        public static List<TestResult> GetTestResultListFromFiles()
        {
            var resultList = new List<TestResult>();
            foreach (var resultFile in Directory.GetFiles(Program.Settings.ResultsDirectory))
            {
                if (resultFile.Contains(".xml"))
                {
                    resultList.AddRange(XMLHelper.ReadResultList(resultFile));
                }
            }
            return resultList;
        }
    }
}
