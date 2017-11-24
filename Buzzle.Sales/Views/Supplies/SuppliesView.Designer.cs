namespace Buzzle.Sales.Views
{
    partial class SuppliesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliesView));
            this.gridControl_Supplies = new DevExpress.XtraGrid.GridControl();
            this.supplyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_Supplies = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSupplyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateRecorded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ViewSupply = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Supplies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Supplies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_Supplies
            // 
            this.gridControl_Supplies.DataSource = this.supplyBindingSource;
            this.gridControl_Supplies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Supplies.Location = new System.Drawing.Point(0, 24);
            this.gridControl_Supplies.MainView = this.gridView_Supplies;
            this.gridControl_Supplies.Name = "gridControl_Supplies";
            this.gridControl_Supplies.Size = new System.Drawing.Size(885, 436);
            this.gridControl_Supplies.TabIndex = 4;
            this.gridControl_Supplies.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Supplies});
            // 
            // supplyBindingSource
            // 
            this.supplyBindingSource.DataSource = typeof(Buzzle.DataModel.Supply);
            // 
            // gridView_Supplies
            // 
            this.gridView_Supplies.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSupplyID,
            this.colDateRecorded,
            this.colPurchaseID,
            this.colUser});
            this.gridView_Supplies.GridControl = this.gridControl_Supplies;
            this.gridView_Supplies.Name = "gridView_Supplies";
            this.gridView_Supplies.OptionsBehavior.Editable = false;
            this.gridView_Supplies.OptionsView.ShowGroupPanel = false;
            this.gridView_Supplies.DoubleClick += new System.EventHandler(this.gridView_Supplies_DoubleClick);
            // 
            // colSupplyID
            // 
            this.colSupplyID.AppearanceCell.Options.UseTextOptions = true;
            this.colSupplyID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupplyID.AppearanceHeader.Options.UseTextOptions = true;
            this.colSupplyID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSupplyID.Caption = "Supply No.";
            this.colSupplyID.DisplayFormat.FormatString = "00000";
            this.colSupplyID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSupplyID.FieldName = "SupplyID";
            this.colSupplyID.Image = ((System.Drawing.Image)(resources.GetObject("colSupplyID.Image")));
            this.colSupplyID.Name = "colSupplyID";
            this.colSupplyID.Visible = true;
            this.colSupplyID.VisibleIndex = 0;
            // 
            // colDateRecorded
            // 
            this.colDateRecorded.DisplayFormat.FormatString = "dd MMM yyyy hh:mm tt";
            this.colDateRecorded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateRecorded.FieldName = "DateRecorded";
            this.colDateRecorded.Name = "colDateRecorded";
            this.colDateRecorded.Visible = true;
            this.colDateRecorded.VisibleIndex = 1;
            // 
            // colPurchaseID
            // 
            this.colPurchaseID.AppearanceCell.Options.UseTextOptions = true;
            this.colPurchaseID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPurchaseID.AppearanceHeader.Options.UseTextOptions = true;
            this.colPurchaseID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPurchaseID.Caption = "Purchase No.";
            this.colPurchaseID.DisplayFormat.FormatString = "00000";
            this.colPurchaseID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurchaseID.FieldName = "PurchaseID";
            this.colPurchaseID.Image = ((System.Drawing.Image)(resources.GetObject("colPurchaseID.Image")));
            this.colPurchaseID.Name = "colPurchaseID";
            this.colPurchaseID.Visible = true;
            this.colPurchaseID.VisibleIndex = 2;
            // 
            // colUser
            // 
            this.colUser.Caption = "Recorded by";
            this.colUser.FieldName = "User.FullName";
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 3;
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
            this.barButtonItem_ViewSupply});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Refresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_ViewSupply, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
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
            // barButtonItem_ViewSupply
            // 
            this.barButtonItem_ViewSupply.Caption = "View Supply";
            this.barButtonItem_ViewSupply.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ViewSupply.Glyph")));
            this.barButtonItem_ViewSupply.Id = 2;
            this.barButtonItem_ViewSupply.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ViewSupply.LargeGlyph")));
            this.barButtonItem_ViewSupply.Name = "barButtonItem_ViewSupply";
            this.barButtonItem_ViewSupply.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ViewSupply_ItemClick);
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
            // SuppliesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 460);
            this.Controls.Add(this.gridControl_Supplies);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SuppliesView";
            this.Text = "Supplies";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Supplies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Supplies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Supplies;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Supplies;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Refresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource supplyBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplyID;
        private DevExpress.XtraGrid.Columns.GridColumn colDateRecorded;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseID;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ViewSupply;
    }
}