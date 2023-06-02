namespace Accounting.GUI.Forms
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتکاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستکاربرانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.محصولاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشوثبتمحصولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستمحصولاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دستهبندیمحصولاتToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hihdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشتریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشوثبتمشتریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستمشتریانToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشوثبتکالاهادرانبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستکالاهایانبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتفاکتورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فروشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خریدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازگشتازخریدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازگشتازخریدToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.دستهبندیوشرکتهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دستهبندیمحصولاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستشرکتهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دیگرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جزئیاتورودToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.چکهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتچکToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعاتچکهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblThisDay = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.خروجToolStripMenuItem,
            this.کاربرانToolStripMenuItem,
            this.محصولاتToolStripMenuItem,
            this.مشتریToolStripMenuItem,
            this.انبارToolStripMenuItem,
            this.دستهبندیوشرکتهاToolStripMenuItem,
            this.ثبتفاکتورToolStripMenuItem,
            this.چکهاToolStripMenuItem,
            this.دیگرToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_exit_sign_128px;
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // کاربرانToolStripMenuItem
            // 
            this.کاربرانToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتکاربرانToolStripMenuItem,
            this.لیستکاربرانToolStripMenuItem});
            this.کاربرانToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_team_48px;
            this.کاربرانToolStripMenuItem.Name = "کاربرانToolStripMenuItem";
            this.کاربرانToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.کاربرانToolStripMenuItem.Text = "کاربران";
            // 
            // مدیریتکاربرانToolStripMenuItem
            // 
            this.مدیریتکاربرانToolStripMenuItem.Name = "مدیریتکاربرانToolStripMenuItem";
            this.مدیریتکاربرانToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.مدیریتکاربرانToolStripMenuItem.Text = "مدیریت کاربران";
            this.مدیریتکاربرانToolStripMenuItem.Click += new System.EventHandler(this.مدیریتکاربرانToolStripMenuItem_Click);
            // 
            // لیستکاربرانToolStripMenuItem
            // 
            this.لیستکاربرانToolStripMenuItem.Name = "لیستکاربرانToolStripMenuItem";
            this.لیستکاربرانToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.لیستکاربرانToolStripMenuItem.Text = "لیست کاربران";
            this.لیستکاربرانToolStripMenuItem.Click += new System.EventHandler(this.لیستکاربرانToolStripMenuItem_Click);
            // 
            // محصولاتToolStripMenuItem
            // 
            this.محصولاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشوثبتمحصولToolStripMenuItem,
            this.لیستمحصولاتToolStripMenuItem,
            this.دستهبندیمحصولاتToolStripMenuItem1,
            this.hihdToolStripMenuItem});
            this.محصولاتToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_product_128px_2;
            this.محصولاتToolStripMenuItem.Name = "محصولاتToolStripMenuItem";
            this.محصولاتToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.محصولاتToolStripMenuItem.Text = "محصولات";
            // 
            // ویرایشوثبتمحصولToolStripMenuItem
            // 
            this.ویرایشوثبتمحصولToolStripMenuItem.Name = "ویرایشوثبتمحصولToolStripMenuItem";
            this.ویرایشوثبتمحصولToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.ویرایشوثبتمحصولToolStripMenuItem.Text = "ویرایش و ثبت محصول";
            this.ویرایشوثبتمحصولToolStripMenuItem.Click += new System.EventHandler(this.ویرایشوثبتمحصولToolStripMenuItem_Click);
            // 
            // لیستمحصولاتToolStripMenuItem
            // 
            this.لیستمحصولاتToolStripMenuItem.Name = "لیستمحصولاتToolStripMenuItem";
            this.لیستمحصولاتToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.لیستمحصولاتToolStripMenuItem.Text = "لیست محصولات";
            this.لیستمحصولاتToolStripMenuItem.Click += new System.EventHandler(this.لیستمحصولاتToolStripMenuItem_Click);
            // 
            // دستهبندیمحصولاتToolStripMenuItem1
            // 
            this.دستهبندیمحصولاتToolStripMenuItem1.Image = global::Accounting.Properties.Resources.Category;
            this.دستهبندیمحصولاتToolStripMenuItem1.Name = "دستهبندیمحصولاتToolStripMenuItem1";
            this.دستهبندیمحصولاتToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.دستهبندیمحصولاتToolStripMenuItem1.Text = "دسته بندی محصولات";
            this.دستهبندیمحصولاتToolStripMenuItem1.Click += new System.EventHandler(this.دستهبندیمحصولاتToolStripMenuItem1_Click);
            // 
            // hihdToolStripMenuItem
            // 
            this.hihdToolStripMenuItem.Name = "hihdToolStripMenuItem";
            this.hihdToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.hihdToolStripMenuItem.Text = "محصولات فروخته شده";
            this.hihdToolStripMenuItem.Click += new System.EventHandler(this.hihdToolStripMenuItem_Click);
            // 
            // مشتریToolStripMenuItem
            // 
            this.مشتریToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشوثبتمشتریToolStripMenuItem,
            this.لیستمشتریانToolStripMenuItem});
            this.مشتریToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_budget_160px;
            this.مشتریToolStripMenuItem.Name = "مشتریToolStripMenuItem";
            this.مشتریToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.مشتریToolStripMenuItem.Text = "مشتری";
            // 
            // ویرایشوثبتمشتریToolStripMenuItem
            // 
            this.ویرایشوثبتمشتریToolStripMenuItem.Name = "ویرایشوثبتمشتریToolStripMenuItem";
            this.ویرایشوثبتمشتریToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.ویرایشوثبتمشتریToolStripMenuItem.Text = "ویرایش و ثبت مشتری";
            this.ویرایشوثبتمشتریToolStripMenuItem.Click += new System.EventHandler(this.ویرایشوثبتمشتریToolStripMenuItem_Click);
            // 
            // لیستمشتریانToolStripMenuItem
            // 
            this.لیستمشتریانToolStripMenuItem.Name = "لیستمشتریانToolStripMenuItem";
            this.لیستمشتریانToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.لیستمشتریانToolStripMenuItem.Text = "لیست مشتریان";
            this.لیستمشتریانToolStripMenuItem.Click += new System.EventHandler(this.لیستمشتریانToolStripMenuItem_Click);
            // 
            // انبارToolStripMenuItem
            // 
            this.انبارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشوثبتکالاهادرانبارToolStripMenuItem,
            this.لیستکالاهایانبارToolStripMenuItem});
            this.انبارToolStripMenuItem.Image = global::Accounting.Properties.Resources.Stock_Pic;
            this.انبارToolStripMenuItem.Name = "انبارToolStripMenuItem";
            this.انبارToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.انبارToolStripMenuItem.Text = "انبار";
            // 
            // ویرایشوثبتکالاهادرانبارToolStripMenuItem
            // 
            this.ویرایشوثبتکالاهادرانبارToolStripMenuItem.Name = "ویرایشوثبتکالاهادرانبارToolStripMenuItem";
            this.ویرایشوثبتکالاهادرانبارToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.ویرایشوثبتکالاهادرانبارToolStripMenuItem.Text = "ویرایش و ثبت کالاها در انبار";
            this.ویرایشوثبتکالاهادرانبارToolStripMenuItem.Click += new System.EventHandler(this.ویرایشوثبتکالاهادرانبارToolStripMenuItem_Click);
            // 
            // لیستکالاهایانبارToolStripMenuItem
            // 
            this.لیستکالاهایانبارToolStripMenuItem.Name = "لیستکالاهایانبارToolStripMenuItem";
            this.لیستکالاهایانبارToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.لیستکالاهایانبارToolStripMenuItem.Text = "لیست کالاهای انبار";
            this.لیستکالاهایانبارToolStripMenuItem.Click += new System.EventHandler(this.لیستکالاهایانبارToolStripMenuItem_Click);
            // 
            // ثبتفاکتورToolStripMenuItem
            // 
            this.ثبتفاکتورToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فروشToolStripMenuItem,
            this.خریدToolStripMenuItem,
            this.بازگشتازخریدToolStripMenuItem,
            this.بازگشتازخریدToolStripMenuItem1});
            this.ثبتفاکتورToolStripMenuItem.Name = "ثبتفاکتورToolStripMenuItem";
            this.ثبتفاکتورToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.ثبتفاکتورToolStripMenuItem.Text = "ثبت فاکتور";
            // 
            // فروشToolStripMenuItem
            // 
            this.فروشToolStripMenuItem.Name = "فروشToolStripMenuItem";
            this.فروشToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.فروشToolStripMenuItem.Text = "فروش";
            this.فروشToolStripMenuItem.Click += new System.EventHandler(this.فروشToolStripMenuItem_Click);
            // 
            // خریدToolStripMenuItem
            // 
            this.خریدToolStripMenuItem.Name = "خریدToolStripMenuItem";
            this.خریدToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.خریدToolStripMenuItem.Text = "خرید";
            // 
            // بازگشتازخریدToolStripMenuItem
            // 
            this.بازگشتازخریدToolStripMenuItem.Name = "بازگشتازخریدToolStripMenuItem";
            this.بازگشتازخریدToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.بازگشتازخریدToolStripMenuItem.Text = "بازگشت از فروش";
            // 
            // بازگشتازخریدToolStripMenuItem1
            // 
            this.بازگشتازخریدToolStripMenuItem1.Name = "بازگشتازخریدToolStripMenuItem1";
            this.بازگشتازخریدToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.بازگشتازخریدToolStripMenuItem1.Text = "بازگشت از خرید ";
            // 
            // دستهبندیوشرکتهاToolStripMenuItem
            // 
            this.دستهبندیوشرکتهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دستهبندیمحصولاتToolStripMenuItem,
            this.لیستشرکتهاToolStripMenuItem});
            this.دستهبندیوشرکتهاToolStripMenuItem.Image = global::Accounting.Properties.Resources.Company_256;
            this.دستهبندیوشرکتهاToolStripMenuItem.Name = "دستهبندیوشرکتهاToolStripMenuItem";
            this.دستهبندیوشرکتهاToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.دستهبندیوشرکتهاToolStripMenuItem.Text = "شرکت ها ";
            // 
            // دستهبندیمحصولاتToolStripMenuItem
            // 
            this.دستهبندیمحصولاتToolStripMenuItem.Name = "دستهبندیمحصولاتToolStripMenuItem";
            this.دستهبندیمحصولاتToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.دستهبندیمحصولاتToolStripMenuItem.Text = "ویرایش و ثبت شرکت";
            this.دستهبندیمحصولاتToolStripMenuItem.Click += new System.EventHandler(this.دستهبندیمحصولاتToolStripMenuItem_Click);
            // 
            // لیستشرکتهاToolStripMenuItem
            // 
            this.لیستشرکتهاToolStripMenuItem.Name = "لیستشرکتهاToolStripMenuItem";
            this.لیستشرکتهاToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.لیستشرکتهاToolStripMenuItem.Text = "لیست شرکت ها ";
            this.لیستشرکتهاToolStripMenuItem.Click += new System.EventHandler(this.لیستشرکتهاToolStripMenuItem_Click_1);
            // 
            // دیگرToolStripMenuItem
            // 
            this.دیگرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.جزئیاتورودToolStripMenuItem});
            this.دیگرToolStripMenuItem.Name = "دیگرToolStripMenuItem";
            this.دیگرToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.دیگرToolStripMenuItem.Text = "دیگر";
            // 
            // جزئیاتورودToolStripMenuItem
            // 
            this.جزئیاتورودToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_enter_80px;
            this.جزئیاتورودToolStripMenuItem.Name = "جزئیاتورودToolStripMenuItem";
            this.جزئیاتورودToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.جزئیاتورودToolStripMenuItem.Text = "جزئیات ورود";
            this.جزئیاتورودToolStripMenuItem.Click += new System.EventHandler(this.جزئیاتورودToolStripMenuItem_Click);
            // 
            // چکهاToolStripMenuItem
            // 
            this.چکهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتچکToolStripMenuItem,
            this.اطلاعاتچکهاToolStripMenuItem});
            this.چکهاToolStripMenuItem.Name = "چکهاToolStripMenuItem";
            this.چکهاToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.چکهاToolStripMenuItem.Text = "چک ها";
            // 
            // ثبتچکToolStripMenuItem
            // 
            this.ثبتچکToolStripMenuItem.Name = "ثبتچکToolStripMenuItem";
            this.ثبتچکToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ثبتچکToolStripMenuItem.Text = "ثبت چک";
            // 
            // اطلاعاتچکهاToolStripMenuItem
            // 
            this.اطلاعاتچکهاToolStripMenuItem.Name = "اطلاعاتچکهاToolStripMenuItem";
            this.اطلاعاتچکهاToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.اطلاعاتچکهاToolStripMenuItem.Text = "اطلاعات چک ها";
            // 
            // lblThisDay
            // 
            this.lblThisDay.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisDay.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblThisDay.Location = new System.Drawing.Point(231, 21);
            this.lblThisDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThisDay.Name = "lblThisDay";
            this.lblThisDay.Size = new System.Drawing.Size(85, 28);
            this.lblThisDay.TabIndex = 74;
            this.lblThisDay.Text = "lblThisDay";
            this.lblThisDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTime.Location = new System.Drawing.Point(7, 22);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(99, 28);
            this.lblTime.TabIndex = 74;
            this.lblTime.Text = "lblTime";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDate.Location = new System.Drawing.Point(146, 22);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 28);
            this.lblDate.TabIndex = 74;
            this.lblDate.Text = "lblDate";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblText.Location = new System.Drawing.Point(88, 24);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblText.Size = new System.Drawing.Size(57, 28);
            this.lblText.TabIndex = 74;
            this.lblText.Text = "ساعت :";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblText);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblThisDay);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(654, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 50);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تاریخ امروز";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::Accounting.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خانه";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        internal System.Windows.Forms.Label lblThisDay;
        internal System.Windows.Forms.Label lblTime;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem کاربرانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکاربرانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستکاربرانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem محصولاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ویرایشوثبتمحصولToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستمحصولاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشتریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ویرایشوثبتمشتریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستمشتریانToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ویرایشوثبتکالاهادرانبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستکالاهایانبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دستهبندیمحصولاتToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem دستهبندیوشرکتهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دستهبندیمحصولاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستشرکتهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دیگرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جزئیاتورودToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتفاکتورToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فروشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خریدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بازگشتازخریدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بازگشتازخریدToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem چکهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتچکToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتچکهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hihdToolStripMenuItem;
    }
}