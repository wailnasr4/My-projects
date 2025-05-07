using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_10.dig_2
{
    public partial class addStudent : Form
    {
        
        public static student[] s = new student[100];  
        public static int count = 0;
        public addStudent()
        {
            InitializeComponent();
        }
        bool isChoceImage = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 100)
            {
                if (isChoceImage)
                {
                    s[count] = new student();
                    s[count].SetNumber(Convert.ToInt32(numericUpDown1.Value));
                    s[count].SetName(textBox1.Text);
                    s[count].SetBirthdate(dateTimePicker1.Text);
                    s[count].SetImgPath(openFileDialog1.FileName);
                    count++;
                    isChoceImage = false;
                    pictureBox1.Image = null;
                    numericUpDown1.Value = 0;
                    textBox1.Text = "";
                    MessageBox.Show(" تم اضافة الطالب بنجاح ", " نجاح ");
                }
                else
                    MessageBox.Show(" الرجاء اختيار صورة الطالب ", " تحذير ");
            }
            else
                MessageBox.Show(" الحد المسموح بة مائة طالب ", " تحذير ");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "img(*.jpg)|*.jpg|(img*.bmp;*.png)|*.bmp;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                isChoceImage = true;
            }
        }
    }
}
