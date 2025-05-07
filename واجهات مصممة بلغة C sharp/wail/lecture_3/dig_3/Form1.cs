using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_3.dig_3
{
    public partial class Form1 : Form
    {
        double x, y, z;
        string[] op = { "+", "-", "*", "/" };

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
           // comboBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("تحذير", "العدد الاول غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }
            try
            {
                y = Convert.ToDouble(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("تحذير", "العدد الثاني غير صالح", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox2.Text = "";
                textBox2.Focus();
                return;
            }
            bool f = true;
            switch (comboBox1.SelectedItem)
            {
                default:break;
                case "+":z = x + y;break;
                case "-":z = x - y;break;
                case "*":z = x * y;break;
                case "/":
                    if (y != 0)
                    {
                        z = x / y;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("لايمكن القسمة على صفر");
                        f = false;
                        textBox3.Text = null;
                        break;
                    }
                    
            }
            textBox3.Text = z.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.ReadOnly = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
