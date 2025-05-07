namespace Exam_Nagm
{
    partial class Frm_Set_Image_Of_Students
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
            this.btn_Set_Image = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 334);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Set_Image
            // 
            this.btn_Set_Image.BackColor = System.Drawing.Color.White;
            this.btn_Set_Image.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_Set_Image.Location = new System.Drawing.Point(54, 365);
            this.btn_Set_Image.Name = "btn_Set_Image";
            this.btn_Set_Image.Size = new System.Drawing.Size(415, 52);
            this.btn_Set_Image.TabIndex = 1;
            this.btn_Set_Image.Text = "اخيار صورة";
            this.btn_Set_Image.UseVisualStyleBackColor = false;
            this.btn_Set_Image.Click += new System.EventHandler(this.btn_Set_Image_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_Set_Image_Of_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 429);
            this.Controls.Add(this.btn_Set_Image);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Set_Image_Of_Students";
            this.Text = "Frm_Set_Image_Of_Students";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Set_Image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}