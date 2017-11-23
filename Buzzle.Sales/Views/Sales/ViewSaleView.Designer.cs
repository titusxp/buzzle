namespace Buzzle.Sales.Views
{
    partial class ViewSaleView
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.label_Total = new System.Windows.Forms.Label();
            this.gridControl_SaleItems = new DevExpress.XtraGrid.GridControl();
            this.saleItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_SaleItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSoldPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSoldPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textBox_CustomerDetails = new System.Windows.Forms.TextBox();
            this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_RecordedBy = new System.Windows.Forms.TextBox();
            this.textBox_DateRecorded = new System.Windows.Forms.TextBox();
            this.textBox_CustomerName = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.colSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit_SaleNumber = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SaleItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SaleItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SaleNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit_SaleNumber);
            this.layoutControl1.Controls.Add(this.label_Total);
            this.layoutControl1.Controls.Add(this.gridControl_SaleItems);
            this.layoutControl1.Controls.Add(this.textBox_CustomerDetails);
            this.layoutControl1.Controls.Add(this.textBox_RecordedBy);
            this.layoutControl1.Controls.Add(this.textBox_DateRecorded);
            this.layoutControl1.Controls.Add(this.textBox_CustomerName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(498, 396);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // label_Total
            // 
            this.label_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_Total.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label_Total.ForeColor = System.Drawing.Color.Black;
            this.label_Total.Location = new System.Drawing.Point(314, 342);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(172, 42);
            this.label_Total.TabIndex = 7;
            this.label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridControl_SaleItems
            // 
            this.gridControl_SaleItems.DataSource = this.saleItemBindingSource;
            this.gridControl_SaleItems.Location = new System.Drawing.Point(12, 102);
            this.gridControl_SaleItems.MainView = this.gridView_SaleItems;
            this.gridControl_SaleItems.Name = "gridControl_SaleItems";
            this.gridControl_SaleItems.Size = new System.Drawing.Size(474, 236);
            this.gridControl_SaleItems.TabIndex = 6;
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
            this.colSoldPrice,
            this.colQuantity,
            this.colTotalSoldPrice,
            this.colStockItemType});
            this.gridView_SaleItems.CustomizationFormBounds = new System.Drawing.Rectangle(343, 368, 210, 179);
            this.gridView_SaleItems.GridControl = this.gridControl_SaleItems;
            this.gridView_SaleItems.Name = "gridView_SaleItems";
            this.gridView_SaleItems.OptionsBehavior.Editable = false;
            this.gridView_SaleItems.OptionsView.ShowGroupPanel = false;
            // 
            // colSoldPrice
            // 
            this.colSoldPrice.Caption = "Unit Price";
            this.colSoldPrice.DisplayFormat.FormatString = "0,# CFA";
            this.colSoldPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSoldPrice.FieldName = "UnitSoldPrice";
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
            // colStockItemType
            // 
            this.colStockItemType.Caption = "Item";
            this.colStockItemType.FieldName = "StockItemType.FullStockItemName";
            this.colStockItemType.Name = "colStockItemType";
            this.colStockItemType.Visible = true;
            this.colStockItemType.VisibleIndex = 0;
            // 
            // textBox_CustomerDetails
            // 
            this.textBox_CustomerDetails.BackColor = System.Drawing.Color.Green;
            this.textBox_CustomerDetails.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "CustomerDetails", true));
            this.textBox_CustomerDetails.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_CustomerDetails.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CustomerDetails.Location = new System.Drawing.Point(335, 38);
            this.textBox_CustomerDetails.Multiline = true;
            this.textBox_CustomerDetails.Name = "textBox_CustomerDetails";
            this.textBox_CustomerDetails.ReadOnly = true;
            this.textBox_CustomerDetails.Size = new System.Drawing.Size(151, 44);
            this.textBox_CustomerDetails.TabIndex = 5;
            // 
            // saleBindingSource
            // 
            this.saleBindingSource.DataSource = typeof(Buzzle.Data.DataModel.Sale);
            // 
            // textBox_RecordedBy
            // 
            this.textBox_RecordedBy.BackColor = System.Drawing.Color.Green;
            this.textBox_RecordedBy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "User.FullName", true));
            this.textBox_RecordedBy.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_RecordedBy.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_RecordedBy.Location = new System.Drawing.Point(96, 62);
            this.textBox_RecordedBy.Name = "textBox_RecordedBy";
            this.textBox_RecordedBy.ReadOnly = true;
            this.textBox_RecordedBy.Size = new System.Drawing.Size(151, 20);
            this.textBox_RecordedBy.TabIndex = 5;
            // 
            // textBox_DateRecorded
            // 
            this.textBox_DateRecorded.BackColor = System.Drawing.Color.Green;
            this.textBox_DateRecorded.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "DateRecorded", true));
            this.textBox_DateRecorded.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_DateRecorded.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_DateRecorded.Location = new System.Drawing.Point(96, 38);
            this.textBox_DateRecorded.Name = "textBox_DateRecorded";
            this.textBox_DateRecorded.ReadOnly = true;
            this.textBox_DateRecorded.Size = new System.Drawing.Size(151, 20);
            this.textBox_DateRecorded.TabIndex = 5;
            // 
            // textBox_CustomerName
            // 
            this.textBox_CustomerName.BackColor = System.Drawing.Color.Green;
            this.textBox_CustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.saleBindingSource, "CustomerName", true));
            this.textBox_CustomerName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_CustomerName.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_CustomerName.Location = new System.Drawing.Point(335, 12);
            this.textBox_CustomerName.Name = "textBox_CustomerName";
            this.textBox_CustomerName.ReadOnly = true;
            this.textBox_CustomerName.Size = new System.Drawing.Size(151, 20);
            this.textBox_CustomerName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(498, 396);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textBox_CustomerName;
            this.layoutControlItem1.CustomizationFormText = "Customer Name:";
            this.layoutControlItem1.Location = new System.Drawing.Point(239, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(239, 26);
            this.layoutControlItem1.Text = "Customer Name:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gridControl_SaleItems;
            this.layoutControlItem6.CustomizationFormText = "Sale Items:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(478, 256);
            this.layoutControlItem6.Text = "Sale Items:";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textBox_CustomerDetails;
            this.layoutControlItem5.CustomizationFormText = "Customer Details";
            this.layoutControlItem5.Location = new System.Drawing.Point(239, 26);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(108, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(239, 48);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "Customer Details";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textBox_DateRecorded;
            this.layoutControlItem3.CustomizationFormText = "Date Recorded:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItem3.Text = "Date Recorded:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textBox_RecordedBy;
            this.layoutControlItem4.CustomizationFormText = "Recorded By:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItem4.Text = "Recorded By:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.label_Total;
            this.layoutControlItem7.CustomizationFormText = "Total:";
            this.layoutControlItem7.Location = new System.Drawing.Point(218, 330);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(260, 46);
            this.layoutControlItem7.Text = "Total:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(81, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 330);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(218, 46);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // colSale
            // 
            this.colSale.FieldName = "Sale";
            this.colSale.Name = "colSale";
            // 
            // colStockItemID
            // 
            this.colStockItemID.FieldName = "StockItemID";
            this.colStockItemID.Name = "colStockItemID";
            // 
            // textEdit_SaleNumber
            // 
            this.textEdit_SaleNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.saleBindingSource, "SaleID", true));
            this.textEdit_SaleNumber.Location = new System.Drawing.Point(96, 12);
            this.textEdit_SaleNumber.Name = "textEdit_SaleNumber";
            this.textEdit_SaleNumber.Properties.Appearance.BackColor = System.Drawing.Color.Green;
            this.textEdit_SaleNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textEdit_SaleNumber.Properties.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.textEdit_SaleNumber.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit_SaleNumber.Properties.Appearance.Options.UseFont = true;
            this.textEdit_SaleNumber.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit_SaleNumber.Properties.DisplayFormat.FormatString = "00000";
            this.textEdit_SaleNumber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit_SaleNumber.Size = new System.Drawing.Size(151, 22);
            this.textEdit_SaleNumber.StyleController = this.layoutControl1;
            this.textEdit_SaleNumber.TabIndex = 8;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.textEdit_SaleNumber;
            this.layoutControlItem8.CustomizationFormText = "Sale Number:";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(239, 26);
            this.layoutControlItem8.Text = "Sale Number:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(81, 13);
            // 
            // ViewSaleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 396);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ViewSaleView";
            this.Text = "View Sale";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SaleItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SaleItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SaleNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.TextBox textBox_RecordedBy;
        private System.Windows.Forms.TextBox textBox_DateRecorded;
        private System.Windows.Forms.TextBox textBox_CustomerName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.TextBox textBox_CustomerDetails;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl_SaleItems;
        private System.Windows.Forms.BindingSource saleItemBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_SaleItems;
        private DevExpress.XtraGrid.Columns.GridColumn colSoldPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSoldPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colStockItemType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn colSale;
        private DevExpress.XtraGrid.Columns.GridColumn colStockItemID;
        private System.Windows.Forms.Label label_Total;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit textEdit_SaleNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;

    }
}