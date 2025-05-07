using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_9.dig_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged += select;
            listBox2.SelectedIndexChanged += select;
            listBox3.SelectedIndexChanged += select;
            listBox4.SelectedIndexChanged += select;
        }

        public static int index = -1;
        void select(object sender,EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                index = listBox1.SelectedIndex = listBox2.SelectedIndex = listBox3.SelectedIndex =
                    listBox4.SelectedIndex = ((ListBox)sender).SelectedIndex;

            }
        }       
        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.Trim());
            listBox2.Items.Add(textBox2.Text.Trim());
            listBox3.Items.Add(textBox3.Text.Trim());
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text.Trim());
            }
            else
                listBox4.Items.Add(radioButton2.Text.Trim());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
            listBox3.Items.Remove(listBox3.SelectedItem);
            listBox4.Items.Remove(listBox4.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items[index] = textBox1.Text;
                listBox2.Items[index] = textBox2.Text;
                listBox3.Items[index] = textBox3.Text;
                if (radioButton1.Checked == true)
                {
                    listBox4.Items[index] = radioButton1.Text.Trim();
                }
                else
                    listBox4.Items[index] = radioButton2.Text.Trim();
            }
        }
    }
}
