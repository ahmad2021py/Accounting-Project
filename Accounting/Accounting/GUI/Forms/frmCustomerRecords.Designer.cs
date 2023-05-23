
namespace Accounting.GUI.Forms
{
    partial class frmCustomerRecords
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerRecords));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.DGV1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnExport = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNationalCode = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV1.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV1.EnableHeadersVisualStyles = false;
            this.DGV1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGV1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DGV1.HeaderBgColor = System.Drawing.Color.Empty;
            this.DGV1.HeaderForeColor = System.Drawing.Color.White;
            this.DGV1.Location = new System.Drawing.Point(313, 12);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowHeadersVisible = false;
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 40;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(677, 506);
            this.DGV1.TabIndex = 81;
            this.DGV1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.DGV1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV1_CellDoubleClick);
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
            this.btnExport.Location = new System.Drawing.Point(67, 132);
            this.btnExport.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(178, 74);
            this.btnExport.TabIndex = 80;
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtNationalCode);
            this.groupBox1.ForeColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 110);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو با کد ملی";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.AcceptsReturn = false;
            this.txtNationalCode.AcceptsTab = false;
            this.txtNationalCode.AnimationSpeed = 200;
            this.txtNationalCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtNationalCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtNationalCode.BackColor = System.Drawing.Color.Transparent;
            this.txtNationalCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtNationalCode.BackgroundImage")));
            this.txtNationalCode.BorderColorActive = System.Drawing.Color.Red;
            this.txtNationalCode.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtNationalCode.BorderColorHover = System.Drawing.Color.Yellow;
            this.txtNationalCode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtNationalCode.BorderRadius = 1;
            this.txtNationalCode.BorderThickness = 1;
            this.txtNationalCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNationalCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalCode.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtNationalCode.DefaultText = "";
            this.txtNationalCode.FillColor = System.Drawing.Color.White;
            this.txtNationalCode.HideSelection = true;
            this.txtNationalCode.IconLeft = null;
            this.txtNationalCode.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalCode.IconPadding = 10;
            this.txtNationalCode.IconRight = null;
            this.txtNationalCode.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalCode.Lines = new string[0];
            this.txtNationalCode.Location = new System.Drawing.Point(17, 30);
            this.txtNationalCode.MaxLength = 32767;
            this.txtNationalCode.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNationalCode.Modified = false;
            this.txtNationalCode.Multiline = false;
            this.txtNationalCode.Name = "txtNationalCode";
            stateProperties5.BorderColor = System.Drawing.Color.Red;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNationalCode.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNationalCode.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Blue;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNationalCode.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtNationalCode.OnIdleState = stateProperties8;
            this.txtNationalCode.Padding = new System.Windows.Forms.Padding(3);
            this.txtNationalCode.PasswordChar = '\0';
            this.txtNationalCode.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNationalCode.PlaceholderText = "";
            this.txtNationalCode.ReadOnly = false;
            this.txtNationalCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNationalCode.SelectedText = "";
            this.txtNationalCode.SelectionLength = 0;
            this.txtNationalCode.SelectionStart = 0;
            this.txtNationalCode.ShortcutsEnabled = true;
            this.txtNationalCode.Size = new System.Drawing.Size(255, 46);
            this.txtNationalCode.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtNationalCode.TabIndex = 4;
            this.txtNationalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNationalCode.TextMarginBottom = 0;
            this.txtNationalCode.TextMarginLeft = 3;
            this.txtNationalCode.TextMarginTop = 0;
            this.txtNationalCode.TextPlaceholder = "";
            this.txtNationalCode.UseSystemPasswordChar = false;
            this.txtNationalCode.WordWrap = true;
            this.txtNationalCode.TextChanged += new System.EventHandler(this.txtNationalCode_TextChanged);
            // 
            // frmCustomerRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 555);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCustomerRecords";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "لیست مشتریان";
            this.Load += new System.EventHandler(this.frmCustomerRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView DGV1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.UI.WinForms.BunifuTextBox txtNationalCode;
    }
}