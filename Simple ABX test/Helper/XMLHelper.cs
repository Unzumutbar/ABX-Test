using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using Simple_ABX_test.Objects;

namespace Simple_ABX_test.Helper
{
    public static class XMLHelper
    {
        public static void WriteEmptyDatabase()
        {
            if (File.Exists(Program.DatabaseXmlFile))
                File.Delete(Program.DatabaseXmlFile);

            using (XmlWriter writer = XmlWriter.Create(Program.DatabaseXmlFile))
            {
                writer.WriteStartElement("SimpleAbxTest");

                writer.WriteStartElement("Settings");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.Flush();
            }
        }

        #region ReadSettings
        public static Settings ReadSettings()
        {
            var settings = new Settings();
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);

            settings.ResultsDirectory = ReadSettingsResultsFile(doc);
            settings.AdminPassword = ReadSettingsAdminPassword(doc);
            settings.NumberOfTests = ReadSettingsNumberOfTests(doc);

            return settings;
        }

        private static int ReadSettingsNumberOfTests(XDocument doc)
        {
            int defaultCount = 10;
            try
            {
                string countAsString = (from _settings in doc.Root.Elements("Settings")
                                        select _settings.Element("NumberOfTests").Value).FirstOrDefault();
                int count;
                if (Int32.TryParse(countAsString, out count))
                    return count;
                else
                    return defaultCount;

            }
            catch (Exception)
            {
                doc.Root.Element("Settings").Add(
                    new XElement("NumberOfTests", defaultCount)
                );
                doc.Save(Program.DatabaseXmlFile);
                return defaultCount;
            }
        }

        private static string ReadSettingsAdminPassword(XDocument doc)
        {
            string defaultPassword = "sound";
            try
            {
                string password = (from _settings in doc.Root.Elements("Settings")
                                   select _settings.Element("AdminPassword").Value).FirstOrDefault();
                return password;

            }
            catch (Exception)
            {
                doc.Root.Element("Settings").Add(
                    new XElement("AdminPassword", defaultPassword)
                );
                doc.Save(Program.DatabaseXmlFile);
                return defaultPassword;
            }
        }

        private static string ReadSettingsResultsFile(XDocument doc)
        {
            string defaultDirectory = string.Empty;
            try
            {
                string resultsFile = (from _settings in doc.Root.Elements("Settings")
                                      select _settings.Element("ResultsFile").Value).FirstOrDefault();
                return resultsFile;

            }
            catch (Exception)
            {
                doc.Root.Element("Settings").Add(
                    new XElement("ResultsFile", defaultDirectory)
                );
                doc.Save(Program.DatabaseXmlFile);
                return defaultDirectory;
            }
        }
        #endregion

        #region Results

        public static string CreateResultFile(AbxTest abxTestToCreate)
        {
            string testDate = abxTestToCreate.Date.ToString("yyyy-MM-dd");
            string subjectName = Regex.Replace(abxTestToCreate.SubjectName, "[^0-9A-Za-z]+", "");
            string fileName = string.Format("{0}_{1}_1.xml", testDate, subjectName);
            string directory = Program.Settings.GetResultDirectory;
            string fullFileName = Path.Combine(directory, fileName);

            int i = 2;
            while(File.Exists(fullFileName))
            {
                fileName = string.Format("{0}_{1}_{2}.xml", testDate, subjectName, i);
                fullFileName = Path.Combine(directory, fileName);
                i++;
            }

            using (XmlWriter writer = XmlWriter.Create(fullFileName))
            {
                writer.WriteStartElement("SimpleAbxResults");

                writer.WriteStartElement("Data");
                writer.WriteStartElement("Name");
                writer.WriteEndElement();
                writer.WriteStartElement("Date");
                writer.WriteEndElement();
                writer.WriteStartElement("SoundFileA");
                writer.WriteEndElement();
                writer.WriteStartElement("SoundFileB");
                writer.WriteEndElement();
                writer.WriteStartElement("Score");
                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteStartElement("Results");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.Flush();
            }

            XDocument doc = XDocument.Load(fullFileName);
            XElement root = doc.Root;

            var target = doc.Root.Element("Data");
            target.Element("Name").Value = subjectName;
            target.Element("Date").Value = abxTestToCreate.Date.ToString();
            target.Element("SoundFileA").Value = abxTestToCreate.SoundFileA;
            target.Element("SoundFileB").Value = abxTestToCreate.SoundFileB;

            doc.Save(fullFileName);

            return fullFileName;
        }

        public static List<Result> ReadResultList(string file)
        {
            try
            {
                XDocument xdoc = XDocument.Load(file);
                var resultList = (from _result in xdoc.Root.Element("Results").Elements("Result")
                        select new Result
                        {
                            TestNumber = int.Parse(_result.Element("TestNumber").Value),
                            SelectedAnswer = _result.Element("SelectedAnswer").Value,
                            CorrectAnswer = _result.Element("CorrectAnswer").Value
                        }).ToList();

                resultList.FirstOrDefault().ProbandName = ReadResultName(xdoc);
                if (resultList.Count > 3)
                {
                    resultList.ElementAt(1).ProbandName = ReadResultSoundFileA(xdoc);
                    resultList.ElementAt(2).ProbandName = ReadResultSoundFileB(xdoc);
                }


                return resultList;
            }
            catch
            {
                return new List<Result>();
            }
        }


        public static void AddResult(Result resultToAdd, AbxTest abxTest)
        {
            XDocument doc = XDocument.Load(abxTest.File);

            doc.Root.Element("Results").Add(
                 new XElement("Result",
                        new XElement("TestNumber", resultToAdd.TestNumber),
                        new XElement("SelectedAnswer", resultToAdd.SelectedAnswer),
                        new XElement("CorrectAnswer", resultToAdd.CorrectAnswer)
                        )
                 );

            doc.Save(abxTest.File);
        }

        private static string ReadResultName(XDocument xdoc)
        {
            try
            {
                string name = (from _settings in xdoc.Root.Elements("Data")
                                      select _settings.Element("Name").Value).FirstOrDefault();

                string date = (from _settings in xdoc.Root.Elements("Data")
                               select _settings.Element("Date").Value).FirstOrDefault();

                return string.Format("{0} {1}", name, date);

            }
            catch
            {
                return string.Empty;
            }
        }

        private static string ReadResultSoundFileA(XDocument xdoc)
        {
            try
            {
                string soundFile = (from _settings in xdoc.Root.Elements("Data")
                               select _settings.Element("SoundFileA").Value).FirstOrDefault();

                return string.Format("Sound A: {0}", Path.GetFileName(soundFile));

            }
            catch
            {
                return string.Empty;
            }
        }

        private static string ReadResultSoundFileB(XDocument xdoc)
        {
            try
            {
                string soundFile = (from _settings in xdoc.Root.Elements("Data")
                                    select _settings.Element("SoundFileB").Value).FirstOrDefault();

                return string.Format("Sound B: {0}", Path.GetFileName(soundFile));

            }
            catch
            {
                return string.Empty;
            }
        }

        public static void UpdateTestScore(AbxTest abxTest)
        {
            XDocument doc = XDocument.Load(abxTest.File);

            XElement root = doc.Root;

            var target = doc.Root.Element("Data");
            target.Element("Score").Value = abxTest.Score.ToString();

            doc.Save(abxTest.File);
        }

        #endregion

        #region UpdateSettings
        public static void UpdateSettings(Settings settings)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);
            XElement root = doc.Root;

            var target = doc.Root.Element("Settings");
            target.Element("ResultsFile").Value = settings.ResultsDirectory;
            target.Element("AdminPassword").Value = settings.AdminPassword;
            target.Element("NumberOfTests").Value = settings.NumberOfTests.ToString();

            doc.Save(Program.DatabaseXmlFile);
        }

        #endregion
    }
}
