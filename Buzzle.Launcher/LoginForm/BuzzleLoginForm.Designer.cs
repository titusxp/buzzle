namespace Buzzle.Launcher
{
    partial class BuzzleLoginForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.button_Atheticate = new System.Windows.Forms.Button();
            this.textEdit_Password = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_UserName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.button_Atheticate);
            this.layoutControl1.Controls.Add(this.textEdit_Password);
            this.layoutControl1.Controls.Add(this.textEdit_UserName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(337, 207);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // button_Atheticate
            // 
            this.button_Atheticate.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Atheticate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_Atheticate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button_Atheticate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Atheticate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.button_Atheticate.ForeColor = System.Drawing.Color.White;
            this.button_Atheticate.Location = new System.Drawing.Point(12, 98);
            this.button_Atheticate.Name = "button_Atheticate";
            this.button_Atheticate.Size = new System.Drawing.Size(313, 97);
            this.button_Atheticate.TabIndex = 6;
            this.button_Atheticate.Text = "Start Buzzling...";
            this.button_Atheticate.UseVisualStyleBackColor = false;
            this.button_Atheticate.Click += new System.EventHandler(this.button_Atheticate_Click);
            // 
            // textEdit_Password
            // 
            this.textEdit_Password.Location = new System.Drawing.Point(12, 60);
            this.textEdit_Password.Name = "textEdit_Password";
            this.textEdit_Password.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.textEdit_Password.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.textEdit_Password.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit_Password.Properties.Appearance.Options.UseFont = true;
            this.textEdit_Password.Properties.NullValuePrompt = "Password:";
            this.textEdit_Password.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit_Password.Properties.PasswordChar = 'ᴃ';
            this.textEdit_Password.Properties.UseSystemPasswordChar = true;
            this.textEdit_Password.Size = new System.Drawing.Size(313, 34);
            this.textEdit_Password.StyleController = this.layoutControl1;
            this.textEdit_Password.TabIndex = 5;
            this.textEdit_Password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textEdit_UserName_KeyUp);
            // 
            // textEdit_UserName
            // 
            this.textEdit_UserName.Location = new System.Drawing.Point(12, 12);
            this.textEdit_UserName.Name = "textEdit_UserName";
            this.textEdit_UserName.Properties.AllowFocused = false;
            this.textEdit_UserName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textEdit_UserName.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.textEdit_UserName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.textEdit_UserName.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit_UserName.Properties.Appearance.Options.UseFont = true;
            this.textEdit_UserName.Properties.NullValuePrompt = "User Name:";
            this.textEdit_UserName.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit_UserName.Size = new System.Drawing.Size(313, 34);
            this.textEdit_UserName.StyleController = this.layoutControl1;
            this.textEdit_UserName.TabIndex = 4;
            this.textEdit_UserName.EditValueChanged += new System.EventHandler(this.textEdit_UserName_EditValueChanged);
            this.textEdit_UserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textEdit_UserName_KeyUp);
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
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(337, 207);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit_UserName;
            this.layoutControlItem1.CustomizationFormText = "User Name:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(317, 38);
            this.layoutControlItem1.Text = "User Name:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit_Password;
            this.layoutControlItem2.CustomizationFormText = "Password";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(317, 38);
            this.layoutControlItem2.Text = "Password";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.button_Atheticate;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(317, 101);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 38);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(317, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // BuzzleLoginForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::Buzzle.Launcher.Properties.Resources.buzzle_Logo1;
            this.ClientSize = new System.Drawing.Size(337, 207);
            this.Controls.Add(this.layoutControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuzzleLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buzzle - Login";
            this.Load += new System.EventHandler(this.BuzzleLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_Password;
        private DevExpress.XtraEditors.TextEdit textEdit_UserName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.Button button_Atheticate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}