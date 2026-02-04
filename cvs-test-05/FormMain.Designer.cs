namespace cvs_test_05
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::cvs_test_05.FormSplashScreen), false, false);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelUp = new DevExpress.XtraEditors.PanelControl();
            this.buttonAbout = new DevExpress.XtraEditors.SimpleButton();
            this.groupOutputData = new DevExpress.XtraEditors.GroupControl();
            this.labelWDim = new DevExpress.XtraEditors.LabelControl();
            this.editW = new DevExpress.XtraEditors.TextEdit();
            this.labelW = new DevExpress.XtraEditors.LabelControl();
            this.labelJDim = new DevExpress.XtraEditors.LabelControl();
            this.editJ = new DevExpress.XtraEditors.TextEdit();
            this.labelJ = new DevExpress.XtraEditors.LabelControl();
            this.labelSDim = new DevExpress.XtraEditors.LabelControl();
            this.editS = new DevExpress.XtraEditors.TextEdit();
            this.labelS = new DevExpress.XtraEditors.LabelControl();
            this.groupInputData = new DevExpress.XtraEditors.GroupControl();
            this.buttonCalcalute = new DevExpress.XtraEditors.SimpleButton();
            this.cboxCalculationMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelCalculationMode = new DevExpress.XtraEditors.LabelControl();
            this.labelInDDim = new DevExpress.XtraEditors.LabelControl();
            this.editInD = new DevExpress.XtraEditors.TextEdit();
            this.labelInD = new DevExpress.XtraEditors.LabelControl();
            this.labelOutDDim = new DevExpress.XtraEditors.LabelControl();
            this.editOutD = new DevExpress.XtraEditors.TextEdit();
            this.labelOutD = new DevExpress.XtraEditors.LabelControl();
            this.pictureEditScheme = new DevExpress.XtraEditors.PictureEdit();
            this.panelDown = new DevExpress.XtraEditors.PanelControl();
            this.buttonCalc = new DevExpress.XtraEditors.SimpleButton();
            this.buttonReport = new DevExpress.XtraEditors.SimpleButton();
            this.buttonSettings = new DevExpress.XtraEditors.SimpleButton();
            this.buttonExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelUp)).BeginInit();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupOutputData)).BeginInit();
            this.groupOutputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editJ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInputData)).BeginInit();
            this.groupInputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCalculationMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editInD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editOutD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditScheme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDown)).BeginInit();
            this.panelDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            splashScreenManager.ClosingDelay = 500;
            // 
            // panelUp
            // 
            this.panelUp.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelUp.Appearance.Options.UseBackColor = true;
            this.panelUp.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelUp.Controls.Add(this.buttonAbout);
            this.panelUp.Controls.Add(this.groupOutputData);
            this.panelUp.Controls.Add(this.groupInputData);
            this.panelUp.Controls.Add(this.pictureEditScheme);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(686, 328);
            this.panelUp.TabIndex = 0;
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbout.Appearance.Options.UseFont = true;
            this.buttonAbout.Location = new System.Drawing.Point(631, 21);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(34, 34);
            this.buttonAbout.TabIndex = 9;
            this.buttonAbout.Text = "?";
            this.buttonAbout.ToolTip = "О программе...";
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // groupOutputData
            // 
            this.groupOutputData.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupOutputData.AppearanceCaption.Options.UseFont = true;
            this.groupOutputData.Controls.Add(this.labelWDim);
            this.groupOutputData.Controls.Add(this.editW);
            this.groupOutputData.Controls.Add(this.labelW);
            this.groupOutputData.Controls.Add(this.labelJDim);
            this.groupOutputData.Controls.Add(this.editJ);
            this.groupOutputData.Controls.Add(this.labelJ);
            this.groupOutputData.Controls.Add(this.labelSDim);
            this.groupOutputData.Controls.Add(this.editS);
            this.groupOutputData.Controls.Add(this.labelS);
            this.groupOutputData.Location = new System.Drawing.Point(12, 163);
            this.groupOutputData.Name = "groupOutputData";
            this.groupOutputData.Size = new System.Drawing.Size(350, 149);
            this.groupOutputData.TabIndex = 2;
            this.groupOutputData.Text = "Выходные данные";
            // 
            // labelWDim
            // 
            this.labelWDim.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWDim.Appearance.Options.UseFont = true;
            this.labelWDim.Location = new System.Drawing.Point(285, 104);
            this.labelWDim.Name = "labelWDim";
            this.labelWDim.Size = new System.Drawing.Size(51, 18);
            this.labelWDim.TabIndex = 8;
            this.labelWDim.Text = "(мм^3)";
            // 
            // editW
            // 
            this.editW.EditValue = "0.00";
            this.editW.Location = new System.Drawing.Point(184, 101);
            this.editW.Name = "editW";
            this.editW.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editW.Properties.Appearance.Options.UseFont = true;
            this.editW.Properties.ReadOnly = true;
            this.editW.Size = new System.Drawing.Size(95, 24);
            this.editW.TabIndex = 7;
            this.editW.TabStop = false;
            // 
            // labelW
            // 
            this.labelW.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelW.Appearance.Options.UseFont = true;
            this.labelW.Location = new System.Drawing.Point(16, 104);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(162, 18);
            this.labelW.TabIndex = 6;
            this.labelW.Text = "Момент сопротивления";
            // 
            // labelJDim
            // 
            this.labelJDim.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelJDim.Appearance.Options.UseFont = true;
            this.labelJDim.Location = new System.Drawing.Point(285, 72);
            this.labelJDim.Name = "labelJDim";
            this.labelJDim.Size = new System.Drawing.Size(51, 18);
            this.labelJDim.TabIndex = 5;
            this.labelJDim.Text = "(мм^4)";
            // 
            // editJ
            // 
            this.editJ.EditValue = "0.00";
            this.editJ.Location = new System.Drawing.Point(184, 69);
            this.editJ.Name = "editJ";
            this.editJ.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editJ.Properties.Appearance.Options.UseFont = true;
            this.editJ.Properties.ReadOnly = true;
            this.editJ.Size = new System.Drawing.Size(95, 24);
            this.editJ.TabIndex = 4;
            this.editJ.TabStop = false;
            // 
            // labelJ
            // 
            this.labelJ.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelJ.Appearance.Options.UseFont = true;
            this.labelJ.Location = new System.Drawing.Point(16, 72);
            this.labelJ.Name = "labelJ";
            this.labelJ.Size = new System.Drawing.Size(116, 18);
            this.labelJ.TabIndex = 3;
            this.labelJ.Text = "Момент инерции";
            // 
            // labelSDim
            // 
            this.labelSDim.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSDim.Appearance.Options.UseFont = true;
            this.labelSDim.Location = new System.Drawing.Point(285, 40);
            this.labelSDim.Name = "labelSDim";
            this.labelSDim.Size = new System.Drawing.Size(51, 18);
            this.labelSDim.TabIndex = 2;
            this.labelSDim.Text = "(мм^2)";
            // 
            // editS
            // 
            this.editS.EditValue = "0.00";
            this.editS.Location = new System.Drawing.Point(184, 37);
            this.editS.Name = "editS";
            this.editS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editS.Properties.Appearance.Options.UseFont = true;
            this.editS.Properties.ReadOnly = true;
            this.editS.Size = new System.Drawing.Size(95, 24);
            this.editS.TabIndex = 1;
            this.editS.TabStop = false;
            // 
            // labelS
            // 
            this.labelS.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelS.Appearance.Options.UseFont = true;
            this.labelS.Location = new System.Drawing.Point(16, 40);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(123, 18);
            this.labelS.TabIndex = 0;
            this.labelS.Text = "Площадь сечения";
            // 
            // groupInputData
            // 
            this.groupInputData.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupInputData.AppearanceCaption.Options.UseFont = true;
            this.groupInputData.Controls.Add(this.buttonCalcalute);
            this.groupInputData.Controls.Add(this.cboxCalculationMode);
            this.groupInputData.Controls.Add(this.labelCalculationMode);
            this.groupInputData.Controls.Add(this.labelInDDim);
            this.groupInputData.Controls.Add(this.editInD);
            this.groupInputData.Controls.Add(this.labelInD);
            this.groupInputData.Controls.Add(this.labelOutDDim);
            this.groupInputData.Controls.Add(this.editOutD);
            this.groupInputData.Controls.Add(this.labelOutD);
            this.groupInputData.Location = new System.Drawing.Point(12, 12);
            this.groupInputData.Name = "groupInputData";
            this.groupInputData.Size = new System.Drawing.Size(350, 145);
            this.groupInputData.TabIndex = 2;
            this.groupInputData.Text = "Входные данные";
            // 
            // buttonCalcalute
            // 
            this.buttonCalcalute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCalcalute.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalcalute.Appearance.Options.UseFont = true;
            this.buttonCalcalute.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("buttonCalcalute.ImageOptions.Image")));
            this.buttonCalcalute.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.buttonCalcalute.Location = new System.Drawing.Point(284, 92);
            this.buttonCalcalute.Name = "buttonCalcalute";
            this.buttonCalcalute.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.buttonCalcalute.Size = new System.Drawing.Size(33, 42);
            this.buttonCalcalute.TabIndex = 7;
            this.buttonCalcalute.ToolTip = "Расчет";
            this.buttonCalcalute.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // cboxCalculationMode
            // 
            this.cboxCalculationMode.Location = new System.Drawing.Point(184, 101);
            this.cboxCalculationMode.Name = "cboxCalculationMode";
            this.cboxCalculationMode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxCalculationMode.Properties.Appearance.Options.UseFont = true;
            this.cboxCalculationMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxCalculationMode.Properties.Items.AddRange(new object[] {
            "D-s",
            "D-d"});
            this.cboxCalculationMode.Size = new System.Drawing.Size(95, 24);
            this.cboxCalculationMode.TabIndex = 5;
            this.cboxCalculationMode.SelectedIndexChanged += new System.EventHandler(this.cboxCalculationMode_SelectedIndexChanged);
            // 
            // labelCalculationMode
            // 
            this.labelCalculationMode.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCalculationMode.Appearance.Options.UseFont = true;
            this.labelCalculationMode.Location = new System.Drawing.Point(16, 104);
            this.labelCalculationMode.Name = "labelCalculationMode";
            this.labelCalculationMode.Size = new System.Drawing.Size(106, 18);
            this.labelCalculationMode.TabIndex = 6;
            this.labelCalculationMode.Text = "Режим расчета";
            // 
            // labelInDDim
            // 
            this.labelInDDim.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInDDim.Appearance.Options.UseFont = true;
            this.labelInDDim.Location = new System.Drawing.Point(285, 72);
            this.labelInDDim.Name = "labelInDDim";
            this.labelInDDim.Size = new System.Drawing.Size(32, 18);
            this.labelInDDim.TabIndex = 5;
            this.labelInDDim.Text = "(мм)";
            // 
            // editInD
            // 
            this.editInD.EditValue = "0.00";
            this.editInD.Location = new System.Drawing.Point(184, 69);
            this.editInD.Name = "editInD";
            this.editInD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editInD.Properties.Appearance.Options.UseFont = true;
            this.editInD.Size = new System.Drawing.Size(95, 24);
            this.editInD.TabIndex = 4;
            // 
            // labelInD
            // 
            this.labelInD.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInD.Appearance.Options.UseFont = true;
            this.labelInD.Location = new System.Drawing.Point(16, 72);
            this.labelInD.Name = "labelInD";
            this.labelInD.Size = new System.Drawing.Size(114, 18);
            this.labelInD.TabIndex = 3;
            this.labelInD.Text = "Толщина стенки";
            // 
            // labelOutDDim
            // 
            this.labelOutDDim.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutDDim.Appearance.Options.UseFont = true;
            this.labelOutDDim.Location = new System.Drawing.Point(285, 40);
            this.labelOutDDim.Name = "labelOutDDim";
            this.labelOutDDim.Size = new System.Drawing.Size(32, 18);
            this.labelOutDDim.TabIndex = 2;
            this.labelOutDDim.Text = "(мм)";
            // 
            // editOutD
            // 
            this.editOutD.EditValue = "0.00";
            this.editOutD.Location = new System.Drawing.Point(184, 37);
            this.editOutD.Name = "editOutD";
            this.editOutD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editOutD.Properties.Appearance.Options.UseFont = true;
            this.editOutD.Size = new System.Drawing.Size(95, 24);
            this.editOutD.TabIndex = 3;
            // 
            // labelOutD
            // 
            this.labelOutD.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOutD.Appearance.Options.UseFont = true;
            this.labelOutD.Location = new System.Drawing.Point(16, 40);
            this.labelOutD.Name = "labelOutD";
            this.labelOutD.Size = new System.Drawing.Size(124, 18);
            this.labelOutD.TabIndex = 0;
            this.labelOutD.Text = "Внешний диаметр";
            // 
            // pictureEditScheme
            // 
            this.pictureEditScheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEditScheme.EditValue = global::cvs_test_05.Properties.Resources.SchemeRU;
            this.pictureEditScheme.Location = new System.Drawing.Point(374, 12);
            this.pictureEditScheme.Name = "pictureEditScheme";
            this.pictureEditScheme.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEditScheme.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditScheme.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditScheme.Size = new System.Drawing.Size(300, 300);
            this.pictureEditScheme.TabIndex = 0;
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.buttonCalc);
            this.panelDown.Controls.Add(this.buttonReport);
            this.panelDown.Controls.Add(this.buttonSettings);
            this.panelDown.Controls.Add(this.buttonExit);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 328);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(686, 60);
            this.panelDown.TabIndex = 1;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Appearance.Options.UseFont = true;
            this.buttonCalc.Location = new System.Drawing.Point(12, 14);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(175, 34);
            this.buttonCalc.TabIndex = 1;
            this.buttonCalc.Text = "РАСЧЕТ";
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReport.Appearance.Options.UseFont = true;
            this.buttonReport.Location = new System.Drawing.Point(196, 14);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(166, 34);
            this.buttonReport.TabIndex = 6;
            this.buttonReport.Text = "ОТЧЕТ";
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Appearance.Options.UseFont = true;
            this.buttonSettings.Location = new System.Drawing.Point(374, 14);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(154, 34);
            this.buttonSettings.TabIndex = 7;
            this.buttonSettings.Text = "НАСТРОЙКИ";
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Appearance.Options.UseFont = true;
            this.buttonExit.Location = new System.Drawing.Point(554, 14);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 34);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "ВЫХОД";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 388);
            this.Controls.Add(this.panelUp);
            this.Controls.Add(this.panelDown);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormMain.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет характеристик сечения трубы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.panelUp)).EndInit();
            this.panelUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupOutputData)).EndInit();
            this.groupOutputData.ResumeLayout(false);
            this.groupOutputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editJ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupInputData)).EndInit();
            this.groupInputData.ResumeLayout(false);
            this.groupInputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCalculationMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editInD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editOutD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditScheme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDown)).EndInit();
            this.panelDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelUp;
        private DevExpress.XtraEditors.PanelControl panelDown;
        private DevExpress.XtraEditors.PictureEdit pictureEditScheme;
        private DevExpress.XtraEditors.GroupControl groupInputData;
        private DevExpress.XtraEditors.LabelControl labelInDDim;
        private DevExpress.XtraEditors.TextEdit editInD;
        private DevExpress.XtraEditors.LabelControl labelInD;
        private DevExpress.XtraEditors.LabelControl labelOutDDim;
        private DevExpress.XtraEditors.TextEdit editOutD;
        private DevExpress.XtraEditors.LabelControl labelOutD;
        private DevExpress.XtraEditors.GroupControl groupOutputData;
        private DevExpress.XtraEditors.LabelControl labelWDim;
        private DevExpress.XtraEditors.TextEdit editW;
        private DevExpress.XtraEditors.LabelControl labelW;
        private DevExpress.XtraEditors.LabelControl labelJDim;
        private DevExpress.XtraEditors.TextEdit editJ;
        private DevExpress.XtraEditors.LabelControl labelJ;
        private DevExpress.XtraEditors.LabelControl labelSDim;
        private DevExpress.XtraEditors.TextEdit editS;
        private DevExpress.XtraEditors.LabelControl labelS;
        private DevExpress.XtraEditors.SimpleButton buttonExit;
        private DevExpress.XtraEditors.ComboBoxEdit cboxCalculationMode;
        private DevExpress.XtraEditors.LabelControl labelCalculationMode;
        private DevExpress.XtraEditors.SimpleButton buttonSettings;
        private DevExpress.XtraEditors.SimpleButton buttonReport;
        private DevExpress.XtraEditors.SimpleButton buttonAbout;
        private DevExpress.XtraEditors.SimpleButton buttonCalc;
        private DevExpress.XtraEditors.SimpleButton buttonCalcalute;
    }
}

