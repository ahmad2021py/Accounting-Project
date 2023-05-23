
namespace Accounting.GUI.Forms
{
    partial class frmProductRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductRecords));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.btnExport = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DGV1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCategory = new Bunifu.UI.WinForms.BunifuTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCompany = new Bunifu.UI.WinForms.BunifuTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductName = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnExport.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExport.IdleBorderThickness = 1;
            this.btnExport.IdleCornerRadius = 20;
            this.btnExport.IdleFillColor = System.Drawing.Color.White;
            this.btnExport.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnExport.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnExport.Location = new System.Drawing.Point(60, 477);
            this.btnExport.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(178, 74);
            this.btnExport.TabIndex = 77;
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.DGV1.Location = new System.Drawing.Point(362, 8);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 40;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(558, 543);
            this.DGV1.TabIndex = 78;
            this.DGV1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.DGV1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.txtCategory);
            this.groupBox3.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox3.Location = new System.Drawing.Point(24, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 98);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "جستجو با دسته بندی";
            // 
            // txtCategory
            // 
            this.txtCategory.AcceptsReturn = false;
            this.txtCategory.AcceptsTab = false;
            this.txtCategory.AnimationSpeed = 200;
            this.txtCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCategory.BackColor = System.Drawing.Color.Transparent;
            this.txtCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCategory.BackgroundImage")));
            this.txtCategory.BorderColorActive = System.Drawing.Color.Red;
            this.txtCategory.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCategory.BorderColorHover = System.Drawing.Color.Yellow;
            this.txtCategory.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCategory.BorderRadius = 1;
            this.txtCategory.BorderThickness = 1;
            this.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategory.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtCategory.DefaultText = "";
            this.txtCategory.FillColor = System.Drawing.Color.White;
            this.txtCategory.HideSelection = true;
            this.txtCategory.IconLeft = null;
            this.txtCategory.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategory.IconPadding = 10;
            this.txtCategory.IconRight = null;
            this.txtCategory.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategory.Lines = new string[0];
            this.txtCategory.Location = new System.Drawing.Point(17, 33);
            this.txtCategory.MaxLength = 32767;
            this.txtCategory.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCategory.Modified = false;
            this.txtCategory.Multiline = false;
            this.txtCategory.Name = "txtCategory";
            stateProperties1.BorderColor = System.Drawing.Color.Red;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCategory.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCategory.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Blue;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCategory.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCategory.OnIdleState = stateProperties4;
            this.txtCategory.Padding = new System.Windows.Forms.Padding(3);
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCategory.PlaceholderText = "دسته بندی را وارد کنید";
            this.txtCategory.ReadOnly = false;
            this.txtCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCategory.SelectedText = "";
            this.txtCategory.SelectionLength = 0;
            this.txtCategory.SelectionStart = 0;
            this.txtCategory.ShortcutsEnabled = true;
            this.txtCategory.Size = new System.Drawing.Size(255, 44);
            this.txtCategory.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCategory.TabIndex = 4;
            this.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCategory.TextMarginBottom = 0;
            this.txtCategory.TextMarginLeft = 3;
            this.txtCategory.TextMarginTop = 0;
            this.txtCategory.TextPlaceholder = "دسته بندی را وارد کنید";
            this.txtCategory.UseSystemPasswordChar = false;
            this.txtCategory.WordWrap = true;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.txtCompany);
            this.groupBox2.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox2.Location = new System.Drawing.Point(24, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 98);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو با نام شرکت";
            // 
            // txtCompany
            // 
            this.txtCompany.AcceptsReturn = false;
            this.txtCompany.AcceptsTab = false;
            this.txtCompany.AnimationSpeed = 200;
            this.txtCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCompany.BackColor = System.Drawing.Color.Transparent;
            this.txtCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCompany.BackgroundImage")));
            this.txtCompany.BorderColorActive = System.Drawing.Color.Red;
            this.txtCompany.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCompany.BorderColorHover = System.Drawing.Color.Yellow;
            this.txtCompany.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCompany.BorderRadius = 1;
            this.txtCompany.BorderThickness = 1;
            this.txtCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompany.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtCompany.DefaultText = "";
            this.txtCompany.FillColor = System.Drawing.Color.White;
            this.txtCompany.HideSelection = true;
            this.txtCompany.IconLeft = null;
            this.txtCompany.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompany.IconPadding = 10;
            this.txtCompany.IconRight = null;
            this.txtCompany.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCompany.Lines = new string[0];
            this.txtCompany.Location = new System.Drawing.Point(17, 31);
            this.txtCompany.MaxLength = 32767;
            this.txtCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtCompany.Modified = false;
            this.txtCompany.Multiline = false;
            this.txtCompany.Name = "txtCompany";
            stateProperties5.BorderColor = System.Drawing.Color.Red;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCompany.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtCompany.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Blue;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCompany.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtCompany.OnIdleState = stateProperties8;
            this.txtCompany.Padding = new System.Windows.Forms.Padding(3);
            this.txtCompany.PasswordChar = '\0';
            this.txtCompany.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCompany.PlaceholderText = "نام شرکت را وارد کنید";
            this.txtCompany.ReadOnly = false;
            this.txtCompany.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCompany.SelectedText = "";
            this.txtCompany.SelectionLength = 0;
            this.txtCompany.SelectionStart = 0;
            this.txtCompany.ShortcutsEnabled = true;
            this.txtCompany.Size = new System.Drawing.Size(255, 44);
            this.txtCompany.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtCompany.TabIndex = 4;
            this.txtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompany.TextMarginBottom = 0;
            this.txtCompany.TextMarginLeft = 3;
            this.txtCompany.TextMarginTop = 0;
            this.txtCompany.TextPlaceholder = "نام شرکت را وارد کنید";
            this.txtCompany.UseSystemPasswordChar = false;
            this.txtCompany.WordWrap = true;
            this.txtCompany.TextChanged += new System.EventHandler(this.txtCompany_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(24, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 110);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو با نام محصول";
            // 
            // txtProductName
            // 
            this.txtProductName.AcceptsReturn = false;
            this.txtProductName.AcceptsTab = false;
            this.txtProductName.AnimationSpeed = 200;
            this.txtProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtProductName.BackColor = System.Drawing.Color.Transparent;
            this.txtProductName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtProductName.BackgroundImage")));
            this.txtProductName.BorderColorActive = System.Drawing.Color.Red;
            this.txtProductName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtProductName.BorderColorHover = System.Drawing.Color.Yellow;
            this.txtProductName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtProductName.BorderRadius = 1;
            this.txtProductName.BorderThickness = 1;
            this.txtProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtProductName.DefaultText = "";
            this.txtProductName.FillColor = System.Drawing.Color.White;
            this.txtProductName.HideSelection = true;
            this.txtProductName.IconLeft = null;
            this.txtProductName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.IconPadding = 10;
            this.txtProductName.IconRight = null;
            this.txtProductName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(17, 30);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtProductName.Modified = false;
            this.txtProductName.Multiline = false;
            this.txtProductName.Name = "txtProductName";
            stateProperties9.BorderColor = System.Drawing.Color.Red;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductName.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtProductName.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.Blue;
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductName.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductName.OnIdleState = stateProperties12;
            this.txtProductName.Padding = new System.Windows.Forms.Padding(3);
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtProductName.PlaceholderText = "نام محصول را وارد کنید";
            this.txtProductName.ReadOnly = false;
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(255, 46);
            this.txtProductName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtProductName.TabIndex = 4;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProductName.TextMarginBottom = 0;
            this.txtProductName.TextMarginLeft = 3;
            this.txtProductName.TextMarginTop = 0;
            this.txtProductName.TextPlaceholder = "نام محصول را وارد کنید";
            this.txtProductName.UseSystemPasswordChar = false;
            this.txtProductName.WordWrap = true;
            // 
            // frmProductRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 567);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btnExport);
            this.Name = "frmProductRecords";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "لیست محصولات";
            this.Load += new System.EventHandler(this.frmConfigRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnExport;
        private Bunifu.UI.WinForms.BunifuDataGridView DGV1;
        private System.Windows.Forms.GroupBox groupBox3;
        public Bunifu.UI.WinForms.BunifuTextBox txtCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        public Bunifu.UI.WinForms.BunifuTextBox txtCompany;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.UI.WinForms.BunifuTextBox txtProductName;
    }
}