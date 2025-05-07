using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wail.lecture_6.dig_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("Camera Roll.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i <= 9)
            {
                pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
                BackgroundImage = Image.FromFile(i.ToString() + ".png");
            }
            else
                i = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            if (i <= 9)
                i = 9;
            
                pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
                BackgroundImage = Image.FromFile(i.ToString() + ".png");
            
        }
    }
}
