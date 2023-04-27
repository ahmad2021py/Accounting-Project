namespace Accounting.GUI.Forms
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsers = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistration = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.lblUser,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 529);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(969, 26);
            this.StatusStrip1.TabIndex = 3;
            this.StatusStrip1.Text = "StatusStrip1";
            this.StatusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStrip1_ItemClicked);
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.RightToLeftAutoMirrorImage = true;
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(95, 20);
            this.ToolStripStatusLabel1.Text = "سطح دسترسی ";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Name = "lblUser";
            this.lblUser.RightToLeftAutoMirrorImage = true;
            this.lblUser.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 20);
            this.toolStripStatusLabel2.Text = "نام کاربری";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_exit_sign_128px;
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.ActiveImage = null;
            this.btnUsers.AllowAnimations = true;
            this.btnUsers.AllowBuffering = false;
            this.btnUsers.AllowToggling = false;
            this.btnUsers.AllowZooming = true;
            this.btnUsers.AllowZoomingOnFocus = false;
            this.btnUsers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUsers.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.ErrorImage")));
            this.btnUsers.FadeWhenInactive = false;
            this.btnUsers.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnUsers.Image = global::Accounting.Properties.Resources.icons8_team_48px;
            this.btnUsers.ImageActive = null;
            this.btnUsers.ImageLocation = "";
            this.btnUsers.ImageMargin = 10;
            this.btnUsers.ImageSize = new System.Drawing.Size(80, 80);
            this.btnUsers.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btnUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUsers.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.InitialImage")));
            this.btnUsers.Location = new System.Drawing.Point(12, 370);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Rotation = 0;
            this.btnUsers.ShowActiveImage = true;
            this.btnUsers.ShowCursorChanges = true;
            this.btnUsers.ShowImageBorders = true;
            this.btnUsers.ShowSizeMarkers = false;
            this.btnUsers.Size = new System.Drawing.Size(90, 90);
            this.btnUsers.TabIndex = 67;
            this.btnUsers.ToolTipText = "";
            this.btnUsers.WaitOnLoad = false;
            this.btnUsers.Zoom = 10;
            this.btnUsers.ZoomSpeed = 10;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(22, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 41);
            this.label1.TabIndex = 68;
            this.label1.Text = "کاربران";
            // 
            // btnRegistration
            // 
            this.btnRegistration.ActiveImage = null;
            this.btnRegistration.AllowAnimations = true;
            this.btnRegistration.AllowBuffering = false;
            this.btnRegistration.AllowToggling = false;
            this.btnRegistration.AllowZooming = true;
            this.btnRegistration.AllowZoomingOnFocus = false;
            this.btnRegistration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistration.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistration.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRegistration.ErrorImage")));
            this.btnRegistration.FadeWhenInactive = false;
            this.btnRegistration.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnRegistration.Image = global::Accounting.Properties.Resources.icons8_registration_skin_type_7_48px;
            this.btnRegistration.ImageActive = null;
            this.btnRegistration.ImageLocation = "";
            this.btnRegistration.ImageMargin = 10;
            this.btnRegistration.ImageSize = new System.Drawing.Size(80, 80);
            this.btnRegistration.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btnRegistration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegistration.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRegistration.InitialImage")));
            this.btnRegistration.Location = new System.Drawing.Point(156, 371);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Rotation = 0;
            this.btnRegistration.ShowActiveImage = true;
            this.btnRegistration.ShowCursorChanges = true;
            this.btnRegistration.ShowImageBorders = true;
            this.btnRegistration.ShowSizeMarkers = false;
            this.btnRegistration.Size = new System.Drawing.Size(90, 90);
            this.btnRegistration.TabIndex = 67;
            this.btnRegistration.ToolTipText = "";
            this.btnRegistration.WaitOnLoad = false;
            this.btnRegistration.Zoom = 10;
            this.btnRegistration.ZoomSpeed = 10;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(129, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 41);
            this.label2.TabIndex = 68;
            this.label2.Text = "مدیریت کاربران";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Accounting.Properties.Resources.main_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خانه";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuImageButton btnUsers;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton btnRegistration;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}