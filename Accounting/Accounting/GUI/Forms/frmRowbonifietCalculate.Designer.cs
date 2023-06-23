
namespace Accounting.GUI.Forms
{
    partial class frmRowbonifietCalculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRowbonifietCalculate));
            this.txtPersianCalenderFrom = new BPersianCalender.BPersianCalenderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersianCalenderTo = new BPersianCalender.BPersianCalenderTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBenefit = new System.Windows.Forms.Label();
            this.lblAllSellQuantity = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(96, 196);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(221, 57);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "محاسبه سود / زیان";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBenefit
            // 
            this.lblBenefit.AutoSize = true;
            this.lblBenefit.Location = new System.Drawing.Point(288, 304);
            this.lblBenefit.Name = "lblBenefit";
            this.lblBenefit.Size = new System.Drawing.Size(0, 17);
            this.lblBenefit.TabIndex = 5;
            // 
            // lblAllSellQuantity
            // 
            this.lblAllSellQuantity.AutoSize = true;
            this.lblAllSellQuantity.Location = new System.Drawing.Point(299, 398);
            this.lblAllSellQuantity.Name = "lblAllSellQuantity";
            this.lblAllSellQuantity.Size = new System.Drawing.Size(0, 17);
            this.lblAllSellQuantity.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPersianCalenderFrom);
            this.groupBox1.Controls.Add(this.txtPersianCalenderTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بازه ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "سود/زیان ناخالص : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "کل تعداد فروش رفته : ";
            // 
            // frmRowbonifietCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAllSellQuantity);
            this.Controls.Add(this.lblBenefit);
            this.Controls.Add(this.btnCalculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRowbonifietCalculate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "سود/زیان ناخالص";
            this.Load += new System.EventHandler(this.frmRowbonifietCalculate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BPersianCalender.BPersianCalenderTextBox txtPersianCalenderFrom;
        private System.Windows.Forms.Label label1;
        private BPersianCalender.BPersianCalenderTextBox txtPersianCalenderTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBenefit;
        private System.Windows.Forms.Label lblAllSellQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}