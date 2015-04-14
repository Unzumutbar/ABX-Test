using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simple_ABX_test.Helper;

namespace Simple_ABX_test.Objects
{
    public class Settings
    {
        public int NumberOfTests;
        public string SoundDirectory;
        public string ResultsDirectory;
        public string AdminPassword;

        public string GetSoundDirectory
        {
            get { return string.IsNullOrEmpty(SoundDirectory) ? Program.AppDirectory : Program.Settings.SoundDirectory; }
        }

        public string GetResultDirectory
        {
            get{ return string.IsNullOrEmpty(ResultsDirectory) ? Program.AppDirectory : Program.Settings.ResultsDirectory;}
        }
    }
}
