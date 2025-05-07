using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_3.dig_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
           // fact(x);
            label2.Text = fact(x).ToString();
        }
        private double fact(int n)
        {
            if (n == 1)

                return 1;
            else
                return n *fact(n - 1);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y=Math.Sqrt(x);
            label3.Text = y.ToString();
            
        }
    }
}
