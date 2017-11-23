namespace Buzzle.Sales.Views
{
    partial class ItemsInStockView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsInStockView));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl_StockItemBalances = new DevExpress.XtraGrid.GridControl();
            this.stockItemBalanceBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView_StockItemBalances = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockItemTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSerialNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitSellingPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_DeleteFromStock = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_StockItemBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemBalanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_StockItemBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_StockItemBalances);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(885, 436);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl_StockItemBalances
            // 
            this.gridControl_StockItemBalances.DataSource = this.stockItemBalanceBindingSource;
            this.gridControl_StockItemBalances.Location = new System.Drawing.Point(12, 12);
            this.gridControl_StockItemBalances.MainView = this.gridView_StockItemBalances;
            this.gridControl_StockItemBalances.Name = "gridControl_StockItemBalances";
            this.gridControl_StockItemBalances.Size = new System.Drawing.Size(861, 412);
            this.gridControl_StockItemBalances.TabIndex = 4;
            this.gridControl_StockItemBalances.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_StockItemBalances});
            // 
            // stockItemBalanceBindingSource
            // 
            this.stockItemBalanceBindingSource.DataSource = typeof(Buzzle.Data.DataModel.StockItemBalance);
            // 
            // gridView_StockItemBalances
            // 
            this.gridView_StockItemBalances.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockItemTypeID,
            this.colStockItemName,
            this.colModel,
            this.colSerialNumber,
            this.colUnitPurchasePrice,
            this.colUnitSellingPrice,
            this.colQuantityInStock});
            this.gridView_StockItemBalances.GridControl = this.gridControl_StockItemBalances;
            this.gridView_StockItemBalances.Name = "gridView_StockItemBalances";
            this.gridView_StockItemBalances.OptionsBehavior.Editable = false;
            this.gridView_StockItemBalances.OptionsView.ShowGroupPanel = false;
            // 
            // colStockItemTypeID
            // 
            this.colStockItemTypeID.FieldName = "StockItemTypeID";
            this.colStockItemTypeID.Name = "colStockItemTypeID";
            // 
            // colStockItemName
            // 
            this.colStockItemName.FieldName = "StockItemName";
            this.colStockItemName.Image = ((System.Drawing.Image)(resources.GetObject("colStockItemName.Image")));
            this.colStockItemName.Name = "colStockItemName";
            this.colStockItemName.Visible = true;
            this.colStockItemName.VisibleIndex = 0;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 1;
            // 
            // colSerialNumber
            // 
            this.colSerialNumber.FieldName = "SerialNumber";
            this.colSerialNumber.Name = "colSerialNumber";
            this.colSerialNumber.Visible = true;
            this.colSerialNumber.VisibleIndex = 2;
            // 
            // colUnitPurchasePrice
            // 
            this.colUnitPurchasePrice.FieldName = "UnitPurchasePrice";
            this.colUnitPurchasePrice.Image = ((System.Drawing.Image)(resources.GetObject("colUnitPurchasePrice.Image")));
            this.colUnitPurchasePrice.Name = "colUnitPurchasePrice";
            this.colUnitPurchasePrice.Visible = true;
            this.colUnitPurchasePrice.VisibleIndex = 3;
            // 
            // colUnitSellingPrice
            // 
            this.colUnitSellingPrice.FieldName = "UnitSellingPrice";
            this.colUnitSellingPrice.Image = ((System.Drawing.Image)(resources.GetObject("colUnitSellingPrice.Image")));
            this.colUnitSellingPrice.Name = "colUnitSellingPrice";
            this.colUnitSellingPrice.Visible = true;
            this.colUnitSellingPrice.VisibleIndex = 4;
            // 
            // colQuantityInStock
            // 
            this.colQuantityInStock.FieldName = "QuantityInStock";
            this.colQuantityInStock.Image = ((System.Drawing.Image)(resources.GetObject("colQuantityInStock.Image")));
            this.colQuantityInStock.Name = "colQuantityInStock";
            this.colQuantityInStock.Visible = true;
            this.colQuantityInStock.VisibleIndex = 5;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(885, 436);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl_StockItemBalances;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(865, 416);
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
            this.barButtonItem_Refresh,
            this.barButtonItem_DeleteFromStock});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Refresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.None, false, this.barButtonItem_DeleteFromStock, false)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_Refresh
            // 
            this.barButtonItem_Refresh.Caption = "Refresh";
            this.barButtonItem_Refresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Refresh.Glyph")));
            this.barButtonItem_Refresh.Id = 0;
            this.barButtonItem_Refresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Refresh.LargeGlyph")));
            this.barButtonItem_Refresh.Name = "barButtonItem_Refresh";
            this.barButtonItem_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Refresh_ItemClick);
            // 
            // barButtonItem_DeleteFromStock
            // 
            this.barButtonItem_DeleteFromStock.Caption = "Delete Items From Stock...";
            this.barButtonItem_DeleteFromStock.Id = 1;
            this.barButtonItem_DeleteFromStock.Name = "barButtonItem_DeleteFromStock";
            toolTipTitleItem1.Text = "Delete Items from Stock";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Opens up a window for the user to select some items and their quantities to delet" +
    "e from stock.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barButtonItem_DeleteFromStock.SuperTip = superToolTip1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(885, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 460);
            this.barDockControlBottom.Size = new System.Drawing.Size(885, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 436);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(885, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 436);
            // 
            // ItemsInStockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 460);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ItemsInStockView";
            this.Text = "Items in Stock";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_StockItemBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemBalanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_StockItemBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl_StockItemBalances;
        private System.Windows.Forms.BindingSource stockItemBalanceBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_StockItemBalances;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colStockItemTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colStockItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitSellingPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityInStock;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Refresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DeleteFromStock;
    }
}