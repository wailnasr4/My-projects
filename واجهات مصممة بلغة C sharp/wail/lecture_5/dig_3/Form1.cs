using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace wail.lecture_5.dig_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            threadgo = new Thread(go);

            threadgo.Start();
        }
        Thread threadgo;
        void go()
        {
            for(int i = 0; i <= this.Width; i++)
            {
                Invoke((Action)(() =>
                {
                    button1.Left += 10;
                }));
                if (button1.Left > this.Width - button1.Width - 50)
                {
                    break;
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = button4.Top; i <= this.Height - button4.Height - 70; i++)
            {
                if (button4.Top > this.Height - button4.Height - 70)
                {
                    break;
                }
                button4.Top += 10;
                System.Threading.Thread.Sleep(100);
                Application.DoEvents();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadgo != null)
                threadgo.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
