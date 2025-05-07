using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Nagm
{
    public partial class Frm_Set_Image_Of_Students : Form
    {
        public Frm_Set_Image_Of_Students()
        {
            InitializeComponent();
        }

        private void btn_Set_Image_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "اختار الصورة";
            openFileDialog1.Filter= "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                Form1.student.Set_Image_Path(openFileDialog1.FileName);
                MessageBox.Show("تم حفظ الصورة");
            }
        }
    }
}
