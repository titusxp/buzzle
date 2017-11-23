namespace Buzzle.Sales.Views
{
    partial class ViewEditPurchaseView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEditPurchaseView));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl_PurchaseItems = new DevExpress.XtraGrid.GridControl();
            this.purchaseItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_PurchaseItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProposedUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalProposedPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalActualPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textEdit_DateCreated = new DevExpress.XtraEditors.TextEdit();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit_Status = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_PurchaseNumber = new DevExpress.XtraEditors.TextEdit();
            this.lookupEdit_CreatedBy = new DevExpress.XtraEditors.LookUpEdit();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Save = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem_Remove = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PurchaseItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PurchaseItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_PurchaseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEdit_CreatedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_PurchaseItems);
            this.layoutControl1.Controls.Add(this.textEdit_DateCreated);
            this.layoutControl1.Controls.Add(this.textEdit_Status);
            this.layoutControl1.Controls.Add(this.textEdit_PurchaseNumber);
            this.layoutControl1.Controls.Add(this.lookupEdit_CreatedBy);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(694, 397);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl_PurchaseItems
            // 
            this.gridControl_PurchaseItems.DataSource = this.purchaseItemBindingSource;
            this.gridControl_PurchaseItems.Location = new System.Drawing.Point(12, 76);
            this.gridControl_PurchaseItems.MainView = this.gridView_PurchaseItems;
            this.gridControl_PurchaseItems.Name = "gridControl_PurchaseItems";
            this.gridControl_PurchaseItems.Size = new System.Drawing.Size(670, 309);
            this.gridControl_PurchaseItems.TabIndex = 8;
            this.gridControl_PurchaseItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_PurchaseItems});
            // 
            // purchaseItemBindingSource
            // 
            this.purchaseItemBindingSource.DataSource = typeof(Buzzle.Data.DataModel.PurchaseItem);
            // 
            // gridView_PurchaseItems
            // 
            this.gridView_PurchaseItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProposedUnitPrice,
            this.colActualUnitPrice,
            this.colQuantity,
            this.colTotalProposedPrice,
            this.colTotalActualPrice,
            this.gridColumn1});
            this.gridView_PurchaseItems.GridControl = this.gridControl_PurchaseItems;
            this.gridView_PurchaseItems.Name = "gridView_PurchaseItems";
            this.gridView_PurchaseItems.OptionsView.ShowGroupPanel = false;
            this.gridView_PurchaseItems.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView_PurchaseItems_MouseUp);
            // 
            // colProposedUnitPrice
            // 
            this.colProposedUnitPrice.FieldName = "ProposedUnitPrice";
            this.colProposedUnitPrice.Name = "colProposedUnitPrice";
            this.colProposedUnitPrice.Visible = true;
            this.colProposedUnitPrice.VisibleIndex = 2;
            // 
            // colActualUnitPrice
            // 
            this.colActualUnitPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colActualUnitPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colActualUnitPrice.AppearanceCell.Options.UseBackColor = true;
            this.colActualUnitPrice.AppearanceCell.Options.UseFont = true;
            this.colActualUnitPrice.FieldName = "ActualUnitPrice";
            this.colActualUnitPrice.Name = "colActualUnitPrice";
            this.colActualUnitPrice.OptionsColumn.AllowEdit = false;
            this.colActualUnitPrice.Visible = true;
            this.colActualUnitPrice.VisibleIndex = 3;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // colTotalProposedPrice
            // 
            this.colTotalProposedPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colTotalProposedPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTotalProposedPrice.AppearanceCell.Options.UseBackColor = true;
            this.colTotalProposedPrice.AppearanceCell.Options.UseFont = true;
            this.colTotalProposedPrice.FieldName = "TotalProposedPrice";
            this.colTotalProposedPrice.Name = "colTotalProposedPrice";
            this.colTotalProposedPrice.OptionsColumn.AllowEdit = false;
            this.colTotalProposedPrice.Visible = true;
            this.colTotalProposedPrice.VisibleIndex = 4;
            // 
            // colTotalActualPrice
            // 
            this.colTotalActualPrice.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colTotalActualPrice.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTotalActualPrice.AppearanceCell.Options.UseBackColor = true;
            this.colTotalActualPrice.AppearanceCell.Options.UseFont = true;
            this.colTotalActualPrice.FieldName = "TotalActualPrice";
            this.colTotalActualPrice.Name = "colTotalActualPrice";
            this.colTotalActualPrice.OptionsColumn.AllowEdit = false;
            this.colTotalActualPrice.Visible = true;
            this.colTotalActualPrice.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn1.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.Caption = "Item";
            this.gridColumn1.FieldName = "StockItemType.FullStockItemName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // textEdit_DateCreated
            // 
            this.textEdit_DateCreated.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.purchaseBindingSource, "DateRecorded", true));
            this.textEdit_DateCreated.Location = new System.Drawing.Point(103, 36);
            this.textEdit_DateCreated.Name = "textEdit_DateCreated";
            this.textEdit_DateCreated.Properties.DisplayFormat.FormatString = "dd MMM yyyy hh:mm tt";
            this.textEdit_DateCreated.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textEdit_DateCreated.Properties.ReadOnly = true;
            this.textEdit_DateCreated.Size = new System.Drawing.Size(253, 20);
            this.textEdit_DateCreated.StyleController = this.layoutControl1;
            this.textEdit_DateCreated.TabIndex = 6;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataSource = typeof(Buzzle.Data.DataModel.Purchase);
            // 
            // textEdit_Status
            // 
            this.textEdit_Status.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.purchaseBindingSource, "Status", true));
            this.textEdit_Status.Location = new System.Drawing.Point(451, 12);
            this.textEdit_Status.Name = "textEdit_Status";
            this.textEdit_Status.Properties.ReadOnly = true;
            this.textEdit_Status.Size = new System.Drawing.Size(231, 20);
            this.textEdit_Status.StyleController = this.layoutControl1;
            this.textEdit_Status.TabIndex = 5;
            // 
            // textEdit_PurchaseNumber
            // 
            this.textEdit_PurchaseNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.purchaseBindingSource, "PurchaseID", true));
            this.textEdit_PurchaseNumber.Location = new System.Drawing.Point(103, 12);
            this.textEdit_PurchaseNumber.Name = "textEdit_PurchaseNumber";
            this.textEdit_PurchaseNumber.Properties.DisplayFormat.FormatString = "0000";
            this.textEdit_PurchaseNumber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit_PurchaseNumber.Properties.ReadOnly = true;
            this.textEdit_PurchaseNumber.Size = new System.Drawing.Size(253, 20);
            this.textEdit_PurchaseNumber.StyleController = this.layoutControl1;
            this.textEdit_PurchaseNumber.TabIndex = 4;
            // 
            // lookupEdit_CreatedBy
            // 
            this.lookupEdit_CreatedBy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.purchaseBindingSource, "CreatedByUserID", true));
            this.lookupEdit_CreatedBy.Location = new System.Drawing.Point(451, 36);
            this.lookupEdit_CreatedBy.Name = "lookupEdit_CreatedBy";
            this.lookupEdit_CreatedBy.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.False;
            this.lookupEdit_CreatedBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookupEdit_CreatedBy.Properties.DataSource = this.userBindingSource;
            this.lookupEdit_CreatedBy.Properties.DisplayMember = "FullName";
            this.lookupEdit_CreatedBy.Properties.NullText = "";
            this.lookupEdit_CreatedBy.Properties.ReadOnly = true;
            this.lookupEdit_CreatedBy.Properties.ShowFooter = false;
            this.lookupEdit_CreatedBy.Properties.ShowHeader = false;
            this.lookupEdit_CreatedBy.Properties.ValueMember = "UserID";
            this.lookupEdit_CreatedBy.Size = new System.Drawing.Size(231, 20);
            this.lookupEdit_CreatedBy.StyleController = this.layoutControl1;
            this.lookupEdit_CreatedBy.TabIndex = 7;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Buzzle.Data.DataModel.User);
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
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(694, 397);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_PurchaseNumber;
            this.layoutControlItem1.CustomizationFormText = "Purchase Number:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(348, 24);
            this.layoutControlItem1.Text = "Purchase Number:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit_Status;
            this.layoutControlItem2.CustomizationFormText = "Status:";
            this.layoutControlItem2.Location = new System.Drawing.Point(348, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(326, 24);
            this.layoutControlItem2.Text = "Status:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEdit_DateCreated;
            this.layoutControlItem3.CustomizationFormText = "Date Created:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(348, 24);
            this.layoutControlItem3.Text = "Date Created:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lookupEdit_CreatedBy;
            this.layoutControlItem4.CustomizationFormText = "Created By:";
            this.layoutControlItem4.Location = new System.Drawing.Point(348, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(326, 24);
            this.layoutControlItem4.Text = "Created By:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl_PurchaseItems;
            this.layoutControlItem5.CustomizationFormText = "Purchase Items:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(674, 329);
            this.layoutControlItem5.Text = "Purchase Items:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(88, 13);
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
            this.barButtonItem_Save,
            this.barButtonItem_Remove});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(186, 132);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Save, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = " ";
            // 
            // barButtonItem_Save
            // 
            this.barButtonItem_Save.Caption = "Save Changes";
            this.barButtonItem_Save.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Save.Glyph")));
            this.barButtonItem_Save.Id = 0;
            this.barButtonItem_Save.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Save.LargeGlyph")));
            this.barButtonItem_Save.Name = "barButtonItem_Save";
            this.barButtonItem_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Save_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(694, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 421);
            this.barDockControlBottom.Size = new System.Drawing.Size(694, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 397);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(694, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 397);
            // 
            // barButtonItem_Remove
            // 
            this.barButtonItem_Remove.Caption = "Remove";
            this.barButtonItem_Remove.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Remove.Glyph")));
            this.barButtonItem_Remove.Id = 1;
            this.barButtonItem_Remove.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Remove.LargeGlyph")));
            this.barButtonItem_Remove.Name = "barButtonItem_Remove";
            this.barButtonItem_Remove.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Remove_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Remove)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // ViewEditPurchaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 421);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ViewEditPurchaseView";
            this.Text = "ViewEditPurchaseView";
            this.Load += new System.EventHandler(this.ViewEditPurchaseView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PurchaseItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PurchaseItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_DateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_PurchaseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupEdit_CreatedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit textEdit_DateCreated;
        private DevExpress.XtraEditors.TextEdit textEdit_Status;
        private DevExpress.XtraEditors.TextEdit textEdit_PurchaseNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl gridControl_PurchaseItems;
        private System.Windows.Forms.BindingSource purchaseItemBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_PurchaseItems;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private DevExpress.XtraEditors.LookUpEdit lookupEdit_CreatedBy;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Save;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Remove;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraGrid.Columns.GridColumn colProposedUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colActualUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalProposedPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalActualPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}