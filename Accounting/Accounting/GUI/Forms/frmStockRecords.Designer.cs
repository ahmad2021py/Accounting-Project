
namespace Accounting.GUI.Forms
{
    partial class frmStockRecords
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockRecords));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.DGV1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtProductId = new Bunifu.UI.WinForms.BunifuTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStockId = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnExport = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bPersianCalenderTextBox1 = new BPersianCalender.BPersianCalenderTextBox();
            this.btnSearchByDate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV1.ColumnHeadersHeight = 40;
            this.DGV1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DGV1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGV1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGV1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DGV1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGV1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DGV1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DGV1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DGV1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGV1.CurrentTheme.Name = null;
            this.DGV1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGV1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGV1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGV1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV1.EnableHeadersVisualStyles = false;
            this.DGV1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGV1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DGV1.HeaderBgColor = System.Drawing.Color.Empty;
            this.DGV1.HeaderForeColor = System.Drawing.Color.White;
            this.DGV1.Location = new System.Drawing.Point(398, 12);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 40;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(746, 506);
            this.DGV1.TabIndex = 82;
            this.DGV1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.txtProductId);
            this.groupBox3.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox3.Location = new System.Drawing.Point(28, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 101);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "جستجو با کد کالا";
            // 
            // txtProductId
            // 
            this.txtProductId.AcceptsReturn = false;
            this.txtProductId.AcceptsTab = false;
            this.txtProductId.AnimationSpeed = 200;
            this.txtProductId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtProductId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtProductId.BackColor = System.Drawing.Color.Transparent;
            this.txtProductId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtProductId.BackgroundImage")));
            this.txtProductId.BorderColorActive = System.Drawing.Color.Red;
            this.txtProductId.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtProductId.BorderColorHover = System.Drawing.Color.Yellow;
            this.txtProductId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtProductId.BorderRadius = 1;
            this.txtProductId.BorderThickness = 1;
            this.txtProductId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductId.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtProductId.DefaultText = "";
            this.txtProductId.FillColor = System.Drawing.Color.White;
            this.txtProductId.HideSelection = true;
            this.txtProductId.IconLeft = null;
            this.txtProductId.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductId.IconPadding = 10;
            this.txtProductId.IconRight = null;
            this.txtProductId.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductId.Lines = new string[0];
            this.txtProductId.Location = new System.Drawing.Point(17, 36);
            this.txtProductId.MaxLength = 32767;
            this.txtProductId.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtProductId.Modified = false;
            this.txtProductId.Multiline = false;
            this.txtProductId.Name = "txtProductId";
            stateProperties1.BorderColor = System.Drawing.Color.Red;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductId.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtProductId.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Blue;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductId.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductId.OnIdleState = stateProperties4;
            this.txtProductId.Padding = new System.Windows.Forms.Padding(3);
            this.txtProductId.PasswordChar = '\0';
            this.txtProductId.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtProductId.PlaceholderText = "دسته بندی را وارد کنید";
            this.txtProductId.ReadOnly = false;
            this.txtProductId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductId.SelectedText = "";
            this.txtProductId.SelectionLength = 0;
            this.txtProductId.SelectionStart = 0;
            this.txtProductId.ShortcutsEnabled = true;
            this.txtProductId.Size = new System.Drawing.Size(255, 44);
            this.txtProductId.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtProductId.TabIndex = 4;
            this.txtProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductId.TextMarginBottom = 0;
            this.txtProductId.TextMarginLeft = 3;
            this.txtProductId.TextMarginTop = 0;
            this.txtProductId.TextPlaceholder = "دسته بندی را وارد کنید";
            this.txtProductId.UseSystemPasswordChar = false;
            this.txtProductId.WordWrap = true;
            this.txtProductId.TextChanged += new System.EventHandler(this.txtProductId_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtStockId);
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 110);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو با کد  انبار";
            // 
            // txtStockId
            // 
            this.txtStockId.AcceptsReturn = false;
            this.txtStockId.AcceptsTab = false;
            this.txtStockId.AnimationSpeed = 200;
            this.txtStockId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtStockId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtStockId.BackColor = System.Drawing.Color.Transparent;
            this.txtStockId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtStockId.BackgroundImage")));
            this.txtStockId.BorderColorActive = System.Drawing.Color.Red;
            this.txtStockId.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtStockId.BorderColorHover = System.Drawing.Color.Yellow;
            this.txtStockId.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtStockId.BorderRadius = 1;
            this.txtStockId.BorderThickness = 1;
            this.txtStockId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStockId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockId.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtStockId.DefaultText = "";
            this.txtStockId.FillColor = System.Drawing.Color.White;
            this.txtStockId.HideSelection = true;
            this.txtStockId.IconLeft = null;
            this.txtStockId.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockId.IconPadding = 10;
            this.txtStockId.IconRight = null;
            this.txtStockId.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockId.Lines = new string[0];
            this.txtStockId.Location = new System.Drawing.Point(17, 32);
            this.txtStockId.MaxLength = 32767;
            this.txtStockId.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtStockId.Modified = false;
            this.txtStockId.Multiline = false;
            this.txtStockId.Name = "txtStockId";
            stateProperties5.BorderColor = System.Drawing.Color.Red;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtStockId.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtStockId.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Blue;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtStockId.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtStockId.OnIdleState = stateProperties8;
            this.txtStockId.Padding = new System.Windows.Forms.Padding(3);
            this.txtStockId.PasswordChar = '\0';
            this.txtStockId.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtStockId.PlaceholderText = "نام محصول را وارد کنید";
            this.txtStockId.ReadOnly = false;
            this.txtStockId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStockId.SelectedText = "";
            this.txtStockId.SelectionLength = 0;
            this.txtStockId.SelectionStart = 0;
            this.txtStockId.ShortcutsEnabled = true;
            this.txtStockId.Size = new System.Drawing.Size(255, 46);
            this.txtStockId.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtStockId.TabIndex = 4;
            this.txtStockId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStockId.TextMarginBottom = 0;
            this.txtStockId.TextMarginLeft = 3;
            this.txtStockId.TextMarginTop = 0;
            this.txtStockId.TextPlaceholder = "نام محصول را وارد کنید";
            this.txtStockId.UseSystemPasswordChar = false;
            this.txtStockId.WordWrap = true;
            this.txtStockId.TextChanged += new System.EventHandler(this.txtStockId_TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.ActiveBorderThickness = 1;
            this.btnExport.ActiveCornerRadius = 20;
            this.btnExport.ActiveFillColor = System.Drawing.Color.Red;
            this.btnExport.ActiveForecolor = System.Drawing.Color.White;
            this.btnExport.ActiveLineColor = System.Drawing.Color.Red;
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.ButtonText = "خروجی اکسل";
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExport.IdleBorderThickness = 1;
            this.btnExport.IdleCornerRadius = 20;
            this.btnExport.IdleFillColor = System.Drawing.Color.White;
            this.btnExport.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnExport.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnExport.Location = new System.Drawing.Point(16, 473);
            this.btnExport.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(104, 50);
            this.btnExport.TabIndex = 83;
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // bPersianCalenderTextBox1
            // 
            this.bPersianCalenderTextBox1.Location = new System.Drawing.Point(13, 37);
            this.bPersianCalenderTextBox1.Miladi = new System.DateTime(((long)(0)));
            this.bPersianCalenderTextBox1.Multiline = true;
            this.bPersianCalenderTextBox1.Name = "bPersianCalenderTextBox1";
            this.bPersianCalenderTextBox1.NowDateSelected = false;
            this.bPersianCalenderTextBox1.ReadOnly = true;
            this.bPersianCalenderTextBox1.SelectedDate = null;
            this.bPersianCalenderTextBox1.Shamsi = null;
            this.bPersianCalenderTextBox1.Size = new System.Drawing.Size(278, 32);
            this.bPersianCalenderTextBox1.TabIndex = 87;
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.ActiveBorderThickness = 1;
            this.btnSearchByDate.ActiveCornerRadius = 20;
            this.btnSearchByDate.ActiveFillColor = System.Drawing.Color.Red;
            this.btnSearchByDate.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearchByDate.ActiveLineColor = System.Drawing.Color.Red;
            this.btnSearchByDate.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchByDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchByDate.BackgroundImage")));
            this.btnSearchByDate.ButtonText = "جستجو";
            this.btnSearchByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchByDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearchByDate.IdleBorderThickness = 1;
            this.btnSearchByDate.IdleCornerRadius = 20;
            this.btnSearchByDate.IdleFillColor = System.Drawing.Color.White;
            this.btnSearchByDate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSearchByDate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearchByDate.Location = new System.Drawing.Point(218, 67);
            this.btnSearchByDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(73, 49);
            this.btnSearchByDate.TabIndex = 94;
            this.btnSearchByDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.bPersianCalenderTextBox1);
            this.groupBox2.Controls.Add(this.btnSearchByDate);
            this.groupBox2.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox2.Location = new System.Drawing.Point(9, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 139);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو با تاریخ ورود به انبار";
            // 
            // frmStockRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.DGV1);
            this.Name = "frmStockRecords";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "انبار";
            this.Load += new System.EventHandler(this.frmStockRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView DGV1;
        private System.Windows.Forms.GroupBox groupBox3;
        public Bunifu.UI.WinForms.BunifuTextBox txtProductId;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.UI.WinForms.BunifuTextBox txtStockId;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExport;
        private BPersianCalender.BPersianCalenderTextBox bPersianCalenderTextBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearchByDate;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}