namespace Buzzle.JobsManager.Views.JobsView
{
    partial class JobsView
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition6 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition7 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition8 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobsView));
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl_Jobs = new DevExpress.XtraGrid.GridControl();
            this.JobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_Jobs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJobID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpectedEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager_Jobs = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_NewJob = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_ViewEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Collected = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Pay = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Revert = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Fixed = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_PrintReceipt = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Jobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Jobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager_Jobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Job Status";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl_Jobs);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(737, 147, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(850, 553);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl_Jobs
            // 
            this.gridControl_Jobs.DataSource = this.JobsBindingSource;
            this.gridControl_Jobs.Location = new System.Drawing.Point(12, 12);
            this.gridControl_Jobs.MainView = this.gridView_Jobs;
            this.gridControl_Jobs.Name = "gridControl_Jobs";
            this.gridControl_Jobs.Size = new System.Drawing.Size(826, 529);
            this.gridControl_Jobs.TabIndex = 4;
            this.gridControl_Jobs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Jobs});
            // 
            // JobsBindingSource
            // 
            this.JobsBindingSource.CurrentChanged += new System.EventHandler(this.JobsBindingSource_CurrentChanged);
            // 
            // gridView_Jobs
            // 
            this.gridView_Jobs.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJobID,
            this.colCustomerName,
            this.colDateCreated,
            this.colExpectedEndDate,
            this.colNotes,
            this.colStatus,
            this.colItemType,
            this.gridColumn1});
            styleFormatCondition5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            styleFormatCondition5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition5.Appearance.Options.UseBackColor = true;
            styleFormatCondition5.Appearance.Options.UseFont = true;
            styleFormatCondition5.Appearance.Options.UseForeColor = true;
            styleFormatCondition5.Column = this.colStatus;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition5.Tag = "<Null>";
            styleFormatCondition5.Value1 = "Cancelled";
            styleFormatCondition6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            styleFormatCondition6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition6.Appearance.Options.UseBackColor = true;
            styleFormatCondition6.Appearance.Options.UseFont = true;
            styleFormatCondition6.Column = this.colStatus;
            styleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition6.Value1 = "Fixed, Awaiting Payment";
            styleFormatCondition7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.Black;
            styleFormatCondition7.Appearance.Options.UseBackColor = true;
            styleFormatCondition7.Appearance.Options.UseFont = true;
            styleFormatCondition7.Appearance.Options.UseForeColor = true;
            styleFormatCondition7.Column = this.colStatus;
            styleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition7.Value1 = "Paid, Awaiting Collection";
            styleFormatCondition8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            styleFormatCondition8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            styleFormatCondition8.Appearance.ForeColor = System.Drawing.Color.White;
            styleFormatCondition8.Appearance.Options.UseBackColor = true;
            styleFormatCondition8.Appearance.Options.UseFont = true;
            styleFormatCondition8.Appearance.Options.UseForeColor = true;
            styleFormatCondition8.Column = this.colStatus;
            styleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition8.Value1 = "Completed";
            this.gridView_Jobs.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition5,
            styleFormatCondition6,
            styleFormatCondition7,
            styleFormatCondition8});
            this.gridView_Jobs.GridControl = this.gridControl_Jobs;
            this.gridView_Jobs.Name = "gridView_Jobs";
            this.gridView_Jobs.OptionsBehavior.Editable = false;
            this.gridView_Jobs.OptionsView.ShowGroupPanel = false;
            this.gridView_Jobs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridView_Jobs_MouseUp);
            this.gridView_Jobs.DoubleClick += new System.EventHandler(this.gridView_Jobs_DoubleClick);
            // 
            // colJobID
            // 
            this.colJobID.AppearanceCell.Options.UseTextOptions = true;
            this.colJobID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colJobID.Caption = "Job No.";
            this.colJobID.DisplayFormat.FormatString = "0000";
            this.colJobID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colJobID.FieldName = "JobID";
            this.colJobID.Name = "colJobID";
            this.colJobID.Visible = true;
            this.colJobID.VisibleIndex = 0;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 2;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Date Recorded";
            this.colDateCreated.DisplayFormat.FormatString = "dd MMM yyyy hh:mm tt";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 1;
            // 
            // colExpectedEndDate
            // 
            this.colExpectedEndDate.FieldName = "ExpectedEndDate";
            this.colExpectedEndDate.Name = "colExpectedEndDate";
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            // 
            // colItemType
            // 
            this.colItemType.Caption = "Item";
            this.colItemType.FieldName = "ItemType.ItemName";
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn1.Caption = "Phone No.";
            this.gridColumn1.FieldName = "CustomerPhoneNumber";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(850, 553);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl_Jobs;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(830, 533);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // barManager_Jobs
            // 
            this.barManager_Jobs.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager_Jobs.DockControls.Add(this.barDockControlTop);
            this.barManager_Jobs.DockControls.Add(this.barDockControlBottom);
            this.barManager_Jobs.DockControls.Add(this.barDockControlLeft);
            this.barManager_Jobs.DockControls.Add(this.barDockControlRight);
            this.barManager_Jobs.Form = this;
            this.barManager_Jobs.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_NewJob,
            this.barButtonItem_ViewEdit,
            this.barButtonItem_Cancel,
            this.barButtonItem_Collected,
            this.barButtonItem_Pay,
            this.barButtonItem_Revert,
            this.barButtonItem_Fixed,
            this.barButtonItem_PrintReceipt});
            this.barManager_Jobs.MainMenu = this.bar2;
            this.barManager_Jobs.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(75, 162);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_NewJob, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_ViewEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Pay, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_PrintReceipt, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_NewJob
            // 
            this.barButtonItem_NewJob.Caption = "New Job";
            this.barButtonItem_NewJob.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NewJob.Glyph")));
            this.barButtonItem_NewJob.Id = 0;
            this.barButtonItem_NewJob.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_NewJob.LargeGlyph")));
            this.barButtonItem_NewJob.Name = "barButtonItem_NewJob";
            this.barButtonItem_NewJob.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_NewJob_ItemClick);
            // 
            // barButtonItem_ViewEdit
            // 
            this.barButtonItem_ViewEdit.Caption = "View Details";
            this.barButtonItem_ViewEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ViewEdit.Glyph")));
            this.barButtonItem_ViewEdit.Id = 1;
            this.barButtonItem_ViewEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_ViewEdit.LargeGlyph")));
            this.barButtonItem_ViewEdit.Name = "barButtonItem_ViewEdit";
            this.barButtonItem_ViewEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_ViewEdit_ItemClick);
            // 
            // barButtonItem_Cancel
            // 
            this.barButtonItem_Cancel.Caption = "&Cancel Job";
            this.barButtonItem_Cancel.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Cancel.Glyph")));
            this.barButtonItem_Cancel.Id = 2;
            this.barButtonItem_Cancel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Cancel.LargeGlyph")));
            this.barButtonItem_Cancel.Name = "barButtonItem_Cancel";
            this.barButtonItem_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Cancel_ItemClick);
            // 
            // barButtonItem_Collected
            // 
            this.barButtonItem_Collected.Caption = "Mark as Collected";
            this.barButtonItem_Collected.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Collected.Glyph")));
            this.barButtonItem_Collected.Id = 3;
            this.barButtonItem_Collected.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Collected.LargeGlyph")));
            this.barButtonItem_Collected.Name = "barButtonItem_Collected";
            this.barButtonItem_Collected.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Collected_ItemClick);
            // 
            // barButtonItem_Pay
            // 
            this.barButtonItem_Pay.Caption = "Record Payment";
            this.barButtonItem_Pay.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Pay.Glyph")));
            this.barButtonItem_Pay.Id = 4;
            this.barButtonItem_Pay.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Pay.LargeGlyph")));
            this.barButtonItem_Pay.Name = "barButtonItem_Pay";
            this.barButtonItem_Pay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Pay_ItemClick);
            // 
            // barButtonItem_Revert
            // 
            this.barButtonItem_Revert.Caption = "Revert to Pending";
            this.barButtonItem_Revert.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Revert.Glyph")));
            this.barButtonItem_Revert.Id = 5;
            this.barButtonItem_Revert.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Revert.LargeGlyph")));
            this.barButtonItem_Revert.Name = "barButtonItem_Revert";
            this.barButtonItem_Revert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Revert_ItemClick);
            // 
            // barButtonItem_Fixed
            // 
            this.barButtonItem_Fixed.Caption = "Mark as Fixed";
            this.barButtonItem_Fixed.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Fixed.Glyph")));
            this.barButtonItem_Fixed.Id = 6;
            this.barButtonItem_Fixed.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Fixed.LargeGlyph")));
            this.barButtonItem_Fixed.Name = "barButtonItem_Fixed";
            this.barButtonItem_Fixed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Fixed_ItemClick);
            // 
            // barButtonItem_PrintReceipt
            // 
            this.barButtonItem_PrintReceipt.Caption = "Print Receipt";
            this.barButtonItem_PrintReceipt.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_PrintReceipt.Glyph")));
            this.barButtonItem_PrintReceipt.Id = 7;
            this.barButtonItem_PrintReceipt.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_PrintReceipt.LargeGlyph")));
            this.barButtonItem_PrintReceipt.Name = "barButtonItem_PrintReceipt";
            this.barButtonItem_PrintReceipt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_PrintReceipt_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(850, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 577);
            this.barDockControlBottom.Size = new System.Drawing.Size(850, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 553);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(850, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 553);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_NewJob),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_ViewEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Fixed),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Pay),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Revert),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Collected),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Cancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_PrintReceipt)});
            this.popupMenu1.Manager = this.barManager_Jobs;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // JobsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 577);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "JobsView";
            this.Text = "Jobs";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Jobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Jobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager_Jobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl_Jobs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Jobs;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource JobsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colJobID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colExpectedEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
        private DevExpress.XtraBars.BarManager barManager_Jobs;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_NewJob;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_ViewEdit;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Cancel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Collected;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Pay;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Revert;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Fixed;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_PrintReceipt;
    }
}