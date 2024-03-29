﻿
namespace Accounting.GUI.Forms
{
    partial class frmSeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeller));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcreditor = new System.Windows.Forms.TextBox();
            this.txtdebtor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSellerEmail = new System.Windows.Forms.TextBox();
            this.txtSellerAddress = new System.Windows.Forms.TextBox();
            this.txtSellerZipCode = new System.Windows.Forms.TextBox();
            this.txtSellerCity = new System.Windows.Forms.TextBox();
            this.txtSellerPhone = new System.Windows.Forms.TextBox();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.cbStates = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShowfmSallerRecords = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txtcreditor);
            this.groupBox1.Controls.Add(this.txtdebtor);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSellerEmail);
            this.groupBox1.Controls.Add(this.txtSellerAddress);
            this.groupBox1.Controls.Add(this.txtSellerZipCode);
            this.groupBox1.Controls.Add(this.txtSellerCity);
            this.groupBox1.Controls.Add(this.txtSellerPhone);
            this.groupBox1.Controls.Add(this.txtSellerName);
            this.groupBox1.Controls.Add(this.txtNationalCode);
            this.groupBox1.Controls.Add(this.cbStates);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PasswordLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(17, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(984, 497);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ویرایش و ثبت فروشنده";
            // 
            // txtcreditor
            // 
            this.txtcreditor.Location = new System.Drawing.Point(197, 95);
            this.txtcreditor.Multiline = true;
            this.txtcreditor.Name = "txtcreditor";
            this.txtcreditor.Size = new System.Drawing.Size(284, 28);
            this.txtcreditor.TabIndex = 10;
            // 
            // txtdebtor
            // 
            this.txtdebtor.Location = new System.Drawing.Point(197, 29);
            this.txtdebtor.Multiline = true;
            this.txtdebtor.Name = "txtdebtor";
            this.txtdebtor.Size = new System.Drawing.Size(284, 28);
            this.txtdebtor.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(485, 95);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 28);
            this.label9.TabIndex = 87;
            this.label9.Text = "بستانکار : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(488, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 28);
            this.label8.TabIndex = 87;
            this.label8.Text = "بدهکار : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSellerEmail
            // 
            this.txtSellerEmail.Location = new System.Drawing.Point(628, 168);
            this.txtSellerEmail.Multiline = true;
            this.txtSellerEmail.Name = "txtSellerEmail";
            this.txtSellerEmail.Size = new System.Drawing.Size(232, 28);
            this.txtSellerEmail.TabIndex = 4;
            // 
            // txtSellerAddress
            // 
            this.txtSellerAddress.Location = new System.Drawing.Point(550, 364);
            this.txtSellerAddress.Multiline = true;
            this.txtSellerAddress.Name = "txtSellerAddress";
            this.txtSellerAddress.Size = new System.Drawing.Size(310, 103);
            this.txtSellerAddress.TabIndex = 8;
            // 
            // txtSellerZipCode
            // 
            this.txtSellerZipCode.Location = new System.Drawing.Point(628, 317);
            this.txtSellerZipCode.Multiline = true;
            this.txtSellerZipCode.Name = "txtSellerZipCode";
            this.txtSellerZipCode.Size = new System.Drawing.Size(232, 28);
            this.txtSellerZipCode.TabIndex = 7;
            // 
            // txtSellerCity
            // 
            this.txtSellerCity.Location = new System.Drawing.Point(626, 264);
            this.txtSellerCity.Multiline = true;
            this.txtSellerCity.Name = "txtSellerCity";
            this.txtSellerCity.Size = new System.Drawing.Size(232, 28);
            this.txtSellerCity.TabIndex = 6;
            // 
            // txtSellerPhone
            // 
            this.txtSellerPhone.Location = new System.Drawing.Point(628, 116);
            this.txtSellerPhone.Multiline = true;
            this.txtSellerPhone.Name = "txtSellerPhone";
            this.txtSellerPhone.Size = new System.Drawing.Size(232, 28);
            this.txtSellerPhone.TabIndex = 3;
            // 
            // txtSellerName
            // 
            this.txtSellerName.Location = new System.Drawing.Point(626, 69);
            this.txtSellerName.Multiline = true;
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(232, 28);
            this.txtSellerName.TabIndex = 2;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(626, 29);
            this.txtNationalCode.Multiline = true;
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(232, 28);
            this.txtNationalCode.TabIndex = 1;
            // 
            // cbStates
            // 
            this.cbStates.FormattingEnabled = true;
            this.cbStates.Location = new System.Drawing.Point(626, 222);
            this.cbStates.Name = "cbStates";
            this.cbStates.Size = new System.Drawing.Size(234, 26);
            this.cbStates.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(874, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 84;
            this.label3.Text = "کد ملی : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnShowfmSallerRecords);
            this.groupBox2.Location = new System.Drawing.Point(21, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 387);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 8);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(97, 54);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 54);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 54);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 54);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "بروزرسانی";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShowfmSallerRecords
            // 
            this.btnShowfmSallerRecords.Location = new System.Drawing.Point(15, 303);
            this.btnShowfmSallerRecords.Name = "btnShowfmSallerRecords";
            this.btnShowfmSallerRecords.Size = new System.Drawing.Size(97, 54);
            this.btnShowfmSallerRecords.TabIndex = 15;
            this.btnShowfmSallerRecords.Text = "لیست فروشندگان";
            this.btnShowfmSallerRecords.UseVisualStyleBackColor = true;
            this.btnShowfmSallerRecords.Click += new System.EventHandler(this.btnShowfmSallerRecords_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(869, 312);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 28);
            this.label7.TabIndex = 80;
            this.label7.Text = "کد پستی : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(875, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 28);
            this.label6.TabIndex = 80;
            this.label6.Text = "شهر : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(883, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 80;
            this.label5.Text = "استان : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(877, 359);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 80;
            this.label1.Text = "آدرس : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(881, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 80;
            this.label4.Text = "ایمیل : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(877, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 80;
            this.label2.Text = "تلفن :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordLabel.Location = new System.Drawing.Point(874, 64);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(103, 28);
            this.PasswordLabel.TabIndex = 78;
            this.PasswordLabel.Text = "نام فروشنده : ";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 546);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSeller";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "فروشنده";
            this.Load += new System.EventHandler(this.frmSeller_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcreditor;
        private System.Windows.Forms.TextBox txtdebtor;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSellerEmail;
        private System.Windows.Forms.TextBox txtSellerAddress;
        private System.Windows.Forms.TextBox txtSellerZipCode;
        private System.Windows.Forms.TextBox txtSellerCity;
        private System.Windows.Forms.TextBox txtSellerPhone;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.TextBox txtNationalCode;
        public System.Windows.Forms.ComboBox cbStates;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShowfmSallerRecords;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label PasswordLabel;
    }
}