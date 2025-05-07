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
    public partial class editStudent : Form
    {
        int index;
        public editStudent()
        {
            InitializeComponent();
        }
        private void editStudent_Load(object sender, EventArgs e)
        {
            loadstudent();
        }

        void loadstudent()
        {
            index = showStudents.index;
            numericUpDown1.Value = Convert.ToDecimal(addStudent.s[index].Getnumber());
            textBox1.Text = addStudent.s[index].GetName();
            dateTimePicker1.Text = addStudent.s[index].GetBirthdate();
            pictureBox1.Image = Image.FromFile(addStudent.s[index].GetImgPath());
        }
        private bool isUpdateImage = false;
        private void button1_Click(object sender, EventArgs e)
        {
            addStudent.s[index].SetNumber(Convert.ToInt32(numericUpDown1.Value));
            addStudent.s[index].SetName(textBox1.Text);
            addStudent.s[index].SetBirthdate(dateTimePicker1.Text);
            if (isUpdateImage)
            {
                addStudent.s[index].SetImgPath(openFileDialog1.FileName);
            }
            Close();
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
                isUpdateImage = true;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
