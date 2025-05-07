using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_8.dig_2
{
    public partial class Form1 : Form
    {

        private Stack<string> actionsStack = new Stack<string>();
        private int maxactions = 10;
    
        public Form1()
        {
            InitializeComponent();
        }
        string mytext = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.Length> 0)
            {
                mytext = textBox1.SelectedText;
            }
        }

        #region زر تراجع
        private void button4_Click(object sender, EventArgs e)
        {
            if (actionsStack.Count > 0)
            {
                string lastactions = actionsStack.Pop();
                label1.Text = "اخر خطوة :" + lastactions;
            }
            else
            {
                label1.Text = " لا توجد خطوات للتراجع ";
            }
        }

        public void performAction(string action)
        {
            if (actionsStack.Count >= maxactions)
            {
                actionsStack.Pop();
            }
            actionsStack.Push(action);
            label1.Text = " تم تنفيذ :" + action;
        }

        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mytext))
            {
                performAction(textBox1.SelectedText);
            }
            textBox2.Text += mytext.Trim();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText.Length > 0)
            {
                textBox1.SelectedText = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
