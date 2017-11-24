namespace Buzzle.Sales.Views
{
    partial class AddEditStockItemTypeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditStockItemTypeView));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.label_fullitemname = new System.Windows.Forms.Label();
            this.stockItemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit_Model = new DevExpress.XtraEditors.TextEdit();
            this.textBox_Notes = new System.Windows.Forms.TextBox();
            this.calcEdit_UnitPrice = new DevExpress.XtraEditors.CalcEdit();
            this.textEdit_ItemName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem_FullName = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem_Save = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.calcEdit_UnitPurchasePrice = new DevExpress.XtraEditors.CalcEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit_UnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_FullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit_UnitPurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.calcEdit_UnitPurchasePrice);
            this.layoutControl1.Controls.Add(this.label_fullitemname);
            this.layoutControl1.Controls.Add(this.textEdit_Model);
            this.layoutControl1.Controls.Add(this.textBox_Notes);
            this.layoutControl1.Controls.Add(this.calcEdit_UnitPrice);
            this.layoutControl1.Controls.Add(this.textEdit_ItemName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(511, 99, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(456, 274);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // label_fullitemname
            // 
            this.label_fullitemname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockItemTypeBindingSource, "FullStockItemName", true));
            this.label_fullitemname.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label_fullitemname.Location = new System.Drawing.Point(111, 224);
            this.label_fullitemname.Name = "label_fullitemname";
            this.label_fullitemname.Size = new System.Drawing.Size(333, 38);
            this.label_fullitemname.TabIndex = 5;
            // 
            // stockItemTypeBindingSource
            // 
            this.stockItemTypeBindingSource.DataSource = typeof(Buzzle.DataModel.StockItemType);
            // 
            // textEdit_Model
            // 
            this.textEdit_Model.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stockItemTypeBindingSource, "Model", true));
            this.textEdit_Model.Location = new System.Drawing.Point(111, 36);
            this.textEdit_Model.Name = "textEdit_Model";
            this.textEdit_Model.Size = new System.Drawing.Size(333, 20);
            this.textEdit_Model.StyleController = this.layoutControl1;
            this.textEdit_Model.TabIndex = 7;
            // 
            // textBox_Notes
            // 
            this.textBox_Notes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockItemTypeBindingSource, "Notes", true));
            this.textBox_Notes.Location = new System.Drawing.Point(12, 124);
            this.textBox_Notes.Multiline = true;
            this.textBox_Notes.Name = "textBox_Notes";
            this.textBox_Notes.Size = new System.Drawing.Size(432, 96);
            this.textBox_Notes.TabIndex = 6;
            // 
            // calcEdit_UnitPrice
            // 
            this.calcEdit_UnitPrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stockItemTypeBindingSource, "UnitSellingPrice", true));
            this.calcEdit_UnitPrice.Location = new System.Drawing.Point(111, 60);
            this.calcEdit_UnitPrice.Name = "calcEdit_UnitPrice";
            this.calcEdit_UnitPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit_UnitPrice.Properties.DisplayFormat.FormatString = "#,# CFA";
            this.calcEdit_UnitPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcEdit_UnitPrice.Size = new System.Drawing.Size(333, 20);
            this.calcEdit_UnitPrice.StyleController = this.layoutControl1;
            this.calcEdit_UnitPrice.TabIndex = 5;
            // 
            // textEdit_ItemName
            // 
            this.textEdit_ItemName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stockItemTypeBindingSource, "StockItemName", true));
            this.textEdit_ItemName.Location = new System.Drawing.Point(111, 12);
            this.textEdit_ItemName.Name = "textEdit_ItemName";
            this.textEdit_ItemName.Properties.NullText = "Select Item...";
            this.textEdit_ItemName.Size = new System.Drawing.Size(333, 20);
            this.textEdit_ItemName.StyleController = this.layoutControl1;
            this.textEdit_ItemName.TabIndex = 4;
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
            this.layoutControlItem_FullName,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(456, 274);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_ItemName;
            this.layoutControlItem1.CustomizationFormText = "Item Name:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(436, 24);
            this.layoutControlItem1.Text = "Item Name:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.calcEdit_UnitPrice;
            this.layoutControlItem2.CustomizationFormText = "Unit Price:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(436, 24);
            this.layoutControlItem2.Text = "Unit Selling Price:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textBox_Notes;
            this.layoutControlItem3.CustomizationFormText = "Description:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(436, 116);
            this.layoutControlItem3.Text = "Notes";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit_Model;
            this.layoutControlItem4.CustomizationFormText = "Model:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(436, 24);
            this.layoutControlItem4.Text = "Model:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(96, 13);
            // 
            // layoutControlItem_FullName
            // 
            this.layoutControlItem_FullName.Control = this.label_fullitemname;
            this.layoutControlItem_FullName.CustomizationFormText = "Full Item Name:";
            this.layoutControlItem_FullName.Location = new System.Drawing.Point(0, 212);
            this.layoutControlItem_FullName.Name = "layoutControlItem_FullName";
            this.layoutControlItem_FullName.Size = new System.Drawing.Size(436, 42);
            this.layoutControlItem_FullName.Text = "Full Item Name:";
            this.layoutControlItem_FullName.TextSize = new System.Drawing.Size(96, 13);
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
            this.barButtonItem_Cancel,
            this.barStaticItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Save),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Cancel)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem_Save
            // 
            this.barButtonItem_Save.Caption = "Save Changes";
            this.barButtonItem_Save.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Save.Glyph")));
            this.barButtonItem_Save.Id = 0;
            this.barButtonItem_Save.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Save.LargeGlyph")));
            this.barButtonItem_Save.Name = "barButtonItem_Save";
            toolTipTitleItem1.Text = "Save Changes";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Saves all changes made to this Item to the database (after verifying that the pro" +
    "vided fields valid)";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barButtonItem_Save.SuperTip = superToolTip1;
            this.barButtonItem_Save.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Save_ItemClick);
            // 
            // barButtonItem_Cancel
            // 
            this.barButtonItem_Cancel.Caption = "Cancel";
            this.barButtonItem_Cancel.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Cancel.Glyph")));
            this.barButtonItem_Cancel.Id = 1;
            this.barButtonItem_Cancel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Cancel.LargeGlyph")));
            this.barButtonItem_Cancel.Name = "barButtonItem_Cancel";
            toolTipTitleItem2.Text = "Cancel";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Closes this window without saving any changes that might have been made";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.barButtonItem_Cancel.SuperTip = superToolTip2;
            this.barButtonItem_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Cancel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(456, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 298);
            this.barDockControlBottom.Size = new System.Drawing.Size(456, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 274);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(456, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 274);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Full Item Name:";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // calcEdit_UnitPurchasePrice
            // 
            this.calcEdit_UnitPurchasePrice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stockItemTypeBindingSource, "UnitPurchasePrice", true));
            this.calcEdit_UnitPurchasePrice.Location = new System.Drawing.Point(111, 84);
            this.calcEdit_UnitPurchasePrice.Name = "calcEdit_UnitPurchasePrice";
            this.calcEdit_UnitPurchasePrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit_UnitPurchasePrice.Properties.DisplayFormat.FormatString = "#,# CFA";
            this.calcEdit_UnitPurchasePrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcEdit_UnitPurchasePrice.Size = new System.Drawing.Size(333, 20);
            this.calcEdit_UnitPurchasePrice.StyleController = this.layoutControl1;
            this.calcEdit_UnitPurchasePrice.TabIndex = 8;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.calcEdit_UnitPurchasePrice;
            this.layoutControlItem5.CustomizationFormText = "Unit Purchase Price:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(436, 24);
            this.layoutControlItem5.Text = "Unit Purchase Price:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(96, 13);
            // 
            // AddEditStockItemTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 298);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AddEditStockItemTypeView";
            this.Text = "AddEditStockItemView";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockItemTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit_UnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_ItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem_FullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit_UnitPurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.TextBox textBox_Notes;
        private DevExpress.XtraEditors.CalcEdit calcEdit_UnitPrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit textEdit_Model;
        private System.Windows.Forms.BindingSource stockItemTypeBindingSource;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Save;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Cancel;
        private DevExpress.XtraEditors.TextEdit textEdit_ItemName;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private System.Windows.Forms.Label label_fullitemname;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem_FullName;
        private DevExpress.XtraEditors.CalcEdit calcEdit_UnitPurchasePrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}