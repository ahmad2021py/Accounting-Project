
namespace Accounting.GUI.Forms
{
    partial class frmReturnFromSellIncoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnFromSellIncoice));
            this.SelectCustomer = new System.Windows.Forms.Button();
            this.btnSelectProductInStock = new System.Windows.Forms.Button();
            this.bPersianCalenderTextBox1 = new BPersianCalender.BPersianCalenderTextBox();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductSoldCode = new System.Windows.Forms.TextBox();
            this.lblStockCode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReturnFromSell_Count = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotaRetunFrmSellAmoun = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReturnFromSell_UnitAmount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnSelectProductSoldCode = new System.Windows.Forms.Button();
            this.txtReturnFromSellInvoiceCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectCustomer
            // 
            this.SelectCustomer.Location = new System.Drawing.Point(130, 187);
            this.SelectCustomer.Name = "SelectCustomer";
            this.SelectCustomer.Size = new System.Drawing.Size(75, 23);
            this.SelectCustomer.TabIndex = 3;
            this.SelectCustomer.Text = "انتخاب";
            this.SelectCustomer.UseVisualStyleBackColor = true;
            this.SelectCustomer.Click += new System.EventHandler(this.SelectCustomer_Click);
            // 
            // btnSelectProductInStock
            // 
            this.btnSelectProductInStock.Location = new System.Drawing.Point(130, 242);
            this.btnSelectProductInStock.Name = "btnSelectProductInStock";
            this.btnSelectProductInStock.Size = new System.Drawing.Size(75, 23);
            this.btnSelectProductInStock.TabIndex = 4;
            this.btnSelectProductInStock.Text = "انتخاب";
            this.btnSelectProductInStock.UseVisualStyleBackColor = true;
            this.btnSelectProductInStock.Click += new System.EventHandler(this.btnSelectProductInStock_Click);
            // 
            // bPersianCalenderTextBox1
            // 
            this.bPersianCalenderTextBox1.Location = new System.Drawing.Point(130, 136);
            this.bPersianCalenderTextBox1.Miladi = new System.DateTime(((long)(0)));
            this.bPersianCalenderTextBox1.Name = "bPersianCalenderTextBox1";
            this.bPersianCalenderTextBox1.NowDateSelected = false;
            this.bPersianCalenderTextBox1.ReadOnly = true;
            this.bPersianCalenderTextBox1.SelectedDate = null;
            this.bPersianCalenderTextBox1.Shamsi = null;
            this.bPersianCalenderTextBox1.Size = new System.Drawing.Size(155, 22);
            this.bPersianCalenderTextBox1.TabIndex = 2;
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCode.Location = new System.Drawing.Point(225, 186);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(0, 24);
            this.lblCustomerCode.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "کد مشتری : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "تاریخ فاکتور : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "شماره فاکتور بازگشت از فروش : ";
            // 
            // txtProductSoldCode
            // 
            this.txtProductSoldCode.Location = new System.Drawing.Point(275, 84);
            this.txtProductSoldCode.Multiline = true;
            this.txtProductSoldCode.Name = "txtProductSoldCode";
            this.txtProductSoldCode.ReadOnly = true;
            this.txtProductSoldCode.Size = new System.Drawing.Size(116, 24);
            this.txtProductSoldCode.TabIndex = 100;
            // 
            // lblStockCode
            // 
            this.lblStockCode.AutoSize = true;
            this.lblStockCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockCode.Location = new System.Drawing.Point(225, 240);
            this.lblStockCode.Name = "lblStockCode";
            this.lblStockCode.Size = new System.Drawing.Size(0, 24);
            this.lblStockCode.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "کد کالای انباری : ";
            // 
            // txtReturnFromSell_Count
            // 
            this.txtReturnFromSell_Count.Location = new System.Drawing.Point(196, 299);
            this.txtReturnFromSell_Count.Multiline = true;
            this.txtReturnFromSell_Count.Name = "txtReturnFromSell_Count";
            this.txtReturnFromSell_Count.Size = new System.Drawing.Size(100, 25);
            this.txtReturnFromSell_Count.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "تعداد بازگشت از فروش : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotaRetunFrmSellAmoun);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(402, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 110);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فاکتور";
            // 
            // lblTotaRetunFrmSellAmoun
            // 
            this.lblTotaRetunFrmSellAmoun.AutoSize = true;
            this.lblTotaRetunFrmSellAmoun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaRetunFrmSellAmoun.Location = new System.Drawing.Point(17, 67);
            this.lblTotaRetunFrmSellAmoun.Name = "lblTotaRetunFrmSellAmoun";
            this.lblTotaRetunFrmSellAmoun.Size = new System.Drawing.Size(0, 24);
            this.lblTotaRetunFrmSellAmoun.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(186, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "کل قیمت بازگشتی از فروش :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "قیمت فروخته شده (هر واحد) : ";
            // 
            // txtReturnFromSell_UnitAmount
            // 
            this.txtReturnFromSell_UnitAmount.Location = new System.Drawing.Point(226, 365);
            this.txtReturnFromSell_UnitAmount.Multiline = true;
            this.txtReturnFromSell_UnitAmount.Name = "txtReturnFromSell_UnitAmount";
            this.txtReturnFromSell_UnitAmount.Size = new System.Drawing.Size(100, 25);
            this.txtReturnFromSell_UnitAmount.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(402, 157);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 42);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "محاسبه";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.Location = new System.Drawing.Point(402, 227);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(106, 42);
            this.btnCommit.TabIndex = 8;
            this.btnCommit.Text = "ثبت";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnSelectProductSoldCode
            // 
            this.btnSelectProductSoldCode.Location = new System.Drawing.Point(190, 85);
            this.btnSelectProductSoldCode.Name = "btnSelectProductSoldCode";
            this.btnSelectProductSoldCode.Size = new System.Drawing.Size(75, 23);
            this.btnSelectProductSoldCode.TabIndex = 1;
            this.btnSelectProductSoldCode.Text = "انتخاب";
            this.btnSelectProductSoldCode.UseVisualStyleBackColor = true;
            this.btnSelectProductSoldCode.Click += new System.EventHandler(this.btnSelectSellInviceCode_Click);
            // 
            // txtReturnFromSellInvoiceCode
            // 
            this.txtReturnFromSellInvoiceCode.Location = new System.Drawing.Point(264, 27);
            this.txtReturnFromSellInvoiceCode.Multiline = true;
            this.txtReturnFromSellInvoiceCode.Name = "txtReturnFromSellInvoiceCode";
            this.txtReturnFromSellInvoiceCode.Size = new System.Drawing.Size(116, 24);
            this.txtReturnFromSellInvoiceCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "کد محصول فروخته شده : ";
            // 
            // frmReturnFromSellIncoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtReturnFromSell_UnitAmount);
            this.Controls.Add(this.txtReturnFromSell_Count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSelectProductSoldCode);
            this.Controls.Add(this.SelectCustomer);
            this.Controls.Add(this.btnSelectProductInStock);
            this.Controls.Add(this.bPersianCalenderTextBox1);
            this.Controls.Add(this.lblCustomerCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReturnFromSellInvoiceCode);
            this.Controls.Add(this.txtProductSoldCode);
            this.Controls.Add(this.lblStockCode);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReturnFromSellIncoice";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "بازگشت از فروش";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectCustomer;
        private System.Windows.Forms.Button btnSelectProductInStock;
        private BPersianCalender.BPersianCalenderTextBox bPersianCalenderTextBox1;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductSoldCode;
        private System.Windows.Forms.Label lblStockCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReturnFromSell_Count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotaRetunFrmSellAmoun;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReturnFromSell_UnitAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnSelectProductSoldCode;
        private System.Windows.Forms.TextBox txtReturnFromSellInvoiceCode;
        private System.Windows.Forms.Label label1;
    }
}