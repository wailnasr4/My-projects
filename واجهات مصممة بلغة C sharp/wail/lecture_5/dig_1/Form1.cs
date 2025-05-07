using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_5.dig_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;bool f = false;
            textBox1.Text = null;
            if (checkBox1.Checked == true)
            {
               s+= Convert.ToInt32(checkBox1.Text);f = true;
            }
            if (checkBox2.Checked == true)
            {
                s += Convert.ToInt32(checkBox2.Text); f = true;
            }
            if (checkBox3.Checked == true)
            {
                s += Convert.ToInt32(checkBox3.Text); f = true;
            }
            if (checkBox4.Checked == true)
            {
                s += Convert.ToInt32(checkBox4.Text); f = true;
            }
            if (checkBox5.Checked == true)
            {
                s += Convert.ToInt32(checkBox5.Text); f = true;
            }
            if (f)
                textBox1.Text = s.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonred.Checked == true)
                label2.BackColor = Color.Red;
            else if (radioButtonyellow.Checked == true)
                label2.BackColor = Color.Yellow;
            else if (radioButtongreen.Checked == true)
                label2.BackColor = Color.Green;
            else if (radioButtonblack.Checked == true)
                label2.BackColor = Color.Black;

          if ( radioButton1.Checked == true)
                label2.ForeColor = Color.Red;
           else if (radioButton2.Checked == true)
                label2.ForeColor = Color.Yellow;
           else if (radioButton3.Checked == true)
                label2.ForeColor = Color.Green;
            else if (radioButton4.Checked == true)
                label2.ForeColor = Color.Black;
        }

        private void btnUnEnabled_Click(object sender, EventArgs e)
        {
            panelbackcolor.Enabled = false;
        }

        private void btnEnabled_Click(object sender, EventArgs e)
        {
            panelbackcolor.Enabled = true;
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            panelbackcolor.Visible = true;
        }

        private void btnUnVisible_Click(object sender, EventArgs e)
        {
            panelbackcolor.Visible = false;
        }
    }
}
