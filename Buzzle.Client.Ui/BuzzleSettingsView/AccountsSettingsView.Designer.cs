

namespace Buzzle.Client.Ui
{
    partial class AccountsSettingsView
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsSettingsView));
            this.standaloneBarDockControl3 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.gridControl_Accounts = new DevExpress.XtraGrid.GridControl();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_Accounts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_SaveAccountSettings = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_RefreshAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem_SaveJobSettings = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_RemoveItemType = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_RemoveFault = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_New = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_DeleteUser = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_SaveTransactionTypes = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_RefreshTransactionTypes = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_SaveGeneralSettings = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl6 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).BeginInit();
            this.layoutControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // standaloneBarDockControl3
            // 
            this.standaloneBarDockControl3.CausesValidation = false;
            this.standaloneBarDockControl3.Location = new System.Drawing.Point(12, 12);
            this.standaloneBarDockControl3.Name = "standaloneBarDockControl3";
            this.standaloneBarDockControl3.Size = new System.Drawing.Size(218, 31);
            this.standaloneBarDockControl3.Text = "standaloneBarDockControl3";
            // 
            // gridControl_Accounts
            // 
            this.gridControl_Accounts.DataSource = this.accountBindingSource;
            this.gridControl_Accounts.Location = new System.Drawing.Point(12, 47);
            this.gridControl_Accounts.MainView = this.gridView_Accounts;
            this.gridControl_Accounts.MenuManager = this.barManager1;
            this.gridControl_Accounts.Name = "gridControl_Accounts";
            this.gridControl_Accounts.Size = new System.Drawing.Size(766, 447);
            this.gridControl_Accounts.TabIndex = 0;
            this.gridControl_Accounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Accounts});
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(Buzzle.DataModel.Account);
            // 
            // gridView_Accounts
            // 
            this.gridView_Accounts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountName,
            this.colDescription});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = ((short)(0));
            this.gridView_Accounts.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_Accounts.GridControl = this.gridControl_Accounts;
            this.gridView_Accounts.Name = "gridView_Accounts";
            this.gridView_Accounts.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_Accounts.OptionsView.ShowGroupPanel = false;
           // 
            // colAccountName
            // 
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 0;
            this.colAccountName.Width = 219;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 521;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl3);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_SaveJobSettings,
            this.barButtonItem_RemoveItemType,
            this.barButtonItem_RemoveFault,
            this.barButtonItem_Refresh,
            this.barButtonItem_New,
            this.barButtonItem_DeleteUser,
            this.barButtonItem_SaveAccountSettings,
            this.barButtonItem_SaveTransactionTypes,
            this.barButtonItem_RefreshTransactionTypes,
            this.barButtonItem_RefreshAccounts,
            this.barButtonItem_SaveGeneralSettings});
            this.barManager1.MaxItemId = 20;
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 4";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar3.FloatLocation = new System.Drawing.Point(515, 231);
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_SaveAccountSettings, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_RefreshAccounts, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.StandaloneBarDockControl = this.standaloneBarDockControl3;
            this.bar3.Text = "Custom 4";
            // 
            // barButtonItem_SaveAccountSettings
            // 
            this.barButtonItem_SaveAccountSettings.Caption = "Save Changes";
            this.barButtonItem_SaveAccountSettings.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SaveAccountSettings.Glyph")));
            this.barButtonItem_SaveAccountSettings.Id = 6;
            this.barButtonItem_SaveAccountSettings.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SaveAccountSettings.LargeGlyph")));
            this.barButtonItem_SaveAccountSettings.Name = "barButtonItem_SaveAccountSettings";
            this.barButtonItem_SaveAccountSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_SaveAccountSettings_ItemClick);
            // 
            // barButtonItem_RefreshAccounts
            // 
            this.barButtonItem_RefreshAccounts.Caption = "Refresh";
            this.barButtonItem_RefreshAccounts.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_RefreshAccounts.Glyph")));
            this.barButtonItem_RefreshAccounts.Id = 9;
            this.barButtonItem_RefreshAccounts.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_RefreshAccounts.LargeGlyph")));
            this.barButtonItem_RefreshAccounts.Name = "barButtonItem_RefreshAccounts";
            this.barButtonItem_RefreshAccounts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_RefreshAccounts_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(790, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 506);
            this.barDockControlBottom.Size = new System.Drawing.Size(790, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 506);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(790, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 506);
            // 
            // barButtonItem_SaveJobSettings
            // 
            this.barButtonItem_SaveJobSettings.Id = 11;
            this.barButtonItem_SaveJobSettings.Name = "barButtonItem_SaveJobSettings";
            // 
            // barButtonItem_RemoveItemType
            // 
            this.barButtonItem_RemoveItemType.Id = 12;
            this.barButtonItem_RemoveItemType.Name = "barButtonItem_RemoveItemType";
            // 
            // barButtonItem_RemoveFault
            // 
            this.barButtonItem_RemoveFault.Id = 13;
            this.barButtonItem_RemoveFault.Name = "barButtonItem_RemoveFault";
            // 
            // barButtonItem_Refresh
            // 
            this.barButtonItem_Refresh.Id = 14;
            this.barButtonItem_Refresh.Name = "barButtonItem_Refresh";
            // 
            // barButtonItem_New
            // 
            this.barButtonItem_New.Id = 15;
            this.barButtonItem_New.Name = "barButtonItem_New";
            // 
            // barButtonItem_DeleteUser
            // 
            this.barButtonItem_DeleteUser.Id = 16;
            this.barButtonItem_DeleteUser.Name = "barButtonItem_DeleteUser";
            // 
            // barButtonItem_SaveTransactionTypes
            // 
            this.barButtonItem_SaveTransactionTypes.Id = 17;
            this.barButtonItem_SaveTransactionTypes.Name = "barButtonItem_SaveTransactionTypes";
            // 
            // barButtonItem_RefreshTransactionTypes
            // 
            this.barButtonItem_RefreshTransactionTypes.Id = 18;
            this.barButtonItem_RefreshTransactionTypes.Name = "barButtonItem_RefreshTransactionTypes";
            // 
            // barButtonItem_SaveGeneralSettings
            // 
            this.barButtonItem_SaveGeneralSettings.Id = 19;
            this.barButtonItem_SaveGeneralSettings.Name = "barButtonItem_SaveGeneralSettings";
            // 
            // layoutControl6
            // 
            this.layoutControl6.Controls.Add(this.gridControl_Accounts);
            this.layoutControl6.Controls.Add(this.standaloneBarDockControl3);
            this.layoutControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl6.Location = new System.Drawing.Point(0, 0);
            this.layoutControl6.Name = "layoutControl6";
            this.layoutControl6.Root = this.layoutControlGroup6;
            this.layoutControl6.Size = new System.Drawing.Size(790, 506);
            this.layoutControl6.TabIndex = 5;
            this.layoutControl6.Text = "layoutControl6";
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "layoutControlGroup6";
            this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup6.GroupBordersVisible = false;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(790, 506);
            this.layoutControlGroup6.Text = "layoutControlGroup6";
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.standaloneBarDockControl3;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(770, 35);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gridControl_Accounts;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 35);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(770, 451);
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // AccountsSettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 506);
            this.Controls.Add(this.layoutControl6);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AccountsSettingsView";
            this.Text = "Accounts Settings";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).EndInit();
            this.layoutControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SaveJobSettings;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RemoveItemType;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RemoveFault;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Refresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_New;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DeleteUser;
        private DevExpress.XtraGrid.GridControl gridControl_Accounts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Accounts;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl3;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SaveAccountSettings;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SaveTransactionTypes;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RefreshTransactionTypes;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RefreshAccounts;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SaveGeneralSettings;
        private DevExpress.XtraLayout.LayoutControl layoutControl6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}