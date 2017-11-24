namespace Buzzle.Sales.Views
{
    partial class SalesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesView));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl_Sales = new DevExpress.XtraGrid.GridControl();
            this.saleBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView_Sales = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSaleID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateRecorded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSalesWorth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_NewSale = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ViewSaleDetails = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu();
            this.barButtonItem_PrintReceipt = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_Sales);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 31);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(646, 413);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl_Sales
            // 
            this.gridControl_Sales.DataSource = this.saleBindingSource;
            this.gridControl_Sales.Location = new System.Drawing.Point(12, 34);
            this.gridControl_Sales.MainView = this.gridView_Sales;
            this.gridControl_Sales.Name = "gridControl_Sales";
            this.gridControl_Sales.Size = new System.Drawing.Size(622, 367);
            this.gridControl_Sales.TabIndex = 4;
            this.gridControl_Sales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Sales});
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(Buzzle.DataModel.Sale);
            // 
            // gridView_Sales
            // 
            this.gridView_Sales.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSaleID,
            this.colCustomerName,
            this.colDateRecorded,
            this.colUser,
            this.colTotalSalesWorth});
            this.gridView_Sales.GridControl = this.gridControl_Sales;
            this.gridView_Sales.Name = "gridView_Sales";
            this.gridView_Sales.OptionsBehavior.Editable = false;
            this.gridView_Sales.OptionsView.ShowGroupPanel = false;
            this.gridView_Sales.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView_Sales_MouseUp);
            this.gridView_Sales.DoubleClick += new System.EventHandler(this.gridView_Sales_DoubleClick);
            // 
            // colSaleID
            // 
            this.colSaleID.AppearanceCell.Options.UseTextOptions = true;
            this.colSaleID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSaleID.Caption = "Sale No.";
            this.colSaleID.DisplayFormat.FormatString = "00000";
            this.colSaleID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaleID.FieldName = "SaleID";
            this.colSaleID.Name = "colSaleID";
            this.colSaleID.Visible = true;
            this.colSaleID.VisibleIndex = 0;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 3;
            // 
            // colDateRecorded
            // 
            this.colDateRecorded.DisplayFormat.FormatString = "dd MMM yyy hh:mm tt";
            this.colDateRecorded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateRecorded.FieldName = "DateRecorded";
            this.colDateRecorded.Name = "colDateRecorded";
            this.colDateRecorded.Visible = true;
            this.colDateRecorded.VisibleIndex = 1;
            // 
            // colUser
            // 
            this.colUser.Caption = "Recorded By";
            this.colUser.FieldName = "User.FullName";
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 4;
            // 
            // colTotalSalesWorth
            // 
            this.colTotalSalesWorth.Caption = "Sale Value";
            this.colTotalSalesWorth.DisplayFormat.FormatString = "0,# CFA";
            this.colTotalSalesWorth.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalSalesWorth.FieldName = "TotalSalesWorth";
            this.colTotalSalesWorth.Name = "colTotalSalesWorth";
            this.colTotalSalesWorth.Visible = true;
            this.colTotalSalesWorth.VisibleIndex = 2;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(646, 413);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.gridControl_Sales;
            this.layoutControlItem1.CustomizationFormText = "Sales:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(626, 393);
            this.layoutControlItem1.Text = "Sales:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(49, 19);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_NewSale,
            this.barButtonItem_ViewSaleDetails,
            this.barButtonItem_PrintReceipt});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_NewSale, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_ViewSaleDetails, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_PrintReceipt, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.Text = "Tools";
            // 
            // barButtonItem_NewSale
            // 
            this.barButtonItem_NewSale.Caption = "New Sale...";
            this.barButtonItem_NewSale.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NewSale.Glyph")));
            this.barButtonItem_NewSale.Id = 0;
            this.barButtonItem_NewSale.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NewSale.LargeGlyph")));
            this.barButtonItem_NewSale.Name = "barButtonItem_NewSale";
            this.barButtonItem_NewSale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_NewSale_ItemClick);
            // 
            // barButtonItem_ViewSaleDetails
            // 
            this.barButtonItem_ViewSaleDetails.Caption = "View Sale Details...";
            this.barButtonItem_ViewSaleDetails.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ViewSaleDetails.Glyph")));
            this.barButtonItem_ViewSaleDetails.Id = 1;
            this.barButtonItem_ViewSaleDetails.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ViewSaleDetails.LargeGlyph")));
            this.barButtonItem_ViewSaleDetails.Name = "barButtonItem_ViewSaleDetails";
            this.barButtonItem_ViewSaleDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ViewSaleDetails_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(646, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 444);
            this.barDockControlBottom.Size = new System.Drawing.Size(646, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 413);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(646, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 413);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_ViewSaleDetails),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_NewSale)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem_PrintReceipt
            // 
            this.barButtonItem_PrintReceipt.Caption = "Print Receipt";
            this.barButtonItem_PrintReceipt.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_PrintReceipt.Glyph")));
            this.barButtonItem_PrintReceipt.Id = 2;
            this.barButtonItem_PrintReceipt.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_PrintReceipt.LargeGlyph")));
            this.barButtonItem_PrintReceipt.Name = "barButtonItem_PrintReceipt";
            this.barButtonItem_PrintReceipt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_PrintReceipt_ItemClick);
            // 
            // SalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 444);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SalesView";
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl_Sales;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Sales;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colDateRecorded;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NewSale;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ViewSaleDetails;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSalesWorth;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_PrintReceipt;
    }
}