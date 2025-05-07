using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_5.dig_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = panel2.Visible = panel3.Visible = panel4.Visible = false;
            panel1.Location = panel2.Location = panel3.Location = panel4.Location = new Point(0, 60);
            this.Height = button11.Height + 50;
            this.Width = button12.Left + button12.Width + 10;

            button3.Click += button2_Click;
            button7.Click += button2_Click;
            button5.Click += button2_Click;

           // textBox1.KeyPress += textBox3_KeyPress;
            textBox2.KeyPress += textBox3_KeyPress;
            textBox3.KeyPress += textBox3_KeyPress;
            textBox4.KeyPress += textBox3_KeyPress;
            textBox5.KeyPress += textBox3_KeyPress;
            textBox6.KeyPress += textBox3_KeyPress;
            textBox7.KeyPress += textBox3_KeyPress;
            textBox8.KeyPress += textBox3_KeyPress;
            textBox9.KeyPress += textBox3_KeyPress;
            textBox10.KeyPress += textBox3_KeyPress;
            textBox11.KeyPress += textBox3_KeyPress;
            textBox12.KeyPress += textBox3_KeyPress;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            this.Height = panel2.Height * 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            Height = panel2.Height * 2;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            Height = panel2.Height * 2;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            Height = panel2.Height * 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text.Trim() != "") && (textBox3.Text.Trim() != ""))
            {
                textBox1.Text = Convert.ToString(Convert.ToInt32(textBox3.Text)
                    + Convert.ToInt32(textBox2.Text));
            }
            else
                MessageBox.Show("enter the number");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9')&&(e.KeyChar!=8) ) 
            e.Handled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox10.Text.Trim() != "") && (textBox11.Text.Trim() != ""))
            {
                if (textBox11.Text != "0")
                {
                    textBox12.Text = Convert.ToString(Convert.ToInt32(textBox10.Text) /
                        Convert.ToInt32(textBox11.Text));
                }
                else
                    MessageBox.Show("error divded by zero");
            }
            else
                MessageBox.Show("enter the number");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((textBox7.Text.Trim() != "") && (textBox8.Text.Trim() != ""))
            {
                textBox9.Text = Convert.ToString(Convert.ToInt32(textBox7.Text)
                * Convert.ToInt32(textBox8.Text));
            }
            else
                MessageBox.Show("enter the number");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox4.Text.Trim() != "") && (textBox5.Text.Trim() != ""))
            {
                textBox6.Text = Convert.ToString(Convert.ToInt32(textBox4.Text)
                - Convert.ToInt32(textBox5.Text));
            }
            else
                MessageBox.Show("enter the number");
        }
    }
}
