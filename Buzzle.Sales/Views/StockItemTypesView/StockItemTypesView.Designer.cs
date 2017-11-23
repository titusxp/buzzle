namespace Buzzle.Sales.Views
{
    partial class StockItemTypesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockItemTypesView));
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl_StockItemTypes = new DevExpress.XtraGrid.GridControl();
            this.stockItemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_StockItemTypes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockItemTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_NewItemType = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ViewEditItem = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_StockItemTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_StockItemTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_StockItemTypes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(613, 322);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl_StockItemTypes
            // 
            this.gridControl_StockItemTypes.DataSource = this.stockItemTypeBindingSource;
            this.gridControl_StockItemTypes.Location = new System.Drawing.Point(12, 12);
            this.gridControl_StockItemTypes.MainView = this.gridView_StockItemTypes;
            this.gridControl_StockItemTypes.Name = "gridControl_StockItemTypes";
            this.gridControl_StockItemTypes.Size = new System.Drawing.Size(589, 298);
            this.gridControl_StockItemTypes.TabIndex = 4;
            this.gridControl_StockItemTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_StockItemTypes});
            // 
            // stockItemTypeBindingSource
            // 
            this.stockItemTypeBindingSource.DataSource = typeof(Buzzle.Data.DataModel.StockItemType);
            this.stockItemTypeBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.stockItemTypeBindingSource_ListChanged);
            // 
            // gridView_StockItemTypes
            // 
            this.gridView_StockItemTypes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockItemTypeID,
            this.colStockItemName,
            this.colUnitPrice,
            this.colNotes,
            this.colModel});
            this.gridView_StockItemTypes.GridControl = this.gridControl_StockItemTypes;
            this.gridView_StockItemTypes.Name = "gridView_StockItemTypes";
            this.gridView_StockItemTypes.OptionsBehavior.Editable = false;
            this.gridView_StockItemTypes.OptionsView.ShowGroupPanel = false;
            this.gridView_StockItemTypes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView_StockItemTypes_MouseUp);
            this.gridView_StockItemTypes.DoubleClick += new System.EventHandler(this.gridView_StockItemTypes_DoubleClick);
            // 
            // colStockItemTypeID
            // 
            this.colStockItemTypeID.FieldName = "StockItemTypeID";
            this.colStockItemTypeID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colStockItemTypeID.Name = "colStockItemTypeID";
            // 
            // colStockItemName
            // 
            this.colStockItemName.Caption = "Item Name";
            this.colStockItemName.FieldName = "StockItemName";
            this.colStockItemName.Image = ((System.Drawing.Image)(resources.GetObject("colStockItemName.Image")));
            this.colStockItemName.Name = "colStockItemName";
            this.colStockItemName.Visible = true;
            this.colStockItemName.VisibleIndex = 0;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DisplayFormat.FormatString = "#,# CFA";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitSellingPrice";
            this.colUnitPrice.Image = ((System.Drawing.Image)(resources.GetObject("colUnitPrice.Image")));
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 2;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Image = ((System.Drawing.Image)(resources.GetObject("colNotes.Image")));
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 3;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.Image = ((System.Drawing.Image)(resources.GetObject("colModel.Image")));
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 1;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(613, 322);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl_StockItemTypes;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(593, 302);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_NewItemType,
            this.barButtonItem_ViewEditItem});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_NewItemType, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_ViewEditItem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_NewItemType
            // 
            this.barButtonItem_NewItemType.Caption = "New Item Type";
            this.barButtonItem_NewItemType.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NewItemType.Glyph")));
            this.barButtonItem_NewItemType.Id = 0;
            this.barButtonItem_NewItemType.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NewItemType.LargeGlyph")));
            this.barButtonItem_NewItemType.Name = "barButtonItem_NewItemType";
            toolTipTitleItem3.Text = "New Item Type";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "create a new item type e.g. item name: Laptop, Model: HP530, Unit Price: 150,000C" +
    "FA etc";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            this.barButtonItem_NewItemType.SuperTip = superToolTip3;
            this.barButtonItem_NewItemType.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_NewItemType_ItemClick);
            // 
            // barButtonItem_ViewEditItem
            // 
            this.barButtonItem_ViewEditItem.Caption = "View/Edit Item";
            this.barButtonItem_ViewEditItem.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ViewEditItem.Glyph")));
            this.barButtonItem_ViewEditItem.Id = 1;
            this.barButtonItem_ViewEditItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ViewEditItem.LargeGlyph")));
            this.barButtonItem_ViewEditItem.Name = "barButtonItem_ViewEditItem";
            toolTipTitleItem4.Text = "View/Edit Item Type";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Opens a view for you to view or editndetails of the selected Item";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            this.barButtonItem_ViewEditItem.SuperTip = superToolTip4;
            this.barButtonItem_ViewEditItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ViewEditItem_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(613, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 346);
            this.barDockControlBottom.Size = new System.Drawing.Size(613, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 322);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(613, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 322);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_ViewEditItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_NewItemType)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // StockItemTypesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 369);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "StockItemTypesView";
            this.Text = "Stock Item Types";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_StockItemTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_StockItemTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl_StockItemTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_StockItemTypes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource stockItemTypeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colStockItemTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colStockItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NewItemType;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ViewEditItem;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}