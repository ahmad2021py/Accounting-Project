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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistration = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.btnCompany = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProdut = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnfrmLoginDetails = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblThisDay = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCustomer = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnStock = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnCategory = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnSaleAndBuy = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lblSaleAndBuy = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnRegistration.Location = new System.Drawing.Point(146, 54);
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
            this.lblRegistration.Location = new System.Drawing.Point(129, 152);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(141, 41);
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
            this.btnCompany.Location = new System.Drawing.Point(277, 54);
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
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(274, 151);
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
            this.btnProdut.Location = new System.Drawing.Point(406, 54);
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
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCustomer.Location = new System.Drawing.Point(555, 152);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(76, 27);
            this.lblCustomer.TabIndex = 72;
            this.lblCustomer.Text = "مشتری";
            // 
            // btnfrmLoginDetails
            // 
            this.btnfrmLoginDetails.ActiveImage = null;
            this.btnfrmLoginDetails.AllowAnimations = true;
            this.btnfrmLoginDetails.AllowBuffering = false;
            this.btnfrmLoginDetails.AllowToggling = false;
            this.btnfrmLoginDetails.AllowZooming = true;
            this.btnfrmLoginDetails.AllowZoomingOnFocus = false;
            this.btnfrmLoginDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnfrmLoginDetails.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnfrmLoginDetails.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnfrmLoginDetails.ErrorImage")));
            this.btnfrmLoginDetails.FadeWhenInactive = false;
            this.btnfrmLoginDetails.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnfrmLoginDetails.Image = global::Accounting.Properties.Resources.icons8_enter_80px;
            this.btnfrmLoginDetails.ImageActive = null;
            this.btnfrmLoginDetails.ImageLocation = "";
            this.btnfrmLoginDetails.ImageMargin = 10;
            this.btnfrmLoginDetails.ImageSize = new System.Drawing.Size(80, 80);
            this.btnfrmLoginDetails.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btnfrmLoginDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnfrmLoginDetails.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnfrmLoginDetails.InitialImage")));
            this.btnfrmLoginDetails.Location = new System.Drawing.Point(18, 54);
            this.btnfrmLoginDetails.Name = "btnfrmLoginDetails";
            this.btnfrmLoginDetails.Rotation = 0;
            this.btnfrmLoginDetails.ShowActiveImage = true;
            this.btnfrmLoginDetails.ShowCursorChanges = true;
            this.btnfrmLoginDetails.ShowImageBorders = true;
            this.btnfrmLoginDetails.ShowSizeMarkers = false;
            this.btnfrmLoginDetails.Size = new System.Drawing.Size(90, 90);
            this.btnfrmLoginDetails.TabIndex = 70;
            this.btnfrmLoginDetails.ToolTipText = "";
            this.btnfrmLoginDetails.WaitOnLoad = false;
            this.btnfrmLoginDetails.Zoom = 10;
            this.btnfrmLoginDetails.ZoomSpeed = 10;
            this.btnfrmLoginDetails.Click += new System.EventHandler(this.btnfrmLoginDetails_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(8, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 41);
            this.label1.TabIndex = 72;
            this.label1.Text = "جزئیات ورود";
            // 
            // lblThisDay
            // 
            this.lblThisDay.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisDay.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblThisDay.Location = new System.Drawing.Point(231, 21);
            this.lblThisDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThisDay.Name = "lblThisDay";
            this.lblThisDay.Size = new System.Drawing.Size(85, 28);
            this.lblThisDay.TabIndex = 74;
            this.lblThisDay.Text = "lblThisDay";
            this.lblThisDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTime.Location = new System.Drawing.Point(7, 22);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(99, 28);
            this.lblTime.TabIndex = 74;
            this.lblTime.Text = "lblTime";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDate.Location = new System.Drawing.Point(146, 22);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 28);
            this.lblDate.TabIndex = 74;
            this.lblDate.Text = "lblDate";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblText.Location = new System.Drawing.Point(88, 24);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblText.Size = new System.Drawing.Size(57, 28);
            this.lblText.TabIndex = 74;
            this.lblText.Text = "ساعت :";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblText);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblThisDay);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(654, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 50);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تاریخ امروز";
            // 
            // btnCustomer
            // 
            this.btnCustomer.ActiveImage = null;
            this.btnCustomer.AllowAnimations = true;
            this.btnCustomer.AllowBuffering = false;
            this.btnCustomer.AllowToggling = false;
            this.btnCustomer.AllowZooming = true;
            this.btnCustomer.AllowZoomingOnFocus = false;
            this.btnCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCustomer.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.ErrorImage")));
            this.btnCustomer.FadeWhenInactive = false;
            this.btnCustomer.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnCustomer.Image = global::Accounting.Properties.Resources.icons8_budget_160px;
            this.btnCustomer.ImageActive = null;
            this.btnCustomer.ImageLocation = "";
            this.btnCustomer.ImageMargin = 10;
            this.btnCustomer.ImageSize = new System.Drawing.Size(80, 80);
            this.btnCustomer.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btnCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCustomer.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.InitialImage")));
            this.btnCustomer.Location = new System.Drawing.Point(542, 54);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Rotation = 0;
            this.btnCustomer.ShowActiveImage = true;
            this.btnCustomer.ShowCursorChanges = true;
            this.btnCustomer.ShowImageBorders = true;
            this.btnCustomer.ShowSizeMarkers = false;
            this.btnCustomer.Size = new System.Drawing.Size(90, 90);
            this.btnCustomer.TabIndex = 70;
            this.btnCustomer.ToolTipText = "";
            this.btnCustomer.WaitOnLoad = false;
            this.btnCustomer.Zoom = 10;
            this.btnCustomer.ZoomSpeed = 10;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.BackColor = System.Drawing.Color.Transparent;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblProducts.Location = new System.Drawing.Point(411, 152);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(94, 27);
            this.lblProducts.TabIndex = 78;
            this.lblProducts.Text = "محصولات";
            // 
            // btnStock
            // 
            this.btnStock.ActiveImage = null;
            this.btnStock.AllowAnimations = true;
            this.btnStock.AllowBuffering = false;
            this.btnStock.AllowToggling = false;
            this.btnStock.AllowZooming = true;
            this.btnStock.AllowZoomingOnFocus = false;
            this.btnStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStock.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnStock.ErrorImage")));
            this.btnStock.FadeWhenInactive = false;
            this.btnStock.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnStock.Image = global::Accounting.Properties.Resources.Stock_Pic;
            this.btnStock.ImageActive = null;
            this.btnStock.ImageLocation = "";
            this.btnStock.ImageMargin = 10;
            this.btnStock.ImageSize = new System.Drawing.Size(80, 80);
            this.btnStock.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btnStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStock.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnStock.InitialImage")));
            this.btnStock.Location = new System.Drawing.Point(665, 54);
            this.btnStock.Name = "btnStock";
            this.btnStock.Rotation = 0;
            this.btnStock.ShowActiveImage = true;
            this.btnStock.ShowCursorChanges = true;
            this.btnStock.ShowImageBorders = true;
            this.btnStock.ShowSizeMarkers = false;
            this.btnStock.Size = new System.Drawing.Size(90, 90);
            this.btnStock.TabIndex = 80;
            this.btnStock.ToolTipText = "";
            this.btnStock.WaitOnLoad = false;
            this.btnStock.Zoom = 10;
            this.btnStock.ZoomSpeed = 10;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblStock.Location = new System.Drawing.Point(690, 150);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(57, 27);
            this.lblStock.TabIndex = 81;
            this.lblStock.Text = "انبار";
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCategory.Location = new System.Drawing.Point(778, 149);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(175, 27);
            this.lblCategory.TabIndex = 83;
            this.lblCategory.Text = "دسته بندی محصولات";
            // 
            // btnCategory
            // 
            this.btnCategory.ActiveImage = null;
            this.btnCategory.AllowAnimations = true;
            this.btnCategory.AllowBuffering = false;
            this.btnCategory.AllowToggling = false;
            this.btnCategory.AllowZooming = true;
            this.btnCategory.AllowZoomingOnFocus = false;
            this.btnCategory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCategory.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCategory.ErrorImage")));
            this.btnCategory.FadeWhenInactive = false;
            this.btnCategory.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnCategory.Image = global::Accounting.Properties.Resources.Category;
            this.btnCategory.ImageActive = null;
            this.btnCategory.ImageLocation = "";
            this.btnCategory.ImageMargin = 10;
            this.btnCategory.ImageSize = new System.Drawing.Size(80, 80);
            this.btnCategory.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btnCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCategory.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCategory.InitialImage")));
            this.btnCategory.Location = new System.Drawing.Point(823, 52);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Rotation = 0;
            this.btnCategory.ShowActiveImage = true;
            this.btnCategory.ShowCursorChanges = true;
            this.btnCategory.ShowImageBorders = true;
            this.btnCategory.ShowSizeMarkers = false;
            this.btnCategory.Size = new System.Drawing.Size(90, 90);
            this.btnCategory.TabIndex = 84;
            this.btnCategory.ToolTipText = "";
            this.btnCategory.WaitOnLoad = false;
            this.btnCategory.Zoom = 10;
            this.btnCategory.ZoomSpeed = 10;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSaleAndBuy
            // 
            this.btnSaleAndBuy.ActiveImage = null;
            this.btnSaleAndBuy.AllowAnimations = true;
            this.btnSaleAndBuy.AllowBuffering = false;
            this.btnSaleAndBuy.AllowToggling = false;
            this.btnSaleAndBuy.AllowZooming = true;
            this.btnSaleAndBuy.AllowZoomingOnFocus = false;
            this.btnSaleAndBuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaleAndBuy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaleAndBuy.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSaleAndBuy.ErrorImage")));
            this.btnSaleAndBuy.FadeWhenInactive = false;
            this.btnSaleAndBuy.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSaleAndBuy.Image = global::Accounting.Properties.Resources.SaleAndBuy;
            this.btnSaleAndBuy.ImageActive = null;
            this.btnSaleAndBuy.ImageLocation = "";
            this.btnSaleAndBuy.ImageMargin = 10;
            this.btnSaleAndBuy.ImageSize = new System.Drawing.Size(80, 80);
            this.btnSaleAndBuy.ImageZoomSize = new System.Drawing.Size(90, 90);
            this.btnSaleAndBuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaleAndBuy.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSaleAndBuy.InitialImage")));
            this.btnSaleAndBuy.Location = new System.Drawing.Point(18, 207);
            this.btnSaleAndBuy.Name = "btnSaleAndBuy";
            this.btnSaleAndBuy.Rotation = 0;
            this.btnSaleAndBuy.ShowActiveImage = true;
            this.btnSaleAndBuy.ShowCursorChanges = true;
            this.btnSaleAndBuy.ShowImageBorders = true;
            this.btnSaleAndBuy.ShowSizeMarkers = false;
            this.btnSaleAndBuy.Size = new System.Drawing.Size(90, 90);
            this.btnSaleAndBuy.TabIndex = 87;
            this.btnSaleAndBuy.ToolTipText = "";
            this.btnSaleAndBuy.WaitOnLoad = false;
            this.btnSaleAndBuy.Zoom = 10;
            this.btnSaleAndBuy.ZoomSpeed = 10;
            this.btnSaleAndBuy.Click += new System.EventHandler(this.btnSaleAndBuy_Click);
            // 
            // lblSaleAndBuy
            // 
            this.lblSaleAndBuy.BackColor = System.Drawing.Color.Transparent;
            this.lblSaleAndBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleAndBuy.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSaleAndBuy.Location = new System.Drawing.Point(7, 314);
            this.lblSaleAndBuy.Name = "lblSaleAndBuy";
            this.lblSaleAndBuy.Size = new System.Drawing.Size(125, 27);
            this.lblSaleAndBuy.TabIndex = 86;
            this.lblSaleAndBuy.Text = "خرید و فروش";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Accounting.Properties.Resources.main_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 555);
            this.Controls.Add(this.btnSaleAndBuy);
            this.Controls.Add(this.lblSaleAndBuy);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnfrmLoginDetails);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnProdut);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.btnRegistration);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuImageButton btnCompany;
        private System.Windows.Forms.Label label3;
        public Bunifu.UI.WinForms.BunifuImageButton btnRegistration;
        public System.Windows.Forms.Label lblRegistration;
        private Bunifu.UI.WinForms.BunifuImageButton btnProdut;
        private System.Windows.Forms.Label lblCustomer;
        private Bunifu.UI.WinForms.BunifuImageButton btnfrmLoginDetails;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblThisDay;
        internal System.Windows.Forms.Label lblTime;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblText;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuImageButton btnCustomer;
        private System.Windows.Forms.Label lblProducts;
        private Bunifu.UI.WinForms.BunifuImageButton btnStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblCategory;
        private Bunifu.UI.WinForms.BunifuImageButton btnCategory;
        private Bunifu.UI.WinForms.BunifuImageButton btnSaleAndBuy;
        private System.Windows.Forms.Label lblSaleAndBuy;
    }
}