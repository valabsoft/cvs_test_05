using cvs_test_05.Common;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cvs_test_05
{
    public partial class FormSplashScreen : DevExpress.XtraSplashScreen.SplashScreen
    {
        public FormSplashScreen()
        {
            InitializeComponent();

            labelTitle.BackColor = Color.Transparent;
            labelTitle.Parent = pictureEditImage;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.BringToFront();

            ApplicationSettings _appSet = new ApplicationSettings();
            _appSet.Load();

            ApplicationTranslator translator = new ApplicationTranslator();
            translator.SetLanguage(_appSet.Language);

            labelTitle.Text = translator.GetText("TITLE_MAIN");
            labelStatus.Text = translator.GetText("LB_STARTED");            

            if (DateTime.Now.Year == 2026)
                this.labelCopyright.Text = $"Copyright © {DateTime.Now.Year.ToString()} {translator.GetText("APP_FIRM")}";
            else
                this.labelCopyright.Text = $"Copyright © 2026-{DateTime.Now.Year.ToString()} {translator.GetText("APP_FIRM")}";
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}