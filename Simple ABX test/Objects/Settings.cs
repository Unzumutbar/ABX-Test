using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple_ABX_test.Helper;

namespace Simple_ABX_test.Objects
{
    public class Settings
    {
        public string SoundFileOne;
        public string SoundFileTwo;
        public int NumberOfTests;
        public string ResultsDirectory;
        public string AdminPassword;
        public bool LoopSound;

        public string GetResultDirectory
        {
            get{ return string.IsNullOrEmpty(ResultsDirectory) ? Program.AppDirectory : Program.Settings.ResultsDirectory;}
        }
    }
}
