namespace Exam_Nagm
{
    partial class Form1
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الرئيسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بياناتالطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.صورةالطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالبياناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اغلاقالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلالبياناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.تعديلبياناتالطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(77, 224);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(140, 50);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 122);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم الطالب :   ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(240, 24);
            this.textBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الرئيسيةToolStripMenuItem,
            this.ملفToolStripMenuItem,
            this.تعديلالبياناتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(731, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الرئيسيةToolStripMenuItem
            // 
            this.الرئيسيةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بياناتالطالبToolStripMenuItem,
            this.صورةالطالبToolStripMenuItem,
            this.عرضالبياناتToolStripMenuItem});
            this.الرئيسيةToolStripMenuItem.Name = "الرئيسيةToolStripMenuItem";
            this.الرئيسيةToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.الرئيسيةToolStripMenuItem.Text = "الرئيسية ";
            // 
            // بياناتالطالبToolStripMenuItem
            // 
            this.بياناتالطالبToolStripMenuItem.Name = "بياناتالطالبToolStripMenuItem";
            this.بياناتالطالبToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.بياناتالطالبToolStripMenuItem.Text = "بيانات الطالب ";
            this.بياناتالطالبToolStripMenuItem.Click += new System.EventHandler(this.بياناتالطالبToolStripMenuItem_Click);
            // 
            // صورةالطالبToolStripMenuItem
            // 
            this.صورةالطالبToolStripMenuItem.Name = "صورةالطالبToolStripMenuItem";
            this.صورةالطالبToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.صورةالطالبToolStripMenuItem.Text = "صورة الطالب";
            this.صورةالطالبToolStripMenuItem.Click += new System.EventHandler(this.صورةالطالبToolStripMenuItem_Click);
            // 
            // عرضالبياناتToolStripMenuItem
            // 
            this.عرضالبياناتToolStripMenuItem.Name = "عرضالبياناتToolStripMenuItem";
            this.عرضالبياناتToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.عرضالبياناتToolStripMenuItem.Text = "عرض البيانات ";
            this.عرضالبياناتToolStripMenuItem.Click += new System.EventHandler(this.عرضالبياناتToolStripMenuItem_Click);
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اغلاقToolStripMenuItem,
            this.اغلاقالكلToolStripMenuItem});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // اغلاقToolStripMenuItem
            // 
            this.اغلاقToolStripMenuItem.Name = "اغلاقToolStripMenuItem";
            this.اغلاقToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.اغلاقToolStripMenuItem.Text = "اغلاق";
            this.اغلاقToolStripMenuItem.Click += new System.EventHandler(this.اغلاقToolStripMenuItem_Click);
            // 
            // اغلاقالكلToolStripMenuItem
            // 
            this.اغلاقالكلToolStripMenuItem.Name = "اغلاقالكلToolStripMenuItem";
            this.اغلاقالكلToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.اغلاقالكلToolStripMenuItem.Text = "اغلاق الكل";
            this.اغلاقالكلToolStripMenuItem.Click += new System.EventHandler(this.اغلاقالكلToolStripMenuItem_Click);
            // 
            // تعديلالبياناتToolStripMenuItem
            // 
            this.تعديلالبياناتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلبياناتالطالبToolStripMenuItem});
            this.تعديلالبياناتToolStripMenuItem.Name = "تعديلالبياناتToolStripMenuItem";
            this.تعديلالبياناتToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.تعديلالبياناتToolStripMenuItem.Text = "تعديل البيانات";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(516, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "حفظ الاسم";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // تعديلبياناتالطالبToolStripMenuItem
            // 
            this.تعديلبياناتالطالبToolStripMenuItem.Name = "تعديلبياناتالطالبToolStripMenuItem";
            this.تعديلبياناتالطالبToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.تعديلبياناتالطالبToolStripMenuItem.Text = "تعديل بيانات الطالب";
            this.تعديلبياناتالطالبToolStripMenuItem.Click += new System.EventHandler(this.تعديلبياناتالطالبToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الرئيسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بياناتالطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem صورةالطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالبياناتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اغلاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اغلاقالكلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلالبياناتToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem تعديلبياناتالطالبToolStripMenuItem;
    }
}

