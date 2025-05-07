namespace Exam_Nagm
{
    partial class frm_ShowData_Of_Students
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Tirm = new System.Windows.Forms.Label();
            this.lb_Level = new System.Windows.Forms.Label();
            this.lb_Ksm = new System.Windows.Forms.Label();
            this.lb_Coolag = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 299);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 299);
            this.button1.TabIndex = 1;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_Tirm);
            this.panel1.Controls.Add(this.lb_Level);
            this.panel1.Controls.Add(this.lb_Ksm);
            this.panel1.Controls.Add(this.lb_Coolag);
            this.panel1.Controls.Add(this.lb_Name);
            this.panel1.Location = new System.Drawing.Point(505, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 299);
            this.panel1.TabIndex = 2;
            // 
            // lb_Tirm
            // 
            this.lb_Tirm.AutoSize = true;
            this.lb_Tirm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tirm.Location = new System.Drawing.Point(199, 238);
            this.lb_Tirm.Name = "lb_Tirm";
            this.lb_Tirm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_Tirm.Size = new System.Drawing.Size(61, 24);
            this.lb_Tirm.TabIndex = 4;
            this.lb_Tirm.Text = "الترم ";
            this.lb_Tirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Level
            // 
            this.lb_Level.AutoSize = true;
            this.lb_Level.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Level.Location = new System.Drawing.Point(157, 184);
            this.lb_Level.Name = "lb_Level";
            this.lb_Level.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_Level.Size = new System.Drawing.Size(103, 24);
            this.lb_Level.TabIndex = 3;
            this.lb_Level.Text = "المستوئ ";
            this.lb_Level.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Ksm
            // 
            this.lb_Ksm.AutoSize = true;
            this.lb_Ksm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ksm.Location = new System.Drawing.Point(184, 147);
            this.lb_Ksm.Name = "lb_Ksm";
            this.lb_Ksm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_Ksm.Size = new System.Drawing.Size(59, 24);
            this.lb_Ksm.TabIndex = 2;
            this.lb_Ksm.Text = "قسم";
            this.lb_Ksm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Coolag
            // 
            this.lb_Coolag.AutoSize = true;
            this.lb_Coolag.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Coolag.Location = new System.Drawing.Point(187, 100);
            this.lb_Coolag.Name = "lb_Coolag";
            this.lb_Coolag.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_Coolag.Size = new System.Drawing.Size(56, 24);
            this.lb_Coolag.TabIndex = 1;
            this.lb_Coolag.Text = "كلية ";
            this.lb_Coolag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(171, 40);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_Name.Size = new System.Drawing.Size(72, 24);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "label1";
            this.lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Name.Click += new System.EventHandler(this.lb_Name_Click);
            // 
            // frm_ShowData_Of_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 332);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_ShowData_Of_Students";
            this.Text = "frm_ShowData_Of_Students";
            this.Load += new System.EventHandler(this.frm_ShowData_Of_Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Tirm;
        private System.Windows.Forms.Label lb_Level;
        private System.Windows.Forms.Label lb_Ksm;
        private System.Windows.Forms.Label lb_Coolag;
        private System.Windows.Forms.Label lb_Name;
    }
}