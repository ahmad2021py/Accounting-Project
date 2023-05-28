
namespace Accounting.GUI.Forms
{
    partial class frmCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompany));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.txtCompanyName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.btnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGetData = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.AcceptsReturn = false;
            this.txtCompanyName.AcceptsTab = false;
            this.txtCompanyName.AnimationSpeed = 200;
            this.txtCompanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCompanyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.txtCompanyName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCompanyName.BackgroundImage")));
            this.txtCompanyName.BorderColorActive = System.Drawing.Color.Red;
            this.txtCompanyName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCompanyName.BorderColorHover = System.Drawing.Color.Yellow;
            this.txtCompanyName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCompanyName.BorderRadius = 1;
            this.txtCompanyName.BorderThickness = 1;
            this.txtCompanyName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtCompanyName.DefaultText = "";
            this.txtCompanyName.FillColor = System.Drawing.Color.White;
            this.txtCompanyName.HideSelection = true;
            this.txtCompanyName.IconLeft = null;
            this.txtCompanyName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.IconPadding = 10;
            this.txtCompanyName.IconRight = null;
            this.txtCompanyName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompanyName.Lines = new string[0];
            this.txtCompanyName.Location = new System.Drawing.Point(138, 144);
            this.txtCompanyName.MaxLength = 32767;
            this.txtCompanyName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCompanyName.Modified = false;
            this.txtCompanyName.Multiline = false;
            this.txtCompanyName.Name = "txtCompanyName";
            stateProperties1.BorderColor = System.Drawing.Color.Red;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCompanyName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCompanyName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Blue;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCompanyName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCompanyName.OnIdleState = stateProperties4;
            this.txtCompanyName.Padding = new System.Windows.Forms.Padding(3);
            this.txtCompanyName.PasswordChar = '\0';
            this.txtCompanyName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCompanyName.PlaceholderText = "نام شرکت را وارد کنید";
            this.txtCompanyName.ReadOnly = false;
            this.txtCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCompanyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.SelectionLength = 0;
            this.txtCompanyName.SelectionStart = 0;
            this.txtCompanyName.ShortcutsEnabled = true;
            this.txtCompanyName.Size = new System.Drawing.Size(246, 44);
            this.txtCompanyName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCompanyName.TabIndex = 3;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompanyName.TextMarginBottom = 0;
            this.txtCompanyName.TextMarginLeft = 3;
            this.txtCompanyName.TextMarginTop = 0;
            this.txtCompanyName.TextPlaceholder = "نام شرکت را وارد کنید";
            this.txtCompanyName.UseSystemPasswordChar = false;
            this.txtCompanyName.WordWrap = true;
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.Red;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.Red;
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "ذخیره";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.White;
            this.btnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(506, 105);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 69);
            this.btnSave.TabIndex = 8;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.UsernameLabel.Location = new System.Drawing.Point(30, 152);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(101, 28);
            this.UsernameLabel.TabIndex = 62;
            this.UsernameLabel.Text = "نام شرکت : ";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNew
            // 
            this.btnNew.ActiveBorderThickness = 1;
            this.btnNew.ActiveCornerRadius = 20;
            this.btnNew.ActiveFillColor = System.Drawing.Color.Red;
            this.btnNew.ActiveForecolor = System.Drawing.Color.White;
            this.btnNew.ActiveLineColor = System.Drawing.Color.Red;
            this.btnNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.ButtonText = "جدید";
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNew.IdleBorderThickness = 1;
            this.btnNew.IdleCornerRadius = 20;
            this.btnNew.IdleFillColor = System.Drawing.Color.White;
            this.btnNew.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNew.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNew.Location = new System.Drawing.Point(507, 26);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 69);
            this.btnNew.TabIndex = 8;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.Red;
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.Red;
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "حذف";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnDelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.Location = new System.Drawing.Point(507, 184);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 69);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.ActiveBorderThickness = 1;
            this.btnGetData.ActiveCornerRadius = 20;
            this.btnGetData.ActiveFillColor = System.Drawing.Color.Red;
            this.btnGetData.ActiveForecolor = System.Drawing.Color.White;
            this.btnGetData.ActiveLineColor = System.Drawing.Color.Red;
            this.btnGetData.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetData.BackgroundImage")));
            this.btnGetData.ButtonText = "لیست";
            this.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetData.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGetData.IdleBorderThickness = 1;
            this.btnGetData.IdleCornerRadius = 20;
            this.btnGetData.IdleFillColor = System.Drawing.Color.White;
            this.btnGetData.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGetData.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGetData.Location = new System.Drawing.Point(505, 265);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(101, 69);
            this.btnGetData.TabIndex = 63;
            this.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(617, 346);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCompanyName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCompany";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "شرکت ها";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuTextBox txtCompanyName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        internal System.Windows.Forms.Label UsernameLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNew;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGetData;
    }
}