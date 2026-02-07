using cvs_test_05.Common;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace cvs_test_05
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            

            ApplicationSettings _appSet = new ApplicationSettings();
            _appSet.Load();

            // Установка темы приложения
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");

            FormMain formMain = new FormMain();
            formMain.InitializeApplication();

            // Загрузка сплеш-формы
            SplashScreenManager.ShowForm(typeof(FormSplashScreen));

            Application.Run(formMain);

            // Закрытие сплеш-формы (перенесено в OnMainFormLoad)
            // SplashScreenManager.CloseForm();
        }
    }
}
