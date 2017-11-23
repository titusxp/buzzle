using Buzzle.Data.DataModel;

namespace Buzzle.GlobalStuff
{
    partial class TransactionTypesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionTypesView));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colTransactionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_SaveTransactionTypes = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_RefreshTransactionTypes = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl4 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem_SaveJobSettings = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_RemoveItemType = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_RemoveFault = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_New = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_DeleteUser = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_SaveAccountSettings = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_RefreshAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_SaveGeneralSettings = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl_TransactionTypes = new DevExpress.XtraGrid.GridControl();
            this.transactionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_TransactionTypes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeductionAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoLookUpEdit_Accounts = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIncreasingAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl6 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TransactionTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TransactionTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLookUpEdit_Accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).BeginInit();
            this.layoutControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // colTransactionName
            // 
            this.colTransactionName.FieldName = "TransactionName";
            this.colTransactionName.Name = "colTransactionName";
            this.colTransactionName.Visible = true;
            this.colTransactionName.VisibleIndex = 0;
            this.colTransactionName.Width = 185;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_SaveJobSettings,
            this.barButtonItem_RemoveItemType,
            this.barButtonItem_RemoveFault,
            this.barButtonItem_Refresh,
            this.barButtonItem_New,
            this.barButtonItem_DeleteUser,
            this.barButtonItem_SaveAccountSettings,
            this.barButtonItem_SaveTransactionTypes,
            this.barButtonItem_RefreshTransactionTypes,
            this.barButtonItem_RefreshAccounts,
            this.barButtonItem_SaveGeneralSettings});
            this.barManager1.MaxItemId = 20;
            // 
            // bar4
            // 
            this.bar4.BarName = "Custom 5";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar4.FloatLocation = new System.Drawing.Point(138, 212);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_SaveTransactionTypes, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_RefreshTransactionTypes, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.StandaloneBarDockControl = this.standaloneBarDockControl4;
            this.bar4.Text = "Custom 5";
            // 
            // barButtonItem_SaveTransactionTypes
            // 
            this.barButtonItem_SaveTransactionTypes.Caption = "Save Changes";
            this.barButtonItem_SaveTransactionTypes.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SaveTransactionTypes.Glyph")));
            this.barButtonItem_SaveTransactionTypes.Id = 7;
            this.barButtonItem_SaveTransactionTypes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_SaveTransactionTypes.LargeGlyph")));
            this.barButtonItem_SaveTransactionTypes.Name = "barButtonItem_SaveTransactionTypes";
            this.barButtonItem_SaveTransactionTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_SaveTransactionTypes_ItemClick);
            // 
            // barButtonItem_RefreshTransactionTypes
            // 
            this.barButtonItem_RefreshTransactionTypes.Caption = "Refresh";
            this.barButtonItem_RefreshTransactionTypes.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_RefreshTransactionTypes.Glyph")));
            this.barButtonItem_RefreshTransactionTypes.Id = 8;
            this.barButtonItem_RefreshTransactionTypes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_RefreshTransactionTypes.LargeGlyph")));
            this.barButtonItem_RefreshTransactionTypes.Name = "barButtonItem_RefreshTransactionTypes";
            this.barButtonItem_RefreshTransactionTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_RefreshTransactionTypes_ItemClick);
            // 
            // standaloneBarDockControl4
            // 
            this.standaloneBarDockControl4.CausesValidation = false;
            this.standaloneBarDockControl4.Location = new System.Drawing.Point(12, 12);
            this.standaloneBarDockControl4.Name = "standaloneBarDockControl4";
            this.standaloneBarDockControl4.Size = new System.Drawing.Size(218, 31);
            this.standaloneBarDockControl4.Text = "standaloneBarDockControl4";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(790, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 506);
            this.barDockControlBottom.Size = new System.Drawing.Size(790, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 506);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(790, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 506);
            // 
            // barButtonItem_SaveJobSettings
            // 
            this.barButtonItem_SaveJobSettings.Id = 11;
            this.barButtonItem_SaveJobSettings.Name = "barButtonItem_SaveJobSettings";
            // 
            // barButtonItem_RemoveItemType
            // 
            this.barButtonItem_RemoveItemType.Id = 12;
            this.barButtonItem_RemoveItemType.Name = "barButtonItem_RemoveItemType";
            // 
            // barButtonItem_RemoveFault
            // 
            this.barButtonItem_RemoveFault.Id = 13;
            this.barButtonItem_RemoveFault.Name = "barButtonItem_RemoveFault";
            // 
            // barButtonItem_Refresh
            // 
            this.barButtonItem_Refresh.Id = 14;
            this.barButtonItem_Refresh.Name = "barButtonItem_Refresh";
            // 
            // barButtonItem_New
            // 
            this.barButtonItem_New.Id = 15;
            this.barButtonItem_New.Name = "barButtonItem_New";
            // 
            // barButtonItem_DeleteUser
            // 
            this.barButtonItem_DeleteUser.Id = 16;
            this.barButtonItem_DeleteUser.Name = "barButtonItem_DeleteUser";
            // 
            // barButtonItem_SaveAccountSettings
            // 
            this.barButtonItem_SaveAccountSettings.Id = 17;
            this.barButtonItem_SaveAccountSettings.Name = "barButtonItem_SaveAccountSettings";
            // 
            // barButtonItem_RefreshAccounts
            // 
            this.barButtonItem_RefreshAccounts.Id = 18;
            this.barButtonItem_RefreshAccounts.Name = "barButtonItem_RefreshAccounts";
            // 
            // barButtonItem_SaveGeneralSettings
            // 
            this.barButtonItem_SaveGeneralSettings.Id = 19;
            this.barButtonItem_SaveGeneralSettings.Name = "barButtonItem_SaveGeneralSettings";
            // 
            // gridControl_TransactionTypes
            // 
            this.gridControl_TransactionTypes.DataSource = this.transactionTypeBindingSource;
            this.gridControl_TransactionTypes.Location = new System.Drawing.Point(12, 47);
            this.gridControl_TransactionTypes.MainView = this.gridView_TransactionTypes;
            this.gridControl_TransactionTypes.MenuManager = this.barManager1;
            this.gridControl_TransactionTypes.Name = "gridControl_TransactionTypes";
            this.gridControl_TransactionTypes.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoLookUpEdit_Accounts});
            this.gridControl_TransactionTypes.Size = new System.Drawing.Size(766, 447);
            this.gridControl_TransactionTypes.TabIndex = 0;
            this.gridControl_TransactionTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_TransactionTypes});
            // 
            // transactionTypeBindingSource
            // 
            this.transactionTypeBindingSource.DataSource = typeof(Buzzle.Data.DataModel.TransactionType);
            // 
            // gridView_TransactionTypes
            // 
            this.gridView_TransactionTypes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionTypeID,
            this.colTransactionName,
            this.colDeductionAccountID,
            this.colIncreasingAccountID,
            this.colAccount,
            this.colAccount1,
            this.colTransactions});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colTransactionName;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "0";
            this.gridView_TransactionTypes.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_TransactionTypes.GridControl = this.gridControl_TransactionTypes;
            this.gridView_TransactionTypes.Name = "gridView_TransactionTypes";
            this.gridView_TransactionTypes.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_TransactionTypes.OptionsView.ShowGroupPanel = false;
            // 
            // colTransactionTypeID
            // 
            this.colTransactionTypeID.FieldName = "TransactionTypeID";
            this.colTransactionTypeID.Name = "colTransactionTypeID";
            // 
            // colDeductionAccountID
            // 
            this.colDeductionAccountID.Caption = "Deducts From Account";
            this.colDeductionAccountID.ColumnEdit = this.repoLookUpEdit_Accounts;
            this.colDeductionAccountID.FieldName = "DeductionAccountID";
            this.colDeductionAccountID.Name = "colDeductionAccountID";
            this.colDeductionAccountID.Visible = true;
            this.colDeductionAccountID.VisibleIndex = 1;
            this.colDeductionAccountID.Width = 279;
            // 
            // repoLookUpEdit_Accounts
            // 
            this.repoLookUpEdit_Accounts.AutoHeight = false;
            this.repoLookUpEdit_Accounts.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoLookUpEdit_Accounts.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "Account Name", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repoLookUpEdit_Accounts.DisplayMember = "AccountName";
            this.repoLookUpEdit_Accounts.Name = "repoLookUpEdit_Accounts";
            this.repoLookUpEdit_Accounts.NullText = "none";
            this.repoLookUpEdit_Accounts.ShowFooter = false;
            this.repoLookUpEdit_Accounts.ShowHeader = false;
            this.repoLookUpEdit_Accounts.ValueMember = "AccountID";
            // 
            // colIncreasingAccountID
            // 
            this.colIncreasingAccountID.Caption = "Adds to Account";
            this.colIncreasingAccountID.ColumnEdit = this.repoLookUpEdit_Accounts;
            this.colIncreasingAccountID.FieldName = "IncreasingAccountID";
            this.colIncreasingAccountID.Name = "colIncreasingAccountID";
            this.colIncreasingAccountID.Visible = true;
            this.colIncreasingAccountID.VisibleIndex = 2;
            this.colIncreasingAccountID.Width = 276;
            // 
            // colAccount
            // 
            this.colAccount.FieldName = "Account";
            this.colAccount.Name = "colAccount";
            // 
            // colAccount1
            // 
            this.colAccount1.FieldName = "Account1";
            this.colAccount1.Name = "colAccount1";
            // 
            // colTransactions
            // 
            this.colTransactions.FieldName = "Transactions";
            this.colTransactions.Name = "colTransactions";
            // 
            // layoutControl6
            // 
            this.layoutControl6.Controls.Add(this.gridControl_TransactionTypes);
            this.layoutControl6.Controls.Add(this.standaloneBarDockControl4);
            this.layoutControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl6.Location = new System.Drawing.Point(0, 0);
            this.layoutControl6.Name = "layoutControl6";
            this.layoutControl6.Root = this.layoutControlGroup6;
            this.layoutControl6.Size = new System.Drawing.Size(790, 506);
            this.layoutControl6.TabIndex = 5;
            this.layoutControl6.Text = "layoutControl6";
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "layoutControlGroup6";
            this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup6.GroupBordersVisible = false;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem8});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(790, 506);
            this.layoutControlGroup6.Text = "layoutControlGroup6";
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.standaloneBarDockControl4;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem9";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(770, 35);
            this.layoutControlItem9.Text = "layoutControlItem9";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextToControlDistance = 0;
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.gridControl_TransactionTypes;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 35);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(770, 451);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // TransactionTypesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 506);
            this.Controls.Add(this.layoutControl6);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "TransactionTypesView";
            this.Text = "Transaction Types";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_TransactionTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_TransactionTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoLookUpEdit_Accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).EndInit();
            this.layoutControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SaveJobSettings;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RemoveItemType;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RemoveFault;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Refresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_New;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DeleteUser;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SaveAccountSettings;
        private DevExpress.XtraGrid.GridControl gridControl_TransactionTypes;
        private System.Windows.Forms.BindingSource transactionTypeBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_TransactionTypes;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionName;
        private DevExpress.XtraGrid.Columns.GridColumn colDeductionAccountID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoLookUpEdit_Accounts;
        private DevExpress.XtraGrid.Columns.GridColumn colIncreasingAccountID;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colAccount1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactions;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SaveTransactionTypes;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RefreshTransactionTypes;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_RefreshAccounts;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_SaveGeneralSettings;
        private DevExpress.XtraLayout.LayoutControl layoutControl6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}