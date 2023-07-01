
namespace Accounting.GUI.Forms
{
    partial class frmOperationBenefitCalculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperationBenefitCalculate));
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersianCalenderFrom = new BPersianCalender.BPersianCalenderTextBox();
            this.txtPersianCalenderTo = new BPersianCalender.BPersianCalenderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAllSellQuantity = new System.Windows.Forms.Label();
            this.lblBenefit = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtCostOfOperations = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "تا تاریخ";
            // 
            // txtPersianCalenderFrom
            // 
            this.txtPersianCalenderFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersianCalenderFrom.Location = new System.Drawing.Point(18, 22);
            this.txtPersianCalenderFrom.Miladi = new System.DateTime(((long)(0)));
            this.txtPersianCalenderFrom.Name = "txtPersianCalenderFrom";
            this.txtPersianCalenderFrom.NowDateSelected = false;
            this.txtPersianCalenderFrom.ReadOnly = true;
            this.txtPersianCalenderFrom.SelectedDate = null;
            this.txtPersianCalenderFrom.Shamsi = null;
            this.txtPersianCalenderFrom.Size = new System.Drawing.Size(191, 34);
            this.txtPersianCalenderFrom.TabIndex = 2;
            // 
            // txtPersianCalenderTo
            // 
            this.txtPersianCalenderTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersianCalenderTo.Location = new System.Drawing.Point(18, 91);
            this.txtPersianCalenderTo.Miladi = new System.DateTime(((long)(0)));
            this.txtPersianCalenderTo.Name = "txtPersianCalenderTo";
            this.txtPersianCalenderTo.NowDateSelected = false;
            this.txtPersianCalenderTo.ReadOnly = true;
            this.txtPersianCalenderTo.SelectedDate = null;
            this.txtPersianCalenderTo.Shamsi = null;
            this.txtPersianCalenderTo.Size = new System.Drawing.Size(191, 34);
            this.txtPersianCalenderTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "از تاریخ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "کل تعداد فروش رفته : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "سود/زیان عملیاتی : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPersianCalenderFrom);
            this.groupBox1.Controls.Add(this.txtPersianCalenderTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 142);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بازه ";
            // 
            // lblAllSellQuantity
            // 
            this.lblAllSellQuantity.AutoSize = true;
            this.lblAllSellQuantity.Location = new System.Drawing.Point(299, 487);
            this.lblAllSellQuantity.Name = "lblAllSellQuantity";
            this.lblAllSellQuantity.Size = new System.Drawing.Size(0, 17);
            this.lblAllSellQuantity.TabIndex = 9;
            // 
            // lblBenefit
            // 
            this.lblBenefit.AutoSize = true;
            this.lblBenefit.Location = new System.Drawing.Point(288, 393);
            this.lblBenefit.Name = "lblBenefit";
            this.lblBenefit.Size = new System.Drawing.Size(0, 17);
            this.lblBenefit.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(29, 274);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(221, 57);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "محاسبه سود / زیان";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtCostOfOperations
            // 
            this.txtCostOfOperations.Location = new System.Drawing.Point(211, 195);
            this.txtCostOfOperations.Multiline = true;
            this.txtCostOfOperations.Name = "txtCostOfOperations";
            this.txtCostOfOperations.Size = new System.Drawing.Size(325, 31);
            this.txtCostOfOperations.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "هزینه های عملیاتی : ";
            // 
            // frmOperationBenefitCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 545);
            this.Controls.Add(this.txtCostOfOperations);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAllSellQuantity);
            this.Controls.Add(this.lblBenefit);
            this.Controls.Add(this.btnCalculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOperationBenefitCalculate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "محاسبه سود عملیاتی";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private BPersianCalender.BPersianCalenderTextBox txtPersianCalenderFrom;
        private BPersianCalender.BPersianCalenderTextBox txtPersianCalenderTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAllSellQuantity;
        private System.Windows.Forms.Label lblBenefit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtCostOfOperations;
        private System.Windows.Forms.Label label5;
    }
}