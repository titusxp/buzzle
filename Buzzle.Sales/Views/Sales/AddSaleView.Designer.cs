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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSaleView));
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl_SaleItems = new DevExpress.XtraGrid.GridControl();
            this.saleItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_SaleItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStockItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItem_StockItems = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSoldPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSoldPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textBox_CustomerDetails = new System.Windows.Forms.TextBox();
            this.label_AmountPayable = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.textEdit_UnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_CustomerName = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit_Item = new DevExpress.XtraEditors.LookUpEdit();
            this.textEdit_Quantity = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_RecordSale = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_RecordAndPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Remove = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SaleItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SaleItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem_StockItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_UnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Item.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Quantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(Buzzle.DataModel.Sale);
            // 
            // gridControl_SaleItems
            // 
            this.gridControl_SaleItems.DataSource = this.saleItemBindingSource;
            this.gridControl_SaleItems.Location = new System.Drawing.Point(12, 54);
            this.gridControl_SaleItems.MainView = this.gridView_SaleItems;
            this.gridControl_SaleItems.Name = "gridControl_SaleItems";
            this.gridControl_SaleItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItem_StockItems});
            this.gridControl_SaleItems.Size = new System.Drawing.Size(687, 230);
            this.gridControl_SaleItems.TabIndex = 7;
            this.gridControl_SaleItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_SaleItems});
            // 
            // saleItemBindingSource
            // 
            this.saleItemBindingSource.DataSource = typeof(Buzzle.DataModel.SaleItem);
            this.saleItemBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.saleItemBindingSource_ListChanged);
            // 
            // gridView_SaleItems
            // 
            this.gridView_SaleItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStockItemID,
            this.colSoldPrice,
            this.colQuantity,
            this.colTotalSoldPrice,
            this.colUnitPurchasePrice});
            this.gridView_SaleItems.CustomizationFormBounds = new System.Drawing.Rectangle(478, 429, 216, 185);
            this.gridView_SaleItems.GridControl = this.gridControl_SaleItems;
            this.gridView_SaleItems.Name = "gridView_SaleItems";
            this.gridView_SaleItems.OptionsBehavior.Editable = false;
            this.gridView_SaleItems.OptionsView.ShowGroupPanel = false;
            this.gridView_SaleItems.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView_SaleItems_MouseUp);
            // 
            // colStockItemID
            // 
            this.colStockItemID.Caption = "Item";
            this.colStockItemID.ColumnEdit = this.repositoryItem_StockItems;
            this.colStockItemID.FieldName = "StockItemTypeID";
            this.colStockItemID.Name = "colStockItemID";
            this.colStockItemID.Visible = true;
            this.colStockItemID.VisibleIndex = 0;
            this.colStockItemID.Width = 223;
            // 
            // repositoryItem_StockItems
            // 
            this.repositoryItem_StockItems.AutoHeight = false;
            this.repositoryItem_StockItems.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItem_StockItems.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullStockItemName", "Full Stock Item Name", 110, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItem_StockItems.DisplayMember = "FullStockItemName";
            this.repositoryItem_StockItems.Name = "repositoryItem_StockItems";
            this.repositoryItem_StockItems.NullText = "";
            this.repositoryItem_StockItems.ReadOnly = true;
            this.repositoryItem_StockItems.ValueMember = "StockItemTypeID";
            // 
            // colSoldPrice
            // 
            this.colSoldPrice.Caption = "Selling Price";
            this.colSoldPrice.DisplayFormat.FormatString = "0,# CFA";
            this.colSoldPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoldPrice.FieldName = "UnitSoldPrice";
            this.colSoldPrice.Name = "colSoldPrice";
            this.colSoldPrice.Visible = true;
            this.colSoldPrice.VisibleIndex = 2;
            this.colSoldPrice.Width = 115;
            // 
            // colQuantity
            // 
            this.colQuantity.DisplayFormat.FormatString = "#,#";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 79;
            // 
            // colTotalSoldPrice
            // 
            this.colTotalSoldPrice.Caption = "Total";
            this.colTotalSoldPrice.DisplayFormat.FormatString = "0,# CFA";
            this.colTotalSoldPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalSoldPrice.FieldName = "TotalSoldPrice";
            this.colTotalSoldPrice.Name = "colTotalSoldPrice";
            this.colTotalSoldPrice.Visible = true;
            this.colTotalSoldPrice.VisibleIndex = 4;
            this.colTotalSoldPrice.Width = 116;
            // 
            // colUnitPurchasePrice
            // 
            this.colUnitPurchasePrice.Caption = " Purchase Price";
            this.colUnitPurchasePrice.DisplayFormat.FormatString = "0,# CFA";
            this.colUnitPurchasePrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPurchasePrice.FieldName = "UnitPurchasePrice";
            this.colUnitPurchasePrice.Name = "colUnitPurchasePrice";
            this.colUnitPurchasePrice.Visible = true;
            this.colUnitPurchasePrice.VisibleIndex = 1;
            this.colUnitPurchasePrice.Width = 136;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textBox_CustomerDetails);
            this.layoutControl1.Controls.Add(this.label_AmountPayable);
            this.layoutControl1.Controls.Add(this.button_Add);
            this.layoutControl1.Controls.Add(this.textEdit_UnitPrice);
            this.layoutControl1.Controls.Add(this.textEdit_CustomerName);
            this.layoutControl1.Controls.Add(this.lookUpEdit_Item);
            this.layoutControl1.Controls.Add(this.gridControl_SaleItems);
            this.layoutControl1.Controls.Add(this.textEdit_Quantity);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(711, 439);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textBox_CustomerDetails
            // 
            this.textBox_CustomerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox_CustomerDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "CustomerDetails", true));
            this.textBox_CustomerDetails.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.textBox_CustomerDetails.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CustomerDetails.Location = new System.Drawing.Point(100, 352);
            this.textBox_CustomerDetails.Multiline = true;
            this.textBox_CustomerDetails.Name = "textBox_CustomerDetails";
            this.textBox_CustomerDetails.Size = new System.Drawing.Size(599, 75);
            this.textBox_CustomerDetails.TabIndex = 14;
            this.textBox_CustomerDetails.Text = "679-684-428 (titusnsami@yahoo.com)";
            // 
            // label_AmountPayable
            // 
            this.label_AmountPayable.BackColor = System.Drawing.Color.Olive;
            this.label_AmountPayable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label_AmountPayable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_AmountPayable.Location = new System.Drawing.Point(498, 288);
            this.label_AmountPayable.Name = "label_AmountPayable";
            this.label_AmountPayable.Size = new System.Drawing.Size(201, 34);
            this.label_AmountPayable.TabIndex = 13;
            this.label_AmountPayable.Text = "CFA";
            this.label_AmountPayable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.button_Add.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.button_Add.ForeColor = System.Drawing.Color.Black;
            this.button_Add.Location = new System.Drawing.Point(567, 12);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(132, 38);
            this.button_Add.TabIndex = 12;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textEdit_UnitPrice
            // 
            this.textEdit_UnitPrice.Location = new System.Drawing.Point(452, 28);
            this.textEdit_UnitPrice.Name = "textEdit_UnitPrice";
            this.textEdit_UnitPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textEdit_UnitPrice.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_UnitPrice.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.textEdit_UnitPrice.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit_UnitPrice.Properties.Appearance.Options.UseFont = true;
            this.textEdit_UnitPrice.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit_UnitPrice.Properties.DisplayFormat.FormatString = "0,# CFA";
            this.textEdit_UnitPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit_UnitPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit_UnitPrice.Size = new System.Drawing.Size(111, 22);
            this.textEdit_UnitPrice.StyleController = this.layoutControl1;
            this.textEdit_UnitPrice.TabIndex = 10;
            // 
            // textEdit_CustomerName
            // 
            this.textEdit_CustomerName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.saleBindingSource, "CustomerName", true));
            this.textEdit_CustomerName.Location = new System.Drawing.Point(100, 326);
            this.textEdit_CustomerName.Name = "textEdit_CustomerName";
            this.textEdit_CustomerName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textEdit_CustomerName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_CustomerName.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.textEdit_CustomerName.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit_CustomerName.Properties.Appearance.Options.UseFont = true;
            this.textEdit_CustomerName.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit_CustomerName.Size = new System.Drawing.Size(599, 22);
            this.textEdit_CustomerName.StyleController = this.layoutControl1;
            this.textEdit_CustomerName.TabIndex = 9;
            // 
            // lookUpEdit_Item
            // 
            this.lookUpEdit_Item.Location = new System.Drawing.Point(12, 28);
            this.lookUpEdit_Item.Name = "lookUpEdit_Item";
            this.lookUpEdit_Item.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lookUpEdit_Item.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lookUpEdit_Item.Properties.ShowFooter = false;
            this.lookUpEdit_Item.Properties.ShowHeader = false;
            this.lookUpEdit_Item.Properties.ValueMember = "StockItemTypeID";
            this.lookUpEdit_Item.Size = new System.Drawing.Size(352, 22);
            this.lookUpEdit_Item.StyleController = this.layoutControl1;
            this.lookUpEdit_Item.TabIndex = 8;
            this.lookUpEdit_Item.EditValueChanged += new System.EventHandler(this.lookUpEdit_Item_EditValueChanged);
            // 
            // textEdit_Quantity
            // 
            this.textEdit_Quantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEdit_Quantity.Location = new System.Drawing.Point(368, 28);
            this.textEdit_Quantity.Name = "textEdit_Quantity";
            this.textEdit_Quantity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textEdit_Quantity.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit_Quantity.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.textEdit_Quantity.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit_Quantity.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Quantity.Properties.Appearance.Options.UseForeColor = true;
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
            this.textEdit_Quantity.Size = new System.Drawing.Size(80, 22);
            this.textEdit_Quantity.StyleController = this.layoutControl1;
            this.textEdit_Quantity.TabIndex = 11;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(711, 439);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl_SaleItems;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(691, 234);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lookUpEdit_Item;
            this.layoutControlItem5.CustomizationFormText = "Item:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(356, 42);
            this.layoutControlItem5.Text = "Item:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textEdit_UnitPrice;
            this.layoutControlItem7.CustomizationFormText = "Unit Price:";
            this.layoutControlItem7.Location = new System.Drawing.Point(440, 0);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(115, 42);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(115, 42);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(115, 42);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "Unit Price:";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.textEdit_Quantity;
            this.layoutControlItem8.CustomizationFormText = "Quantity";
            this.layoutControlItem8.Location = new System.Drawing.Point(356, 0);
            this.layoutControlItem8.MaxSize = new System.Drawing.Size(84, 42);
            this.layoutControlItem8.MinSize = new System.Drawing.Size(84, 42);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(84, 42);
            this.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem8.Text = "Quantity";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.button_Add;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(555, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(136, 42);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.label_AmountPayable;
            this.layoutControlItem2.CustomizationFormText = "Amount Payable:";
            this.layoutControlItem2.Location = new System.Drawing.Point(398, 276);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(293, 38);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(293, 38);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(293, 38);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Amount Payable:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(85, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 276);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(398, 38);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textEdit_CustomerName;
            this.layoutControlItem6.CustomizationFormText = "Customer Name:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 314);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(691, 26);
            this.layoutControlItem6.Text = "Customer Name:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(85, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textBox_CustomerDetails;
            this.layoutControlItem3.CustomizationFormText = "Customer Details:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 340);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(691, 79);
            this.layoutControlItem3.Text = "Customer Details:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(85, 13);
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
            this.barButtonItem_RecordSale,
            this.barButtonItem_RecordAndPrint,
            this.barButtonItem_Remove});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_RecordSale, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_RecordAndPrint, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Remove, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_RecordSale
            // 
            this.barButtonItem_RecordSale.Caption = "Record Sale";
            this.barButtonItem_RecordSale.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_RecordSale.Glyph")));
            this.barButtonItem_RecordSale.Id = 0;
            this.barButtonItem_RecordSale.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_RecordSale.LargeGlyph")));
            this.barButtonItem_RecordSale.Name = "barButtonItem_RecordSale";
            this.barButtonItem_RecordSale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_RecordSale_ItemClick);
            // 
            // barButtonItem_RecordAndPrint
            // 
            this.barButtonItem_RecordAndPrint.Caption = "Record Sale and Print Receipt";
            this.barButtonItem_RecordAndPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_RecordAndPrint.Glyph")));
            this.barButtonItem_RecordAndPrint.Id = 1;
            this.barButtonItem_RecordAndPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_RecordAndPrint.LargeGlyph")));
            this.barButtonItem_RecordAndPrint.Name = "barButtonItem_RecordAndPrint";
            this.barButtonItem_RecordAndPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_RecordAndPrint_ItemClick);
            // 
            // barButtonItem_Remove
            // 
            this.barButtonItem_Remove.Caption = "Remove Item";
            this.barButtonItem_Remove.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Remove.Glyph")));
            this.barButtonItem_Remove.Id = 2;
            this.barButtonItem_Remove.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Remove.LargeGlyph")));
            this.barButtonItem_Remove.Name = "barButtonItem_Remove";
            this.barButtonItem_Remove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Remove_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(711, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 463);
            this.barDockControlBottom.Size = new System.Drawing.Size(711, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 439);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(711, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 439);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Remove)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // AddSaleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 463);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AddSaleView";
            this.Text = "AddSaleView";
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SaleItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SaleItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItem_StockItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_UnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_Item.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Quantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_SaleItems;
        private System.Windows.Forms.BindingSource saleItemBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_SaleItems;
        private DevExpress.XtraGrid.Columns.GridColumn colStockItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colSoldPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSoldPrice;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
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
        private System.Windows.Forms.Button button_Add;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.Label label_AmountPayable;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RecordSale;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.TextBox textBox_CustomerDetails;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPurchasePrice;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RecordAndPrint;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Remove;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}