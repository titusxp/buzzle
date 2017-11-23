namespace Buzzle.GlobalStuff
{
    partial class AddEditUserView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditUserView));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.toggleSwitch_IsAdmin = new DevExpress.XtraEditors.ToggleSwitch();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Save = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dateEdit_DateOfBirth = new DevExpress.XtraEditors.DateEdit();
            this.textEdit_LastName = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Password = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_FirstName = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_Username = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_IsAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_DateOfBirth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_DateOfBirth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_LastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_FirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.toggleSwitch_IsAdmin);
            this.layoutControl1.Controls.Add(this.dateEdit_DateOfBirth);
            this.layoutControl1.Controls.Add(this.textEdit_LastName);
            this.layoutControl1.Controls.Add(this.textEdit_Password);
            this.layoutControl1.Controls.Add(this.textEdit_FirstName);
            this.layoutControl1.Controls.Add(this.textEdit_Username);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(689, 2, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(377, 170);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // toggleSwitch_IsAdmin
            // 
            this.toggleSwitch_IsAdmin.AutoSizeInLayoutControl = true;
            this.toggleSwitch_IsAdmin.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "IsAdministrator", true));
            this.toggleSwitch_IsAdmin.Location = new System.Drawing.Point(80, 132);
            this.toggleSwitch_IsAdmin.MenuManager = this.barManager1;
            this.toggleSwitch_IsAdmin.Name = "toggleSwitch_IsAdmin";
            this.toggleSwitch_IsAdmin.Properties.AutoWidth = true;
            this.toggleSwitch_IsAdmin.Properties.OffText = "No";
            this.toggleSwitch_IsAdmin.Properties.OnText = "Yes";
            this.toggleSwitch_IsAdmin.Size = new System.Drawing.Size(90, 24);
            this.toggleSwitch_IsAdmin.StyleController = this.layoutControl1;
            this.toggleSwitch_IsAdmin.TabIndex = 9;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Buzzle.Data.DataModel.User);
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
            this.barButtonItem_Save});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 2";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Save, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 2";
            // 
            // barButtonItem_Save
            // 
            this.barButtonItem_Save.Caption = "&Save";
            this.barButtonItem_Save.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Save.Glyph")));
            this.barButtonItem_Save.Id = 0;
            this.barButtonItem_Save.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Save.LargeGlyph")));
            this.barButtonItem_Save.Name = "barButtonItem_Save";
            this.barButtonItem_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Save_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(377, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 194);
            this.barDockControlBottom.Size = new System.Drawing.Size(377, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 170);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(377, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 170);
            // 
            // dateEdit_DateOfBirth
            // 
            this.dateEdit_DateOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "DateOfBirth", true));
            this.dateEdit_DateOfBirth.EditValue = null;
            this.dateEdit_DateOfBirth.Location = new System.Drawing.Point(80, 108);
            this.dateEdit_DateOfBirth.Name = "dateEdit_DateOfBirth";
            this.dateEdit_DateOfBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_DateOfBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_DateOfBirth.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateEdit_DateOfBirth.Properties.DisplayFormat.FormatString = "dd MMM yyyy";
            this.dateEdit_DateOfBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_DateOfBirth.Properties.EditFormat.FormatString = "dd MMM yyyy";
            this.dateEdit_DateOfBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_DateOfBirth.Properties.Mask.EditMask = "dd MMM yyyy";
            this.dateEdit_DateOfBirth.Properties.NullValuePrompt = "Select date [optional]";
            this.dateEdit_DateOfBirth.Properties.NullValuePromptShowForEmptyValue = true;
            this.dateEdit_DateOfBirth.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit_DateOfBirth.Size = new System.Drawing.Size(285, 20);
            this.dateEdit_DateOfBirth.StyleController = this.layoutControl1;
            this.dateEdit_DateOfBirth.TabIndex = 8;
            // 
            // textEdit_LastName
            // 
            this.textEdit_LastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "LastName", true));
            this.textEdit_LastName.Location = new System.Drawing.Point(80, 84);
            this.textEdit_LastName.Name = "textEdit_LastName";
            this.textEdit_LastName.Size = new System.Drawing.Size(285, 20);
            this.textEdit_LastName.StyleController = this.layoutControl1;
            this.textEdit_LastName.TabIndex = 7;
            // 
            // textEdit_Password
            // 
            this.textEdit_Password.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "PassWord", true));
            this.textEdit_Password.Location = new System.Drawing.Point(80, 36);
            this.textEdit_Password.Name = "textEdit_Password";
            this.textEdit_Password.Properties.PasswordChar = '*';
            this.textEdit_Password.Properties.UseSystemPasswordChar = true;
            this.textEdit_Password.Size = new System.Drawing.Size(285, 20);
            this.textEdit_Password.StyleController = this.layoutControl1;
            this.textEdit_Password.TabIndex = 6;
            // 
            // textEdit_FirstName
            // 
            this.textEdit_FirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "FirstName", true));
            this.textEdit_FirstName.Location = new System.Drawing.Point(80, 60);
            this.textEdit_FirstName.Name = "textEdit_FirstName";
            this.textEdit_FirstName.Size = new System.Drawing.Size(285, 20);
            this.textEdit_FirstName.StyleController = this.layoutControl1;
            this.textEdit_FirstName.TabIndex = 5;
            // 
            // textEdit_Username
            // 
            this.textEdit_Username.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userBindingSource, "UserName", true));
            this.textEdit_Username.Location = new System.Drawing.Point(80, 12);
            this.textEdit_Username.Name = "textEdit_Username";
            this.textEdit_Username.Size = new System.Drawing.Size(285, 20);
            this.textEdit_Username.StyleController = this.layoutControl1;
            this.textEdit_Username.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(377, 170);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEdit_Password;
            this.layoutControlItem3.CustomizationFormText = "Password:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(357, 24);
            this.layoutControlItem3.Text = "Password:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_Username;
            this.layoutControlItem1.CustomizationFormText = "Username:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(357, 24);
            this.layoutControlItem1.Text = "Username:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit_FirstName;
            this.layoutControlItem2.CustomizationFormText = "First Name:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(357, 24);
            this.layoutControlItem2.Text = "First Name:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit_LastName;
            this.layoutControlItem4.CustomizationFormText = "Last Name:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(357, 24);
            this.layoutControlItem4.Text = "Last Name:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dateEdit_DateOfBirth;
            this.layoutControlItem5.CustomizationFormText = "Date of Birth:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(357, 24);
            this.layoutControlItem5.Text = "Date of Birth:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.toggleSwitch_IsAdmin;
            this.layoutControlItem6.CustomizationFormText = "Is Admin?";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(357, 30);
            this.layoutControlItem6.Text = "Is Admin?";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(65, 13);
            // 
            // AddEditUserView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(377, 194);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditUserView";
            this.Text = "Buzzle - Add/Edit User";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_IsAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_DateOfBirth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_DateOfBirth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_LastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_FirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit dateEdit_DateOfBirth;
        private DevExpress.XtraEditors.TextEdit textEdit_LastName;
        private DevExpress.XtraEditors.TextEdit textEdit_Password;
        private DevExpress.XtraEditors.TextEdit textEdit_FirstName;
        private DevExpress.XtraEditors.TextEdit textEdit_Username;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Save;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_IsAdmin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}