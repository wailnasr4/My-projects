using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_2.dig_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double x = double.Parse(textBox1.Text);
            //double y = double.Parse(textBox2.Text);
            //double z = x + y;
            //textBox3.Text = z.ToString();

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = x + y;
                textBox3.Text = z.ToString();
            }
            else
                MessageBox.Show(" الرجاء الادخال ", "تحذير", MessageBoxButtons.YesNoCancel);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
