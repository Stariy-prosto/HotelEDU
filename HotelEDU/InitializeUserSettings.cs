using System;
using System.Configuration;
using System.IO;
using System.Xml;

namespace HotelEDU
{
    class InitializeUserSettings
    {
        //Пользовательские настройки
        //Строка подключения к базе данных
        private string ConnectionString { get; set; }
        //Строка хранения папки с базой данных и файлом конфигурации (По-умолчанию "Документы\HotelEDU")
        private string UserPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HotelEDU";

        public InitializeUserSettings()
        {
            //Проверка наличия папки с базой данных
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

        //Метод создающий программные папки HotelEDU и HotelEDU\DataBase
        private void CreateProgramFolders()
        {
            //Строка хранения HotelEDU\DataBase
            string DBFolderPath = UserPath + @"\DataBase";

            //Создание папок HotelEDU и HotelEDU\DataBase
            Directory.CreateDirectory(UserPath);
            Directory.CreateDirectory(DBFolderPath);

            //Копирование файлов базы данных из корневой папки приложения
            string[] DBFiles = Directory.GetFiles(@"Database");
            foreach (var DBFile in DBFiles)
            {
                FileInfo fi = new FileInfo(DBFile);
                fi.CopyTo(DBFolderPath + @"\" + fi.Name, true);
            }
            //Формирование строки подключения к базе данных
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = " + DBFolderPath + @"\HotelEDUdb.mdf; Integrated Security = True; Connect Timeout=30";
            UserXmlWrite();
            SetApplicationConfig();
        }

        //Запись пользовательских настроек в файл UserConfig.xml
        private void UserXmlWrite()
        {
            //Создание xml файла
            XmlWriter xmlWriter = XmlWriter.Create(UserPath + @"\UserConfig.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("UserSettings");
            //Запись данных строки подключения в файл конфигурации
            xmlWriter.WriteStartElement("ConnectionString");
            xmlWriter.WriteString(ConnectionString);
            xmlWriter.WriteEndElement();
            //Запись строки хранения папки с базой данных и файлом конфигурации в файл конфигурации
            xmlWriter.WriteStartElement("UserPath");
            xmlWriter.WriteString(UserPath);
            xmlWriter.WriteEndElement();
            //Закрытие xml файла
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }

        //Чтение пользовательских настроек из файла UserConfig.xml
        private void UserXmlRead()
        {
            FileStream stream = new FileStream(UserPath + @"\UserConfig.xml", FileMode.Open, FileAccess.Read);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(stream);
            var nodes = xmlDoc.DocumentElement.ChildNodes;
            ConnectionString = nodes[0].InnerText;
            UserPath = nodes[1].InnerText;
        }

        //Присвоение пользовательских настроек приложению
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

