﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_3.dig_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (sender == button2)
            //    button1.BackColor = Color.Red;
            //else if (sender == button3)
            //    button1.BackColor = Color.Green;
            //else if (sender == button4)
            //    button1.BackColor = Color.Yellow;
        }
    }
}
