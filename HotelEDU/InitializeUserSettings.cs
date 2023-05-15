using System;
using System.Configuration;
using System.IO;
using System.Xml;

namespace HotelEDU
{
    class InitializeUserSettings
    {
        private string ConnectionString { get; set; }
        private string UserPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HotelEDU";

        public InitializeUserSettings()
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HotelEDU"))
            {
                CreateProgramFolders();
            }
            else
            {
                UserXmlRead();
                SetApplicationConfig();
            }
        }

        private void CreateProgramFolders()
        {
            string DBFolderPath = UserPath + @"\DataBase";

            Directory.CreateDirectory(UserPath);
            Directory.CreateDirectory(DBFolderPath);

            string[] DBFiles = Directory.GetFiles(@"Database");
            foreach (var DBFile in DBFiles)
            {
                FileInfo fi = new FileInfo(DBFile);
                fi.CopyTo(DBFolderPath + @"\" + fi.Name, true);
            }
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = " + DBFolderPath + @"\HotelEDUdb.mdf; Integrated Security = True; Connect Timeout=30";
            UserXmlWrite();
            SetApplicationConfig();
        }

        private void UserXmlWrite()
        {
            XmlWriter xmlWriter = XmlWriter.Create(UserPath + @"\UserConfig.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("UserSettings");

            xmlWriter.WriteStartElement("ConnectionString");
            xmlWriter.WriteString(ConnectionString);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("UserPath");
            xmlWriter.WriteString(UserPath);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }

        private void UserXmlRead()
        {
            FileStream stream = new FileStream(UserPath + @"\UserConfig.xml", FileMode.Open, FileAccess.Read);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(stream);
            var nodes = xmlDoc.DocumentElement.ChildNodes;
            ConnectionString = nodes[0].InnerText;
        }

        private void SetApplicationConfig()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Remove("HotelEDU.Properties.Settings.HotelEDUdbConnectionString");
            config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("HotelEDU.Properties.Settings.HotelEDUdbConnectionString", ConnectionString, "System.Data.SqlClient"));
            config.AppSettings.Settings.Add("UserPath", UserPath);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}

