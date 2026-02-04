using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvs_test_05.Common
{
    public class ApplicationTranslator
    {
        // Код текущего языка
        private Language _language;
        // Словарь русского языка
        private Dictionary<string, string> _RU;
        // Словарь английского языка
        private Dictionary<string, string> _EN;
        
        /// <summary>
        /// Установка значения кода языка
        /// </summary>
        /// <param name="lang">Код языка для перевода</param>
        public void SetLanguage(Language language)
        {
            _language = language;
        }

        public Language GetLanguage()
        {
            return _language;
        }
        
        /// <summary>
        /// Функция для получения текстовой константы по ключу
        /// </summary>
        /// <param name="key">Ключ текстовой константы</param>
        /// <returns>Локализованная текстовая константа или пустая строка (если словарь не существует или заданный ключ не найден)</returns>
        public string GetText(string key)
        {
            try
            {
                switch (_language)
                {
                    case Language.EN:
                        if (_EN == null)
                            return String.Empty;
                        if (!_EN.ContainsKey(key))
                            return String.Empty;
                        return _EN[key];
                    case Language.RU:
                        if (_RU == null)
                            return String.Empty;
                        if (!_RU.ContainsKey(key))
                            return String.Empty;
                        return _RU[key];
                    default:
                        if (_RU == null)
                            return String.Empty;
                        if (!_RU.ContainsKey(key))
                            return String.Empty;
                        return _RU[key];
                }
            }
            catch {
                // В случае возникновения исключения возвращаем строку
                return String.Empty;
            }
            
        }

        /// <summary>
        /// Инициализация переводчика
        /// </summary>
        public ApplicationTranslator()
        {
            TranslatorInitialization();
        }

        /// <summary>
        /// Создание словарей и определение языковых констант
        /// </summary>
        private void TranslatorInitialization()
        {
            // Создаем пустые словари
            _RU = new Dictionary<string, string>();
            _EN = new Dictionary<string, string>();
            
            // Название фирмы
            _RU.Add("APP_FIRM", "ООО «ЦКТИ-Вибросейсм»");
            _EN.Add("APP_FIRM", "CKTI-Vibroseism Ltd.");
            
            #region Метки на лейблах
            // Окно приветствия статус загрузки
            _RU.Add("LB_STARTED", "Запуск приложения ...");
            _EN.Add("LB_STARTED", "Application started ...");

            // Главное окно
            _RU.Add("LB_OUTER_DIAMETER", "Внешний диаметр");
            _EN.Add("LB_OUTER_DIAMETER", "Outer diameter");
            _RU.Add("LB_INNER_DIAMETER", "Внутренний диаметр");
            _EN.Add("LB_INNER_DIAMETER", "Inner diameter");
            _RU.Add("LB_PIPE_THICKNESS", "Толщина стенки");
            _EN.Add("LB_PIPE_THICKNESS", "Thickness");
            _RU.Add("LB_CALC_MODE", "Режим расчета");
            _EN.Add("LB_CALC_MODE", "Calculation mode");
            _RU.Add("LB_PIPE_CROSS_AREA", "Площадь сечения");
            _EN.Add("LB_PIPE_CROSS_AREA", "Cross-sectional area");
            _RU.Add("LB_MOMENT_INERTIA", "Момент инерции");
            _EN.Add("LB_MOMENT_INERTIA", "Moment of inertia");
            _RU.Add("LB_MOMENT_RESISTANCE", "Момент сопротивления");
            _EN.Add("LB_MOMENT_RESISTANCE", "Moment resistance");

            _RU.Add("LB_MM", "(мм)");
            _EN.Add("LB_MM", "(mm)");
            _RU.Add("LB_MM2", "(мм^2)");
            _EN.Add("LB_MM2", "(mm^2)");
            _RU.Add("LB_MM3", "(мм^3)");
            _EN.Add("LB_MM3", "(mm^3)");
            _RU.Add("LB_MM4", "(мм^4)");
            _EN.Add("LB_MM4", "(mm^4)");

            // Окно о программе
            _RU.Add("LB_VERSION", "Версия приложения:");
            _EN.Add("LB_VERSION", "Application version:");
            _RU.Add("LB_FORUM", "Форум:");
            _EN.Add("LB_FORUM", "Forum:");
            _RU.Add("LB_SUPPORT", "Поддержка:");
            _EN.Add("LB_SUPPORT", "Support:");

            // Окно настроек
            _RU.Add("LB_LANGUAGE", "Язык интерфейса");
            _EN.Add("LB_LANGUAGE", "GUI language");
            _RU.Add("LB_DECIMAL_PLACES", "Количество знаков");
            _EN.Add("LB_DECIMAL_PLACES", "Decimal places");

            _RU.Add("LB_SPLASH_SCREEN", "Окно приветствия");
            _EN.Add("LB_SPLASH_SCREEN", "Splash screen");

            #endregion

            #region Заголовки гроупбоксов

            // Главное окно
            _RU.Add("GRP_INPUT_DATA", "Входные данные");
            _EN.Add("GRP_INPUT_DATA", "Input data");
            _RU.Add("GRP_OUTPUT_DATA", "Выходные данные");
            _EN.Add("GRP_OUTPUT_DATA", "Output data");

            #endregion

            #region Кнопки
            _RU.Add("BT_CALCULATE", "РАСЧЕТ");
            _EN.Add("BT_CALCULATE", "CALCULATE");
            _RU.Add("BT_REPORT", "ОТЧЕТ");
            _EN.Add("BT_REPORT", "REPORT");
            _RU.Add("BT_SETTINGS", "НАСТРОЙКИ");
            _EN.Add("BT_SETTINGS", "SETTINGS");
            _RU.Add("BT_EXIT", "ВЫХОД");
            _EN.Add("BT_EXIT", "EXIT");
            _RU.Add("BT_OK", "OK");
            _EN.Add("BT_OK", "OK");
            _RU.Add("BT_CANCEL", "ОТМЕНА");
            _EN.Add("BT_CANCEL", "CANCEL");
            #endregion

            // Диалог закрытия окна приложения
            _RU.Add("DLG_CONFIRMATION", "Подтверждение");
            _EN.Add("DLG_CONFIRMATION", "Confirmation");
            _RU.Add("DLG_WARNING", "Внимание");
            _EN.Add("DLG_WARNING", "Warning");
            _RU.Add("DLG_INFORMATION", "Информация");
            _EN.Add("DLG_INFORMATION", "Information");
            _RU.Add("DLG_CLOSE_APP", "Вы действительно хотите закрыть приложение?");
            _EN.Add("DLG_CLOSE_APP", "Do you realy want to close the application?");

            // Тултипы
            _RU.Add("TLT_ABOUT", "О программе");
            _EN.Add("TLT_ABOUT", "About");
            _RU.Add("TLT_CALC", "Расчет характеристик");
            _EN.Add("TLT_CALC", "Calculation of characteristics");

            // Окно настроек - Имена закладок
            _RU.Add("TAB_GENERAL", "Основные");
            _EN.Add("TAB_GENERAL", "General");
            _RU.Add("TAB_CALC", "Параметры расчета");
            _EN.Add("TAB_CALC", "Calculation parameters");

            // Заголовки окон
            _RU.Add("TITLE_MAIN", "Расчет характеристик сечения трубы");
            _EN.Add("TITLE_MAIN", "Calculation of pipe cross-section characteristics");
            _RU.Add("TITLE_ABOUT", "О программе");
            _EN.Add("TITLE_ABOUT", "About");
            _RU.Add("TITLE_SETTINGS", "Настройки");
            _EN.Add("TITLE_SETTINGS", "Settings");

            // Сообщения об ошибках
            _RU.Add("TXT_PARAMETER", "Параметр");
            _EN.Add("TXT_PARAMETER", "The parameter");
            _RU.Add("TXT_MUSTBEGREATE", "должен быть больше чем");
            _EN.Add("TXT_MUSTBEGREATE", "must be greater than");
            _RU.Add("TXT_INCORRECTLY", "задан неверно");
            _EN.Add("TXT_INCORRECTLY", "is specified incorrectly");

            _RU.Add("TXT_DONE", "Расчет закончен.");
            _EN.Add("TXT_DONE", "The calculation is complete.");
        }
    }
}
