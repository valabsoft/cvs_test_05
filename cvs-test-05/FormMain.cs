using cvs_test_05.Common;
using cvs_test_05.Properties;
using DevExpress.Data;
using DevExpress.LookAndFeel.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace cvs_test_05
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        // Переводчик интерфейса
        private ApplicationTranslator _appTr;
        private ApplicationSettings _appSet;
        private PipeModel _pipeModel;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            try
            {
                // Объект для работы с локализацией настроек
                _appTr = new ApplicationTranslator();

                // Объект для работы с настройками приложения
                _appSet = new ApplicationSettings();

                // Объект для работы с расчетами модели
                _pipeModel = new PipeModel();
            }
            catch (Exception ex)
            {
                // TODO: Добавить обработчик иключения
            }
            
            // Спрятать основную форму для показа заставки
            this.Opacity = 0;
        }
        /// <summary>
        /// Загрузка главного окна приложения
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            #region Загрузка настроек приложения
            // Загружаем настройки из файла
            if (_appSet == null)
                _appSet = new ApplicationSettings();
            
            _appSet.Load();

            // Мепинг параметров            
            cboxCalculationMode.SelectedIndex = (int)_appSet.CalculationMode;
            
            // Сброс вычислительных полей
            editOutD.Text = DoubleToStr(0.0, _appSet.DecimalPlaces);
            editInD.Text = DoubleToStr(0.0, _appSet.DecimalPlaces);
            
            editS.Text = DoubleToStr(0.0, _appSet.DecimalPlaces);
            editJ.Text = DoubleToStr(0.0, _appSet.DecimalPlaces);
            editW.Text = DoubleToStr(0.0, _appSet.DecimalPlaces);
            #endregion

            #region Переводим интерфейс
            if (_appTr == null)
                _appTr = new ApplicationTranslator();
            
            // Перевод интерфейса
            TranslateGUI(_appSet.Language);
            #endregion

            // Установка фокуса
            buttonAbout.Select();
            
            // Закрываем окно приветствия            
            SplashScreenManager.CloseForm(false);
        }
        /// <summary>
        /// Заглушка - имитация загрузки данных программы
        /// </summary>
        public void InitializeApplication()
        {
            // Иммитация ресурсоемкой операции (подключение к базе, загрузка данных и т.д.)
            Thread.Sleep(3000);
        }
        /// <summary>
        /// Перевод интерфейса программы (локализация)
        /// </summary>
        /// <param name="lang">Язык интерфейса: RU - Русский; EN - English</param>
        public void TranslateGUI(Language lang = Language.RU)
        {
            // Устанавливаем текущий язык
            _appTr.SetLanguage(lang);

            #region Перевод интерфейса
            // Заголовок окна
            // Получаем текущую сборку
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = assembly.GetName();
            Version version = assemblyName.Version;
            this.Text = $"{_appTr.GetText("TITLE_MAIN")} {version.Major}.{version.Minor}";

            // Обновляем рисунок с условными обозначениями
            switch (_appTr.GetLanguage())
            {
                case Language.EN:
                    pictureEditScheme.Image = Properties.Resources.SchemeEN;
                    break;
                case Language.RU:
                    pictureEditScheme.Image = Properties.Resources.SchemeRU;
                    break;
                default:
                    pictureEditScheme.Image = Properties.Resources.SchemeEN;
                    break;
            }

            // Перевод
            groupInputData.Text = _appTr.GetText("GRP_INPUT_DATA");
            labelOutD.Text = _appTr.GetText("LB_OUTER_DIAMETER");

            switch (cboxCalculationMode.SelectedIndex)
            {
                case 0:
                    labelInD.Text = _appTr.GetText("LB_PIPE_THICKNESS");
                    break;
                case 1:
                    labelInD.Text = _appTr.GetText("LB_INNER_DIAMETER");
                    break;
                default:
                    labelInD.Text = _appTr.GetText("LB_PIPE_THICKNESS");
                    break;
            }

            labelCalculationMode.Text = _appTr.GetText("LB_CALC_MODE");

            groupOutputData.Text = _appTr.GetText("GRP_OUTPUT_DATA");
            labelS.Text = _appTr.GetText("LB_PIPE_CROSS_AREA");
            labelJ.Text = _appTr.GetText("LB_MOMENT_INERTIA");
            labelW.Text = _appTr.GetText("LB_MOMENT_RESISTANCE");

            buttonCalc.Text = _appTr.GetText("BT_CALCULATE");
            buttonReport.Text = _appTr.GetText("BT_REPORT");
            buttonSettings.Text = _appTr.GetText("BT_SETTINGS");
            buttonExit.Text = _appTr.GetText("BT_EXIT");

            labelOutDDim.Text = _appTr.GetText("LB_MM");
            labelInDDim.Text = _appTr.GetText("LB_MM");
            labelSDim.Text = _appTr.GetText("LB_MM2");
            labelJDim.Text = _appTr.GetText("LB_MM4");
            labelWDim.Text = _appTr.GetText("LB_MM3");

            buttonAbout.ToolTip = _appTr.GetText("TLT_ABOUT");
            buttonCalcalute.ToolTip = _appTr.GetText("TLT_CALC");
            #endregion
        }
        /// <summary>
        /// Обработчик показа формы (сброс служебного флага)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        #region Обработчики нажатий на кнопки        
        /// <summary>
        /// Обработчик нажатия на кнопку РАСЧЕТ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Расчет характеристик
            PipeCalculation();
        }
        /// <summary>
        /// Обработчик нажатия на кнопку РАСЧЕТ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            // Расчет характеристик
            PipeCalculation();
        }
        /// <summary>
        /// Обработчик нажатия на кнопку ОТЧЕТ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                // Создаем объект отчета
                XtraReport report = new XtraReport();

                // Формируем набор параметров для генерации отчета
                report.pReportTitle.Value = _appTr.GetText("TITLE_MAIN");

                report.pOutDTitle.Value = _appTr.GetText("LB_OUTER_DIAMETER");
                report.pInDTitle.Value = _appTr.GetText("LB_INNER_DIAMETER");
                report.pTTitle.Value = _appTr.GetText("LB_PIPE_THICKNESS");

                report.pSTitle.Value = _appTr.GetText("LB_PIPE_CROSS_AREA");
                report.pJTitle.Value = _appTr.GetText("LB_MOMENT_INERTIA");
                report.pWTitle.Value = _appTr.GetText("LB_MOMENT_RESISTANCE");

                report.pOutDValue.Value = DoubleToStr(_pipeModel.OuterDiameter, _appSet.DecimalPlaces);
                report.pInDValue.Value = DoubleToStr(_pipeModel.InnerDiameter, _appSet.DecimalPlaces);
                report.pTValue.Value = DoubleToStr(_pipeModel.Thickness, _appSet.DecimalPlaces);

                report.pSValue.Value = DoubleToStr(_pipeModel.Area, _appSet.DecimalPlaces);
                report.pJValue.Value = DoubleToStr(_pipeModel.MomentInertia, _appSet.DecimalPlaces);
                report.pWValue.Value = DoubleToStr(_pipeModel.MomentResistance, _appSet.DecimalPlaces);

                report.pFirm.Value = _appTr.GetText("APP_FIRM");
                report.pMM.Value = _appTr.GetText("LB_MM_REPORT");
                
                // Предотвращаем показ служебного окна с параметрами
                report.RequestParameters = false;

                // Подготавливаем окно для показа превью отчета
                ReportPrintTool reportPrintTool = new ReportPrintTool(report);
                reportPrintTool.PreviewForm.StartPosition = FormStartPosition.CenterParent;
                reportPrintTool.ShowPreviewDialog();
            }
            catch
            {
                // TODO: Добавить диагоностический лог
            }            
            Cursor.Current = Cursors.Default;
        }
        /// <summary>
        /// Обработчик нажатия на кнопку НАСТРОЙКИ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            using (FormSettings formSettings = new FormSettings())
            {
                if (formSettings.ShowDialog() == DialogResult.OK)
                {
                    // Запоминаем старые настройки
                    Language lang = _appSet.Language;
                    CalculationMode mode = _appSet.CalculationMode;
                    decimal dcml = _appSet.DecimalPlaces;

                    // Если пользовать нажал ОК - нужно обновить настройки
                    _appSet.Load();

                    // Изменить интерфейс приложения
                    if (lang != _appSet.Language)
                        TranslateGUI(_appSet.Language);

                    // Изменить режим вычсилений
                    if (mode != _appSet.CalculationMode)
                        cboxCalculationMode.SelectedIndex = (int)_appSet.CalculationMode;

                    // Изменить кол-во знаков после запятой
                    if (dcml != _appSet.DecimalPlaces)
                    {
                        double OutD = StrToDouble(editOutD.Text);
                        double InD = StrToDouble(editInD.Text);

                        double S = StrToDouble(editS.Text);
                        double J = StrToDouble(editJ.Text);
                        double W = StrToDouble(editW.Text);

                        editOutD.Text = DoubleToStr(OutD, _appSet.DecimalPlaces);
                        editInD.Text = DoubleToStr(InD, _appSet.DecimalPlaces);

                        editS.Text = DoubleToStr(S, _appSet.DecimalPlaces);
                        editJ.Text = DoubleToStr(J, _appSet.DecimalPlaces);
                        editW.Text = DoubleToStr(W, _appSet.DecimalPlaces);
                    }
                }
            }
        }
        /// <summary>
        /// Обработчик нажатия на кнопку ВЫХОД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Обработчик нажатия на кнопку О ПРОГРАММЕ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            using (FormAbout formAbout = new FormAbout())
            {
                formAbout.ShowDialog();
            }
        }

        #endregion
        /// <summary>
        /// Обработчик закрытия главного окна приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show(
                _appTr.GetText("DLG_CLOSE_APP"),
                _appTr.GetText("DLG_CONFIRMATION"),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Обработчик события - Смена режима вычислений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxCalculationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // В зависимости от выбора пользователя меняем текст на лейбле второго параметра
            switch (cboxCalculationMode.SelectedIndex)
            {
                case 0:
                    labelInD.Text = _appTr.GetText("LB_PIPE_THICKNESS");
                    break;
                case 1:
                    labelInD.Text = _appTr.GetText("LB_INNER_DIAMETER");
                    break;
                default:
                    labelInD.Text = _appTr.GetText("LB_PIPE_THICKNESS");
                    break;
            }
        }
        /// <summary>
        /// Основная функция расчета параметров сечения трубы
        /// </summary>
        private void PipeCalculation()
        {
            // Чтение параметров
            double OutD = StrToDouble(editOutD.Text);
            double InD = StrToDouble(editInD.Text);
            
            // Корректировка кол-ва знаков после запятой
            editOutD.Text = DoubleToStr(OutD, _appSet.DecimalPlaces);
            editInD.Text = DoubleToStr(InD, _appSet.DecimalPlaces);

            // Режим по умолчанию
            CalculationMode mode = CalculationMode.DS;
            // Читаем активный режим и выполняем расчет
            if (_pipeModel != null)
            {
                // Уставка параметров
                switch (cboxCalculationMode.SelectedIndex)
                {
                    case 0: // D-s
                        mode = CalculationMode.DS;                        
                        break;
                    case 1: // D-d
                        mode = CalculationMode.DD;
                        break;
                }
                // Передаем параметры в модель для расчетов
                int res = _pipeModel.SetCalculationParameters(OutD, InD, mode);
                editS.Text = DoubleToStr(0.00, _appSet.DecimalPlaces);
                editJ.Text = DoubleToStr(0.00, _appSet.DecimalPlaces);
                editW.Text = DoubleToStr(0.00, _appSet.DecimalPlaces);
                // Анализ результатов расчета, при возникновении ошибки - выводим соответствующее предупреждение
                switch (res)
                {
                    // -1 - Признак возникновения исключительной ситуации
                    case 0: // 0 - Признак успешного выполнения
                        // Расчет характеристик
                        _pipeModel.Calculate();

                        editS.Text = DoubleToStr(_pipeModel.Area, _appSet.DecimalPlaces).ToString();
                        editJ.Text = DoubleToStr(_pipeModel.MomentInertia, _appSet.DecimalPlaces).ToString();
                        editW.Text = DoubleToStr(_pipeModel.MomentResistance, _appSet.DecimalPlaces).ToString();

                        XtraMessageBox.Show(
                            _appTr.GetText("TXT_DONE"),
                            _appTr.GetText("DLG_INFORMATION"),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        buttonReport.Select();

                        break;
                    case 1: // 1 - Значение первого параметра задано неверно
                        XtraMessageBox.Show(
                            $"{_appTr.GetText("TXT_PARAMETER")} <{labelOutD.Text}> {_appTr.GetText("TXT_INCORRECTLY")}!",
                            _appTr.GetText("DLG_WARNING"),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        editOutD.Select();
                        break;
                    case 2: // 2 - Значение второго параметра задано неверно
                        XtraMessageBox.Show(
                            $"{_appTr.GetText("TXT_PARAMETER")} <{labelInD.Text}> {_appTr.GetText("TXT_INCORRECTLY")}!",
                            _appTr.GetText("DLG_WARNING"),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        editInD.Select();
                        break;                        
                    case 3: // 3 - Значение первого параметра меньше чем значение второго
                        XtraMessageBox.Show(
                            $"{_appTr.GetText("TXT_PARAMETER")} <{labelOutD.Text}> {_appTr.GetText("TXT_MUSTBEGREATE")} <{labelInD.Text}>!",
                            _appTr.GetText("DLG_WARNING"),
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        editOutD.Select();
                        break;
                }
            }
        }
        /// <summary>
        /// Служебная функция для перевода вещественного числа в строку
        /// </summary>
        /// <param name="value">Число для перевода</param>
        /// <param name="decimalplaces">Количество десятичных знаков после запятой</param>
        /// <returns>Преобразованная строка</returns>
        private String DoubleToStr(double value, decimal decimalplaces)
        {
            switch (decimalplaces)
            {
                case 0:
                    return value.ToString("F0");
                case 1:
                    return value.ToString("F1");
                case 2:
                    return value.ToString("F2");
                case 3:
                    return value.ToString("F3");
                case 4:
                    return value.ToString("F4");
                default:
                    return value.ToString("F2");

            }
        }
        /// <summary>
        /// Служебная функция для перевода строки в число
        /// </summary>
        /// <param name="value">Строка для перевода</param>
        /// <returns>Результат преобразования</returns>
        private Double StrToDouble(string value)
        {
            try
            {
                // В зависимости от региональных настроек пользователя определяем десятичный разделитель.
                string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                // Корректируем разделитель в зависимости от ввода пользователя
                value = value.Replace(".", decimalSeparator).Replace(",", decimalSeparator);
                // Выполняем преобразование
                double result = Convert.ToDouble(value);
                return result;
            }
            catch
            {
                return 0;
            }
        }
    }
}
