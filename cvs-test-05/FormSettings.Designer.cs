namespace cvs_test_05
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.panelUP = new DevExpress.XtraEditors.PanelControl();
            this.tabSettings = new DevExpress.XtraTab.XtraTabControl();
            this.tabGeneral = new DevExpress.XtraTab.XtraTabPage();
            this.cboxLanguage = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelLanguage = new DevExpress.XtraEditors.LabelControl();
            this.tabCalculation = new DevExpress.XtraTab.XtraTabPage();
            this.spinDecimalPlaces = new DevExpress.XtraEditors.SpinEdit();
            this.labelDecimalPlaces = new DevExpress.XtraEditors.LabelControl();
            this.cboxCalculationMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelCalculationMode = new DevExpress.XtraEditors.LabelControl();
            this.panelDown = new DevExpress.XtraEditors.PanelControl();
            this.buttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.buttonOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelUP)).BeginInit();
            this.panelUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabSettings)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxLanguage.Properties)).BeginInit();
            this.tabCalculation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDecimalPlaces.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCalculationMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDown)).BeginInit();
            this.panelDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUP
            // 
            this.panelUP.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelUP.Appearance.Options.UseBackColor = true;
            this.panelUP.Controls.Add(this.tabSettings);
            this.panelUP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUP.Location = new System.Drawing.Point(0, 0);
            this.panelUP.Name = "panelUP";
            this.panelUP.Size = new System.Drawing.Size(438, 208);
            this.panelUP.TabIndex = 4;
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(5, 5);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedTabPage = this.tabGeneral;
            this.tabSettings.Size = new System.Drawing.Size(428, 197);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabGeneral,
            this.tabCalculation});
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.cboxLanguage);
            this.tabGeneral.Controls.Add(this.labelLanguage);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(426, 172);
            this.tabGeneral.Text = "Основные";
            // 
            // cboxLanguage
            // 
            this.cboxLanguage.Location = new System.Drawing.Point(214, 20);
            this.cboxLanguage.Name = "cboxLanguage";
            this.cboxLanguage.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxLanguage.Properties.Appearance.Options.UseFont = true;
            this.cboxLanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxLanguage.Properties.Items.AddRange(new object[] {
            "Русский",
            "English"});
            this.cboxLanguage.Size = new System.Drawing.Size(100, 24);
            this.cboxLanguage.TabIndex = 10;
            // 
            // labelLanguage
            // 
            this.labelLanguage.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLanguage.Appearance.Options.UseFont = true;
            this.labelLanguage.Location = new System.Drawing.Point(20, 23);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(121, 18);
            this.labelLanguage.TabIndex = 9;
            this.labelLanguage.Text = "Язык интерфейса";
            // 
            // tabCalculation
            // 
            this.tabCalculation.Controls.Add(this.spinDecimalPlaces);
            this.tabCalculation.Controls.Add(this.labelDecimalPlaces);
            this.tabCalculation.Controls.Add(this.cboxCalculationMode);
            this.tabCalculation.Controls.Add(this.labelCalculationMode);
            this.tabCalculation.Name = "tabCalculation";
            this.tabCalculation.Size = new System.Drawing.Size(426, 172);
            this.tabCalculation.Text = "Параметры расчета";
            // 
            // spinDecimalPlaces
            // 
            this.spinDecimalPlaces.EditValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinDecimalPlaces.Location = new System.Drawing.Point(214, 50);
            this.spinDecimalPlaces.Name = "spinDecimalPlaces";
            this.spinDecimalPlaces.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinDecimalPlaces.Properties.Appearance.Options.UseFont = true;
            this.spinDecimalPlaces.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinDecimalPlaces.Properties.IsFloatValue = false;
            this.spinDecimalPlaces.Properties.MaskSettings.Set("mask", "N00");
            this.spinDecimalPlaces.Properties.MaxValue = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.spinDecimalPlaces.Size = new System.Drawing.Size(100, 24);
            this.spinDecimalPlaces.TabIndex = 14;
            // 
            // labelDecimalPlaces
            // 
            this.labelDecimalPlaces.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDecimalPlaces.Appearance.Options.UseFont = true;
            this.labelDecimalPlaces.Location = new System.Drawing.Point(20, 50);
            this.labelDecimalPlaces.Name = "labelDecimalPlaces";
            this.labelDecimalPlaces.Size = new System.Drawing.Size(131, 18);
            this.labelDecimalPlaces.TabIndex = 13;
            this.labelDecimalPlaces.Text = "Количество знаков";
            // 
            // cboxCalculationMode
            // 
            this.cboxCalculationMode.Location = new System.Drawing.Point(214, 20);
            this.cboxCalculationMode.Name = "cboxCalculationMode";
            this.cboxCalculationMode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cboxCalculationMode.Properties.Appearance.Options.UseFont = true;
            this.cboxCalculationMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxCalculationMode.Properties.Items.AddRange(new object[] {
            "D-s",
            "D-d"});
            this.cboxCalculationMode.Size = new System.Drawing.Size(100, 24);
            this.cboxCalculationMode.TabIndex = 12;
            // 
            // labelCalculationMode
            // 
            this.labelCalculationMode.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCalculationMode.Appearance.Options.UseFont = true;
            this.labelCalculationMode.Location = new System.Drawing.Point(20, 23);
            this.labelCalculationMode.Name = "labelCalculationMode";
            this.labelCalculationMode.Size = new System.Drawing.Size(106, 18);
            this.labelCalculationMode.TabIndex = 11;
            this.labelCalculationMode.Text = "Режим расчета";
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.buttonCancel);
            this.panelDown.Controls.Add(this.buttonOK);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 208);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(438, 60);
            this.panelDown.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Appearance.Options.UseFont = true;
            this.buttonCancel.Location = new System.Drawing.Point(326, 14);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 32);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "ОТМЕНА";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Appearance.Options.UseFont = true;
            this.buttonOK.Location = new System.Drawing.Point(220, 14);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 32);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 268);
            this.Controls.Add(this.panelUP);
            this.Controls.Add(this.panelDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormSettings.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelUP)).EndInit();
            this.panelUP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabSettings)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboxLanguage.Properties)).EndInit();
            this.tabCalculation.ResumeLayout(false);
            this.tabCalculation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDecimalPlaces.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxCalculationMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDown)).EndInit();
            this.panelDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelUP;
        private DevExpress.XtraEditors.PanelControl panelDown;
        private DevExpress.XtraEditors.SimpleButton buttonCancel;
        private DevExpress.XtraEditors.SimpleButton buttonOK;
        private DevExpress.XtraTab.XtraTabControl tabSettings;
        private DevExpress.XtraTab.XtraTabPage tabGeneral;
        private DevExpress.XtraTab.XtraTabPage tabCalculation;
        private DevExpress.XtraEditors.ComboBoxEdit cboxLanguage;
        private DevExpress.XtraEditors.LabelControl labelLanguage;
        private DevExpress.XtraEditors.LabelControl labelDecimalPlaces;
        private DevExpress.XtraEditors.ComboBoxEdit cboxCalculationMode;
        private DevExpress.XtraEditors.LabelControl labelCalculationMode;
        private DevExpress.XtraEditors.SpinEdit spinDecimalPlaces;
    }
}