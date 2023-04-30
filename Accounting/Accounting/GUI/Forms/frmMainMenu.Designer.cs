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
            this.lblUsers = new System.Windows.Forms.Label();
            this.btnRegistration = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.btnCompany = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProdut = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblProdut = new System.Windows.Forms.Label();
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
            // lblUsers
            // 
            this.lblUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUsers.Location = new System.Drawing.Point(22, 468);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(80, 41);
            this.lblUsers.TabIndex = 68;
            this.lblUsers.Text = "کاربران";
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
            // lblRegistration
            // 
            this.lblRegistration.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblRegistration.Location = new System.Drawing.Point(129, 468);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(146, 41);
            this.lblRegistration.TabIndex = 68;
            this.lblRegistration.Text = "مدیریت کاربران";
            // 
            // btnCompany
            // 
            this.btnCompany.ActiveImage = null;
            this.btnCompany.AllowAnimations = true;
            this.btnCompany.AllowBuffering = false;
            this.btnCompany.AllowToggling = false;
            this.btnCompany.AllowZooming = true;
            this.btnCompany.AllowZoomingOnFocus = false;
            this.btnCompany.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCompany.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCompany.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCompany.ErrorImage")));
            this.btnCompany.FadeWhenInactive = false;
            this.btnCompany.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnCompany.Image = global::Accounting.Properties.Resources.Company_256;
            this.btnCompany.ImageActive = null;
            this.btnCompany.ImageLocation = "";
            this.btnCompany.ImageMargin = 10;
            this.btnCompany.ImageSize = new System.Drawing.Size(80, 80);
            this.btnCompany.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btnCompany.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCompany.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCompany.InitialImage")));
            this.btnCompany.Location = new System.Drawing.Point(295, 371);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Rotation = 0;
            this.btnCompany.ShowActiveImage = true;
            this.btnCompany.ShowCursorChanges = true;
            this.btnCompany.ShowImageBorders = true;
            this.btnCompany.ShowSizeMarkers = false;
            this.btnCompany.Size = new System.Drawing.Size(90, 90);
            this.btnCompany.TabIndex = 70;
            this.btnCompany.ToolTipText = "";
            this.btnCompany.WaitOnLoad = false;
            this.btnCompany.Zoom = 10;
            this.btnCompany.ZoomSpeed = 10;
            this.btnCompany.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(292, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 41);
            this.label3.TabIndex = 72;
            this.label3.Text = "شرکت ها";
            // 
            // btnProdut
            // 
            this.btnProdut.ActiveImage = null;
            this.btnProdut.AllowAnimations = true;
            this.btnProdut.AllowBuffering = false;
            this.btnProdut.AllowToggling = false;
            this.btnProdut.AllowZooming = true;
            this.btnProdut.AllowZoomingOnFocus = false;
            this.btnProdut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProdut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProdut.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnProdut.ErrorImage")));
            this.btnProdut.FadeWhenInactive = false;
            this.btnProdut.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnProdut.Image = global::Accounting.Properties.Resources.icons8_product_128px_2;
            this.btnProdut.ImageActive = null;
            this.btnProdut.ImageLocation = "";
            this.btnProdut.ImageMargin = 10;
            this.btnProdut.ImageSize = new System.Drawing.Size(80, 80);
            this.btnProdut.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btnProdut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProdut.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnProdut.InitialImage")));
            this.btnProdut.Location = new System.Drawing.Point(448, 371);
            this.btnProdut.Name = "btnProdut";
            this.btnProdut.Rotation = 0;
            this.btnProdut.ShowActiveImage = true;
            this.btnProdut.ShowCursorChanges = true;
            this.btnProdut.ShowImageBorders = true;
            this.btnProdut.ShowSizeMarkers = false;
            this.btnProdut.Size = new System.Drawing.Size(90, 90);
            this.btnProdut.TabIndex = 70;
            this.btnProdut.ToolTipText = "";
            this.btnProdut.WaitOnLoad = false;
            this.btnProdut.Zoom = 10;
            this.btnProdut.ZoomSpeed = 10;
            this.btnProdut.Click += new System.EventHandler(this.btnProdut_Click);
            // 
            // lblProdut
            // 
            this.lblProdut.BackColor = System.Drawing.Color.Transparent;
            this.lblProdut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdut.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblProdut.Location = new System.Drawing.Point(446, 469);
            this.lblProdut.Name = "lblProdut";
            this.lblProdut.Size = new System.Drawing.Size(93, 41);
            this.lblProdut.TabIndex = 72;
            this.lblProdut.Text = "محصولات";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Accounting.Properties.Resources.main_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 555);
            this.Controls.Add(this.lblProdut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProdut);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.lblUsers);
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
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private Bunifu.UI.WinForms.BunifuImageButton btnCompany;
        private System.Windows.Forms.Label label3;
        public Bunifu.UI.WinForms.BunifuImageButton btnUsers;
        public Bunifu.UI.WinForms.BunifuImageButton btnRegistration;
        public System.Windows.Forms.Label lblRegistration;
        public System.Windows.Forms.Label lblUsers;
        private Bunifu.UI.WinForms.BunifuImageButton btnProdut;
        private System.Windows.Forms.Label lblProdut;
    }
}