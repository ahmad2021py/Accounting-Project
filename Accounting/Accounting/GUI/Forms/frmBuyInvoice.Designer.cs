
namespace Accounting.GUI.Forms
{
    partial class frmBuyInvoice
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInvoiceTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalBuyAmountWithOff = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalBuyPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSellerCreditor = new System.Windows.Forms.Label();
            this.lblSellerCreditorWithThisInvoice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.SelectSeller = new System.Windows.Forms.Button();
            this.bPersianCalenderTextBox1 = new BPersianCalender.BPersianCalenderTextBox();
            this.lblSellerCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOff = new System.Windows.Forms.TextBox();
            this.txtBuyPricePerUnit = new System.Windows.Forms.TextBox();
            this.txtBuyCount = new System.Windows.Forms.TextBox();
            this.txtBuyInvoiceCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStockCodeForStore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSelectProductCode = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInvoiceTotalPrice);
            this.groupBox2.Controls.Add(this.lblTotalBuyAmountWithOff);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblTotalBuyPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(454, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 110);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فاکتور";
            // 
            // lblInvoiceTotalPrice
            // 
            this.lblInvoiceTotalPrice.AutoSize = true;
            this.lblInvoiceTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTotalPrice.Location = new System.Drawing.Point(265, 89);
            this.lblInvoiceTotalPrice.Name = "lblInvoiceTotalPrice";
            this.lblInvoiceTotalPrice.Size = new System.Drawing.Size(0, 24);
            this.lblInvoiceTotalPrice.TabIndex = 2;
            // 
            // lblTotalBuyAmountWithOff
            // 
            this.lblTotalBuyAmountWithOff.AutoSize = true;
            this.lblTotalBuyAmountWithOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBuyAmountWithOff.Location = new System.Drawing.Point(96, 70);
            this.lblTotalBuyAmountWithOff.Name = "lblTotalBuyAmountWithOff";
            this.lblTotalBuyAmountWithOff.Size = new System.Drawing.Size(0, 24);
            this.lblTotalBuyAmountWithOff.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(279, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "مبلغ نهایی با احتساب تخفیف : ";
            // 
            // lblTotalBuyPrice
            // 
            this.lblTotalBuyPrice.AutoSize = true;
            this.lblTotalBuyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBuyPrice.Location = new System.Drawing.Point(151, 18);
            this.lblTotalBuyPrice.Name = "lblTotalBuyPrice";
            this.lblTotalBuyPrice.Size = new System.Drawing.Size(0, 24);
            this.lblTotalBuyPrice.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(362, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "کل مبلغ خرید : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSellerCreditor);
            this.groupBox1.Controls.Add(this.lblSellerCreditorWithThisInvoice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(444, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 128);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشتری ";
            // 
            // lblSellerCreditor
            // 
            this.lblSellerCreditor.AutoSize = true;
            this.lblSellerCreditor.Location = new System.Drawing.Point(201, 35);
            this.lblSellerCreditor.Name = "lblSellerCreditor";
            this.lblSellerCreditor.Size = new System.Drawing.Size(0, 17);
            this.lblSellerCreditor.TabIndex = 3;
            // 
            // lblSellerCreditorWithThisInvoice
            // 
            this.lblSellerCreditorWithThisInvoice.AutoSize = true;
            this.lblSellerCreditorWithThisInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerCreditorWithThisInvoice.Location = new System.Drawing.Point(178, 78);
            this.lblSellerCreditorWithThisInvoice.Name = "lblSellerCreditorWithThisInvoice";
            this.lblSellerCreditorWithThisInvoice.Size = new System.Drawing.Size(0, 24);
            this.lblSellerCreditorWithThisInvoice.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(247, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "بستانکاری قبلی با احتساب این فاکتور : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(229, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(269, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "بستانکاری قبلی بدون احتساب این فاکتور : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "بدهی قبلی بدون احتساب این فاکتور : ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(444, 275);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 39);
            this.btnCalculate.TabIndex = 28;
            this.btnCalculate.Text = "محاسبه";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(444, 329);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(112, 39);
            this.btnCommit.TabIndex = 27;
            this.btnCommit.Text = "ثبت فاکتور";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // SelectSeller
            // 
            this.SelectSeller.Location = new System.Drawing.Point(134, 126);
            this.SelectSeller.Name = "SelectSeller";
            this.SelectSeller.Size = new System.Drawing.Size(75, 23);
            this.SelectSeller.TabIndex = 26;
            this.SelectSeller.Text = "انتخاب";
            this.SelectSeller.UseVisualStyleBackColor = true;
            this.SelectSeller.Click += new System.EventHandler(this.SelectSeller_Click);
            // 
            // bPersianCalenderTextBox1
            // 
            this.bPersianCalenderTextBox1.Location = new System.Drawing.Point(205, 83);
            this.bPersianCalenderTextBox1.Miladi = new System.DateTime(((long)(0)));
            this.bPersianCalenderTextBox1.Name = "bPersianCalenderTextBox1";
            this.bPersianCalenderTextBox1.NowDateSelected = false;
            this.bPersianCalenderTextBox1.ReadOnly = true;
            this.bPersianCalenderTextBox1.SelectedDate = null;
            this.bPersianCalenderTextBox1.Shamsi = null;
            this.bPersianCalenderTextBox1.Size = new System.Drawing.Size(155, 22);
            this.bPersianCalenderTextBox1.TabIndex = 24;
            // 
            // lblSellerCode
            // 
            this.lblSellerCode.AutoSize = true;
            this.lblSellerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerCode.Location = new System.Drawing.Point(229, 125);
            this.lblSellerCode.Name = "lblSellerCode";
            this.lblSellerCode.Size = new System.Drawing.Size(76, 24);
            this.lblSellerCode.TabIndex = 22;
            this.lblSellerCode.Text = "کد فروشنده";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "کد فروشنده : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "تاریخ فاکتور : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "شماره فاکتور خرید : ";
            // 
            // txtOff
            // 
            this.txtOff.Location = new System.Drawing.Point(190, 453);
            this.txtOff.Multiline = true;
            this.txtOff.Name = "txtOff";
            this.txtOff.Size = new System.Drawing.Size(171, 27);
            this.txtOff.TabIndex = 12;
            // 
            // txtBuyPricePerUnit
            // 
            this.txtBuyPricePerUnit.Location = new System.Drawing.Point(192, 397);
            this.txtBuyPricePerUnit.Multiline = true;
            this.txtBuyPricePerUnit.Name = "txtBuyPricePerUnit";
            this.txtBuyPricePerUnit.Size = new System.Drawing.Size(169, 27);
            this.txtBuyPricePerUnit.TabIndex = 11;
            // 
            // txtBuyCount
            // 
            this.txtBuyCount.Location = new System.Drawing.Point(190, 334);
            this.txtBuyCount.Multiline = true;
            this.txtBuyCount.Name = "txtBuyCount";
            this.txtBuyCount.Size = new System.Drawing.Size(171, 25);
            this.txtBuyCount.TabIndex = 10;
            // 
            // txtBuyInvoiceCode
            // 
            this.txtBuyInvoiceCode.Location = new System.Drawing.Point(192, 18);
            this.txtBuyInvoiceCode.Multiline = true;
            this.txtBuyInvoiceCode.Name = "txtBuyInvoiceCode";
            this.txtBuyInvoiceCode.Size = new System.Drawing.Size(168, 24);
            this.txtBuyInvoiceCode.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 456);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "تخفیف (درصد) : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "قیمت خرید  (هر واحد) : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "تعداد خرید : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "کد انبار جهت ذخیره : ";
            // 
            // txtStockCodeForStore
            // 
            this.txtStockCodeForStore.Location = new System.Drawing.Point(193, 271);
            this.txtStockCodeForStore.Multiline = true;
            this.txtStockCodeForStore.Name = "txtStockCodeForStore";
            this.txtStockCodeForStore.Size = new System.Drawing.Size(168, 24);
            this.txtStockCodeForStore.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "توضیحات جهت ذخیره در انبار :  ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(190, 535);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(323, 110);
            this.txtDescription.TabIndex = 12;
            // 
            // btnSelectProductCode
            // 
            this.btnSelectProductCode.Location = new System.Drawing.Point(134, 176);
            this.btnSelectProductCode.Name = "btnSelectProductCode";
            this.btnSelectProductCode.Size = new System.Drawing.Size(75, 23);
            this.btnSelectProductCode.TabIndex = 26;
            this.btnSelectProductCode.Text = "انتخاب";
            this.btnSelectProductCode.UseVisualStyleBackColor = true;
            this.btnSelectProductCode.Click += new System.EventHandler(this.btnSelectProductCode_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "محصول : ";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(229, 176);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(79, 24);
            this.lblProductCode.TabIndex = 21;
            this.lblProductCode.Text = "کد محصول";
            // 
            // frmBuyInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnSelectProductCode);
            this.Controls.Add(this.SelectSeller);
            this.Controls.Add(this.bPersianCalenderTextBox1);
            this.Controls.Add(this.lblSellerCode);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtOff);
            this.Controls.Add(this.txtBuyPricePerUnit);
            this.Controls.Add(this.txtBuyCount);
            this.Controls.Add(this.txtStockCodeForStore);
            this.Controls.Add(this.txtBuyInvoiceCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.Name = "frmBuyInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فاکتور خرید ";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblInvoiceTotalPrice;
        private System.Windows.Forms.Label lblTotalBuyAmountWithOff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalBuyPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSellerCreditor;
        private System.Windows.Forms.Label lblSellerCreditorWithThisInvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button SelectSeller;
        private BPersianCalender.BPersianCalenderTextBox bPersianCalenderTextBox1;
        private System.Windows.Forms.Label lblSellerCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOff;
        private System.Windows.Forms.TextBox txtBuyPricePerUnit;
        private System.Windows.Forms.TextBox txtBuyCount;
        private System.Windows.Forms.TextBox txtBuyInvoiceCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockCodeForStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSelectProductCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblProductCode;
    }
}