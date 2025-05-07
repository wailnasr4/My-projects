﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_6.dig_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.Filter = "image Files|*.png;*.jpeg;*.jpg;*.bmp;*.gif|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filrname = openFileDialog1.FileName;
                Bitmap mybitmap = new Bitmap(filrname);
                pictureBox1.Image = mybitmap;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
