using cvs_test_05.Common;
using cvs_test_05.Properties;
using DevExpress.Data;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
                _appTr = new ApplicationTranslator();
                _pipeModel = new PipeModel();
                _appSet = new ApplicationSettings();
            }
            catch (Exception ex)
            {
                // TODO: Добавить обработчик иключения
            }
            
            // Спрятать основную форму для показа заставки
            // this.Opacity = 1;
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

            if (_appTr == null)
                _appTr = new ApplicationTranslator();
            
            // Перевод интерфейса
            TranslateGUI(_appSet.Language);

            // Установка фокуса
            buttonAbout.Select();
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
            this.Text = _appTr.GetText("TITLE_MAIN");

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


        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        #region Обработчики нажатий на кнопки        

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Расчет характеристик
            PipeCalculation();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            // Расчет характеристик
            PipeCalculation();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            ;
        }

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
                        editInD.Text = DoubleToStr(InD, _appSet.DecimalPlaces).ToString();

                        editS.Text = DoubleToStr(S, _appSet.DecimalPlaces).ToString();
                        editJ.Text = DoubleToStr(J, _appSet.DecimalPlaces).ToString();
                        editW.Text = DoubleToStr(W, _appSet.DecimalPlaces).ToString();
                    }
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            using (FormAbout formAbout = new FormAbout())
            {
                formAbout.ShowDialog();
            }
        }

        #endregion

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

        private void cboxCalculationMode_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void PipeCalculation()
        {
            // Чтение параметров
            double OutD = StrToDouble(editOutD.Text);
            double InD = StrToDouble(editInD.Text);
            
            // Корректировка кол-ва знаков после запятой
            editOutD.Text = DoubleToStr(OutD, _appSet.DecimalPlaces);
            editInD.Text = DoubleToStr(InD, _appSet.DecimalPlaces);

            CalculationMode mode = CalculationMode.DS;


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

                int res = _pipeModel.SetCalculationParameters(OutD, InD, mode);
                editS.Text = DoubleToStr(0.00, _appSet.DecimalPlaces).ToString();
                editJ.Text = DoubleToStr(0.00, _appSet.DecimalPlaces).ToString();
                editW.Text = DoubleToStr(0.00, _appSet.DecimalPlaces).ToString();

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

        private Double StrToDouble(string value)
        {
            try
            {
                string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                value = value.Replace(".", decimalSeparator).Replace(",", decimalSeparator);
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
