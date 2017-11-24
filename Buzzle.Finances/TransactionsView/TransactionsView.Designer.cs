namespace Buzzle.Finances
{
    partial class TransactionsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsView));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl_Transactions = new DevExpress.XtraGrid.GridControl();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView_Transactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateRecorded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ViewAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_NewTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_Transactions);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(618, 438);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl_Transactions
            // 
            this.gridControl_Transactions.DataSource = this.transactionBindingSource;
            this.gridControl_Transactions.Location = new System.Drawing.Point(12, 12);
            this.gridControl_Transactions.MainView = this.gridView_Transactions;
            this.gridControl_Transactions.Name = "gridControl_Transactions";
            this.gridControl_Transactions.Size = new System.Drawing.Size(594, 414);
            this.gridControl_Transactions.TabIndex = 4;
            this.gridControl_Transactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Transactions});
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(Buzzle.DataModel.Transaction);
            // 
            // gridView_Transactions
            // 
            this.gridView_Transactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAmount,
            this.colDateRecorded,
            this.colTransactionType,
            this.colUser});
            this.gridView_Transactions.GridControl = this.gridControl_Transactions;
            this.gridView_Transactions.Name = "gridView_Transactions";
            this.gridView_Transactions.OptionsBehavior.Editable = false;
            this.gridView_Transactions.OptionsView.ShowGroupPanel = false;
            // 
            // colAmount
            // 
            this.colAmount.DisplayFormat.FormatString = "#,#";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            this.colAmount.Width = 81;
            // 
            // colDateRecorded
            // 
            this.colDateRecorded.DisplayFormat.FormatString = "dd MMM yyyy hh:mmtt";
            this.colDateRecorded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateRecorded.FieldName = "DateRecorded";
            this.colDateRecorded.Name = "colDateRecorded";
            this.colDateRecorded.Visible = true;
            this.colDateRecorded.VisibleIndex = 0;
            this.colDateRecorded.Width = 119;
            // 
            // colTransactionType
            // 
            this.colTransactionType.Caption = "Transaction Name";
            this.colTransactionType.FieldName = "TransactionType.TransactionName";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.Visible = true;
            this.colTransactionType.VisibleIndex = 1;
            this.colTransactionType.Width = 101;
            // 
            // colUser
            // 
            this.colUser.Caption = "Recorded By";
            this.colUser.FieldName = "User.FullName";
            this.colUser.Name = "colUser";
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 3;
            this.colUser.Width = 145;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(618, 438);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl_Transactions;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(598, 418);
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
            this.barButtonItem_ViewAccounts,
            this.barButtonItem_NewTransaction});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Refresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_ViewAccounts, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_NewTransaction, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_Refresh
            // 
            this.barButtonItem_Refresh.Caption = "&Refresh";
            this.barButtonItem_Refresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Refresh.Glyph")));
            this.barButtonItem_Refresh.Id = 0;
            this.barButtonItem_Refresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Refresh.LargeGlyph")));
            this.barButtonItem_Refresh.Name = "barButtonItem_Refresh";
            this.barButtonItem_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Refresh_ItemClick);
            // 
            // barButtonItem_ViewAccounts
            // 
            this.barButtonItem_ViewAccounts.Caption = "View Accounts";
            this.barButtonItem_ViewAccounts.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ViewAccounts.Glyph")));
            this.barButtonItem_ViewAccounts.Id = 1;
            this.barButtonItem_ViewAccounts.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ViewAccounts.LargeGlyph")));
            this.barButtonItem_ViewAccounts.Name = "barButtonItem_ViewAccounts";
            this.barButtonItem_ViewAccounts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ViewAccounts_ItemClick);
            // 
            // barButtonItem_NewTransaction
            // 
            this.barButtonItem_NewTransaction.Caption = "New Transaction";
            this.barButtonItem_NewTransaction.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NewTransaction.Glyph")));
            this.barButtonItem_NewTransaction.Id = 2;
            this.barButtonItem_NewTransaction.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NewTransaction.LargeGlyph")));
            this.barButtonItem_NewTransaction.Name = "barButtonItem_NewTransaction";
            this.barButtonItem_NewTransaction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_NewTransaction_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(618, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 462);
            this.barDockControlBottom.Size = new System.Drawing.Size(618, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 438);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(618, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 438);
            // 
            // TransactionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 462);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TransactionsView";
            this.Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl_Transactions;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Transactions;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDateRecorded;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionType;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Refresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ViewAccounts;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NewTransaction;
    }
}