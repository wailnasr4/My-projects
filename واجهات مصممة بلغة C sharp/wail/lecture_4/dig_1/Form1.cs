using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_4.dig_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ترحيب", "انقر على الواجهة للحصول على الوان مختلفة", MessageBoxButtons.OKCancel);
            this.CenterToParent();
            txt_show.Text = "وائل علي احمد نصر" + "\r\n";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_enter.Text.Trim() != "" && !isnumber(txt_enter.Text))
            {
                txt_show.Text += txt_enter.Text + "\r\n".ToString();
                txt_enter.Focus();
                txt_enter.Clear();
            }
            else
            {
                MessageBox.Show("خطاء في مربع النص");
                txt_enter.Focus();
                txt_enter.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_enter.Text.Trim() != "")
                txt_enter.BackColor = Color.Yellow;
            else
                txt_enter.BackColor = Color.White;
        }

        

        private void btn_add_MouseEnter(object sender, EventArgs e)
        {
            btn_add.ForeColor = Color.Red;
            btn_add.BackColor = Color.Yellow;
        }

        private void btn_add_MouseLeave(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.Gray;
            btn_add.ForeColor = Color.Black;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("مع السلامة");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isnumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (s[i] >= 48 && s[i] <= 57)
                    return true;
            return false;
        }
        int x = 0;

        private void btn_add_MouseHover(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.Black;
        }
    }
}
