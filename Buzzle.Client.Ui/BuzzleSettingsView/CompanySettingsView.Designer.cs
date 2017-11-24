namespace Buzzle.Client.Ui
{
    partial class CompanySettingsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanySettingsView));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource();
            this.textEdit_PhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Email = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_CompanyName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Save = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ChangePicture = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_PhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CompanyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.pictureBox_Logo);
            this.layoutControl1.Controls.Add(this.textEdit_PhoneNumber);
            this.layoutControl1.Controls.Add(this.textEdit_Email);
            this.layoutControl1.Controls.Add(this.textEdit_CompanyName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(627, 141);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox_Logo.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.companyBindingSource, "CompanyLogo", true));
            this.pictureBox_Logo.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(132, 117);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 7;
            this.pictureBox_Logo.TabStop = false;
            this.pictureBox_Logo.DoubleClick += new System.EventHandler(this.pictureBox_Logo_DoubleClick);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(Buzzle.DataModel.Company);
            // 
            // textEdit_PhoneNumber
            // 
            this.textEdit_PhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "PhoneNumber", true));
            this.textEdit_PhoneNumber.Location = new System.Drawing.Point(246, 84);
            this.textEdit_PhoneNumber.Name = "textEdit_PhoneNumber";
            this.textEdit_PhoneNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.textEdit_PhoneNumber.Properties.Appearance.Options.UseFont = true;
            this.textEdit_PhoneNumber.Size = new System.Drawing.Size(369, 32);
            this.textEdit_PhoneNumber.StyleController = this.layoutControl1;
            this.textEdit_PhoneNumber.TabIndex = 5;
            // 
            // textEdit_Email
            // 
            this.textEdit_Email.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "Email", true));
            this.textEdit_Email.Location = new System.Drawing.Point(246, 48);
            this.textEdit_Email.Name = "textEdit_Email";
            this.textEdit_Email.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.textEdit_Email.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Email.Size = new System.Drawing.Size(369, 32);
            this.textEdit_Email.StyleController = this.layoutControl1;
            this.textEdit_Email.TabIndex = 5;
            // 
            // textEdit_CompanyName
            // 
            this.textEdit_CompanyName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.companyBindingSource, "CompanyName", true));
            this.textEdit_CompanyName.Location = new System.Drawing.Point(246, 12);
            this.textEdit_CompanyName.Name = "textEdit_CompanyName";
            this.textEdit_CompanyName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.textEdit_CompanyName.Properties.Appearance.Options.UseFont = true;
            this.textEdit_CompanyName.Size = new System.Drawing.Size(369, 32);
            this.textEdit_CompanyName.StyleController = this.layoutControl1;
            this.textEdit_CompanyName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(627, 141);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.textEdit_CompanyName;
            this.layoutControlItem1.CustomizationFormText = "Company Name:";
            this.layoutControlItem1.Location = new System.Drawing.Point(136, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(471, 36);
            this.layoutControlItem1.Text = "Company Name:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.textEdit_Email;
            this.layoutControlItem2.CustomizationFormText = "Email:";
            this.layoutControlItem2.Location = new System.Drawing.Point(136, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(471, 36);
            this.layoutControlItem2.Text = "Email:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.textEdit_PhoneNumber;
            this.layoutControlItem3.CustomizationFormText = "Phone Number:";
            this.layoutControlItem3.Location = new System.Drawing.Point(136, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(471, 49);
            this.layoutControlItem3.Text = "Phone Number:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(95, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.pictureBox_Logo;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(136, 121);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(136, 121);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(136, 121);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_Save,
            this.barButtonItem_ChangePicture});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Save, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_ChangePicture, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_Save
            // 
            this.barButtonItem_Save.Caption = "Save Changes";
            this.barButtonItem_Save.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Save.Glyph")));
            this.barButtonItem_Save.Id = 0;
            this.barButtonItem_Save.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Save.LargeGlyph")));
            this.barButtonItem_Save.Name = "barButtonItem_Save";
            this.barButtonItem_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Save_ItemClick);
            // 
            // barButtonItem_ChangePicture
            // 
            this.barButtonItem_ChangePicture.Caption = "Change Picture";
            this.barButtonItem_ChangePicture.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChangePicture.Glyph")));
            this.barButtonItem_ChangePicture.Id = 1;
            this.barButtonItem_ChangePicture.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ChangePicture.LargeGlyph")));
            this.barButtonItem_ChangePicture.Name = "barButtonItem_ChangePicture";
            this.barButtonItem_ChangePicture.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ChangePicture_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(627, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 165);
            this.barDockControlBottom.Size = new System.Drawing.Size(627, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 141);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(627, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 141);
            // 
            // CompanySettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 165);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CompanySettingsView";
            this.Text = "Company Settings";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_PhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CompanyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private DevExpress.XtraEditors.TextEdit textEdit_PhoneNumber;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit_Email;
        private DevExpress.XtraEditors.TextEdit textEdit_CompanyName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Save;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ChangePicture;
    }
}