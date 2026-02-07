using cvs_test_05.Common;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cvs_test_05
{
    public partial class FormSettings : DevExpress.XtraEditors.XtraForm
    {
        private ApplicationSettings _appSet;
        public FormSettings()
        {
            InitializeComponent();

            _appSet = new ApplicationSettings();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            #region Сохранение настроек
            
            // Обратный мепинг
            _appSet.Language = (Language)cboxLanguage.SelectedIndex;

            _appSet.CalculationMode = (CalculationMode)cboxCalculationMode.SelectedIndex;
            _appSet.DecimalPlaces = spinDecimalPlaces.Value;

            // Сохраняем настройки в файл
            _appSet.Save();
            #endregion

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            try
            {
                // Загрузка настроек приложения
                _appSet.Load();

                #region Перевод интерфейса

                ApplicationTranslator _appTr = new ApplicationTranslator();
                _appTr.SetLanguage(_appSet.Language);

                this.Text = _appTr.GetText("TITLE_SETTINGS");
                tabGeneral.Text = _appTr.GetText("TAB_GENERAL");
                tabCalculation.Text = _appTr.GetText("TAB_CALC");
                labelLanguage.Text = _appTr.GetText("LB_LANGUAGE");
                buttonOK.Text = _appTr.GetText("BT_OK");
                buttonCancel.Text = _appTr.GetText("BT_CANCEL");
                labelCalculationMode.Text = _appTr.GetText("LB_CALC_MODE");
                labelDecimalPlaces.Text = _appTr.GetText("LB_DECIMAL_PLACES");

                #endregion

                // Мепинг настроек и элементов формы                
                cboxLanguage.SelectedIndex = (int)_appSet.Language;
                
                cboxCalculationMode.SelectedIndex = (int)_appSet.CalculationMode;
                spinDecimalPlaces.Value = _appSet.DecimalPlaces;                
                
            }
            catch (Exception)
            {
                // TODO: Добавить обработчик ошибки
            }
            
        }
    }
}