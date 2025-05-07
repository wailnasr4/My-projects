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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2, number3;
            string operation1 = txtopreation1.Text;
            string operation2 = txtoperation2.Text;
            string intermediateResult = "";
            string finalResult = "";
            if(double.TryParse(txtNumber1.Text,out number1)&&
               double.TryParse(txtNumber2.Text, out number2) &&
               double.TryParse(txtNumber3.Text, out number3))
            {
                intermediateResult = performOperation(number1, number2, operation1).ToString();
                if(intermediateResult=="NaN")
                {
                    MessageBox.Show("العملية الاولى غير صحيحة.");
                    txtopreation1.Focus();
                    return;
                }
                finalResult = performOperation(Convert.ToDouble(intermediateResult),number3, operation2).ToString();
                if (finalResult == "NaN")
                {
                    MessageBox.Show("العملية الثانية غير صحيحة.");
                    txtoperation2.Focus();
                    return;
                }txtResult.Text = finalResult.ToString();
            }
            else
            {
                MessageBox.Show("يرجاء ادخال ارقام صحيحة.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private double performOperation(double num1,double num2,string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num2 != 0 ? num1 / num2 : double.NaN;
                default:
                    return double.NaN;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
