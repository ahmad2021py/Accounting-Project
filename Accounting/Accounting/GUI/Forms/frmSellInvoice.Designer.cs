
namespace Accounting.GUI.Forms
{
    partial class frmSellInvoice
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSellInvoiceCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bPersianCalenderTextBox1 = new BPersianCalender.BPersianCalenderTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSellCount = new System.Windows.Forms.TextBox();
            this.txtSellPricePerUnit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblStockCode = new System.Windows.Forms.Label();
            this.btnSelectProductInStock = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOff = new System.Windows.Forms.TextBox();
            this.SelectCustomer = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCustomerDebt = new System.Windows.Forms.Label();
            this.lblCustomerDebtWithThisSellInvoice = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInvoiceTotalPrice = new System.Windows.Forms.Label();
            this.lblTotaSellAmountWithOff = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalSellPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStockTotalQuantity = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "شماره فاکتور : ";
            // 
            // txtSellInvoiceCode
            // 
            this.txtSellInvoiceCode.Location = new System.Drawing.Point(142, 30);
            this.txtSellInvoiceCode.Multiline = true;
            this.txtSellInvoiceCode.Name = "txtSellInvoiceCode";
            this.txtSellInvoiceCode.Size = new System.Drawing.Size(168, 24);
            this.txtSellInvoiceCode.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "تاریخ فاکتور : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "کد مشتری : ";
            // 
            // bPersianCalenderTextBox1
            // 
            this.bPersianCalenderTextBox1.Location = new System.Drawing.Point(128, 87);
            this.bPersianCalenderTextBox1.Miladi = new System.DateTime(((long)(0)));
            this.bPersianCalenderTextBox1.Name = "bPersianCalenderTextBox1";
            this.bPersianCalenderTextBox1.NowDateSelected = false;
            this.bPersianCalenderTextBox1.ReadOnly = true;
            this.bPersianCalenderTextBox1.SelectedDate = null;
            this.bPersianCalenderTextBox1.Shamsi = null;
            this.bPersianCalenderTextBox1.Size = new System.Drawing.Size(155, 22);
            this.bPersianCalenderTextBox1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "بدهی قبلی با احتساب این فاکتور : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "کد کالای انباری : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "تعداد فروش : ";
            // 
            // txtSellCount
            // 
            this.txtSellCount.Location = new System.Drawing.Point(135, 321);
            this.txtSellCount.Multiline = true;
            this.txtSellCount.Name = "txtSellCount";
            this.txtSellCount.Size = new System.Drawing.Size(100, 25);
            this.txtSellCount.TabIndex = 0;
            // 
            // txtSellPricePerUnit
            // 
            this.txtSellPricePerUnit.Location = new System.Drawing.Point(192, 379);
            this.txtSellPricePerUnit.Multiline = true;
            this.txtSellPricePerUnit.Name = "txtSellPricePerUnit";
            this.txtSellPricePerUnit.Size = new System.Drawing.Size(169, 27);
            this.txtSellPricePerUnit.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "قیمت فروش  (هر واحد) : ";
            // 
            // lblStockCode
            // 
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCode.Location = new System.Drawing.Point(223, 191);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(110, 24);
            this.lblStockCode.TabIndex = 1;
            this.lblStockCode.Text = "کد کالای انتخابی";
            // 
            // btnSelectProductInStock
            // 
            this.btnSelectProductInStock.Location = new System.Drawing.Point(128, 193);
            this.btnSelectProductInStock.Name = "btnSelectProductInStock";
            this.btnSelectProductInStock.Size = new System.Drawing.Size(75, 23);
            this.btnSelectProductInStock.TabIndex = 4;
            this.btnSelectProductInStock.Text = "انتخاب";
            this.btnSelectProductInStock.UseVisualStyleBackColor = true;
            this.btnSelectProductInStock.Click += new System.EventHandler(this.btnSelectProductInStock_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "تخفیف (درصد) : ";
            // 
            // txtOff
            // 
            this.txtOff.Location = new System.Drawing.Point(190, 440);
            this.txtOff.Multiline = true;
            this.txtOff.Name = "txtOff";
            this.txtOff.Size = new System.Drawing.Size(171, 27);
            this.txtOff.TabIndex = 0;
            // 
            // SelectCustomer
            // 
            this.SelectCustomer.Location = new System.Drawing.Point(128, 138);
            this.SelectCustomer.Name = "SelectCustomer";
            this.SelectCustomer.Size = new System.Drawing.Size(75, 23);
            this.SelectCustomer.TabIndex = 5;
            this.SelectCustomer.Text = "انتخاب";
            this.SelectCustomer.UseVisualStyleBackColor = true;
            this.SelectCustomer.Click += new System.EventHandler(this.SelectCustomer_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(438, 341);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(112, 39);
            this.btnCommit.TabIndex = 6;
            this.btnCommit.Text = "ثبت فاکتور";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCode.Location = new System.Drawing.Point(223, 137);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(71, 24);
            this.lblCustomerCode.TabIndex = 1;
            this.lblCustomerCode.Text = "کد مشتری";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(438, 287);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 39);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "محاسبه";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCustomerDebt);
            this.groupBox1.Controls.Add(this.lblCustomerDebtWithThisSellInvoice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(438, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشتری ";
            // 
            // lblCustomerDebt
            // 
            this.lblCustomerDebt.AutoSize = true;
            this.lblCustomerDebt.Location = new System.Drawing.Point(201, 35);
            this.lblCustomerDebt.Name = "lblCustomerDebt";
            this.lblCustomerDebt.Size = new System.Drawing.Size(0, 17);
            this.lblCustomerDebt.TabIndex = 3;
            // 
            // lblCustomerDebtWithThisSellInvoice
            // 
            this.lblCustomerDebtWithThisSellInvoice.AutoSize = true;
            this.lblCustomerDebtWithThisSellInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerDebtWithThisSellInvoice.Location = new System.Drawing.Point(178, 78);
            this.lblCustomerDebtWithThisSellInvoice.Name = "lblCustomerDebtWithThisSellInvoice";
            this.lblCustomerDebtWithThisSellInvoice.Size = new System.Drawing.Size(0, 24);
            this.lblCustomerDebtWithThisSellInvoice.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 24);
            this.label14.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(259, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(239, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "بدهی قبلی بدون احتساب این فاکتور : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInvoiceTotalPrice);
            this.groupBox2.Controls.Add(this.lblTotaSellAmountWithOff);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblTotalSellPrice);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(448, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 110);
            this.groupBox2.TabIndex = 8;
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
            // lblTotaSellAmountWithOff
            // 
            this.lblTotaSellAmountWithOff.AutoSize = true;
            this.lblTotaSellAmountWithOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaSellAmountWithOff.Location = new System.Drawing.Point(96, 70);
            this.lblTotaSellAmountWithOff.Name = "lblTotaSellAmountWithOff";
            this.lblTotaSellAmountWithOff.Size = new System.Drawing.Size(0, 24);
            this.lblTotaSellAmountWithOff.TabIndex = 3;
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
            // lblTotalSellPrice
            // 
            this.lblTotalSellPrice.AutoSize = true;
            this.lblTotalSellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSellPrice.Location = new System.Drawing.Point(151, 18);
            this.lblTotalSellPrice.Name = "lblTotalSellPrice";
            this.lblTotalSellPrice.Size = new System.Drawing.Size(0, 24);
            this.lblTotalSellPrice.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(362, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "کل مبلغ فروش : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "تعدا موجود  :";
            // 
            // lblStockTotalQuantity
            // 
            this.lblStockTotalQuantity.AutoSize = true;
            this.lblStockTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockTotalQuantity.Location = new System.Drawing.Point(131, 246);
            this.lblStockTotalQuantity.Name = "lblStockTotalQuantity";
            this.lblStockTotalQuantity.Size = new System.Drawing.Size(76, 24);
            this.lblStockTotalQuantity.TabIndex = 1;
            this.lblStockTotalQuantity.Text = "تعدا موجود";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSellInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.SelectCustomer);
            this.Controls.Add(this.btnSelectProductInStock);
            this.Controls.Add(this.bPersianCalenderTextBox1);
            this.Controls.Add(this.lblCustomerCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOff);
            this.Controls.Add(this.txtSellPricePerUnit);
            this.Controls.Add(this.txtSellCount);
            this.Controls.Add(this.txtSellInvoiceCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblStockCode);
            this.Controls.Add(this.lblStockTotalQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.Name = "frmSellInvoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فاکتور فروش";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSellInvoiceCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private BPersianCalender.BPersianCalenderTextBox bPersianCalenderTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSellCount;
        private System.Windows.Forms.TextBox txtSellPricePerUnit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblStockCode;
        private System.Windows.Forms.Button btnSelectProductInStock;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOff;
        private System.Windows.Forms.Button SelectCustomer;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblInvoiceTotalPrice;
        private System.Windows.Forms.Label lblTotaSellAmountWithOff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotalSellPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCustomerDebtWithThisSellInvoice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCustomerDebt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStockTotalQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}