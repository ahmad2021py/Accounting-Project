﻿namespace Accounting.GUI.Forms
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
            this.محصولاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشوثبتمحصولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دستهبندیمحصولاتToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.شرکتتولیدکنندهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشوثبتکالاهادرانبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشتریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشوثبتمشتریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ویرایشوثبتفروشندهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتفاکتورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فروشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خریدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازگشتازخریدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازگشتازخریدToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.محاسبهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سودخالصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سودعملیاتیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستفاکتورهایخریدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستفاکتورهایبازگشتازخریدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستفاکتورهایفروشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستفاکتورهایبازگشتازفروشToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستشرکتهاToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.لیسامحصولاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستکالاهایانبارToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستمشتریانToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستفروشندگانToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.اطلاعاتچکهاToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.دیگرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتچکهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جزئیاتورودToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتکاربرانToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.لیستکاربرانToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblThisDay = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.piBoxBackground = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piBoxBackground)).BeginInit();
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
            this.محصولاتToolStripMenuItem,
            this.انبارToolStripMenuItem,
            this.مشتریToolStripMenuItem,
            this.ثبتفاکتورToolStripMenuItem,
            this.محاسبهToolStripMenuItem,
            this.لیستهاToolStripMenuItem,
            this.دیگرToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 33);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // محصولاتToolStripMenuItem
            // 
            this.محصولاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشوثبتمحصولToolStripMenuItem,
            this.دستهبندیمحصولاتToolStripMenuItem1,
            this.شرکتتولیدکنندهToolStripMenuItem});
            this.محصولاتToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.محصولاتToolStripMenuItem.Name = "محصولاتToolStripMenuItem";
            this.محصولاتToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.محصولاتToolStripMenuItem.Text = "کالا / محصولات";
            // 
            // ویرایشوثبتمحصولToolStripMenuItem
            // 
            this.ویرایشوثبتمحصولToolStripMenuItem.Name = "ویرایشوثبتمحصولToolStripMenuItem";
            this.ویرایشوثبتمحصولToolStripMenuItem.Size = new System.Drawing.Size(273, 30);
            this.ویرایشوثبتمحصولToolStripMenuItem.Text = "ویرایش و ثبت محصول";
            this.ویرایشوثبتمحصولToolStripMenuItem.Click += new System.EventHandler(this.ویرایشوثبتمحصولToolStripMenuItem_Click);
            // 
            // دستهبندیمحصولاتToolStripMenuItem1
            // 
            this.دستهبندیمحصولاتToolStripMenuItem1.Name = "دستهبندیمحصولاتToolStripMenuItem1";
            this.دستهبندیمحصولاتToolStripMenuItem1.Size = new System.Drawing.Size(273, 30);
            this.دستهبندیمحصولاتToolStripMenuItem1.Text = "دسته بندی محصولات";
            this.دستهبندیمحصولاتToolStripMenuItem1.Click += new System.EventHandler(this.دستهبندیمحصولاتToolStripMenuItem1_Click);
            // 
            // شرکتتولیدکنندهToolStripMenuItem
            // 
            this.شرکتتولیدکنندهToolStripMenuItem.Name = "شرکتتولیدکنندهToolStripMenuItem";
            this.شرکتتولیدکنندهToolStripMenuItem.Size = new System.Drawing.Size(273, 30);
            this.شرکتتولیدکنندهToolStripMenuItem.Text = "ویرایش و ثبت شرکت";
            this.شرکتتولیدکنندهToolStripMenuItem.Click += new System.EventHandler(this.شرکتتولیدکنندهToolStripMenuItem_Click);
            // 
            // انبارToolStripMenuItem
            // 
            this.انبارToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشوثبتکالاهادرانبارToolStripMenuItem});
            this.انبارToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.انبارToolStripMenuItem.Name = "انبارToolStripMenuItem";
            this.انبارToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.انبارToolStripMenuItem.Text = "موجودی";
            // 
            // ویرایشوثبتکالاهادرانبارToolStripMenuItem
            // 
            this.ویرایشوثبتکالاهادرانبارToolStripMenuItem.Name = "ویرایشوثبتکالاهادرانبارToolStripMenuItem";
            this.ویرایشوثبتکالاهادرانبارToolStripMenuItem.Size = new System.Drawing.Size(311, 30);
            this.ویرایشوثبتکالاهادرانبارToolStripMenuItem.Text = "ویرایش و ثبت کالاها در انبار";
            this.ویرایشوثبتکالاهادرانبارToolStripMenuItem.Click += new System.EventHandler(this.ویرایشوثبتکالاهادرانبارToolStripMenuItem_Click);
            // 
            // مشتریToolStripMenuItem
            // 
            this.مشتریToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشوثبتمشتریToolStripMenuItem,
            this.ویرایشوثبتفروشندهToolStripMenuItem});
            this.مشتریToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.مشتریToolStripMenuItem.Name = "مشتریToolStripMenuItem";
            this.مشتریToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.مشتریToolStripMenuItem.Text = "طرف حساب";
            // 
            // ویرایشوثبتمشتریToolStripMenuItem
            // 
            this.ویرایشوثبتمشتریToolStripMenuItem.Name = "ویرایشوثبتمشتریToolStripMenuItem";
            this.ویرایشوثبتمشتریToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.ویرایشوثبتمشتریToolStripMenuItem.Text = "ویرایش و ثبت مشتری";
            this.ویرایشوثبتمشتریToolStripMenuItem.Click += new System.EventHandler(this.ویرایشوثبتمشتریToolStripMenuItem_Click);
            // 
            // ویرایشوثبتفروشندهToolStripMenuItem
            // 
            this.ویرایشوثبتفروشندهToolStripMenuItem.Name = "ویرایشوثبتفروشندهToolStripMenuItem";
            this.ویرایشوثبتفروشندهToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.ویرایشوثبتفروشندهToolStripMenuItem.Text = "ویرایش و ثبت فروشنده";
            this.ویرایشوثبتفروشندهToolStripMenuItem.Click += new System.EventHandler(this.ویرایشوثبتفروشندهToolStripMenuItem_Click);
            // 
            // ثبتفاکتورToolStripMenuItem
            // 
            this.ثبتفاکتورToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فروشToolStripMenuItem,
            this.خریدToolStripMenuItem,
            this.بازگشتازخریدToolStripMenuItem,
            this.بازگشتازخریدToolStripMenuItem1});
            this.ثبتفاکتورToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ثبتفاکتورToolStripMenuItem.Name = "ثبتفاکتورToolStripMenuItem";
            this.ثبتفاکتورToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.ثبتفاکتورToolStripMenuItem.Text = "ثبت فاکتور/سند";
            // 
            // فروشToolStripMenuItem
            // 
            this.فروشToolStripMenuItem.Name = "فروشToolStripMenuItem";
            this.فروشToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.فروشToolStripMenuItem.Text = "فروش";
            this.فروشToolStripMenuItem.Click += new System.EventHandler(this.فروشToolStripMenuItem_Click);
            // 
            // خریدToolStripMenuItem
            // 
            this.خریدToolStripMenuItem.Name = "خریدToolStripMenuItem";
            this.خریدToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.خریدToolStripMenuItem.Text = "خرید";
            this.خریدToolStripMenuItem.Click += new System.EventHandler(this.خریدToolStripMenuItem_Click);
            // 
            // بازگشتازخریدToolStripMenuItem
            // 
            this.بازگشتازخریدToolStripMenuItem.Name = "بازگشتازخریدToolStripMenuItem";
            this.بازگشتازخریدToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.بازگشتازخریدToolStripMenuItem.Text = "بازگشت از فروش";
            this.بازگشتازخریدToolStripMenuItem.Click += new System.EventHandler(this.بازگشتازخریدToolStripMenuItem_Click);
            // 
            // بازگشتازخریدToolStripMenuItem1
            // 
            this.بازگشتازخریدToolStripMenuItem1.Name = "بازگشتازخریدToolStripMenuItem1";
            this.بازگشتازخریدToolStripMenuItem1.Size = new System.Drawing.Size(229, 30);
            this.بازگشتازخریدToolStripMenuItem1.Text = "بازگشت از خرید ";
            this.بازگشتازخریدToolStripMenuItem1.Click += new System.EventHandler(this.بازگشتازخریدToolStripMenuItem1_Click);
            // 
            // محاسبهToolStripMenuItem
            // 
            this.محاسبهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.سودخالصToolStripMenuItem,
            this.سودعملیاتیToolStripMenuItem});
            this.محاسبهToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.محاسبهToolStripMenuItem.Name = "محاسبهToolStripMenuItem";
            this.محاسبهToolStripMenuItem.Size = new System.Drawing.Size(177, 29);
            this.محاسبهToolStripMenuItem.Text = "محاسبه سود / زیان";
            this.محاسبهToolStripMenuItem.Click += new System.EventHandler(this.محاسبهToolStripMenuItem_Click);
            // 
            // سودخالصToolStripMenuItem
            // 
            this.سودخالصToolStripMenuItem.Name = "سودخالصToolStripMenuItem";
            this.سودخالصToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.سودخالصToolStripMenuItem.Text = "سود ناخالص";
            this.سودخالصToolStripMenuItem.Click += new System.EventHandler(this.سودخالصToolStripMenuItem_Click);
            // 
            // سودعملیاتیToolStripMenuItem
            // 
            this.سودعملیاتیToolStripMenuItem.Name = "سودعملیاتیToolStripMenuItem";
            this.سودعملیاتیToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.سودعملیاتیToolStripMenuItem.Text = "سود عملیاتی";
            this.سودعملیاتیToolStripMenuItem.Click += new System.EventHandler(this.سودعملیاتیToolStripMenuItem_Click);
            // 
            // لیستهاToolStripMenuItem
            // 
            this.لیستهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.لیستفاکتورهایخریدToolStripMenuItem,
            this.لیستفاکتورهایبازگشتازخریدToolStripMenuItem,
            this.لیستفاکتورهایفروشToolStripMenuItem,
            this.لیستفاکتورهایبازگشتازفروشToolStripMenuItem1,
            this.لیستشرکتهاToolStripMenuItem2,
            this.لیسامحصولاتToolStripMenuItem,
            this.لیستکالاهایانبارToolStripMenuItem1,
            this.لیستمشتریانToolStripMenuItem1,
            this.لیستفروشندگانToolStripMenuItem1,
            this.اطلاعاتچکهاToolStripMenuItem1});
            this.لیستهاToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.لیستهاToolStripMenuItem.Name = "لیستهاToolStripMenuItem";
            this.لیستهاToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.لیستهاToolStripMenuItem.Text = "لیست ها";
            // 
            // لیستفاکتورهایخریدToolStripMenuItem
            // 
            this.لیستفاکتورهایخریدToolStripMenuItem.Name = "لیستفاکتورهایخریدToolStripMenuItem";
            this.لیستفاکتورهایخریدToolStripMenuItem.Size = new System.Drawing.Size(370, 30);
            this.لیستفاکتورهایخریدToolStripMenuItem.Text = "لیست فاکتورهای خرید";
            this.لیستفاکتورهایخریدToolStripMenuItem.Click += new System.EventHandler(this.لیستفاکتورهایخریدToolStripMenuItem_Click);
            // 
            // لیستفاکتورهایبازگشتازخریدToolStripMenuItem
            // 
            this.لیستفاکتورهایبازگشتازخریدToolStripMenuItem.Name = "لیستفاکتورهایبازگشتازخریدToolStripMenuItem";
            this.لیستفاکتورهایبازگشتازخریدToolStripMenuItem.Size = new System.Drawing.Size(370, 30);
            this.لیستفاکتورهایبازگشتازخریدToolStripMenuItem.Text = "لیست فاکتور های بازگشت از خرید";
            this.لیستفاکتورهایبازگشتازخریدToolStripMenuItem.Click += new System.EventHandler(this.لیستفاکتورهایبازگشتازخریدToolStripMenuItem_Click);
            // 
            // لیستفاکتورهایفروشToolStripMenuItem
            // 
            this.لیستفاکتورهایفروشToolStripMenuItem.Name = "لیستفاکتورهایفروشToolStripMenuItem";
            this.لیستفاکتورهایفروشToolStripMenuItem.Size = new System.Drawing.Size(370, 30);
            this.لیستفاکتورهایفروشToolStripMenuItem.Text = "لیست فاکتورهای فروش";
            this.لیستفاکتورهایفروشToolStripMenuItem.Click += new System.EventHandler(this.لیستفاکتورهایفروشToolStripMenuItem_Click_1);
            // 
            // لیستفاکتورهایبازگشتازفروشToolStripMenuItem1
            // 
            this.لیستفاکتورهایبازگشتازفروشToolStripMenuItem1.Name = "لیستفاکتورهایبازگشتازفروشToolStripMenuItem1";
            this.لیستفاکتورهایبازگشتازفروشToolStripMenuItem1.Size = new System.Drawing.Size(370, 30);
            this.لیستفاکتورهایبازگشتازفروشToolStripMenuItem1.Text = "لیست فاکتور های بازگشت از فروش";
            this.لیستفاکتورهایبازگشتازفروشToolStripMenuItem1.Click += new System.EventHandler(this.لیستفاکتورهایبازگشتازفروشToolStripMenuItem1_Click);
            // 
            // لیستشرکتهاToolStripMenuItem2
            // 
            this.لیستشرکتهاToolStripMenuItem2.Name = "لیستشرکتهاToolStripMenuItem2";
            this.لیستشرکتهاToolStripMenuItem2.Size = new System.Drawing.Size(370, 30);
            this.لیستشرکتهاToolStripMenuItem2.Text = "لیست شرکت ها ";
            this.لیستشرکتهاToolStripMenuItem2.Click += new System.EventHandler(this.لیستشرکتهاToolStripMenuItem2_Click);
            // 
            // لیسامحصولاتToolStripMenuItem
            // 
            this.لیسامحصولاتToolStripMenuItem.Name = "لیسامحصولاتToolStripMenuItem";
            this.لیسامحصولاتToolStripMenuItem.Size = new System.Drawing.Size(370, 30);
            this.لیسامحصولاتToolStripMenuItem.Text = "لیست محصولات";
            this.لیسامحصولاتToolStripMenuItem.Click += new System.EventHandler(this.لیسامحصولاتToolStripMenuItem_Click);
            // 
            // لیستکالاهایانبارToolStripMenuItem1
            // 
            this.لیستکالاهایانبارToolStripMenuItem1.Name = "لیستکالاهایانبارToolStripMenuItem1";
            this.لیستکالاهایانبارToolStripMenuItem1.Size = new System.Drawing.Size(370, 30);
            this.لیستکالاهایانبارToolStripMenuItem1.Text = "لیست کالاهای انبار";
            this.لیستکالاهایانبارToolStripMenuItem1.Click += new System.EventHandler(this.لیستکالاهایانبارToolStripMenuItem1_Click);
            // 
            // لیستمشتریانToolStripMenuItem1
            // 
            this.لیستمشتریانToolStripMenuItem1.Name = "لیستمشتریانToolStripMenuItem1";
            this.لیستمشتریانToolStripMenuItem1.Size = new System.Drawing.Size(370, 30);
            this.لیستمشتریانToolStripMenuItem1.Text = "لیست مشتریان";
            this.لیستمشتریانToolStripMenuItem1.Click += new System.EventHandler(this.لیستمشتریانToolStripMenuItem1_Click);
            // 
            // لیستفروشندگانToolStripMenuItem1
            // 
            this.لیستفروشندگانToolStripMenuItem1.Name = "لیستفروشندگانToolStripMenuItem1";
            this.لیستفروشندگانToolStripMenuItem1.Size = new System.Drawing.Size(370, 30);
            this.لیستفروشندگانToolStripMenuItem1.Text = "لیست فروشندگان";
            this.لیستفروشندگانToolStripMenuItem1.Click += new System.EventHandler(this.لیستفروشندگانToolStripMenuItem1_Click);
            // 
            // اطلاعاتچکهاToolStripMenuItem1
            // 
            this.اطلاعاتچکهاToolStripMenuItem1.Name = "اطلاعاتچکهاToolStripMenuItem1";
            this.اطلاعاتچکهاToolStripMenuItem1.Size = new System.Drawing.Size(370, 30);
            this.اطلاعاتچکهاToolStripMenuItem1.Text = "اطلاعات چک ها";
            this.اطلاعاتچکهاToolStripMenuItem1.Click += new System.EventHandler(this.اطلاعاتچکهاToolStripMenuItem1_Click);
            // 
            // دیگرToolStripMenuItem
            // 
            this.دیگرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتچکهاToolStripMenuItem,
            this.جزئیاتورودToolStripMenuItem,
            this.مدیریتکاربرانToolStripMenuItem1,
            this.لیستکاربرانToolStripMenuItem1});
            this.دیگرToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.دیگرToolStripMenuItem.Name = "دیگرToolStripMenuItem";
            this.دیگرToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.دیگرToolStripMenuItem.Text = "دیگر";
            this.دیگرToolStripMenuItem.Click += new System.EventHandler(this.دیگرToolStripMenuItem_Click);
            // 
            // ثبتچکهاToolStripMenuItem
            // 
            this.ثبتچکهاToolStripMenuItem.Name = "ثبتچکهاToolStripMenuItem";
            this.ثبتچکهاToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.ثبتچکهاToolStripMenuItem.Text = "ثبت چک";
            this.ثبتچکهاToolStripMenuItem.Click += new System.EventHandler(this.ثبتچکهاToolStripMenuItem_Click);
            // 
            // جزئیاتورودToolStripMenuItem
            // 
            this.جزئیاتورودToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_enter_80px;
            this.جزئیاتورودToolStripMenuItem.Name = "جزئیاتورودToolStripMenuItem";
            this.جزئیاتورودToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.جزئیاتورودToolStripMenuItem.Text = "جزئیات ورود";
            this.جزئیاتورودToolStripMenuItem.Click += new System.EventHandler(this.جزئیاتورودToolStripMenuItem_Click);
            // 
            // مدیریتکاربرانToolStripMenuItem1
            // 
            this.مدیریتکاربرانToolStripMenuItem1.Image = global::Accounting.Properties.Resources.icons8_registration_skin_type_7_48px;
            this.مدیریتکاربرانToolStripMenuItem1.Name = "مدیریتکاربرانToolStripMenuItem1";
            this.مدیریتکاربرانToolStripMenuItem1.Size = new System.Drawing.Size(216, 30);
            this.مدیریتکاربرانToolStripMenuItem1.Text = "مدیریت کاربران";
            this.مدیریتکاربرانToolStripMenuItem1.Click += new System.EventHandler(this.مدیریتکاربرانToolStripMenuItem1_Click);
            // 
            // لیستکاربرانToolStripMenuItem1
            // 
            this.لیستکاربرانToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.لیستکاربرانToolStripMenuItem1.Image = global::Accounting.Properties.Resources.icons8_team_48px;
            this.لیستکاربرانToolStripMenuItem1.Name = "لیستکاربرانToolStripMenuItem1";
            this.لیستکاربرانToolStripMenuItem1.Size = new System.Drawing.Size(216, 30);
            this.لیستکاربرانToolStripMenuItem1.Text = "لیست کاربران";
            this.لیستکاربرانToolStripMenuItem1.Click += new System.EventHandler(this.لیستکاربرانToolStripMenuItem1_Click);
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
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.lblText);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblThisDay);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(685, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 50);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تاریخ امروز";
            // 
            // piBoxBackground
            // 
            this.piBoxBackground.Image = global::Accounting.Properties.Resources.background;
            this.piBoxBackground.Location = new System.Drawing.Point(0, 28);
            this.piBoxBackground.Name = "piBoxBackground";
            this.piBoxBackground.Size = new System.Drawing.Size(996, 527);
            this.piBoxBackground.TabIndex = 78;
            this.piBoxBackground.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::Accounting.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(994, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.piBoxBackground);
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
            ((System.ComponentModel.ISupportInitialize)(this.piBoxBackground)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem محصولاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ویرایشوثبتمحصولToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشتریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ویرایشوثبتمشتریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem انبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ویرایشوثبتکالاهادرانبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دستهبندیمحصولاتToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem دیگرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جزئیاتورودToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتفاکتورToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فروشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خریدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بازگشتازخریدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بازگشتازخریدToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشوثبتفروشندهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتکاربرانToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem لیستکاربرانToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem لیستهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستفاکتورهایبازگشتازفروشToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem لیستفاکتورهایفروشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستفاکتورهایخریدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستفاکتورهایبازگشتازخریدToolStripMenuItem;
        private System.Windows.Forms.PictureBox piBoxBackground;
        private System.Windows.Forms.ToolStripMenuItem محاسبهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سودخالصToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سودعملیاتیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem شرکتتولیدکنندهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستشرکتهاToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem لیسامحصولاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem لیستکالاهایانبارToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem لیستمشتریانToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem لیستفروشندگانToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem اطلاعاتچکهاToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ثبتچکهاToolStripMenuItem;
    }
}