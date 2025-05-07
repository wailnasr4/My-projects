using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_3.dig_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumber1.Text);
            double num2 = Convert.ToDouble(txtNumber2.Text);
            double num3 = Convert.ToDouble(txtNumber3.Text);
            string operation1 = comboBox1.SelectedItem.ToString();
            string operation2 = comboBox2.SelectedItem.ToString();
            double reslt = calculate(num1, num2, operation1);
            reslt = calculate(reslt, num3, operation2);

            txtResult.Text = reslt.ToString();

        }
        private double calculate(double a,double b,string op)
        {
            switch (op)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return b != 0 ? a / b : double.NaN;
                default:
                    return double.NaN;
            }
        }
    }
}
