

namespace Buzzle.Client.Ui
{
    partial class UsersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersView));
            this.tileControl_Users = new DevExpress.XtraEditors.TileControl();
            this.tileGroup_UsersGroup = new DevExpress.XtraEditors.TileGroup();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barButtonItem_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_New = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem_DeleteUser = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu_Tiles = new DevExpress.XtraBars.PopupMenu(this.components);
            this.layoutControl6 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu_Tiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).BeginInit();
            this.layoutControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // tileControl_Users
            // 
            this.tileControl_Users.Groups.Add(this.tileGroup_UsersGroup);
            this.tileControl_Users.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileControl_Users.Location = new System.Drawing.Point(12, 12);
            this.tileControl_Users.MaxId = 4;
            this.tileControl_Users.Name = "tileControl_Users";
            this.tileControl_Users.Size = new System.Drawing.Size(766, 451);
            this.tileControl_Users.TabIndex = 0;
            this.tileControl_Users.Text = "tileControl1";
            this.tileControl_Users.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // tileGroup_UsersGroup
            // 
            this.tileGroup_UsersGroup.Name = "tileGroup_UsersGroup";
            this.tileGroup_UsersGroup.Text = null;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_Refresh,
            this.barButtonItem_New,
            this.barButtonItem_DeleteUser});
            this.barManager1.MaxItemId = 19;
            // 
            // barButtonItem_Refresh
            // 
            this.barButtonItem_Refresh.Caption = "&Refresh";
            this.barButtonItem_Refresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Refresh.Glyph")));
            this.barButtonItem_Refresh.Id = 3;
            this.barButtonItem_Refresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_Refresh.LargeGlyph")));
            this.barButtonItem_Refresh.Name = "barButtonItem_Refresh";
            this.barButtonItem_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Refresh_ItemClick_1);
            // 
            // barButtonItem_New
            // 
            this.barButtonItem_New.Caption = "Add &New";
            this.barButtonItem_New.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_New.Glyph")));
            this.barButtonItem_New.Id = 4;
            this.barButtonItem_New.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_New.LargeGlyph")));
            this.barButtonItem_New.Name = "barButtonItem_New";
            this.barButtonItem_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_New_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(790, 31);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 475);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(790, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 475);
            // 
            // barButtonItem_DeleteUser
            // 
            this.barButtonItem_DeleteUser.Caption = "Delete User";
            this.barButtonItem_DeleteUser.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_DeleteUser.Glyph")));
            this.barButtonItem_DeleteUser.Id = 5;
            this.barButtonItem_DeleteUser.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem_DeleteUser.LargeGlyph")));
            this.barButtonItem_DeleteUser.Name = "barButtonItem_DeleteUser";
            this.barButtonItem_DeleteUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_DeleteUser_ItemClick);
            // 
            // popupMenu_Tiles
            // 
            this.popupMenu_Tiles.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_DeleteUser)});
            this.popupMenu_Tiles.Manager = this.barManager1;
            this.popupMenu_Tiles.Name = "popupMenu_Tiles";
            // 
            // layoutControl6
            // 
            this.layoutControl6.Controls.Add(this.tileControl_Users);
            this.layoutControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl6.Location = new System.Drawing.Point(0, 31);
            this.layoutControl6.Name = "layoutControl6";
            this.layoutControl6.Root = this.layoutControlGroup6;
            this.layoutControl6.Size = new System.Drawing.Size(790, 475);
            this.layoutControl6.TabIndex = 5;
            this.layoutControl6.Text = "layoutControl6";
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "layoutControlGroup6";
            this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup6.GroupBordersVisible = false;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Size = new System.Drawing.Size(790, 475);
            this.layoutControlGroup6.Text = "layoutControlGroup6";
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tileControl_Users;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(770, 455);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_Refresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem_New, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.Text = "Custom 2";
            // 
            // UsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 506);
            this.Controls.Add(this.layoutControl6);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UsersView";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu_Tiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl6)).EndInit();
            this.layoutControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.TileControl tileControl_Users;
        private DevExpress.XtraEditors.TileGroup tileGroup_UsersGroup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Refresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_New;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_DeleteUser;
        private DevExpress.XtraBars.PopupMenu popupMenu_Tiles;
        private DevExpress.XtraLayout.LayoutControl layoutControl6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraBars.Bar bar1;
    }
}