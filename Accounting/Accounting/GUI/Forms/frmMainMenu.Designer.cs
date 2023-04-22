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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnRegistration = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.ToolStripStatusLabel3,
            this.ToolStripStatusLabel4});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 527);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(996, 27);
            this.StatusStrip1.TabIndex = 3;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(82, 21);
            this.ToolStripStatusLabel1.Text = "نام کاربر ی";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Image = ((System.Drawing.Image)(resources.GetObject("lblUser.Image")));
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(20, 21);
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(688, 21);
            this.ToolStripStatusLabel3.Spring = true;
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel4.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripStatusLabel4.Image")));
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(186, 21);
            this.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خروجToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Image = global::Accounting.Properties.Resources.exit;
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.AllowAnimations = true;
            this.btnUsers.AllowMouseEffects = true;
            this.btnUsers.AllowToggling = false;
            this.btnUsers.AnimationSpeed = 200;
            this.btnUsers.AutoGenerateColors = false;
            this.btnUsers.AutoRoundBorders = false;
            this.btnUsers.AutoSizeLeftIcon = true;
            this.btnUsers.AutoSizeRightIcon = true;
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BackColor1 = System.Drawing.Color.Blue;
            this.btnUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.BackgroundImage")));
            this.btnUsers.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.ButtonText = "کاربران";
            this.btnUsers.ButtonTextMarginLeft = 0;
            this.btnUsers.ColorContrastOnClick = 45;
            this.btnUsers.ColorContrastOnHover = 45;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnUsers.CustomizableEdges = borderEdges1;
            this.btnUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUsers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUsers.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUsers.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUsers.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnUsers.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnUsers.IconMarginLeft = 11;
            this.btnUsers.IconPadding = 10;
            this.btnUsers.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnUsers.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnUsers.IconSize = 25;
            this.btnUsers.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUsers.IdleBorderRadius = 1;
            this.btnUsers.IdleBorderThickness = 1;
            this.btnUsers.IdleFillColor = System.Drawing.Color.Blue;
            this.btnUsers.IdleIconLeftImage = null;
            this.btnUsers.IdleIconRightImage = null;
            this.btnUsers.IndicateFocus = false;
            this.btnUsers.Location = new System.Drawing.Point(851, 459);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnUsers.OnDisabledState.BorderRadius = 1;
            this.btnUsers.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.OnDisabledState.BorderThickness = 1;
            this.btnUsers.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnUsers.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnUsers.OnDisabledState.IconLeftImage = null;
            this.btnUsers.OnDisabledState.IconRightImage = null;
            this.btnUsers.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.btnUsers.onHoverState.BorderRadius = 1;
            this.btnUsers.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.onHoverState.BorderThickness = 1;
            this.btnUsers.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnUsers.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnUsers.onHoverState.IconLeftImage = null;
            this.btnUsers.onHoverState.IconRightImage = null;
            this.btnUsers.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUsers.OnIdleState.BorderRadius = 1;
            this.btnUsers.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.OnIdleState.BorderThickness = 1;
            this.btnUsers.OnIdleState.FillColor = System.Drawing.Color.Blue;
            this.btnUsers.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnUsers.OnIdleState.IconLeftImage = null;
            this.btnUsers.OnIdleState.IconRightImage = null;
            this.btnUsers.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUsers.OnPressedState.BorderRadius = 1;
            this.btnUsers.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnUsers.OnPressedState.BorderThickness = 1;
            this.btnUsers.OnPressedState.FillColor = System.Drawing.Color.Maroon;
            this.btnUsers.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnUsers.OnPressedState.IconLeftImage = null;
            this.btnUsers.OnPressedState.IconRightImage = null;
            this.btnUsers.Size = new System.Drawing.Size(117, 52);
            this.btnUsers.TabIndex = 16;
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsers.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUsers.TextMarginLeft = 0;
            this.btnUsers.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnUsers.UseDefaultRadiusAndThickness = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.AllowAnimations = true;
            this.btnRegistration.AllowMouseEffects = true;
            this.btnRegistration.AllowToggling = false;
            this.btnRegistration.AnimationSpeed = 200;
            this.btnRegistration.AutoGenerateColors = false;
            this.btnRegistration.AutoRoundBorders = false;
            this.btnRegistration.AutoSizeLeftIcon = true;
            this.btnRegistration.AutoSizeRightIcon = true;
            this.btnRegistration.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistration.BackColor1 = System.Drawing.Color.Blue;
            this.btnRegistration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistration.BackgroundImage")));
            this.btnRegistration.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistration.ButtonText = "مدیریت کاربران ";
            this.btnRegistration.ButtonTextMarginLeft = 0;
            this.btnRegistration.ColorContrastOnClick = 45;
            this.btnRegistration.ColorContrastOnHover = 45;
            this.btnRegistration.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnRegistration.CustomizableEdges = borderEdges2;
            this.btnRegistration.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRegistration.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegistration.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegistration.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegistration.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRegistration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistration.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistration.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegistration.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRegistration.IconMarginLeft = 11;
            this.btnRegistration.IconPadding = 10;
            this.btnRegistration.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistration.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnRegistration.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRegistration.IconSize = 25;
            this.btnRegistration.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistration.IdleBorderRadius = 1;
            this.btnRegistration.IdleBorderThickness = 1;
            this.btnRegistration.IdleFillColor = System.Drawing.Color.Blue;
            this.btnRegistration.IdleIconLeftImage = null;
            this.btnRegistration.IdleIconRightImage = null;
            this.btnRegistration.IndicateFocus = false;
            this.btnRegistration.Location = new System.Drawing.Point(851, 391);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRegistration.OnDisabledState.BorderRadius = 1;
            this.btnRegistration.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistration.OnDisabledState.BorderThickness = 1;
            this.btnRegistration.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRegistration.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRegistration.OnDisabledState.IconLeftImage = null;
            this.btnRegistration.OnDisabledState.IconRightImage = null;
            this.btnRegistration.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.btnRegistration.onHoverState.BorderRadius = 1;
            this.btnRegistration.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistration.onHoverState.BorderThickness = 1;
            this.btnRegistration.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRegistration.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.onHoverState.IconLeftImage = null;
            this.btnRegistration.onHoverState.IconRightImage = null;
            this.btnRegistration.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistration.OnIdleState.BorderRadius = 1;
            this.btnRegistration.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistration.OnIdleState.BorderThickness = 1;
            this.btnRegistration.OnIdleState.FillColor = System.Drawing.Color.Blue;
            this.btnRegistration.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.OnIdleState.IconLeftImage = null;
            this.btnRegistration.OnIdleState.IconRightImage = null;
            this.btnRegistration.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRegistration.OnPressedState.BorderRadius = 1;
            this.btnRegistration.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRegistration.OnPressedState.BorderThickness = 1;
            this.btnRegistration.OnPressedState.FillColor = System.Drawing.Color.Maroon;
            this.btnRegistration.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRegistration.OnPressedState.IconLeftImage = null;
            this.btnRegistration.OnPressedState.IconRightImage = null;
            this.btnRegistration.Size = new System.Drawing.Size(117, 52);
            this.btnRegistration.TabIndex = 16;
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistration.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRegistration.TextMarginLeft = 0;
            this.btnRegistration.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRegistration.UseDefaultRadiusAndThickness = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Accounting.Properties.Resources.main_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 554);
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
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel lblUser;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnUsers;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRegistration;
    }
}