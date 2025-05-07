using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_8.dig_2
{
    public partial class Form2 : Form
    {
        private string copied = string.Empty;
        private Stack<string> undostack = new Stack<string>();
        private const int maxundosteps = 10;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            copied = textBox1.SelectedText;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(copied))
            {
                if (undostack.Count >= maxundosteps)
                {
                    undostack.Pop();
                }
                undostack.Push(textBox2.SelectedText);

                textBox2.SelectedText += copied;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (undostack.Count > 0)
            {
                textBox1.SelectedText = undostack.Pop();
            }
        }
    }
}
