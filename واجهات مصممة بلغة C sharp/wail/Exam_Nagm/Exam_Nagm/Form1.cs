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
    public partial class Form1 : Form
    {

        public static Cls_Students student = new Cls_Students();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد الخروج ؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Application.Exit();
            }
        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count;
            if(count>1)
            {
                Application.OpenForms[count - 1].Close();
            }
        }

        private void اغلاقالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //اغلاق الكل عداء الرئيسي 
            int count = Application.OpenForms.Count;
            for(int i =count -1 ;i>=1;i--)
            {
                Application.OpenForms[i].Close();
            }

        }
        frm_Data f1;
        private void بياناتالطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f1 == null || f1.IsDisposed)
            {
                f1 = new frm_Data();
                f1.Show();
            }
            else
            {
                f1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                // تخزين اسم الطالب في الكائن
                student.Set_Name(textBox1.Text.Trim());

                MessageBox.Show("تم إضافة الاسم بنجاح");

                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("أدخل الاسم أولاً!");
            }
        }
        Frm_Set_Image_Of_Students f2;
        private void صورةالطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new Frm_Set_Image_Of_Students();
                f2.Show();
            }
            else
            {
                f2.Focus();
            }
        }
        frm_ShowData_Of_Students f3;
        private void عرضالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (f3 == null || f3.IsDisposed)
            {
                f3 = new frm_ShowData_Of_Students();
                f3.Show();
            }
            else
            {
                f3.Focus();
            }
        }
        frm_Edit_Data f4;
        private void تعديلبياناتالطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(f4==null || f4.IsDisposed)
            {
                f4 = new frm_Edit_Data();
                f4.Show();
            }
            else
            {
                f4.Focus();
            }
        }
    }
}
