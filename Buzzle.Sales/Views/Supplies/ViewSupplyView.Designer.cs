namespace Buzzle.Sales.Views
{
    partial class ViewSupplyView
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.textEdit_SupplyNumber = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit_DateRecorded = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit_RecordedBy = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit_PurchaseNumber = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl_SupplyItems = new DevExpress.XtraGrid.GridControl();
            this.gridView_SupplyItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colPurchasedUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchasedQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSpent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label_TotalSpent = new System.Windows.Forms.Label();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SupplyNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DateRecorded.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_RecordedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_PurchaseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SupplyItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SupplyItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.label_TotalSpent);
            this.layoutControl1.Controls.Add(this.gridControl_SupplyItems);
            this.layoutControl1.Controls.Add(this.textEdit_PurchaseNumber);
            this.layoutControl1.Controls.Add(this.textEdit_RecordedBy);
            this.layoutControl1.Controls.Add(this.textEdit_DateRecorded);
            this.layoutControl1.Controls.Add(this.textEdit_SupplyNumber);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(608, 495);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(608, 495);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // textEdit_SupplyNumber
            // 
            this.textEdit_SupplyNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.supplyBindingSource, "SupplyID", true));
            this.textEdit_SupplyNumber.Location = new System.Drawing.Point(104, 12);
            this.textEdit_SupplyNumber.Name = "textEdit_SupplyNumber";
            this.textEdit_SupplyNumber.Properties.DisplayFormat.FormatString = "00000";
            this.textEdit_SupplyNumber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit_SupplyNumber.Properties.ReadOnly = true;
            this.textEdit_SupplyNumber.Size = new System.Drawing.Size(492, 20);
            this.textEdit_SupplyNumber.StyleController = this.layoutControl1;
            this.textEdit_SupplyNumber.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_SupplyNumber;
            this.layoutControlItem1.CustomizationFormText = "Supply No.";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(588, 24);
            this.layoutControlItem1.Text = "Supply No.";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(88, 13);
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataSource = typeof(Buzzle.DataModel.Supply);
            // 
            // textEdit_DateRecorded
            // 
            this.textEdit_DateRecorded.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.supplyBindingSource, "DateRecorded", true));
            this.textEdit_DateRecorded.Location = new System.Drawing.Point(104, 36);
            this.textEdit_DateRecorded.Name = "textEdit_DateRecorded";
            this.textEdit_DateRecorded.Properties.DisplayFormat.FormatString = "dddd dd MMMM yyyy";
            this.textEdit_DateRecorded.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textEdit_DateRecorded.Properties.ReadOnly = true;
            this.textEdit_DateRecorded.Size = new System.Drawing.Size(492, 20);
            this.textEdit_DateRecorded.StyleController = this.layoutControl1;
            this.textEdit_DateRecorded.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit_DateRecorded;
            this.layoutControlItem2.CustomizationFormText = "Date Recorded:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(588, 24);
            this.layoutControlItem2.Text = "Date Recorded:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(88, 13);
            // 
            // textEdit_RecordedBy
            // 
            this.textEdit_RecordedBy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.supplyBindingSource, "User.FullName", true));
            this.textEdit_RecordedBy.Location = new System.Drawing.Point(104, 60);
            this.textEdit_RecordedBy.Name = "textEdit_RecordedBy";
            this.textEdit_RecordedBy.Properties.ReadOnly = true;
            this.textEdit_RecordedBy.Size = new System.Drawing.Size(492, 20);
            this.textEdit_RecordedBy.StyleController = this.layoutControl1;
            this.textEdit_RecordedBy.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEdit_RecordedBy;
            this.layoutControlItem3.CustomizationFormText = "Recorded By:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(588, 24);
            this.layoutControlItem3.Text = "Recorded By:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(88, 13);
            // 
            // textEdit_PurchaseNumber
            // 
            this.textEdit_PurchaseNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.supplyBindingSource, "PurchaseID", true));
            this.textEdit_PurchaseNumber.Location = new System.Drawing.Point(104, 84);
            this.textEdit_PurchaseNumber.Name = "textEdit_PurchaseNumber";
            this.textEdit_PurchaseNumber.Properties.DisplayFormat.FormatString = "00000";
            this.textEdit_PurchaseNumber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit_PurchaseNumber.Properties.ReadOnly = true;
            this.textEdit_PurchaseNumber.Size = new System.Drawing.Size(492, 20);
            this.textEdit_PurchaseNumber.StyleController = this.layoutControl1;
            this.textEdit_PurchaseNumber.TabIndex = 6;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit_PurchaseNumber;
            this.layoutControlItem4.CustomizationFormText = "Purchase Number:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(588, 24);
            this.layoutControlItem4.Text = "Purchase Number:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(88, 13);
            // 
            // gridControl_SupplyItems
            // 
            this.gridControl_SupplyItems.Location = new System.Drawing.Point(12, 124);
            this.gridControl_SupplyItems.MainView = this.gridView_SupplyItems;
            this.gridControl_SupplyItems.Name = "gridControl_SupplyItems";
            this.gridControl_SupplyItems.Size = new System.Drawing.Size(584, 313);
            this.gridControl_SupplyItems.TabIndex = 7;
            this.gridControl_SupplyItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_SupplyItems});
            // 
            // gridView_SupplyItems
            // 
            this.gridView_SupplyItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPurchasedUnitPrice,
            this.colPurchasedQuantity,
            this.colTotalSpent,
            this.colStockItemType});
            this.gridView_SupplyItems.GridControl = this.gridControl_SupplyItems;
            this.gridView_SupplyItems.Name = "gridView_SupplyItems";
            this.gridView_SupplyItems.OptionsBehavior.Editable = false;
            this.gridView_SupplyItems.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl_SupplyItems;
            this.layoutControlItem5.CustomizationFormText = "Supply Items:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(588, 333);
            this.layoutControlItem5.Text = "Supply Items:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(88, 13);
            // 
            // colPurchasedUnitPrice
            // 
            this.colPurchasedUnitPrice.FieldName = "PurchasedUnitPrice";
            this.colPurchasedUnitPrice.Name = "colPurchasedUnitPrice";
            this.colPurchasedUnitPrice.Visible = true;
            this.colPurchasedUnitPrice.VisibleIndex = 1;
            // 
            // colPurchasedQuantity
            // 
            this.colPurchasedQuantity.FieldName = "PurchasedQuantity";
            this.colPurchasedQuantity.Name = "colPurchasedQuantity";
            this.colPurchasedQuantity.Visible = true;
            this.colPurchasedQuantity.VisibleIndex = 2;
            // 
            // colTotalSpent
            // 
            this.colTotalSpent.Caption = "Total";
            this.colTotalSpent.FieldName = "TotalSpent";
            this.colTotalSpent.Name = "colTotalSpent";
            this.colTotalSpent.Visible = true;
            this.colTotalSpent.VisibleIndex = 3;
            // 
            // colStockItemType
            // 
            this.colStockItemType.Caption = "Purchased Item";
            this.colStockItemType.FieldName = "StockItemType.FullStockItemName";
            this.colStockItemType.Name = "colStockItemType";
            this.colStockItemType.Visible = true;
            this.colStockItemType.VisibleIndex = 0;
            // 
            // label_TotalSpent
            // 
            this.label_TotalSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalSpent.Location = new System.Drawing.Point(401, 441);
            this.label_TotalSpent.Name = "label_TotalSpent";
            this.label_TotalSpent.Size = new System.Drawing.Size(195, 42);
            this.label_TotalSpent.TabIndex = 8;
            this.label_TotalSpent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.label_TotalSpent;
            this.layoutControlItem6.CustomizationFormText = "Total Spent:";
            this.layoutControlItem6.Location = new System.Drawing.Point(297, 429);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(291, 46);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(291, 46);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(291, 46);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "Total Spent:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(88, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 429);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(297, 46);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ViewSupplyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 495);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ViewSupplyView";
            this.Text = "ViewSupplyView";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_SupplyNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DateRecorded.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_RecordedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_PurchaseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_SupplyItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_SupplyItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Label label_TotalSpent;
        private DevExpress.XtraGrid.GridControl gridControl_SupplyItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_SupplyItems;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasedUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasedQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSpent;
        private DevExpress.XtraGrid.Columns.GridColumn colStockItemType;
        private DevExpress.XtraEditors.TextEdit textEdit_PurchaseNumber;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit_RecordedBy;
        private DevExpress.XtraEditors.TextEdit textEdit_DateRecorded;
        private DevExpress.XtraEditors.TextEdit textEdit_SupplyNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}