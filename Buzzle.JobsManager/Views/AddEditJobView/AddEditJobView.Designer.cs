using Buzzle.Data.DataModel;

namespace Buzzle.JobsManager.Views
{
    partial class AddEditJobView
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
            DevExpress.XtraRichEdit.RichEditControl richEditControl_Notes;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditJobView));
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Save = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_AddNote = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Pay = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Collected = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Fixed = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Revert = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.textEdit_CreatedBy = new DevExpress.XtraEditors.TextEdit();
            this.tabControl_Notes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage_Payments = new System.Windows.Forms.TabPage();
            this.gridControl_JobPayments = new DevExpress.XtraGrid.GridControl();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView_JobPayments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateRecorded = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateEdit_ExpEndDate = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit_DateCreated = new DevExpress.XtraEditors.DateEdit();
            this.memoEdit_FaultDescription = new DevExpress.XtraEditors.MemoEdit();
            this.textEdit_CustomerName = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_ItemDescription = new DevExpress.XtraEditors.MemoEdit();
            this.calcEdit_PhoneNumber = new DevExpress.XtraEditors.CalcEdit();
            this.textEdit_JobStatus = new DevExpress.XtraEditors.TextEdit();
            this.comboEdit_ItemType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboEdit_FaultType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lookupDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            richEditControl_Notes = new DevExpress.XtraRichEdit.RichEditControl();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CreatedBy.Properties)).BeginInit();
            this.tabControl_Notes.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage_Payments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_JobPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_JobPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ExpEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ExpEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_DateCreated.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_DateCreated.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_FaultDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ItemDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit_PhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_JobStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboEdit_ItemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboEdit_FaultType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl_Notes
            // 
            richEditControl_Notes.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            richEditControl_Notes.DataBindings.Add(new System.Windows.Forms.Binding("HtmlText", this.jobBindingSource, "Notes", true));
            richEditControl_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            richEditControl_Notes.Location = new System.Drawing.Point(3, 3);
            richEditControl_Notes.MenuManager = this.barManager;
            richEditControl_Notes.Name = "richEditControl_Notes";
            richEditControl_Notes.Options.Fields.UseCurrentCultureDateTimeFormat = false;
            richEditControl_Notes.Options.HorizontalRuler.ShowLeftIndent = false;
            richEditControl_Notes.Options.HorizontalRuler.ShowRightIndent = false;
            richEditControl_Notes.Options.HorizontalRuler.ShowTabs = false;
            richEditControl_Notes.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            richEditControl_Notes.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            richEditControl_Notes.Options.MailMerge.KeepLastParagraph = false;
            richEditControl_Notes.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            richEditControl_Notes.ReadOnly = true;
            richEditControl_Notes.ShowCaretInReadOnly = false;
            richEditControl_Notes.Size = new System.Drawing.Size(708, 260);
            richEditControl_Notes.TabIndex = 0;
            richEditControl_Notes.Text = "Notes...";
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(Buzzle.Data.DataModel.Job);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_Save,
            this.barButtonItem_AddNote,
            this.barButtonItem_Cancel,
            this.barButtonItem_Pay,
            this.barButtonItem_Collected,
            this.barButtonItem_Fixed,
            this.barButtonItem_Revert});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(49, 170);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Save, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_AddNote, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Cancel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Pay, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Collected, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Fixed, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Revert, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_Save
            // 
            this.barButtonItem_Save.Caption = "Save Job";
            this.barButtonItem_Save.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Save.Glyph")));
            this.barButtonItem_Save.Id = 0;
            this.barButtonItem_Save.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Save.LargeGlyph")));
            this.barButtonItem_Save.Name = "barButtonItem_Save";
            this.barButtonItem_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Save_ItemClick);
            // 
            // barButtonItem_AddNote
            // 
            this.barButtonItem_AddNote.Caption = "Add Note...";
            this.barButtonItem_AddNote.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_AddNote.Glyph")));
            this.barButtonItem_AddNote.Id = 1;
            this.barButtonItem_AddNote.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_AddNote.LargeGlyph")));
            this.barButtonItem_AddNote.Name = "barButtonItem_AddNote";
            this.barButtonItem_AddNote.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_AddNote_ItemClick);
            // 
            // barButtonItem_Cancel
            // 
            this.barButtonItem_Cancel.Caption = "Cancel";
            this.barButtonItem_Cancel.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Cancel.Glyph")));
            this.barButtonItem_Cancel.Id = 2;
            this.barButtonItem_Cancel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Cancel.LargeGlyph")));
            this.barButtonItem_Cancel.Name = "barButtonItem_Cancel";
            this.barButtonItem_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Cancel_ItemClick);
            // 
            // barButtonItem_Pay
            // 
            this.barButtonItem_Pay.Caption = "Record Payment";
            this.barButtonItem_Pay.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Pay.Glyph")));
            this.barButtonItem_Pay.Id = 3;
            this.barButtonItem_Pay.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Pay.LargeGlyph")));
            this.barButtonItem_Pay.Name = "barButtonItem_Pay";
            this.barButtonItem_Pay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Pay_ItemClick);
            // 
            // barButtonItem_Collected
            // 
            this.barButtonItem_Collected.Caption = "Mark as Collected";
            this.barButtonItem_Collected.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Collected.Glyph")));
            this.barButtonItem_Collected.Id = 4;
            this.barButtonItem_Collected.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Collected.LargeGlyph")));
            this.barButtonItem_Collected.Name = "barButtonItem_Collected";
            this.barButtonItem_Collected.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Collected_ItemClick);
            // 
            // barButtonItem_Fixed
            // 
            this.barButtonItem_Fixed.Caption = "Mark as Fixed";
            this.barButtonItem_Fixed.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Fixed.Glyph")));
            this.barButtonItem_Fixed.Id = 5;
            this.barButtonItem_Fixed.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Fixed.LargeGlyph")));
            this.barButtonItem_Fixed.Name = "barButtonItem_Fixed";
            this.barButtonItem_Fixed.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Fixed_ItemClick);
            // 
            // barButtonItem_Revert
            // 
            this.barButtonItem_Revert.Caption = "Revert to Pending";
            this.barButtonItem_Revert.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Revert.Glyph")));
            this.barButtonItem_Revert.Id = 6;
            this.barButtonItem_Revert.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Revert.LargeGlyph")));
            this.barButtonItem_Revert.Name = "barButtonItem_Revert";
            this.barButtonItem_Revert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Revert_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(746, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 576);
            this.barDockControlBottom.Size = new System.Drawing.Size(746, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 521);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(746, 55);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 521);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit_CreatedBy);
            this.layoutControl1.Controls.Add(this.tabControl_Notes);
            this.layoutControl1.Controls.Add(this.dateEdit_ExpEndDate);
            this.layoutControl1.Controls.Add(this.dateEdit_DateCreated);
            this.layoutControl1.Controls.Add(this.memoEdit_FaultDescription);
            this.layoutControl1.Controls.Add(this.textEdit_CustomerName);
            this.layoutControl1.Controls.Add(this.textEdit_ItemDescription);
            this.layoutControl1.Controls.Add(this.calcEdit_PhoneNumber);
            this.layoutControl1.Controls.Add(this.textEdit_JobStatus);
            this.layoutControl1.Controls.Add(this.comboEdit_ItemType);
            this.layoutControl1.Controls.Add(this.comboEdit_FaultType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 55);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(468, 274, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(746, 521);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // textEdit_CreatedBy
            // 
            this.textEdit_CreatedBy.EditValue = "Unknown user";
            this.textEdit_CreatedBy.Location = new System.Drawing.Point(111, 191);
            this.textEdit_CreatedBy.MenuManager = this.barManager;
            this.textEdit_CreatedBy.Name = "textEdit_CreatedBy";
            this.textEdit_CreatedBy.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.textEdit_CreatedBy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textEdit_CreatedBy.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.textEdit_CreatedBy.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit_CreatedBy.Properties.Appearance.Options.UseFont = true;
            this.textEdit_CreatedBy.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit_CreatedBy.Properties.ReadOnly = true;
            this.textEdit_CreatedBy.Size = new System.Drawing.Size(623, 22);
            this.textEdit_CreatedBy.StyleController = this.layoutControl1;
            this.textEdit_CreatedBy.TabIndex = 15;
            // 
            // tabControl_Notes
            // 
            this.tabControl_Notes.Controls.Add(this.tabPage1);
            this.tabControl_Notes.Controls.Add(this.tabPage_Payments);
            this.tabControl_Notes.Location = new System.Drawing.Point(12, 217);
            this.tabControl_Notes.Name = "tabControl_Notes";
            this.tabControl_Notes.SelectedIndex = 0;
            this.tabControl_Notes.Size = new System.Drawing.Size(722, 292);
            this.tabControl_Notes.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(richEditControl_Notes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Notes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage_Payments
            // 
            this.tabPage_Payments.Controls.Add(this.gridControl_JobPayments);
            this.tabPage_Payments.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Payments.Name = "tabPage_Payments";
            this.tabPage_Payments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Payments.Size = new System.Drawing.Size(714, 266);
            this.tabPage_Payments.TabIndex = 1;
            this.tabPage_Payments.Text = "Job Payment Info";
            this.tabPage_Payments.UseVisualStyleBackColor = true;
            // 
            // gridControl_JobPayments
            // 
            this.gridControl_JobPayments.DataSource = this.transactionBindingSource;
            this.gridControl_JobPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_JobPayments.Location = new System.Drawing.Point(3, 3);
            this.gridControl_JobPayments.MainView = this.gridView_JobPayments;
            this.gridControl_JobPayments.MenuManager = this.barManager;
            this.gridControl_JobPayments.Name = "gridControl_JobPayments";
            this.gridControl_JobPayments.Size = new System.Drawing.Size(708, 260);
            this.gridControl_JobPayments.TabIndex = 2;
            this.gridControl_JobPayments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_JobPayments});
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(Buzzle.Data.DataModel.Transaction);
            // 
            // gridView_JobPayments
            // 
            this.gridView_JobPayments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAmount,
            this.colNotes,
            this.colDateRecorded,
            this.colTransactionType});
            this.gridView_JobPayments.GridControl = this.gridControl_JobPayments;
            this.gridView_JobPayments.Name = "gridView_JobPayments";
            this.gridView_JobPayments.OptionsView.ShowGroupPanel = false;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceCell.Options.UseTextOptions = true;
            this.colAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAmount.DisplayFormat.FormatString = "#,# CFA";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            this.colAmount.Width = 185;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 3;
            // 
            // colDateRecorded
            // 
            this.colDateRecorded.Caption = "Payment Date";
            this.colDateRecorded.DisplayFormat.FormatString = "dd MMM yyyy hh:mm tt";
            this.colDateRecorded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateRecorded.FieldName = "DateRecorded";
            this.colDateRecorded.Name = "colDateRecorded";
            this.colDateRecorded.Visible = true;
            this.colDateRecorded.VisibleIndex = 0;
            this.colDateRecorded.Width = 132;
            // 
            // colTransactionType
            // 
            this.colTransactionType.Caption = "Reason";
            this.colTransactionType.FieldName = "TransactionType.TransactionName";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.Visible = true;
            this.colTransactionType.VisibleIndex = 1;
            this.colTransactionType.Width = 185;
            // 
            // dateEdit_ExpEndDate
            // 
            this.dateEdit_ExpEndDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobBindingSource, "ExpectedEndDate", true));
            this.dateEdit_ExpEndDate.EditValue = new System.DateTime(2014, 10, 14, 23, 31, 39, 0);
            this.dateEdit_ExpEndDate.Location = new System.Drawing.Point(537, 167);
            this.dateEdit_ExpEndDate.Name = "dateEdit_ExpEndDate";
            this.dateEdit_ExpEndDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit_ExpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_ExpEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_ExpEndDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dateEdit_ExpEndDate.Properties.DisplayFormat.FormatString = "dd MMM yyyy";
            this.dateEdit_ExpEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_ExpEndDate.Properties.EditFormat.FormatString = "dd MMM yyyy";
            this.dateEdit_ExpEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_ExpEndDate.Properties.NullText = "Enter expected end date...";
            this.dateEdit_ExpEndDate.Properties.ShowToday = false;
            this.dateEdit_ExpEndDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit_ExpEndDate.Size = new System.Drawing.Size(197, 20);
            this.dateEdit_ExpEndDate.StyleController = this.layoutControl1;
            this.dateEdit_ExpEndDate.TabIndex = 10;
            // 
            // dateEdit_DateCreated
            // 
            this.dateEdit_DateCreated.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobBindingSource, "DateCreated", true));
            this.dateEdit_DateCreated.EditValue = new System.DateTime(2014, 10, 14, 23, 31, 22, 0);
            this.dateEdit_DateCreated.Location = new System.Drawing.Point(111, 167);
            this.dateEdit_DateCreated.Name = "dateEdit_DateCreated";
            this.dateEdit_DateCreated.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit_DateCreated.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_DateCreated.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_DateCreated.Properties.DisplayFormat.FormatString = "dd MMM yyyy (hh:mm tt)";
            this.dateEdit_DateCreated.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_DateCreated.Properties.EditFormat.FormatString = "dd MMM yyyy (hh:mm tt)";
            this.dateEdit_DateCreated.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_DateCreated.Properties.ReadOnly = true;
            this.dateEdit_DateCreated.Size = new System.Drawing.Size(318, 20);
            this.dateEdit_DateCreated.StyleController = this.layoutControl1;
            this.dateEdit_DateCreated.TabIndex = 9;
            // 
            // memoEdit_FaultDescription
            // 
            this.memoEdit_FaultDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobBindingSource, "FaultDescription", true));
            this.memoEdit_FaultDescription.Location = new System.Drawing.Point(438, 100);
            this.memoEdit_FaultDescription.Name = "memoEdit_FaultDescription";
            this.memoEdit_FaultDescription.Size = new System.Drawing.Size(296, 63);
            this.memoEdit_FaultDescription.StyleController = this.layoutControl1;
            this.memoEdit_FaultDescription.TabIndex = 8;
            this.memoEdit_FaultDescription.UseOptimizedRendering = true;
            // 
            // textEdit_CustomerName
            // 
            this.textEdit_CustomerName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobBindingSource, "CustomerName", true));
            this.textEdit_CustomerName.Location = new System.Drawing.Point(111, 36);
            this.textEdit_CustomerName.Name = "textEdit_CustomerName";
            this.textEdit_CustomerName.Size = new System.Drawing.Size(318, 20);
            this.textEdit_CustomerName.StyleController = this.layoutControl1;
            this.textEdit_CustomerName.TabIndex = 4;
            // 
            // textEdit_ItemDescription
            // 
            this.textEdit_ItemDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobBindingSource, "ItemDescription", true));
            this.textEdit_ItemDescription.Location = new System.Drawing.Point(12, 100);
            this.textEdit_ItemDescription.Name = "textEdit_ItemDescription";
            this.textEdit_ItemDescription.Size = new System.Drawing.Size(417, 63);
            this.textEdit_ItemDescription.StyleController = this.layoutControl1;
            this.textEdit_ItemDescription.TabIndex = 6;
            this.textEdit_ItemDescription.UseOptimizedRendering = true;
            // 
            // calcEdit_PhoneNumber
            // 
            this.calcEdit_PhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobBindingSource, "CustomerPhoneNumber", true));
            this.calcEdit_PhoneNumber.Location = new System.Drawing.Point(537, 36);
            this.calcEdit_PhoneNumber.MenuManager = this.barManager;
            this.calcEdit_PhoneNumber.Name = "calcEdit_PhoneNumber";
            this.calcEdit_PhoneNumber.Properties.Appearance.Options.UseTextOptions = true;
            this.calcEdit_PhoneNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.calcEdit_PhoneNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit_PhoneNumber.Properties.DisplayFormat.FormatString = "\\d{1,3}-\\d{1,3}-\\d{1,3}";
            this.calcEdit_PhoneNumber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcEdit_PhoneNumber.Properties.EditFormat.FormatString = "\\d{1,3}-\\d{1,3}-\\d{1,3}";
            this.calcEdit_PhoneNumber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcEdit_PhoneNumber.Properties.Mask.EditMask = "\\d{0,}";
            this.calcEdit_PhoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.calcEdit_PhoneNumber.Size = new System.Drawing.Size(197, 20);
            this.calcEdit_PhoneNumber.StyleController = this.layoutControl1;
            this.calcEdit_PhoneNumber.TabIndex = 13;
            // 
            // textEdit_JobStatus
            // 
            this.textEdit_JobStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.jobBindingSource, "Status", true));
            this.textEdit_JobStatus.EditValue = "";
            this.textEdit_JobStatus.Location = new System.Drawing.Point(111, 12);
            this.textEdit_JobStatus.Name = "textEdit_JobStatus";
            this.textEdit_JobStatus.Properties.NullText = "Select Job status...";
            this.textEdit_JobStatus.Properties.ReadOnly = true;
            this.textEdit_JobStatus.Size = new System.Drawing.Size(623, 20);
            this.textEdit_JobStatus.StyleController = this.layoutControl1;
            this.textEdit_JobStatus.TabIndex = 12;
            // 
            // comboEdit_ItemType
            // 
            this.comboEdit_ItemType.Location = new System.Drawing.Point(111, 60);
            this.comboEdit_ItemType.Name = "comboEdit_ItemType";
            this.comboEdit_ItemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboEdit_ItemType.Properties.NullText = "Select Item type...";
            this.comboEdit_ItemType.Size = new System.Drawing.Size(318, 20);
            this.comboEdit_ItemType.StyleController = this.layoutControl1;
            this.comboEdit_ItemType.TabIndex = 5;
            // 
            // comboEdit_FaultType
            // 
            this.comboEdit_FaultType.Location = new System.Drawing.Point(537, 60);
            this.comboEdit_FaultType.Name = "comboEdit_FaultType";
            this.comboEdit_FaultType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboEdit_FaultType.Properties.NullText = "Select Fault Type...";
            this.comboEdit_FaultType.Size = new System.Drawing.Size(197, 20);
            this.comboEdit_FaultType.StyleController = this.layoutControl1;
            this.comboEdit_FaultType.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.splitterItem1,
            this.layoutControlItem1,
            this.layoutControlItem10,
            this.layoutControlItem8,
            this.layoutControlItem11});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(746, 521);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem2.Control = this.comboEdit_ItemType;
            this.layoutControlItem2.CustomizationFormText = "Item Type";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(421, 24);
            this.layoutControlItem2.Text = "Item Type";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem3.Control = this.textEdit_ItemDescription;
            this.layoutControlItem3.CustomizationFormText = "Item Description:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(421, 83);
            this.layoutControlItem3.Text = "Item Description:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem4.Control = this.comboEdit_FaultType;
            this.layoutControlItem4.CustomizationFormText = "Fault Type:";
            this.layoutControlItem4.Location = new System.Drawing.Point(426, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem4.Text = "Fault Type:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem5.Control = this.memoEdit_FaultDescription;
            this.layoutControlItem5.CustomizationFormText = "Fault Description:";
            this.layoutControlItem5.Location = new System.Drawing.Point(426, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(300, 83);
            this.layoutControlItem5.Text = "Fault Description:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem6.Control = this.dateEdit_DateCreated;
            this.layoutControlItem6.CustomizationFormText = "Date Created:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 155);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(421, 24);
            this.layoutControlItem6.Text = "Date Created:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.BackColor = System.Drawing.Color.Transparent;
            this.layoutControlItem7.AppearanceItemCaption.Options.UseBackColor = true;
            this.layoutControlItem7.Control = this.dateEdit_ExpEndDate;
            this.layoutControlItem7.CustomizationFormText = "Expected End Date:";
            this.layoutControlItem7.Location = new System.Drawing.Point(426, 155);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem7.Text = "Expected End Date:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.textEdit_JobStatus;
            this.layoutControlItem9.CustomizationFormText = "Job Status:";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(726, 24);
            this.layoutControlItem9.Text = "Job Status:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(96, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(421, 24);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 155);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_CustomerName;
            this.layoutControlItem1.CustomizationFormText = "Customer Name:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(421, 24);
            this.layoutControlItem1.Text = "Customer Name:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.calcEdit_PhoneNumber;
            this.layoutControlItem10.CustomizationFormText = "Phone Number:";
            this.layoutControlItem10.Location = new System.Drawing.Point(426, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem10.Text = "Phone Number:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.tabControl_Notes;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 205);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(726, 296);
            this.layoutControlItem8.Text = "layoutControlItem8";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextToControlDistance = 0;
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.textEdit_CreatedBy;
            this.layoutControlItem11.CustomizationFormText = "Created By:";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 179);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(726, 26);
            this.layoutControlItem11.Text = "Created By:";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(96, 13);
            // 
            // lookupDataBindingSource
            // 
            this.lookupDataBindingSource.DataSource = typeof(Buzzle.Data.DataModel.LookupData);
            // 
            // AddEditJobView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 576);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AddEditJobView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buzzle - Add/Edit Jobs";
            this.Load += new System.EventHandler(this.AddEditJobView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CreatedBy.Properties)).EndInit();
            this.tabControl_Notes.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage_Payments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_JobPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_JobPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ExpEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_ExpEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_DateCreated.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_DateCreated.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_FaultDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_CustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ItemDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit_PhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_JobStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboEdit_ItemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboEdit_FaultType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit textEdit_CustomerName;
        private DevExpress.XtraEditors.MemoEdit textEdit_ItemDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.DateEdit dateEdit_ExpEndDate;
        private DevExpress.XtraEditors.DateEdit dateEdit_DateCreated;
        private DevExpress.XtraEditors.MemoEdit memoEdit_FaultDescription;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Save;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_AddNote;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraEditors.CalcEdit calcEdit_PhoneNumber;
        private System.Windows.Forms.BindingSource lookupDataBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit_JobStatus;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Cancel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Pay;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Collected;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Fixed;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Revert;
        private System.Windows.Forms.TabControl tabControl_Notes;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.ComboBoxEdit comboEdit_ItemType;
        private DevExpress.XtraEditors.ComboBoxEdit comboEdit_FaultType;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.TabPage tabPage_Payments;
        private DevExpress.XtraGrid.GridControl gridControl_JobPayments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_JobPayments;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colDateRecorded;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionType;
        private DevExpress.XtraEditors.TextEdit textEdit_CreatedBy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
    }
}