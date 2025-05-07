using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_4.dig_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(radioButtonUp.Checked)
                for(int i = 0; i < Top; i++)
                {
                    if (checkBox5.Checked)
                        btnplayer.Top -= Convert.ToInt32(checkBox5.Text);
                    else if (checkBox10.Checked)
                        btnplayer.Top -= Convert.ToInt32(checkBox10.Text);
                    else if (checkBox15.Checked)
                        btnplayer.Top -= Convert.ToInt32(checkBox15.Text);
                    else if (checkBox20.Checked)
                        btnplayer.Top -= Convert.ToInt32(checkBox20.Text);
                    for (int j = 0; j < 10000000; j++) ;
                }
            else
                if(radioButtondown.Checked)
                for(int i = 0; i < Top; i++)
                {
                    if (checkBox5.Checked)
                        btnplayer.Top += Convert.ToInt32(checkBox5.Text);
                    else if (checkBox10.Checked)
                        btnplayer.Top += Convert.ToInt32(checkBox10.Text);
                    else if (checkBox15.Checked)
                        btnplayer.Top += Convert.ToInt32(checkBox15.Text);
                    else if (checkBox20.Checked)
                        btnplayer.Top += Convert.ToInt32(checkBox20.Text);
                    for (int j = 0; j < 10000000; j++) ;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnplayer.Top -= 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnplayer.Top += 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnplayer.Size = new Size(btnplayer.Width, btnplayer.Height + 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnplayer.Size = new Size(btnplayer.Width, btnplayer.Height - 5);
        }
    }
}
