using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_6.dig_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap mybitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int x, y;
            for (x = 20; x < 100; x++)
            {
                //for(y= 100; y > 20; y--)
                y = x;
                 mybitmap.SetPixel(x, y, Color.Red);
               
            }
            pictureBox1.Image = mybitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
