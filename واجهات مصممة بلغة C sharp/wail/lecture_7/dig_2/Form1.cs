﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_7.dig_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Form2 add;
        private void button1_Click(object sender, EventArgs e)
        {
            if (add == null || add.IsDisposed)
            {
                add = new Form2();
                add.Show();
            }
            else
            {
                add.Show();
            }
        }
    }
}
