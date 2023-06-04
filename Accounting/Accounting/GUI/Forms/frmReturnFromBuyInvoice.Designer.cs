
namespace Accounting.GUI.Forms
{
    partial class frmReturnFromBuyInvoice
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
            this.btnCommit = new System.Windows.Forms.Button();
            this.txtReturnFromBuy_Count = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSelectBuyInvoiceCode = new System.Windows.Forms.Button();
            this.bPersianCalenderTextBox1 = new BPersianCalender.BPersianCalenderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReturnFromBuyInvoiceCode = new System.Windows.Forms.TextBox();
            this.txtBuyInvoiceCode = new System.Windows.Forms.TextBox();
            this.lblStockCode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommit
            // 
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.Location = new System.Drawing.Point(451, 316);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(106, 42);
            this.btnCommit.TabIndex = 41;
            this.btnCommit.Text = "ثبت";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // txtReturnFromBuy_Count
            // 
            this.txtReturnFromBuy_Count.Location = new System.Drawing.Point(195, 297);
            this.txtReturnFromBuy_Count.Multiline = true;
            this.txtReturnFromBuy_Count.Name = "txtReturnFromBuy_Count";
            this.txtReturnFromBuy_Count.Size = new System.Drawing.Size(100, 25);
            this.txtReturnFromBuy_Count.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "تعداد بازگشت از خرید : ";
            // 
            // btnSelectBuyInvoiceCode
            // 
            this.btnSelectBuyInvoiceCode.Location = new System.Drawing.Point(155, 81);
            this.btnSelectBuyInvoiceCode.Name = "btnSelectBuyInvoiceCode";
            this.btnSelectBuyInvoiceCode.Size = new System.Drawing.Size(75, 23);
            this.btnSelectBuyInvoiceCode.TabIndex = 33;
            this.btnSelectBuyInvoiceCode.Text = "انتخاب";
            this.btnSelectBuyInvoiceCode.UseVisualStyleBackColor = true;
            this.btnSelectBuyInvoiceCode.Click += new System.EventHandler(this.btnSelectBuyInvoiceCode_Click);
            // 
            // bPersianCalenderTextBox1
            // 
            this.bPersianCalenderTextBox1.Location = new System.Drawing.Point(140, 134);
            this.bPersianCalenderTextBox1.Miladi = new System.DateTime(((long)(0)));
            this.bPersianCalenderTextBox1.Name = "bPersianCalenderTextBox1";
            this.bPersianCalenderTextBox1.NowDateSelected = false;
            this.bPersianCalenderTextBox1.ReadOnly = true;
            this.bPersianCalenderTextBox1.SelectedDate = null;
            this.bPersianCalenderTextBox1.Shamsi = null;
            this.bPersianCalenderTextBox1.Size = new System.Drawing.Size(155, 22);
            this.bPersianCalenderTextBox1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "کد فاکتور خرید : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "تاریخ فاکتور : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "شماره فاکتور بازگشت از خرید : ";
            // 
            // txtReturnFromBuyInvoiceCode
            // 
            this.txtReturnFromBuyInvoiceCode.Location = new System.Drawing.Point(261, 28);
            this.txtReturnFromBuyInvoiceCode.Multiline = true;
            this.txtReturnFromBuyInvoiceCode.Name = "txtReturnFromBuyInvoiceCode";
            this.txtReturnFromBuyInvoiceCode.Size = new System.Drawing.Size(116, 24);
            this.txtReturnFromBuyInvoiceCode.TabIndex = 23;
            // 
            // txtBuyInvoiceCode
            // 
            this.txtBuyInvoiceCode.Location = new System.Drawing.Point(261, 82);
            this.txtBuyInvoiceCode.Multiline = true;
            this.txtBuyInvoiceCode.Name = "txtBuyInvoiceCode";
            this.txtBuyInvoiceCode.ReadOnly = true;
            this.txtBuyInvoiceCode.Size = new System.Drawing.Size(116, 24);
            this.txtBuyInvoiceCode.TabIndex = 22;
            // 
            // lblStockCode
            // 
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCode.Location = new System.Drawing.Point(151, 197);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(0, 24);
            this.lblStockCode.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "کد کالای انباری : ";
            // 
            // frmReturnFromBuyInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 370);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.txtReturnFromBuy_Count);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSelectBuyInvoiceCode);
            this.Controls.Add(this.bPersianCalenderTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReturnFromBuyInvoiceCode);
            this.Controls.Add(this.txtBuyInvoiceCode);
            this.Controls.Add(this.lblStockCode);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.Name = "frmReturnFromBuyInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فاکتور بازگشت از خرید";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.TextBox txtReturnFromBuy_Count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelectBuyInvoiceCode;
        private BPersianCalender.BPersianCalenderTextBox bPersianCalenderTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReturnFromBuyInvoiceCode;
        private System.Windows.Forms.TextBox txtBuyInvoiceCode;
        private System.Windows.Forms.Label lblStockCode;
        private System.Windows.Forms.Label label7;
    }
}