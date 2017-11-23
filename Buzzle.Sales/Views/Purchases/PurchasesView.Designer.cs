namespace Buzzle.Sales.Views
{
    partial class PurchasesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasesView));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl_Purchases = new DevExpress.XtraGrid.GridControl();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView_Purchases = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPurchaseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateRecorded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_New = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ViewEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ProcessPurchase = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Purchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Purchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_Purchases);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(731, 426);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl_Purchases
            // 
            this.gridControl_Purchases.DataSource = this.purchaseBindingSource;
            this.gridControl_Purchases.Location = new System.Drawing.Point(12, 12);
            this.gridControl_Purchases.MainView = this.gridView_Purchases;
            this.gridControl_Purchases.Name = "gridControl_Purchases";
            this.gridControl_Purchases.Size = new System.Drawing.Size(707, 402);
            this.gridControl_Purchases.TabIndex = 4;
            this.gridControl_Purchases.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Purchases});
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataSource = typeof(Buzzle.Data.DataModel.Purchase);
            this.purchaseBindingSource.CurrentChanged += new System.EventHandler(this.purchaseBindingSource_CurrentChanged);
            // 
            // gridView_Purchases
            // 
            this.gridView_Purchases.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPurchaseID,
            this.colDateRecorded,
            this.colStatus,
            this.colUser});
            this.gridView_Purchases.GridControl = this.gridControl_Purchases;
            this.gridView_Purchases.Name = "gridView_Purchases";
            this.gridView_Purchases.OptionsBehavior.Editable = false;
            this.gridView_Purchases.OptionsFind.AlwaysVisible = true;
            this.gridView_Purchases.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.FindClick;
            this.gridView_Purchases.OptionsView.ShowGroupPanel = false;
            this.gridView_Purchases.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView_Purchases_MouseUp);
            this.gridView_Purchases.DoubleClick += new System.EventHandler(this.gridView_Purchases_DoubleClick);
            // 
            // colPurchaseID
            // 
            this.colPurchaseID.AppearanceCell.Options.UseTextOptions = true;
            this.colPurchaseID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPurchaseID.Caption = "Purchase No.";
            this.colPurchaseID.DisplayFormat.FormatString = "000000";
            this.colPurchaseID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchaseID.FieldName = "PurchaseID";
            this.colPurchaseID.Image = ((System.Drawing.Image)(resources.GetObject("colPurchaseID.Image")));
            this.colPurchaseID.Name = "colPurchaseID";
            this.colPurchaseID.Visible = true;
            this.colPurchaseID.VisibleIndex = 0;
            this.colPurchaseID.Width = 95;
            // 
            // colDateRecorded
            // 
            this.colDateRecorded.DisplayFormat.FormatString = "dd MMM yyyy hh:mm:tt";
            this.colDateRecorded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateRecorded.FieldName = "DateRecorded";
            this.colDateRecorded.Image = ((System.Drawing.Image)(resources.GetObject("colDateRecorded.Image")));
            this.colDateRecorded.Name = "colDateRecorded";
            this.colDateRecorded.Visible = true;
            this.colDateRecorded.VisibleIndex = 1;
            this.colDateRecorded.Width = 157;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Image = ((System.Drawing.Image)(resources.GetObject("colStatus.Image")));
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            this.colStatus.Width = 132;
            // 
            // colUser
            // 
            this.colUser.Caption = "Created By";
            this.colUser.FieldName = "User.FullName";
            this.colUser.Image = ((System.Drawing.Image)(resources.GetObject("colUser.Image")));
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 2;
            this.colUser.Width = 305;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(731, 426);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl_Purchases;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(711, 406);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
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
            this.barButtonItem_New,
            this.barButtonItem_ProcessPurchase,
            this.barButtonItem_Cancel,
            this.barButtonItem_Delete,
            this.barButtonItem_ViewEdit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_New, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_ViewEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_ProcessPurchase, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Cancel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_New
            // 
            this.barButtonItem_New.Caption = "New Purchase";
            this.barButtonItem_New.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_New.Glyph")));
            this.barButtonItem_New.Id = 0;
            this.barButtonItem_New.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_New.LargeGlyph")));
            this.barButtonItem_New.Name = "barButtonItem_New";
            this.barButtonItem_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_New_ItemClick);
            // 
            // barButtonItem_ViewEdit
            // 
            this.barButtonItem_ViewEdit.Caption = "View or Edit";
            this.barButtonItem_ViewEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ViewEdit.Glyph")));
            this.barButtonItem_ViewEdit.Id = 5;
            this.barButtonItem_ViewEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ViewEdit.LargeGlyph")));
            this.barButtonItem_ViewEdit.Name = "barButtonItem_ViewEdit";
            this.barButtonItem_ViewEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ViewEdit_ItemClick);
            // 
            // barButtonItem_ProcessPurchase
            // 
            this.barButtonItem_ProcessPurchase.Caption = "Process Purchase";
            this.barButtonItem_ProcessPurchase.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ProcessPurchase.Glyph")));
            this.barButtonItem_ProcessPurchase.Id = 1;
            this.barButtonItem_ProcessPurchase.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ProcessPurchase.LargeGlyph")));
            this.barButtonItem_ProcessPurchase.Name = "barButtonItem_ProcessPurchase";
            toolTipTitleItem1.Text = "Process Purchase";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Used when you have already bought the items in the purchase. It opens a window fo" +
    "r you to enter details of the purchase and then store the new items to your stoc" +
    "k";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barButtonItem_ProcessPurchase.SuperTip = superToolTip1;
            this.barButtonItem_ProcessPurchase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ProcessPurchase_ItemClick);
            // 
            // barButtonItem_Cancel
            // 
            this.barButtonItem_Cancel.Caption = "Cancel Purchase";
            this.barButtonItem_Cancel.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Cancel.Glyph")));
            this.barButtonItem_Cancel.Id = 2;
            this.barButtonItem_Cancel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Cancel.LargeGlyph")));
            this.barButtonItem_Cancel.Name = "barButtonItem_Cancel";
            toolTipTitleItem2.Text = "Cancel Purchase";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Cancels the purchase, rendering it unprocessable";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.barButtonItem_Cancel.SuperTip = superToolTip2;
            this.barButtonItem_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Cancel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(731, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Size = new System.Drawing.Size(731, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 426);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(731, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 426);
            // 
            // barButtonItem_Delete
            // 
            this.barButtonItem_Delete.Caption = "Delete Purchase";
            this.barButtonItem_Delete.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Delete.Glyph")));
            this.barButtonItem_Delete.Id = 4;
            this.barButtonItem_Delete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Delete.LargeGlyph")));
            this.barButtonItem_Delete.Name = "barButtonItem_Delete";
            this.barButtonItem_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Delete_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_ViewEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_ProcessPurchase),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Cancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_New)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // PurchasesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PurchasesView";
            this.Text = "Purchases";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Purchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Purchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl_Purchases;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Purchases;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseID;
        private DevExpress.XtraGrid.Columns.GridColumn colDateRecorded;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_New;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ProcessPurchase;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Cancel;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Delete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ViewEdit;
    }
}