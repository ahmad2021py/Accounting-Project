﻿
namespace Accounting.GUI.Forms
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblproductId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetData = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBrowse = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PboxProductPicture = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtFeatures = new Bunifu.UI.WinForms.BunifuTextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PboxProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lblproductId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.PboxProductPicture);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtFeatures);
            this.groupBox1.Controls.Add(this.PasswordLabel);
            this.groupBox1.Controls.Add(this.cmbProductName);
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(989, 471);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ویرایش و ثبت ویژگی ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblproductId
            // 
            this.lblproductId.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductId.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblproductId.Location = new System.Drawing.Point(695, 25);
            this.lblproductId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblproductId.Name = "lblproductId";
            this.lblproductId.Size = new System.Drawing.Size(135, 28);
            this.lblproductId.TabIndex = 85;
            this.lblproductId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(838, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 84;
            this.label3.Text = "کد محصول :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetData);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Location = new System.Drawing.Point(21, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 387);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
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
            this.btnGetData.ButtonText = "لیست محصولات";
            this.btnGetData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGetData.IdleBorderThickness = 1;
            this.btnGetData.IdleCornerRadius = 20;
            this.btnGetData.IdleFillColor = System.Drawing.Color.White;
            this.btnGetData.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGetData.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGetData.Location = new System.Drawing.Point(8, 284);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(5);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(111, 64);
            this.btnGetData.TabIndex = 5;
            this.btnGetData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.Red;
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.Red;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "بروزرسانی";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.Location = new System.Drawing.Point(7, 208);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 70);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnDelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.Location = new System.Drawing.Point(7, 142);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 67);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.White;
            this.btnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(7, 78);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 64);
            this.btnSave.TabIndex = 5;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNew.IdleBorderThickness = 1;
            this.btnNew.IdleCornerRadius = 20;
            this.btnNew.IdleFillColor = System.Drawing.Color.White;
            this.btnNew.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnNew.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnNew.Location = new System.Drawing.Point(7, 13);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 60);
            this.btnNew.TabIndex = 5;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.ActiveBorderThickness = 1;
            this.btnBrowse.ActiveCornerRadius = 20;
            this.btnBrowse.ActiveFillColor = System.Drawing.Color.Red;
            this.btnBrowse.ActiveForecolor = System.Drawing.Color.White;
            this.btnBrowse.ActiveLineColor = System.Drawing.Color.Red;
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Control;
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.ButtonText = "انتخاب تصویر";
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBrowse.IdleBorderThickness = 1;
            this.btnBrowse.IdleCornerRadius = 20;
            this.btnBrowse.IdleFillColor = System.Drawing.Color.White;
            this.btnBrowse.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnBrowse.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnBrowse.Location = new System.Drawing.Point(231, 393);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(117, 55);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // PboxProductPicture
            // 
            this.PboxProductPicture.AllowFocused = false;
            this.PboxProductPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PboxProductPicture.AutoSizeHeight = true;
            this.PboxProductPicture.BorderRadius = 141;
            this.PboxProductPicture.Image = ((System.Drawing.Image)(resources.GetObject("PboxProductPicture.Image")));
            this.PboxProductPicture.IsCircle = true;
            this.PboxProductPicture.Location = new System.Drawing.Point(154, 103);
            this.PboxProductPicture.Name = "PboxProductPicture";
            this.PboxProductPicture.Size = new System.Drawing.Size(282, 282);
            this.PboxProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PboxProductPicture.TabIndex = 82;
            this.PboxProductPicture.TabStop = false;
            this.PboxProductPicture.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(895, 359);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 80;
            this.label1.Text = "قیمت : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(871, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 80;
            this.label2.Text = "ویژگی ها :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            this.txtPrice.AcceptsReturn = false;
            this.txtPrice.AcceptsTab = false;
            this.txtPrice.AnimationSpeed = 200;
            this.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPrice.BackgroundImage")));
            this.txtPrice.BorderColorActive = System.Drawing.Color.Red;
            this.txtPrice.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPrice.BorderColorHover = System.Drawing.Color.Yellow;
            this.txtPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtPrice.BorderRadius = 1;
            this.txtPrice.BorderThickness = 1;
            this.txtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPrice.DefaultText = "";
            this.txtPrice.FillColor = System.Drawing.Color.White;
            this.txtPrice.HideSelection = true;
            this.txtPrice.IconLeft = null;
            this.txtPrice.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.IconPadding = 10;
            this.txtPrice.IconRight = null;
            this.txtPrice.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(625, 359);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPrice.Modified = false;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            stateProperties1.BorderColor = System.Drawing.Color.Red;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPrice.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPrice.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Blue;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPrice.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPrice.OnIdleState = stateProperties4;
            this.txtPrice.Padding = new System.Windows.Forms.Padding(3);
            this.txtPrice.PasswordChar = '●';
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.ReadOnly = false;
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(264, 30);
            this.txtPrice.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPrice.TabIndex = 79;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.TextMarginBottom = 0;
            this.txtPrice.TextMarginLeft = 3;
            this.txtPrice.TextMarginTop = 0;
            this.txtPrice.TextPlaceholder = "";
            this.txtPrice.UseSystemPasswordChar = true;
            this.txtPrice.WordWrap = true;
            // 
            // txtFeatures
            // 
            this.txtFeatures.AcceptsReturn = false;
            this.txtFeatures.AcceptsTab = false;
            this.txtFeatures.AnimationSpeed = 200;
            this.txtFeatures.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFeatures.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFeatures.BackColor = System.Drawing.Color.Transparent;
            this.txtFeatures.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFeatures.BackgroundImage")));
            this.txtFeatures.BorderColorActive = System.Drawing.Color.Red;
            this.txtFeatures.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFeatures.BorderColorHover = System.Drawing.Color.Yellow;
            this.txtFeatures.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtFeatures.BorderRadius = 1;
            this.txtFeatures.BorderThickness = 1;
            this.txtFeatures.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFeatures.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFeatures.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtFeatures.DefaultText = "";
            this.txtFeatures.FillColor = System.Drawing.Color.White;
            this.txtFeatures.HideSelection = true;
            this.txtFeatures.IconLeft = null;
            this.txtFeatures.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFeatures.IconPadding = 10;
            this.txtFeatures.IconRight = null;
            this.txtFeatures.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFeatures.Lines = new string[0];
            this.txtFeatures.Location = new System.Drawing.Point(462, 143);
            this.txtFeatures.MaxLength = 32767;
            this.txtFeatures.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtFeatures.Modified = false;
            this.txtFeatures.Multiline = false;
            this.txtFeatures.Name = "txtFeatures";
            stateProperties5.BorderColor = System.Drawing.Color.Red;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFeatures.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtFeatures.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Blue;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFeatures.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtFeatures.OnIdleState = stateProperties8;
            this.txtFeatures.Padding = new System.Windows.Forms.Padding(3);
            this.txtFeatures.PasswordChar = '●';
            this.txtFeatures.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFeatures.PlaceholderText = "";
            this.txtFeatures.ReadOnly = false;
            this.txtFeatures.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFeatures.SelectedText = "";
            this.txtFeatures.SelectionLength = 0;
            this.txtFeatures.SelectionStart = 0;
            this.txtFeatures.ShortcutsEnabled = true;
            this.txtFeatures.Size = new System.Drawing.Size(508, 181);
            this.txtFeatures.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtFeatures.TabIndex = 79;
            this.txtFeatures.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFeatures.TextMarginBottom = 0;
            this.txtFeatures.TextMarginLeft = 3;
            this.txtFeatures.TextMarginTop = 0;
            this.txtFeatures.TextPlaceholder = "";
            this.txtFeatures.UseSystemPasswordChar = true;
            this.txtFeatures.WordWrap = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.PasswordLabel.Location = new System.Drawing.Point(853, 65);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(122, 28);
            this.PasswordLabel.TabIndex = 78;
            this.PasswordLabel.Text = "نام محصول :";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbProductName
            // 
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(645, 70);
            this.cmbProductName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(201, 24);
            this.cmbProductName.TabIndex = 77;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 484);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConfig";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ویرایش و ثبت ویژگی ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PboxProductPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbProductName;
        internal System.Windows.Forms.Label PasswordLabel;
        public Bunifu.UI.WinForms.BunifuTextBox txtFeatures;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        public Bunifu.UI.WinForms.BunifuTextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBrowse;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGetData;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNew;
        internal System.Windows.Forms.Label lblproductId;
        internal System.Windows.Forms.Label label3;
        public Bunifu.UI.WinForms.BunifuPictureBox PboxProductPicture;
    }
}