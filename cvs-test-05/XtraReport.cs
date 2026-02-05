using cvs_test_05.Common;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace cvs_test_05
{
    public partial class XtraReport : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport()
        {
            InitializeComponent();

            ApplicationSettings _appSet = new ApplicationSettings();
            _appSet.Load();

            if (_appSet.Language == Language.RU)
            {
                xrPictureBoxSchemeRU.Visible = true;
                xrPictureBoxSchemeEN.Visible = false;

                
            }
            else
            {
                xrPictureBoxSchemeRU.Visible = false;
                xrPictureBoxSchemeEN.Visible = true;
            }

            
        }

        private void XtraReport_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e)
        {
            xrLabelOutDDem.Text = $"({pMM.Value})";
            xrLabelInDDem.Text = $"({pMM.Value})";
            xrLabelTDem.Text = $"({pMM.Value})";
        }
    }
}
