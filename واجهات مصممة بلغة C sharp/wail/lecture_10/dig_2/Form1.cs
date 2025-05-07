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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        addStudent add;
        private void اضافةطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //addStudent add = new addStudent();
            //add.Show();
            
            if (add == null || add.IsDisposed)
            {
                add = new addStudent();
                add.Show();
            }
            else
            {
                add.Focus();
            }
        }

        private void عرضالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecture_10.dig_2.showStudents show = new showStudents();
            show.Show();
        }

        private void ادارتبياناتالطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count;
            if (count > 1)
            {
                Application.OpenForms[count - 1].Close();
            }
        }

        private void اغلاقالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count;
            if (count > 1)
            {
                for (int i = count - 1; i >= 1; i--)
                    Application.OpenForms[i].Close();
            }
        }
    }
}
