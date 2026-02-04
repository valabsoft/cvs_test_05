using DevExpress.Data.TreeList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cvs_test_05.Common
{
    /// <summary>
    /// Языковые настройки
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// RU - Поддержка русского языка
        /// </summary>
        RU = 0,
        /// <summary>
        /// EN - Поддержка английского языка
        /// </summary>
        EN = 1
    }

    [Serializable]
    public class ApplicationSettings
    {
        // Имя файла с настройками приложения
        private string _settingsFile;

        [XmlElement("Language")]
        public Language Language { get; set; }
       
        [XmlElement("CalculationMode")]
        public CalculationMode CalculationMode { get; set; }

        [XmlElement("DecimalPlaces")]
        public decimal DecimalPlaces { get; set; }
        

        public ApplicationSettings()
        {
            // По умолчанию файл с настройками лежит в папке приложения
            _settingsFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "cvs-test-05.dat");

            Language = Language.RU;
            CalculationMode = CalculationMode.DS;
            DecimalPlaces = 1;
        }
                
        /// <summary>
        /// Загрузка настроек из файла
        /// </summary>
        public void Load()
        {
            if (File.Exists(_settingsFile))
            {
                try
                {
                    String serializedString = System.IO.File.ReadAllText(_settingsFile);
                    this.DeserializeFromString(serializedString);
                }
                catch (Exception ex) { }
            }
        }
        /// <summary>
        /// Сохранение настроек в файл
        /// </summary>
        public void Save()
        {
            try
            {
                String serializedString = this.SerializeToString();
                System.IO.File.WriteAllText(_settingsFile, serializedString);
            }
            catch (Exception ex) { }
        }
        /// <summary>
        /// Сериализация настроек в строку
        /// </summary>
        /// <returns>XML-строка с настройками программы</returns>
        public String SerializeToString()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
                StringWriter textWriter = new StringWriter();

                xmlSerializer.Serialize(textWriter, this);
                return textWriter.ToString();
            }
            catch (Exception ex)
            {
                return String.Empty;
            }
        }
        /// <summary>
        /// Десериализация строки
        /// </summary>
        /// <param name="data">Результат десериализации</param>
        public void DeserializeFromString(string data)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(GetType());
                using (TextReader reader = new StringReader(data))
                {
                    ApplicationSettings temp = (ApplicationSettings)xmlSerializer.Deserialize(reader);

                    this.Language = temp.Language;
                    this.CalculationMode = temp.CalculationMode;
                    this.DecimalPlaces = temp.DecimalPlaces;
                }
            }
            catch (Exception ex) { }
        }
    }
}
