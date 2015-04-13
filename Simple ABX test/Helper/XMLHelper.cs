using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

            settings.SoundFileOne = ReadSettingsSoundFileOne(doc);
            settings.SoundFileTwo = ReadSettingsSoundFileTwo(doc);
            settings.ResultsDirectory = ReadSettingsResultsFile(doc);
            settings.AdminPassword = ReadSettingsAdminPassword(doc);
            settings.NumberOfTests = ReadSettingsNumberOfTests(doc);
            settings.LoopSound = ReadSettingsLoopSound(doc);

            return settings;
        }

        private static bool ReadSettingsLoopSound(XDocument doc)
        {
            bool defaultLoop = true;
            try
            {
                string loopAsString = (from _settings in doc.Root.Elements("Settings")
                                        select _settings.Element("LoopSound").Value).FirstOrDefault();
                return loopAsString == "false" ? false : true;

            }
            catch (Exception)
            {
                doc.Root.Element("Settings").Add(
                    new XElement("LoopSound", defaultLoop)
                );
                doc.Save(Program.DatabaseXmlFile);
                return defaultLoop;
            }
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

        private static string ReadSettingsSoundFileTwo(XDocument doc)
        {
            try
            {
                string fileTwo = (from _settings in doc.Root.Elements("Settings")
                                  select _settings.Element("SoundFileTwo").Value).FirstOrDefault();
                return fileTwo;

            }
            catch (Exception)
            {
                doc.Root.Element("Settings").Add(
                    new XElement("SoundFileTwo", string.Empty)
                );
                doc.Save(Program.DatabaseXmlFile);
                return string.Empty;
            }
        }

        private static string ReadSettingsSoundFileOne(XDocument doc)
        {
            try
            {
                string fileOne = (from _settings in doc.Root.Elements("Settings")
                                  select _settings.Element("SoundFileOne").Value).FirstOrDefault();
                return fileOne;

            }
            catch (Exception)
            {
                doc.Root.Element("Settings").Add(
                    new XElement("SoundFileOne", string.Empty)
                );
                doc.Save(Program.DatabaseXmlFile);
                return string.Empty;
            }
        }
        #endregion

        #region Results

        public static string CreateResultsFile(string probandName)
        {
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd");
            string fileName = string.Format("{0}_{1}.xml", currentTime, probandName);
            string directory = string.IsNullOrEmpty(Program.Settings.ResultsDirectory) ? Program.AppDirectory : Program.Settings.ResultsDirectory;
            string fullFileName = Path.Combine(directory, fileName);
            if (File.Exists(fullFileName))
                File.Delete(fullFileName);

            using (XmlWriter writer = XmlWriter.Create(fullFileName))
            {
                writer.WriteStartElement("SimpleAbxResults");

                writer.WriteStartElement("Data");
                writer.WriteStartElement("Name");
                writer.WriteEndElement();
                writer.WriteStartElement("Date");
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
            target.Element("Name").Value = probandName;
            target.Element("Date").Value = currentTime;

            doc.Save(fullFileName);

            return fullFileName;
        }

        public static List<TestResult> ReadResultList(string file)
        {
            try
            {
                XDocument xdoc = XDocument.Load(file);
                var resultList = (from _result in xdoc.Root.Element("Results").Elements("Result")
                        select new TestResult
                        {
                            TestNumber = int.Parse(_result.Element("TestNumber").Value),
                            SelectedAnswer = _result.Element("SelectedAnswer").Value,
                            CorrectAnswer = _result.Element("CorrectAnswer").Value
                        }).ToList();

                resultList.FirstOrDefault().ProbandName = ReadResultName(xdoc);

                return resultList;
            }
            catch
            {
                return new List<TestResult>();
            }
        }


        public static void AddResult(TestResult resultToAdd, string file)
        {
            XDocument doc = XDocument.Load(file);

            doc.Root.Element("Results").Add(
                 new XElement("Result",
                        new XElement("TestNumber", resultToAdd.TestNumber),
                        new XElement("SelectedAnswer", resultToAdd.SelectedAnswer),
                        new XElement("CorrectAnswer", resultToAdd.CorrectAnswer)
                        )
                 );

            doc.Save(file);
        }

        private static string ReadResultName(XDocument xdoc)
        {
            try
            {
                string name = (from _settings in xdoc.Root.Elements("Data")
                                      select _settings.Element("Name").Value).FirstOrDefault();

                string date = (from _settings in xdoc.Root.Elements("Data")
                               select _settings.Element("Date").Value).FirstOrDefault();

                return string.Format("{0} {1}", date, name);

            }
            catch
            {
                return string.Empty;
            }
        }

        public static void UpdateTestScore(decimal score, string file)
        {
            XDocument doc = XDocument.Load(file);

            XElement root = doc.Root;

            var target = doc.Root.Element("Data");
            target.Element("Score").Value = score.ToString();

            doc.Save(file);
        }

        #endregion

        #region UpdateSettings
        public static void UpdateSettings(Settings settings)
        {
            XDocument doc = XDocument.Load(Program.DatabaseXmlFile);
            XElement root = doc.Root;

            var target = doc.Root.Element("Settings");
            target.Element("SoundFileOne").Value = settings.SoundFileOne;
            target.Element("SoundFileTwo").Value = settings.SoundFileTwo;
            target.Element("ResultsFile").Value = settings.ResultsDirectory;
            target.Element("AdminPassword").Value = settings.AdminPassword;
            target.Element("NumberOfTests").Value = settings.NumberOfTests.ToString();
            target.Element("LoopSound").Value = settings.LoopSound ? "true" : "false";

            doc.Save(Program.DatabaseXmlFile);
        }

        #endregion
    }
}
