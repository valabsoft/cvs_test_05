namespace cvs_test_05
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.panelUP = new DevExpress.XtraEditors.PanelControl();
            this.panelDown = new DevExpress.XtraEditors.PanelControl();
            this.pictureLogo = new DevExpress.XtraEditors.PictureEdit();
            this.buttonOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelTitle = new DevExpress.XtraEditors.LabelControl();
            this.labelSupport = new DevExpress.XtraEditors.LabelControl();
            this.linkLabelWWW = new System.Windows.Forms.LinkLabel();
            this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.labelForum = new DevExpress.XtraEditors.LabelControl();
            this.labelVersion = new DevExpress.XtraEditors.LabelControl();
            this.labelTel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelUP)).BeginInit();
            this.panelUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDown)).BeginInit();
            this.panelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUP
            // 
            this.panelUP.Appearance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelUP.Appearance.Options.UseBackColor = true;
            this.panelUP.Controls.Add(this.labelTel);
            this.panelUP.Controls.Add(this.labelVersion);
            this.panelUP.Controls.Add(this.labelForum);
            this.panelUP.Controls.Add(this.labelCopyright);
            this.panelUP.Controls.Add(this.linkLabelWWW);
            this.panelUP.Controls.Add(this.labelSupport);
            this.panelUP.Controls.Add(this.labelTitle);
            this.panelUP.Controls.Add(this.pictureLogo);
            this.panelUP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUP.Location = new System.Drawing.Point(0, 0);
            this.panelUP.Name = "panelUP";
            this.panelUP.Size = new System.Drawing.Size(438, 208);
            this.panelUP.TabIndex = 2;
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.buttonOK);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 208);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(438, 60);
            this.panelDown.TabIndex = 3;
            // 
            // pictureLogo
            // 
            this.pictureLogo.EditValue = global::cvs_test_05.Properties.Resources.LogoCVS;
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Properties.InitialImageOptions.Image = global::cvs_test_05.Properties.Resources.LogoCVS;
            this.pictureLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureLogo.Size = new System.Drawing.Size(100, 96);
            this.pictureLogo.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Appearance.Options.UseFont = true;
            this.buttonOK.Location = new System.Drawing.Point(144, 14);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(150, 32);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Appearance.Options.UseFont = true;
            this.labelTitle.Appearance.Options.UseTextOptions = true;
            this.labelTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelTitle.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelTitle.Location = new System.Drawing.Point(118, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(310, 69);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Расчет характеристик сечения трубы";
            // 
            // labelSupport
            // 
            this.labelSupport.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSupport.Appearance.Options.UseFont = true;
            this.labelSupport.Location = new System.Drawing.Point(12, 149);
            this.labelSupport.Name = "labelSupport";
            this.labelSupport.Size = new System.Drawing.Size(71, 16);
            this.labelSupport.TabIndex = 4;
            this.labelSupport.Text = "Поддержка:";
            // 
            // linkLabelWWW
            // 
            this.linkLabelWWW.AutoSize = true;
            this.linkLabelWWW.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelWWW.Location = new System.Drawing.Point(93, 171);
            this.linkLabelWWW.Name = "linkLabelWWW";
            this.linkLabelWWW.Size = new System.Drawing.Size(88, 16);
            this.linkLabelWWW.TabIndex = 6;
            this.linkLabelWWW.TabStop = true;
            this.linkLabelWWW.Text = "www.dpipe.ru";
            this.linkLabelWWW.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWWW_LinkClicked);
            // 
            // labelCopyright
            // 
            this.labelCopyright.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopyright.Appearance.Options.UseFont = true;
            this.labelCopyright.Location = new System.Drawing.Point(12, 127);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(54, 16);
            this.labelCopyright.TabIndex = 8;
            this.labelCopyright.Text = "Copyright";
            // 
            // labelForum
            // 
            this.labelForum.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForum.Appearance.Options.UseFont = true;
            this.labelForum.Location = new System.Drawing.Point(12, 171);
            this.labelForum.Name = "labelForum";
            this.labelForum.Size = new System.Drawing.Size(43, 16);
            this.labelForum.TabIndex = 9;
            this.labelForum.Text = "Форум:";
            // 
            // labelVersion
            // 
            this.labelVersion.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVersion.Appearance.Options.UseFont = true;
            this.labelVersion.Appearance.Options.UseTextOptions = true;
            this.labelVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelVersion.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.labelVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelVersion.Location = new System.Drawing.Point(144, 84);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(284, 24);
            this.labelVersion.TabIndex = 10;
            this.labelVersion.Text = "Версия приложения:";
            // 
            // labelTel
            // 
            this.labelTel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTel.Appearance.Options.UseFont = true;
            this.labelTel.Location = new System.Drawing.Point(93, 149);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(113, 16);
            this.labelTel.TabIndex = 11;
            this.labelTel.Text = "+7 (812) 327-85-99";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 268);
            this.Controls.Add(this.panelUP);
            this.Controls.Add(this.panelDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormAbout.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelUP)).EndInit();
            this.panelUP.ResumeLayout(false);
            this.panelUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelDown)).EndInit();
            this.panelDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelUP;
        private DevExpress.XtraEditors.PictureEdit pictureLogo;
        private DevExpress.XtraEditors.PanelControl panelDown;
        private DevExpress.XtraEditors.SimpleButton buttonOK;
        private DevExpress.XtraEditors.LabelControl labelTitle;
        private System.Windows.Forms.LinkLabel linkLabelWWW;
        private DevExpress.XtraEditors.LabelControl labelSupport;
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.XtraEditors.LabelControl labelForum;
        private DevExpress.XtraEditors.LabelControl labelVersion;
        private DevExpress.XtraEditors.LabelControl labelTel;
    }
}