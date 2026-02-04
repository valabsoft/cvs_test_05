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
using System.Reflection;

namespace cvs_test_05
{
    public partial class FormAbout : DevExpress.XtraEditors.XtraForm
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void linkLabelWWW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dpipe.ru/forum/index.php");        
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            // Получаем текущую сборку
            Assembly assembly = Assembly.GetExecutingAssembly();
            AssemblyName assemblyName = assembly.GetName();
            Version version = assemblyName.Version;

            ApplicationSettings _appSet = new ApplicationSettings();
            _appSet.Load();

            ApplicationTranslator translator = new ApplicationTranslator();
            translator.SetLanguage(_appSet.Language);

            this.Text = translator.GetText("TITLE_ABOUT");
            labelTitle.Text = translator.GetText("TITLE_MAIN");
            labelVersion.Text = $"{translator.GetText("LB_VERSION")} {version.Major}.{version.Minor}";
            labelForum.Text = translator.GetText("LB_FORUM");
            labelSupport.Text = translator.GetText("LB_SUPPORT");

            if (DateTime.Now.Year == 2026)
                this.labelCopyright.Text = $"Copyright © {DateTime.Now.Year.ToString()} {translator.GetText("APP_FIRM")}";
            else
                this.labelCopyright.Text = $"Copyright © 2026-{DateTime.Now.Year.ToString()} {translator.GetText("APP_FIRM")}";

            buttonOK.Select();
        }
    }
}