namespace Buzzle.Sales.Views
{
    partial class AddSaleView
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.lookUpEdit_RecordedBy = new DevExpress.XtraEditors.LookUpEdit();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit_DateRecorded = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_SaleNumber = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl_SaleItems = new DevExpress.XtraGrid.GridControl();
            this.saleItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_SaleItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItem_StockItems = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSoldPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSoldPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit_CustomerName = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit_Item = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl_GroupControlSales = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit_UnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit_Quantity = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_RecordedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DateRecorded.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SaleNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SaleItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SaleItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem_StockItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Item.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_GroupControlSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_UnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Quantity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(582, 120);
            this.groupControl1.TabIndex = 0;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.lookUpEdit_RecordedBy);
            this.layoutControl2.Controls.Add(this.textEdit_DateRecorded);
            this.layoutControl2.Controls.Add(this.textEdit_SaleNumber);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 21);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(578, 97);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // lookUpEdit_RecordedBy
            // 
            this.lookUpEdit_RecordedBy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.saleBindingSource, "RecordedByUserID", true));
            this.lookUpEdit_RecordedBy.Location = new System.Drawing.Point(91, 62);
            this.lookUpEdit_RecordedBy.Name = "lookUpEdit_RecordedBy";
            this.lookUpEdit_RecordedBy.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lookUpEdit_RecordedBy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_RecordedBy.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.lookUpEdit_RecordedBy.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit_RecordedBy.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_RecordedBy.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEdit_RecordedBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_RecordedBy.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Name1")});
            this.lookUpEdit_RecordedBy.Properties.DisplayMember = "FullName";
            this.lookUpEdit_RecordedBy.Properties.NullText = "";
            this.lookUpEdit_RecordedBy.Properties.ReadOnly = true;
            this.lookUpEdit_RecordedBy.Properties.ValueMember = "UserID";
            this.lookUpEdit_RecordedBy.Size = new System.Drawing.Size(475, 22);
            this.lookUpEdit_RecordedBy.StyleController = this.layoutControl2;
            this.lookUpEdit_RecordedBy.TabIndex = 6;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(Buzzle.Data.DataModel.Sale);
            // 
            // textEdit_DateRecorded
            // 
            this.textEdit_DateRecorded.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.saleBindingSource, "DateRecorded", true));
            this.textEdit_DateRecorded.Location = new System.Drawing.Point(91, 36);
            this.textEdit_DateRecorded.Name = "textEdit_DateRecorded";
            this.textEdit_DateRecorded.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textEdit_DateRecorded.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textEdit_DateRecorded.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.textEdit_DateRecorded.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit_DateRecorded.Properties.Appearance.Options.UseFont = true;
            this.textEdit_DateRecorded.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit_DateRecorded.Size = new System.Drawing.Size(475, 22);
            this.textEdit_DateRecorded.StyleController = this.layoutControl2;
            this.textEdit_DateRecorded.TabIndex = 5;
            // 
            // textEdit_SaleNumber
            // 
            this.textEdit_SaleNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.saleBindingSource, "SaleID", true));
            this.textEdit_SaleNumber.Location = new System.Drawing.Point(91, 12);
            this.textEdit_SaleNumber.Name = "textEdit_SaleNumber";
            this.textEdit_SaleNumber.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textEdit_SaleNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textEdit_SaleNumber.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.textEdit_SaleNumber.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit_SaleNumber.Properties.Appearance.Options.UseFont = true;
            this.textEdit_SaleNumber.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit_SaleNumber.Size = new System.Drawing.Size(475, 22);
            this.textEdit_SaleNumber.StyleController = this.layoutControl2;
            this.textEdit_SaleNumber.TabIndex = 4;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(578, 97);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_SaleNumber;
            this.layoutControlItem1.CustomizationFormText = "Sale No.";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 24);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(133, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(558, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Sale No.";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit_DateRecorded;
            this.layoutControlItem2.CustomizationFormText = "Date Recorded:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(558, 26);
            this.layoutControlItem2.Text = "Date Recorded:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(76, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lookUpEdit_RecordedBy;
            this.layoutControlItem3.CustomizationFormText = "Recorded By:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(558, 27);
            this.layoutControlItem3.Text = "Recorded By:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(76, 13);
            // 
            // gridControl_SaleItems
            // 
            this.gridControl_SaleItems.DataSource = this.saleItemBindingSource;
            this.gridControl_SaleItems.Location = new System.Drawing.Point(12, 204);
            this.gridControl_SaleItems.MainView = this.gridView_SaleItems;
            this.gridControl_SaleItems.Name = "gridControl_SaleItems";
            this.gridControl_SaleItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItem_StockItems});
            this.gridControl_SaleItems.Size = new System.Drawing.Size(582, 190);
            this.gridControl_SaleItems.TabIndex = 7;
            this.gridControl_SaleItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_SaleItems});
            // 
            // saleItemBindingSource
            // 
            this.saleItemBindingSource.DataSource = typeof(Buzzle.Data.DataModel.SaleItem);
            // 
            // gridView_SaleItems
            // 
            this.gridView_SaleItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockItemID,
            this.colSoldPrice,
            this.colQuantity,
            this.colTotalSoldPrice});
            this.gridView_SaleItems.GridControl = this.gridControl_SaleItems;
            this.gridView_SaleItems.Name = "gridView_SaleItems";
            this.gridView_SaleItems.OptionsView.ShowGroupPanel = false;
            // 
            // colStockItemID
            // 
            this.colStockItemID.Caption = "Item";
            this.colStockItemID.ColumnEdit = this.repositoryItem_StockItems;
            this.colStockItemID.FieldName = "StockItemID";
            this.colStockItemID.Name = "colStockItemID";
            this.colStockItemID.Visible = true;
            this.colStockItemID.VisibleIndex = 0;
            // 
            // repositoryItem_StockItems
            // 
            this.repositoryItem_StockItems.AutoHeight = false;
            this.repositoryItem_StockItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItem_StockItems.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullStockItemName", "Full Stock Item Name", 110, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItem_StockItems.Name = "repositoryItem_StockItems";
            this.repositoryItem_StockItems.NullText = "";
            this.repositoryItem_StockItems.ReadOnly = true;
            // 
            // colSoldPrice
            // 
            this.colSoldPrice.Caption = "Unit Selling Price";
            this.colSoldPrice.DisplayFormat.FormatString = "0,# CFA";
            this.colSoldPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoldPrice.FieldName = "SoldPrice";
            this.colSoldPrice.Name = "colSoldPrice";
            this.colSoldPrice.Visible = true;
            this.colSoldPrice.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colTotalSoldPrice
            // 
            this.colTotalSoldPrice.Caption = "Total";
            this.colTotalSoldPrice.DisplayFormat.FormatString = "0,# CFA";
            this.colTotalSoldPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalSoldPrice.FieldName = "TotalSoldPrice";
            this.colTotalSoldPrice.Name = "colTotalSoldPrice";
            this.colTotalSoldPrice.Visible = true;
            this.colTotalSoldPrice.VisibleIndex = 3;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit_UnitPrice);
            this.layoutControl1.Controls.Add(this.textEdit_CustomerName);
            this.layoutControl1.Controls.Add(this.lookUpEdit_Item);
            this.layoutControl1.Controls.Add(this.gridControl_SaleItems);
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Controls.Add(this.textEdit_Quantity);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(606, 406);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit_CustomerName
            // 
            this.textEdit_CustomerName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.saleBindingSource, "CustomerName", true));
            this.textEdit_CustomerName.Location = new System.Drawing.Point(95, 136);
            this.textEdit_CustomerName.Name = "textEdit_CustomerName";
            this.textEdit_CustomerName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textEdit_CustomerName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textEdit_CustomerName.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.textEdit_CustomerName.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit_CustomerName.Properties.Appearance.Options.UseFont = true;
            this.textEdit_CustomerName.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit_CustomerName.Size = new System.Drawing.Size(499, 22);
            this.textEdit_CustomerName.StyleController = this.layoutControl1;
            this.textEdit_CustomerName.TabIndex = 9;
            // 
            // lookUpEdit_Item
            // 
            this.lookUpEdit_Item.Location = new System.Drawing.Point(12, 178);
            this.lookUpEdit_Item.Name = "lookUpEdit_Item";
            this.lookUpEdit_Item.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lookUpEdit_Item.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lookUpEdit_Item.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.lookUpEdit_Item.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit_Item.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit_Item.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEdit_Item.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_Item.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullStockItemName", "Full Stock Item Name", 143, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit_Item.Properties.DisplayMember = "FullStockItemName";
            this.lookUpEdit_Item.Properties.NullText = "Select Item...";
            this.lookUpEdit_Item.Properties.ValueMember = "StockItemTypeID";
            this.lookUpEdit_Item.Size = new System.Drawing.Size(289, 22);
            this.lookUpEdit_Item.StyleController = this.layoutControl1;
            this.lookUpEdit_Item.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControl_GroupControlSales,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(606, 406);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControl_GroupControlSales
            // 
            this.layoutControl_GroupControlSales.Control = this.groupControl1;
            this.layoutControl_GroupControlSales.CustomizationFormText = "layoutControl_GroupControlSales";
            this.layoutControl_GroupControlSales.Location = new System.Drawing.Point(0, 0);
            this.layoutControl_GroupControlSales.MaxSize = new System.Drawing.Size(0, 124);
            this.layoutControl_GroupControlSales.MinSize = new System.Drawing.Size(104, 124);
            this.layoutControl_GroupControlSales.Name = "layoutControl_GroupControlSales";
            this.layoutControl_GroupControlSales.Size = new System.Drawing.Size(586, 124);
            this.layoutControl_GroupControlSales.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_GroupControlSales.Text = "layoutControl_GroupControlSales";
            this.layoutControl_GroupControlSales.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_GroupControlSales.TextToControlDistance = 0;
            this.layoutControl_GroupControlSales.TextVisible = false;
            this.layoutControl_GroupControlSales.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl_SaleItems;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(586, 194);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lookUpEdit_Item;
            this.layoutControlItem5.CustomizationFormText = "Item:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 150);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(293, 42);
            this.layoutControlItem5.Text = "Item:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textEdit_CustomerName;
            this.layoutControlItem6.CustomizationFormText = "Customer Name:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(586, 26);
            this.layoutControlItem6.Text = "Customer Name:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(80, 13);
            // 
            // textEdit_UnitPrice
            // 
            this.textEdit_UnitPrice.Location = new System.Drawing.Point(451, 178);
            this.textEdit_UnitPrice.Name = "textEdit_UnitPrice";
            this.textEdit_UnitPrice.Properties.DisplayFormat.FormatString = "0,# CFA";
            this.textEdit_UnitPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit_UnitPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit_UnitPrice.Size = new System.Drawing.Size(143, 20);
            this.textEdit_UnitPrice.StyleController = this.layoutControl1;
            this.textEdit_UnitPrice.TabIndex = 10;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textEdit_UnitPrice;
            this.layoutControlItem7.CustomizationFormText = "Unit Price:";
            this.layoutControlItem7.Location = new System.Drawing.Point(439, 150);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(147, 42);
            this.layoutControlItem7.Text = "Unit Price:";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(80, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.textEdit_Quantity;
            this.layoutControlItem8.CustomizationFormText = "Quantity";
            this.layoutControlItem8.Location = new System.Drawing.Point(293, 150);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(146, 42);
            this.layoutControlItem8.Text = "Quantity";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(80, 13);
            // 
            // textEdit_Quantity
            // 
            this.textEdit_Quantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEdit_Quantity.Location = new System.Drawing.Point(305, 178);
            this.textEdit_Quantity.Name = "textEdit_Quantity";
            this.textEdit_Quantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit_Quantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit_Quantity.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit_Quantity.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEdit_Quantity.Properties.IsFloatValue = false;
            this.textEdit_Quantity.Properties.Mask.EditMask = "N00";
            this.textEdit_Quantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit_Quantity.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textEdit_Quantity.Size = new System.Drawing.Size(142, 20);
            this.textEdit_Quantity.StyleController = this.layoutControl1;
            this.textEdit_Quantity.TabIndex = 11;
            // 
            // AddSaleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 406);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AddSaleView";
            this.Text = "AddSaleView";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_RecordedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DateRecorded.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SaleNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SaleItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SaleItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem_StockItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Item.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_GroupControlSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_UnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Quantity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gridControl_SaleItems;
        private System.Windows.Forms.BindingSource saleItemBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_SaleItems;
        private DevExpress.XtraGrid.Columns.GridColumn colStockItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colSoldPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSoldPrice;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_RecordedBy;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit_DateRecorded;
        private DevExpress.XtraEditors.TextEdit textEdit_SaleNumber;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControl_GroupControlSales;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItem_StockItems;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_Item;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit textEdit_CustomerName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit textEdit_UnitPrice;
        private DevExpress.XtraEditors.SpinEdit textEdit_Quantity;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}