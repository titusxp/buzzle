namespace Buzzle.Finances
{
    partial class AccountsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsView));
            this.gridControl_Accounts = new DevExpress.XtraGrid.GridControl();
            this.gridView_Accounts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colamount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVisible = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Accounts)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_Accounts
            // 
            this.gridControl_Accounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Accounts.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Accounts.MainView = this.gridView_Accounts;
            this.gridControl_Accounts.Name = "gridControl_Accounts";
            this.gridControl_Accounts.Size = new System.Drawing.Size(338, 401);
            this.gridControl_Accounts.TabIndex = 0;
            this.gridControl_Accounts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Accounts});
            // 
            // gridView_Accounts
            // 
            this.gridView_Accounts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountID,
            this.colAccountName,
            this.colamount,
            this.colVisible});
            this.gridView_Accounts.GridControl = this.gridControl_Accounts;
            this.gridView_Accounts.Name = "gridView_Accounts";
            this.gridView_Accounts.OptionsBehavior.Editable = false;
            this.gridView_Accounts.OptionsView.ShowGroupPanel = false;
            // 
            // colAccountID
            // 
            this.colAccountID.FieldName = "AccountID";
            this.colAccountID.Name = "colAccountID";
            // 
            // colAccountName
            // 
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 0;
            this.colAccountName.Width = 196;
            // 
            // colamount
            // 
            this.colamount.Caption = "Account Balance";
            this.colamount.DisplayFormat.FormatString = "#,# CFA";
            this.colamount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colamount.FieldName = "amount";
            this.colamount.Image = ((System.Drawing.Image)(resources.GetObject("colamount.Image")));
            this.colamount.Name = "colamount";
            this.colamount.Visible = true;
            this.colamount.VisibleIndex = 1;
            this.colamount.Width = 177;
            // 
            // colVisible
            // 
            this.colVisible.FieldName = "Visible";
            this.colVisible.Name = "colVisible";
            // 
            // AccountsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 401);
            this.Controls.Add(this.gridControl_Accounts);
            this.Name = "AccountsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Accounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_Accounts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Accounts;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountID;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colamount;
        private DevExpress.XtraGrid.Columns.GridColumn colVisible;
    }
}