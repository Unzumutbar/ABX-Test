using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Simple_ABX_test.Helper;
using Simple_ABX_test.Objects;

namespace Simple_ABX_test
{
    static class Program
    {
        public static int CurrentDataBaseVersion = 2;
        public static string AppDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public static string DatabaseXmlFile = "Simple ABX test.xml";
        public static Settings Settings;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!File.Exists(DatabaseXmlFile))
                XMLHelper.WriteEmptyDatabase();

            Settings = XMLHelper.ReadSettings();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
        }
    }
}
