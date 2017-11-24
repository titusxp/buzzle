

namespace Buzzle.Client.Ui
{
    partial class JobSettingsView
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobSettingsView));
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.gridControl_FaultTypes = new DevExpress.XtraGrid.GridControl();
            this.faultTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_FaultTypes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFaultTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaultName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_ItemTypes = new DevExpress.XtraGrid.GridControl();
            this.ItemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_ItemTypes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_SaveJobSettings = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem_RemoveItemType = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_RemoveFault = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_New = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_DeleteUser = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_SaveAccountSettings = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_SaveTransactionTypes = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_RefreshTransactionTypes = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_RefreshAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_SaveGeneralSettings = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu_ItemTypes = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenu_Fault = new DevExpress.XtraBars.PopupMenu(this.components);
            this.layoutControl6 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_FaultTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_FaultTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ItemTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ItemTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu_ItemTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu_Fault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).BeginInit();
            this.layoutControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(12, 12);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(766, 24);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // gridControl_FaultTypes
            // 
            this.gridControl_FaultTypes.DataSource = this.faultTypeBindingSource;
            this.gridControl_FaultTypes.Location = new System.Drawing.Point(402, 40);
            this.gridControl_FaultTypes.MainView = this.gridView_FaultTypes;
            this.gridControl_FaultTypes.Name = "gridControl_FaultTypes";
            this.gridControl_FaultTypes.Size = new System.Drawing.Size(376, 454);
            this.gridControl_FaultTypes.TabIndex = 1;
            this.gridControl_FaultTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_FaultTypes});
            // 
            // faultTypeBindingSource
            // 
            this.faultTypeBindingSource.DataSource = typeof(Buzzle.DataModel.FaultType);
            // 
            // gridView_FaultTypes
            // 
            this.gridView_FaultTypes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFaultTypeID,
            this.colFaultName,
            this.colNotes1});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colFaultTypeID;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "0";
            this.gridView_FaultTypes.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_FaultTypes.GridControl = this.gridControl_FaultTypes;
            this.gridView_FaultTypes.Name = "gridView_FaultTypes";
            this.gridView_FaultTypes.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_FaultTypes.OptionsView.ShowGroupPanel = false;
            this.gridView_FaultTypes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView_FaultTypes_MouseUp);
            // 
            // colFaultTypeID
            // 
            this.colFaultTypeID.FieldName = "FaultTypeID";
            this.colFaultTypeID.Name = "colFaultTypeID";
            // 
            // colFaultName
            // 
            this.colFaultName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colFaultName.AppearanceHeader.Options.UseFont = true;
            this.colFaultName.Caption = "Fault Types";
            this.colFaultName.FieldName = "FaultName";
            this.colFaultName.Name = "colFaultName";
            this.colFaultName.Visible = true;
            this.colFaultName.VisibleIndex = 0;
            // 
            // colNotes1
            // 
            this.colNotes1.FieldName = "Notes";
            this.colNotes1.Name = "colNotes1";
            // 
            // gridControl_ItemTypes
            // 
            this.gridControl_ItemTypes.DataSource = this.ItemTypeBindingSource;
            this.gridControl_ItemTypes.Location = new System.Drawing.Point(12, 40);
            this.gridControl_ItemTypes.MainView = this.gridView_ItemTypes;
            this.gridControl_ItemTypes.Name = "gridControl_ItemTypes";
            this.gridControl_ItemTypes.Size = new System.Drawing.Size(381, 454);
            this.gridControl_ItemTypes.TabIndex = 0;
            this.gridControl_ItemTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ItemTypes});
            // 
            // ItemTypeBindingSource
            // 
            this.ItemTypeBindingSource.DataSource = typeof(Buzzle.DataModel.JobItemType);
            // 
            // gridView_ItemTypes
            // 
            this.gridView_ItemTypes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemTypeID,
            this.colItemName,
            this.colNotes});
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colItemTypeID;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "0";
            this.gridView_ItemTypes.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.gridView_ItemTypes.GridControl = this.gridControl_ItemTypes;
            this.gridView_ItemTypes.Name = "gridView_ItemTypes";
            this.gridView_ItemTypes.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView_ItemTypes.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_ItemTypes.OptionsView.ShowGroupPanel = false;
            this.gridView_ItemTypes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView_ItemTypes_MouseUp);
            // 
            // colItemTypeID
            // 
            this.colItemTypeID.FieldName = "ItemTypeID";
            this.colItemTypeID.Name = "colItemTypeID";
            // 
            // colItemName
            // 
            this.colItemName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.colItemName.AppearanceHeader.Options.UseFont = true;
            this.colItemName.Caption = "Item Types";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 0;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
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
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 19;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.FloatLocation = new System.Drawing.Point(169, 212);
            this.bar2.FloatSize = new System.Drawing.Size(137, 31);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_SaveJobSettings, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_SaveJobSettings
            // 
            this.barButtonItem_SaveJobSettings.Caption = "Save Changes";
            this.barButtonItem_SaveJobSettings.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SaveJobSettings.Glyph")));
            this.barButtonItem_SaveJobSettings.Id = 0;
            this.barButtonItem_SaveJobSettings.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SaveJobSettings.LargeGlyph")));
            this.barButtonItem_SaveJobSettings.Name = "barButtonItem_SaveJobSettings";
            this.barButtonItem_SaveJobSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_SaveJobSettings_ItemClick);
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
            // barButtonItem_RemoveItemType
            // 
            this.barButtonItem_RemoveItemType.Caption = "Remove Item Type";
            this.barButtonItem_RemoveItemType.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_RemoveItemType.Glyph")));
            this.barButtonItem_RemoveItemType.Id = 1;
            this.barButtonItem_RemoveItemType.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_RemoveItemType.LargeGlyph")));
            this.barButtonItem_RemoveItemType.Name = "barButtonItem_RemoveItemType";
            this.barButtonItem_RemoveItemType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_RemoveItemType_ItemClick);
            // 
            // barButtonItem_RemoveFault
            // 
            this.barButtonItem_RemoveFault.Caption = "Remove Fault Type";
            this.barButtonItem_RemoveFault.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_RemoveFault.Glyph")));
            this.barButtonItem_RemoveFault.Id = 2;
            this.barButtonItem_RemoveFault.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_RemoveFault.LargeGlyph")));
            this.barButtonItem_RemoveFault.Name = "barButtonItem_RemoveFault";
            this.barButtonItem_RemoveFault.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_RemoveFault_ItemClick);
            // 
            // barButtonItem_Refresh
            // 
            this.barButtonItem_Refresh.Id = 11;
            this.barButtonItem_Refresh.Name = "barButtonItem_Refresh";
            // 
            // barButtonItem_New
            // 
            this.barButtonItem_New.Id = 12;
            this.barButtonItem_New.Name = "barButtonItem_New";
            // 
            // barButtonItem_DeleteUser
            // 
            this.barButtonItem_DeleteUser.Id = 13;
            this.barButtonItem_DeleteUser.Name = "barButtonItem_DeleteUser";
            // 
            // barButtonItem_SaveAccountSettings
            // 
            this.barButtonItem_SaveAccountSettings.Id = 14;
            this.barButtonItem_SaveAccountSettings.Name = "barButtonItem_SaveAccountSettings";
            // 
            // barButtonItem_SaveTransactionTypes
            // 
            this.barButtonItem_SaveTransactionTypes.Id = 15;
            this.barButtonItem_SaveTransactionTypes.Name = "barButtonItem_SaveTransactionTypes";
            // 
            // barButtonItem_RefreshTransactionTypes
            // 
            this.barButtonItem_RefreshTransactionTypes.Id = 16;
            this.barButtonItem_RefreshTransactionTypes.Name = "barButtonItem_RefreshTransactionTypes";
            // 
            // barButtonItem_RefreshAccounts
            // 
            this.barButtonItem_RefreshAccounts.Id = 17;
            this.barButtonItem_RefreshAccounts.Name = "barButtonItem_RefreshAccounts";
            // 
            // barButtonItem_SaveGeneralSettings
            // 
            this.barButtonItem_SaveGeneralSettings.Id = 18;
            this.barButtonItem_SaveGeneralSettings.Name = "barButtonItem_SaveGeneralSettings";
            // 
            // popupMenu_ItemTypes
            // 
            this.popupMenu_ItemTypes.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_RemoveItemType)});
            this.popupMenu_ItemTypes.Manager = this.barManager1;
            this.popupMenu_ItemTypes.Name = "popupMenu_ItemTypes";
            // 
            // popupMenu_Fault
            // 
            this.popupMenu_Fault.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_RemoveFault)});
            this.popupMenu_Fault.Manager = this.barManager1;
            this.popupMenu_Fault.Name = "popupMenu_Fault";
            // 
            // layoutControl6
            // 
            this.layoutControl6.Controls.Add(this.gridControl_FaultTypes);
            this.layoutControl6.Controls.Add(this.standaloneBarDockControl1);
            this.layoutControl6.Controls.Add(this.gridControl_ItemTypes);
            this.layoutControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl6.Location = new System.Drawing.Point(0, 0);
            this.layoutControl6.Name = "layoutControl6";
            this.layoutControl6.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(490, 307, 250, 350);
            this.layoutControl6.Root = this.layoutControlGroup6;
            this.layoutControl6.Size = new System.Drawing.Size(790, 506);
            this.layoutControl6.TabIndex = 5;
            this.layoutControl6.Text = "layoutControl6";
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "Root";
            this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup6.GroupBordersVisible = false;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "Root";
            this.layoutControlGroup6.Size = new System.Drawing.Size(790, 506);
            this.layoutControlGroup6.Text = "Root";
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.standaloneBarDockControl1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(770, 28);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl_ItemTypes;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(385, 458);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl_FaultTypes;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(390, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(380, 458);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(385, 28);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 458);
            // 
            // JobSettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 506);
            this.Controls.Add(this.layoutControl6);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "JobSettingsView";
            this.Text = "Job Settings";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_FaultTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_FaultTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ItemTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ItemTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu_ItemTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu_Fault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).EndInit();
            this.layoutControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_FaultTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_FaultTypes;
        private System.Windows.Forms.BindingSource ItemTypeBindingSource;
        private System.Windows.Forms.BindingSource faultTypeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFaultTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colFaultName;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SaveJobSettings;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl_ItemTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ItemTypes;
        private DevExpress.XtraGrid.Columns.GridColumn colItemTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RemoveItemType;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RemoveFault;
        private DevExpress.XtraBars.PopupMenu popupMenu_ItemTypes;
        private DevExpress.XtraBars.PopupMenu popupMenu_Fault;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Refresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_New;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DeleteUser;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SaveAccountSettings;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SaveTransactionTypes;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RefreshTransactionTypes;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RefreshAccounts;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SaveGeneralSettings;
        private DevExpress.XtraLayout.LayoutControl layoutControl6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}