

namespace Buzzle.Client.Ui
{
    partial class BuzzleSettingsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuzzleSettingsView));
            this.lookUpEdit_SalesTransactionType = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControl6 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Save = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_SalesTransactionType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).BeginInit();
            this.layoutControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit_SalesTransactionType
            // 
            this.lookUpEdit_SalesTransactionType.Location = new System.Drawing.Point(126, 12);
            this.lookUpEdit_SalesTransactionType.Name = "lookUpEdit_SalesTransactionType";
            this.lookUpEdit_SalesTransactionType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TransactionName", "TransactionName")});
            this.lookUpEdit_SalesTransactionType.Properties.DisplayMember = "TransactionName";
            this.lookUpEdit_SalesTransactionType.Properties.NullText = "";
            this.lookUpEdit_SalesTransactionType.Properties.NullValuePrompt = "Select a Transaction type for sales";
            this.lookUpEdit_SalesTransactionType.Properties.ShowFooter = false;
            this.lookUpEdit_SalesTransactionType.Properties.ShowHeader = false;
            this.lookUpEdit_SalesTransactionType.Properties.ValueMember = "TransactionTypeID";
            this.lookUpEdit_SalesTransactionType.Size = new System.Drawing.Size(246, 20);
            this.lookUpEdit_SalesTransactionType.StyleController = this.layoutControl6;
            this.lookUpEdit_SalesTransactionType.TabIndex = 4;
            // 
            // layoutControl6
            // 
            this.layoutControl6.Controls.Add(this.lookUpEdit_SalesTransactionType);
            this.layoutControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl6.Location = new System.Drawing.Point(0, 24);
            this.layoutControl6.Name = "layoutControl6";
            this.layoutControl6.Root = this.layoutControlGroup6;
            this.layoutControl6.Size = new System.Drawing.Size(384, 214);
            this.layoutControl6.TabIndex = 5;
            this.layoutControl6.Text = "layoutControl6";
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "layoutControlGroup6";
            this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup6.GroupBordersVisible = false;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem12});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(384, 214);
            this.layoutControlGroup6.Text = "layoutControlGroup6";
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.lookUpEdit_SalesTransactionType;
            this.layoutControlItem12.CustomizationFormText = "Sales Transaction Type";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(364, 194);
            this.layoutControlItem12.Text = "Sales Transaction Type";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(111, 13);
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
            this.barButtonItem_Save});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Save, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_Save
            // 
            this.barButtonItem_Save.Caption = "&Save";
            this.barButtonItem_Save.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Save.Glyph")));
            this.barButtonItem_Save.Id = 0;
            this.barButtonItem_Save.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Save.LargeGlyph")));
            this.barButtonItem_Save.Name = "barButtonItem_Save";
            this.barButtonItem_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_SaveGeneralSettings_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(384, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 238);
            this.barDockControlBottom.Size = new System.Drawing.Size(384, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 214);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(384, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 214);
            // 
            // BuzzleSettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 238);
            this.Controls.Add(this.layoutControl6);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BuzzleSettingsView";
            this.Text = "General Preferences";
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_SalesTransactionType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).EndInit();
            this.layoutControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_SalesTransactionType;
        private DevExpress.XtraLayout.LayoutControl layoutControl6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Save;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}