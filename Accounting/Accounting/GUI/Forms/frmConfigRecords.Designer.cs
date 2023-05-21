
namespace Accounting.GUI.Forms
{
    partial class frmConfigRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigRecords));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnExport = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DGV1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 110);
            this.groupBox1.TabIndex = 3;
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
            stateProperties1.BorderColor = System.Drawing.Color.Red;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtProductName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Blue;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtProductName.OnIdleState = stateProperties4;
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
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
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
            // frmConfigRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 567);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConfigRecords";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmConfigRecords";
            this.Load += new System.EventHandler(this.frmConfigRecords_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.UI.WinForms.BunifuTextBox txtProductName;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExport;
        private Bunifu.UI.WinForms.BunifuDataGridView DGV1;
    }
}