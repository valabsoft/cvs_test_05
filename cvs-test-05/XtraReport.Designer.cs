namespace cvs_test_05
{
    partial class XtraReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLineUp = new DevExpress.XtraReports.UI.XRLine();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLineDown = new DevExpress.XtraReports.UI.XRLine();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPictureBoxSchemeEN = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabelWValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelWTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelJValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelJTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelSValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelSTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelInDValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelInDTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelOutDValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelOutDTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLineSeparator = new DevExpress.XtraReports.UI.XRLine();
            this.xrPictureBoxSchemeRU = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabelReportTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.pReportTitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pOutDTitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pOutDValue = new DevExpress.XtraReports.Parameters.Parameter();
            this.pSTitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pSValue = new DevExpress.XtraReports.Parameters.Parameter();
            this.pJTitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pJValue = new DevExpress.XtraReports.Parameters.Parameter();
            this.pWTitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pWValue = new DevExpress.XtraReports.Parameters.Parameter();
            this.pInDTitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pInDValue = new DevExpress.XtraReports.Parameters.Parameter();
            this.pTValue = new DevExpress.XtraReports.Parameters.Parameter();
            this.pTTitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pFirm = new DevExpress.XtraReports.Parameters.Parameter();
            this.pMM = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabelOutDDem = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelInDDem = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTDem = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelMM2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelMM4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelMM3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrPictureLogo,
            this.xrLineUp});
            this.TopMargin.Name = "TopMargin";
            // 
            // xrLabel13
            // 
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pFirm")});
            this.xrLabel13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel13.ForeColor = System.Drawing.Color.DarkBlue;
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(150.125F, 67.62498F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(499.875F, 23F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseForeColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "xrLabelFirm";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrPictureLogo
            // 
            this.xrPictureLogo.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::cvs_test_05.Properties.Resources.LogoCVS, true);
            this.xrPictureLogo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 40F);
            this.xrPictureLogo.Name = "xrPictureLogo";
            this.xrPictureLogo.SizeF = new System.Drawing.SizeF(50F, 50F);
            this.xrPictureLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLineUp
            // 
            this.xrLineUp.LocationFloat = new DevExpress.Utils.PointFloat(0F, 90.62498F);
            this.xrLineUp.Name = "xrLineUp";
            this.xrLineUp.SizeF = new System.Drawing.SizeF(650F, 9.375015F);
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLineDown});
            this.BottomMargin.HeightF = 100.3563F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // xrLineDown
            // 
            this.xrLineDown.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLineDown.Name = "xrLineDown";
            this.xrLineDown.SizeF = new System.Drawing.SizeF(650F, 9.375015F);
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabelMM3,
            this.xrLabelMM4,
            this.xrLabelMM2,
            this.xrLabelTDem,
            this.xrLabelInDDem,
            this.xrLabelOutDDem,
            this.xrLabelWValue,
            this.xrLabelWTitle,
            this.xrLabelJValue,
            this.xrLabelJTitle,
            this.xrLabelTValue,
            this.xrLabelTTitle,
            this.xrLabelSValue,
            this.xrLabelSTitle,
            this.xrLabelInDValue,
            this.xrLabelInDTitle,
            this.xrLabelOutDValue,
            this.xrLabelOutDTitle,
            this.xrLineSeparator,
            this.xrPictureBoxSchemeRU,
            this.xrLabelReportTitle,
            this.xrPictureBoxSchemeEN});
            this.Detail.HeightF = 740.8262F;
            this.Detail.Name = "Detail";
            // 
            // xrPictureBoxSchemeEN
            // 
            this.xrPictureBoxSchemeEN.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::cvs_test_05.Properties.Resources.SchemeEN, true);
            this.xrPictureBoxSchemeEN.LocationFloat = new DevExpress.Utils.PointFloat(100F, 70F);
            this.xrPictureBoxSchemeEN.Name = "xrPictureBoxSchemeEN";
            this.xrPictureBoxSchemeEN.SizeF = new System.Drawing.SizeF(450F, 450F);
            this.xrPictureBoxSchemeEN.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabelWValue
            // 
            this.xrLabelWValue.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pWValue")});
            this.xrLabelWValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelWValue.LocationFloat = new DevExpress.Utils.PointFloat(320F, 677.9167F);
            this.xrLabelWValue.Multiline = true;
            this.xrLabelWValue.Name = "xrLabelWValue";
            this.xrLabelWValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelWValue.SizeF = new System.Drawing.SizeF(128F, 22.99994F);
            this.xrLabelWValue.StylePriority.UseFont = false;
            this.xrLabelWValue.Text = "xrLabelWValue";
            // 
            // xrLabelWTitle
            // 
            this.xrLabelWTitle.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pWTitle")});
            this.xrLabelWTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelWTitle.LocationFloat = new DevExpress.Utils.PointFloat(100F, 677.9167F);
            this.xrLabelWTitle.Multiline = true;
            this.xrLabelWTitle.Name = "xrLabelWTitle";
            this.xrLabelWTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelWTitle.SizeF = new System.Drawing.SizeF(219.8751F, 23F);
            this.xrLabelWTitle.StylePriority.UseFont = false;
            this.xrLabelWTitle.Text = "xrLabelWTitle";
            // 
            // xrLabelJValue
            // 
            this.xrLabelJValue.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pJValue")});
            this.xrLabelJValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelJValue.LocationFloat = new DevExpress.Utils.PointFloat(319.9999F, 654.9167F);
            this.xrLabelJValue.Multiline = true;
            this.xrLabelJValue.Name = "xrLabelJValue";
            this.xrLabelJValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelJValue.SizeF = new System.Drawing.SizeF(128F, 23F);
            this.xrLabelJValue.StylePriority.UseFont = false;
            this.xrLabelJValue.Text = "xrLabelJValue";
            // 
            // xrLabelJTitle
            // 
            this.xrLabelJTitle.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pJTitle")});
            this.xrLabelJTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelJTitle.LocationFloat = new DevExpress.Utils.PointFloat(100F, 654.9167F);
            this.xrLabelJTitle.Multiline = true;
            this.xrLabelJTitle.Name = "xrLabelJTitle";
            this.xrLabelJTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelJTitle.SizeF = new System.Drawing.SizeF(219.8751F, 23F);
            this.xrLabelJTitle.StylePriority.UseFont = false;
            this.xrLabelJTitle.Text = "xrLabelJTitle";
            // 
            // xrLabelTValue
            // 
            this.xrLabelTValue.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pTValue")});
            this.xrLabelTValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelTValue.LocationFloat = new DevExpress.Utils.PointFloat(319.875F, 586F);
            this.xrLabelTValue.Multiline = true;
            this.xrLabelTValue.Name = "xrLabelTValue";
            this.xrLabelTValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelTValue.SizeF = new System.Drawing.SizeF(128.1251F, 23F);
            this.xrLabelTValue.StylePriority.UseFont = false;
            this.xrLabelTValue.Text = "xrLabelTValue";
            // 
            // xrLabelTTitle
            // 
            this.xrLabelTTitle.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pTTitle")});
            this.xrLabelTTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelTTitle.LocationFloat = new DevExpress.Utils.PointFloat(100F, 586F);
            this.xrLabelTTitle.Multiline = true;
            this.xrLabelTTitle.Name = "xrLabelTTitle";
            this.xrLabelTTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelTTitle.SizeF = new System.Drawing.SizeF(219.8751F, 23F);
            this.xrLabelTTitle.StylePriority.UseFont = false;
            this.xrLabelTTitle.Text = "xrLabelTTitle";
            // 
            // xrLabelSValue
            // 
            this.xrLabelSValue.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pSValue")});
            this.xrLabelSValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelSValue.LocationFloat = new DevExpress.Utils.PointFloat(319.9999F, 631.9167F);
            this.xrLabelSValue.Multiline = true;
            this.xrLabelSValue.Name = "xrLabelSValue";
            this.xrLabelSValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelSValue.SizeF = new System.Drawing.SizeF(128F, 23F);
            this.xrLabelSValue.StylePriority.UseFont = false;
            this.xrLabelSValue.Text = "xrLabelSValue";
            // 
            // xrLabelSTitle
            // 
            this.xrLabelSTitle.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pSTitle")});
            this.xrLabelSTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelSTitle.LocationFloat = new DevExpress.Utils.PointFloat(100F, 631.9167F);
            this.xrLabelSTitle.Multiline = true;
            this.xrLabelSTitle.Name = "xrLabelSTitle";
            this.xrLabelSTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelSTitle.SizeF = new System.Drawing.SizeF(219.8751F, 23F);
            this.xrLabelSTitle.StylePriority.UseFont = false;
            this.xrLabelSTitle.Text = "xrLabelSTitle";
            this.xrLabelSTitle.WordWrap = false;
            // 
            // xrLabelInDValue
            // 
            this.xrLabelInDValue.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pInDValue")});
            this.xrLabelInDValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelInDValue.LocationFloat = new DevExpress.Utils.PointFloat(320F, 563F);
            this.xrLabelInDValue.Multiline = true;
            this.xrLabelInDValue.Name = "xrLabelInDValue";
            this.xrLabelInDValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelInDValue.SizeF = new System.Drawing.SizeF(128F, 23F);
            this.xrLabelInDValue.StylePriority.UseFont = false;
            this.xrLabelInDValue.Text = "xrLabelInDValue";
            // 
            // xrLabelInDTitle
            // 
            this.xrLabelInDTitle.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pInDTitle")});
            this.xrLabelInDTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelInDTitle.LocationFloat = new DevExpress.Utils.PointFloat(100F, 563F);
            this.xrLabelInDTitle.Multiline = true;
            this.xrLabelInDTitle.Name = "xrLabelInDTitle";
            this.xrLabelInDTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelInDTitle.SizeF = new System.Drawing.SizeF(220F, 23F);
            this.xrLabelInDTitle.StylePriority.UseFont = false;
            this.xrLabelInDTitle.Text = "xrLabelInDTitle";
            // 
            // xrLabelOutDValue
            // 
            this.xrLabelOutDValue.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pOutDValue")});
            this.xrLabelOutDValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelOutDValue.LocationFloat = new DevExpress.Utils.PointFloat(320F, 540F);
            this.xrLabelOutDValue.Multiline = true;
            this.xrLabelOutDValue.Name = "xrLabelOutDValue";
            this.xrLabelOutDValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelOutDValue.SizeF = new System.Drawing.SizeF(128F, 23F);
            this.xrLabelOutDValue.StylePriority.UseFont = false;
            this.xrLabelOutDValue.Text = "xrLabelOutDValue";
            // 
            // xrLabelOutDTitle
            // 
            this.xrLabelOutDTitle.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pOutDTitle")});
            this.xrLabelOutDTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelOutDTitle.LocationFloat = new DevExpress.Utils.PointFloat(100F, 540F);
            this.xrLabelOutDTitle.Multiline = true;
            this.xrLabelOutDTitle.Name = "xrLabelOutDTitle";
            this.xrLabelOutDTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelOutDTitle.SizeF = new System.Drawing.SizeF(220F, 23F);
            this.xrLabelOutDTitle.StylePriority.UseFont = false;
            this.xrLabelOutDTitle.Text = "xrLabelOutDTitle";
            // 
            // xrLineSeparator
            // 
            this.xrLineSeparator.LocationFloat = new DevExpress.Utils.PointFloat(100F, 609F);
            this.xrLineSeparator.Name = "xrLineSeparator";
            this.xrLineSeparator.SizeF = new System.Drawing.SizeF(450F, 22.91669F);
            // 
            // xrPictureBoxSchemeRU
            // 
            this.xrPictureBoxSchemeRU.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBoxSchemeRU.ImageSource"));
            this.xrPictureBoxSchemeRU.LocationFloat = new DevExpress.Utils.PointFloat(100F, 70F);
            this.xrPictureBoxSchemeRU.Name = "xrPictureBoxSchemeRU";
            this.xrPictureBoxSchemeRU.SizeF = new System.Drawing.SizeF(450F, 450F);
            this.xrPictureBoxSchemeRU.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabelReportTitle
            // 
            this.xrLabelReportTitle.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pReportTitle")});
            this.xrLabelReportTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelReportTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabelReportTitle.Multiline = true;
            this.xrLabelReportTitle.Name = "xrLabelReportTitle";
            this.xrLabelReportTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelReportTitle.SizeF = new System.Drawing.SizeF(650F, 70.00003F);
            this.xrLabelReportTitle.StylePriority.UseFont = false;
            this.xrLabelReportTitle.StylePriority.UseTextAlignment = false;
            this.xrLabelReportTitle.Text = "xrLabelReportTitle";
            this.xrLabelReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // pReportTitle
            // 
            this.pReportTitle.AllowNull = true;
            this.pReportTitle.Description = "ReportTitle";
            this.pReportTitle.Name = "pReportTitle";
            this.pReportTitle.Visible = false;
            // 
            // pOutDTitle
            // 
            this.pOutDTitle.AllowNull = true;
            this.pOutDTitle.Name = "pOutDTitle";
            this.pOutDTitle.Visible = false;
            // 
            // pOutDValue
            // 
            this.pOutDValue.AllowNull = true;
            this.pOutDValue.Name = "pOutDValue";
            this.pOutDValue.Visible = false;
            // 
            // pSTitle
            // 
            this.pSTitle.AllowNull = true;
            this.pSTitle.Name = "pSTitle";
            this.pSTitle.Visible = false;
            // 
            // pSValue
            // 
            this.pSValue.AllowNull = true;
            this.pSValue.Name = "pSValue";
            this.pSValue.Visible = false;
            // 
            // pJTitle
            // 
            this.pJTitle.AllowNull = true;
            this.pJTitle.Name = "pJTitle";
            this.pJTitle.Visible = false;
            // 
            // pJValue
            // 
            this.pJValue.AllowNull = true;
            this.pJValue.Name = "pJValue";
            this.pJValue.Visible = false;
            // 
            // pWTitle
            // 
            this.pWTitle.AllowNull = true;
            this.pWTitle.MultiValue = true;
            this.pWTitle.Name = "pWTitle";
            this.pWTitle.Visible = false;
            // 
            // pWValue
            // 
            this.pWValue.AllowNull = true;
            this.pWValue.MultiValue = true;
            this.pWValue.Name = "pWValue";
            this.pWValue.Visible = false;
            // 
            // pInDTitle
            // 
            this.pInDTitle.AllowNull = true;
            this.pInDTitle.Name = "pInDTitle";
            this.pInDTitle.Visible = false;
            // 
            // pInDValue
            // 
            this.pInDValue.AllowNull = true;
            this.pInDValue.Name = "pInDValue";
            this.pInDValue.Visible = false;
            // 
            // pTValue
            // 
            this.pTValue.AllowNull = true;
            this.pTValue.Name = "pTValue";
            this.pTValue.Visible = false;
            // 
            // pTTitle
            // 
            this.pTTitle.AllowNull = true;
            this.pTTitle.Name = "pTTitle";
            this.pTTitle.Visible = false;
            // 
            // pFirm
            // 
            this.pFirm.AllowNull = true;
            this.pFirm.Name = "pFirm";
            this.pFirm.Visible = false;
            // 
            // pMM
            // 
            this.pMM.AllowNull = true;
            this.pMM.Description = "pMM";
            this.pMM.Name = "pMM";
            this.pMM.Visible = false;
            // 
            // xrLabelOutDDem
            // 
            this.xrLabelOutDDem.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pMM")});
            this.xrLabelOutDDem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelOutDDem.LocationFloat = new DevExpress.Utils.PointFloat(448F, 540F);
            this.xrLabelOutDDem.Multiline = true;
            this.xrLabelOutDDem.Name = "xrLabelOutDDem";
            this.xrLabelOutDDem.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelOutDDem.SizeF = new System.Drawing.SizeF(55F, 23F);
            this.xrLabelOutDDem.StylePriority.UseFont = false;
            this.xrLabelOutDDem.Text = "xrLabelOutDValue";
            // 
            // xrLabelInDDem
            // 
            this.xrLabelInDDem.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pMM")});
            this.xrLabelInDDem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelInDDem.LocationFloat = new DevExpress.Utils.PointFloat(448.0001F, 563F);
            this.xrLabelInDDem.Multiline = true;
            this.xrLabelInDDem.Name = "xrLabelInDDem";
            this.xrLabelInDDem.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelInDDem.SizeF = new System.Drawing.SizeF(55F, 23F);
            this.xrLabelInDDem.StylePriority.UseFont = false;
            this.xrLabelInDDem.Text = "xrLabelOutDValue";
            // 
            // xrLabelTDem
            // 
            this.xrLabelTDem.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pMM")});
            this.xrLabelTDem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelTDem.LocationFloat = new DevExpress.Utils.PointFloat(448.0001F, 586F);
            this.xrLabelTDem.Multiline = true;
            this.xrLabelTDem.Name = "xrLabelTDem";
            this.xrLabelTDem.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelTDem.SizeF = new System.Drawing.SizeF(55F, 23F);
            this.xrLabelTDem.StylePriority.UseFont = false;
            this.xrLabelTDem.Text = "xrLabelOutDValue";
            // 
            // xrLabelMM2
            // 
            this.xrLabelMM2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pMM")});
            this.xrLabelMM2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelMM2.LocationFloat = new DevExpress.Utils.PointFloat(448F, 631.9167F);
            this.xrLabelMM2.Multiline = true;
            this.xrLabelMM2.Name = "xrLabelMM2";
            this.xrLabelMM2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelMM2.SizeF = new System.Drawing.SizeF(55F, 23F);
            this.xrLabelMM2.StylePriority.UseFont = false;
            this.xrLabelMM2.Text = "xrLabelOutDValue";
            // 
            // xrLabelMM4
            // 
            this.xrLabelMM4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pMM")});
            this.xrLabelMM4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelMM4.LocationFloat = new DevExpress.Utils.PointFloat(448.0001F, 654.9167F);
            this.xrLabelMM4.Multiline = true;
            this.xrLabelMM4.Name = "xrLabelMM4";
            this.xrLabelMM4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelMM4.SizeF = new System.Drawing.SizeF(55F, 23F);
            this.xrLabelMM4.StylePriority.UseFont = false;
            this.xrLabelMM4.Text = "xrLabelOutDValue";
            // 
            // xrLabelMM3
            // 
            this.xrLabelMM3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pMM")});
            this.xrLabelMM3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabelMM3.LocationFloat = new DevExpress.Utils.PointFloat(448.0001F, 677.9167F);
            this.xrLabelMM3.Multiline = true;
            this.xrLabelMM3.Name = "xrLabelMM3";
            this.xrLabelMM3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelMM3.SizeF = new System.Drawing.SizeF(55F, 23F);
            this.xrLabelMM3.StylePriority.UseFont = false;
            this.xrLabelMM3.Text = "xrLabelOutDValue";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(477.2773F, 629.7164F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(17.72259F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "2";
            this.xrLabel2.WordWrap = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(477.2775F, 652.7164F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(17.72259F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "4";
            this.xrLabel4.WordWrap = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(477.2773F, 675.7164F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(17.72259F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "3";
            this.xrLabel3.WordWrap = false;
            // 
            // XtraReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pReportTitle,
            this.pOutDTitle,
            this.pOutDValue,
            this.pSTitle,
            this.pSValue,
            this.pJTitle,
            this.pJValue,
            this.pWTitle,
            this.pWValue,
            this.pInDTitle,
            this.pInDValue,
            this.pTValue,
            this.pTTitle,
            this.pFirm,
            this.pMM});
            this.RequestParameters = false;
            this.Version = "21.2";
            this.DesignerLoaded += new DevExpress.XtraReports.UserDesigner.DesignerLoadedEventHandler(this.XtraReport_DesignerLoaded);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabelReportTitle;
        public DevExpress.XtraReports.Parameters.Parameter pReportTitle;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxSchemeRU;
        private DevExpress.XtraReports.UI.XRLine xrLineSeparator;
        private DevExpress.XtraReports.UI.XRLabel xrLabelOutDTitle;
        private DevExpress.XtraReports.UI.XRLabel xrLabelWTitle;
        private DevExpress.XtraReports.UI.XRLabel xrLabelJValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelJTitle;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTTitle;
        private DevExpress.XtraReports.UI.XRLabel xrLabelSValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelSTitle;
        private DevExpress.XtraReports.UI.XRLabel xrLabelInDValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelInDTitle;
        private DevExpress.XtraReports.UI.XRLabel xrLabelOutDValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabelWValue;
        public DevExpress.XtraReports.Parameters.Parameter pOutDTitle;
        public DevExpress.XtraReports.Parameters.Parameter pOutDValue;
        public DevExpress.XtraReports.Parameters.Parameter pSTitle;
        public DevExpress.XtraReports.Parameters.Parameter pSValue;
        public DevExpress.XtraReports.Parameters.Parameter pJTitle;
        public DevExpress.XtraReports.Parameters.Parameter pJValue;
        public DevExpress.XtraReports.Parameters.Parameter pInDTitle;
        public DevExpress.XtraReports.Parameters.Parameter pInDValue;
        public DevExpress.XtraReports.Parameters.Parameter pTValue;
        public DevExpress.XtraReports.Parameters.Parameter pTTitle;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxSchemeEN;
        public DevExpress.XtraReports.Parameters.Parameter pWTitle;
        public DevExpress.XtraReports.Parameters.Parameter pWValue;
        private DevExpress.XtraReports.UI.XRLine xrLineUp;
        private DevExpress.XtraReports.UI.XRLine xrLineDown;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureLogo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        public DevExpress.XtraReports.Parameters.Parameter pFirm;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabelMM3;
        private DevExpress.XtraReports.UI.XRLabel xrLabelMM4;
        private DevExpress.XtraReports.UI.XRLabel xrLabelMM2;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTDem;
        private DevExpress.XtraReports.UI.XRLabel xrLabelInDDem;
        private DevExpress.XtraReports.UI.XRLabel xrLabelOutDDem;
        public DevExpress.XtraReports.Parameters.Parameter pMM;
    }
}
