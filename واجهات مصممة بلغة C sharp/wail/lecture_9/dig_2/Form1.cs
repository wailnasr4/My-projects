using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_9.dig_2
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setEnabled();
            Height = groupBox1.Top + 40;
            Random r = new Random();
            for(int x = 0; x < 10; x++)
            {
                int n=r.Next(100);
                listBox1.Items.Add(n);
            }
        }
        // زر v
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "v")
            {
                Height = button5.Top + button5.Height + 50;
                button4.Text = "^";
            }
            else
            {
                button4.Text = "v";
                Height = groupBox1.Top + 40;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        // زر اغلاق 
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
        // زر عدد العناصر المظللة
        private void button14_Click(object sender, EventArgs e)
        {
            textBox5.Text=(listBox1.Items.Count-listBox1.SelectedItems.Count).ToString();
        }
        // زر اضافة
        private void button1_Click(object sender, EventArgs e)
        {
            if (isNumoric(textBox1.Text.Trim()))
            {
                if (!repeated(listBox1, textBox1.Text))
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show(" الرقم موجود مسبقا ");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show(" يجب ان يكون المدخل رقما ");
                textBox1.Clear();
                textBox1.Focus();
            }
            
        }
       // زر <
        private void button2_Click(object sender, EventArgs e)
        {
            int c = listBox1.SelectedItems.Count;
            for(int i = 0; i < c; i++)
            {
                if (!repeated(listBox2, listBox1.SelectedItems[0].ToString()))
                {
                    listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
        }
        // زر <<
        private void button3_Click(object sender, EventArgs e)
        {
            int c = listBox1.Items.Count;
            for(int i = 0; i < c; i++)
            {
                if (!listBox2.Items.Contains(listBox1.Items[i]))
                {
                    listBox2.Items.Add(listBox1.Items[0]);
                    listBox1.Items.Remove(listBox1.Items[0]);
                }
            }
        }
        // زر ترتيب العناصر كامل القائمة الاولى 
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            sortAnyListBox(listBox1);
        }
        // زر عكس العناصر القائمة الاولى 
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            revers(listBox1);
        }
        // زر زوجي 
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            if (radioButton1.Checked)
            {
                for(int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2==0 )
                        listBox1.SelectedIndex = i;
                }
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show(" لاتوجد عناصر زوجية ");
            }
        }
        // زر فردي 
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            if (radioButton2.Checked)
            {
                for(int i=0; i < listBox1.Items.Count; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2 != 0)
                        listBox1.SelectedIndex = i;
                }
                if (listBox1.SelectedIndex == -1)
                    MessageBox.Show(" لاتوجد عناصر فردية ");
            }
        }
        // زر اولي 
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex= -1;
            bool flag = true;
            if (radioButton3.Checked)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    int n = Convert.ToInt32((listBox1.Items[i]));
                    flag = true;
                    for (int j = 1; j < n; j++)
                    {
                        if (n % j == 0) { flag = false; break; }
                    }
                    if (flag == true)
                        listBox1.SelectedIndex = i;
                }
                    if (listBox1.SelectedIndex == -1)
                        MessageBox.Show(" لايوجد عناصر اولية ");
                
            }
        }
        // حذف عنصر مظلل من القائمة الاولى 
        private void button6_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(listBox1.SelectedItem);
            if(listBox1.SelectedIndex!=-1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
         private void sortAnyListBox(ListBox l)
        {
            int t;int c = l.Items.Count;
            for(int i = 0; i < c; i++)
            {
                for(int j=i+1; j < c; j++)
                {
                    int n1=Convert.ToInt32((l.Items[i]));
                    int n2=Convert.ToInt32((l.Items[j]));
                    if (n1 < n2)
                    {
                        t = n1;
                        l.Items[i] = n2;
                        l.Items[j] = t;
                    }
                }
            }
        }
        // زر نقل العناصر معكوسة 
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count-1;
            for(int i = 0; i < n; i++)
            {
                if (radioButton7.Checked == true)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                    listBox1.Items.Remove(listBox1.Items[i]); 
                }
            }
        }
        // زر عكس العناصر القائمة الثانية 
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            revers(listBox2);
        }
        // زر ترتيب العناصر كامل تنازليا القائمة الثانية 
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            sortAnyListBox(listBox2);
        }
        // زر عمل تظليل على العنصر  
        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Add(textBox2.Text);
        }
        // زر ازالة تظليل على العنصر  
        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Remove(textBox3.Text);
        }
        // زر التظليل على جميع العناصر 
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SelectedIndex = i;
                }
            }
            else
                MessageBox.Show("not found elements");
        }
        // زر ازالة التظليل على جميع العناصر 
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }
        // زر حذف الكل القائمة الاولى 
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }



        // التحقق من ان المدخل رقم 
        bool isNumoric(string element)
        {
            if (element == "") return false;
            for(int i = 0; i < element.Length; i++)
            {
                if(element[i]<48||element[i]>57)
                    return false;
            }
            return true;
        }
        // التحقق من تكرار العنصر في القائمة 
        bool repeated(ListBox l,string s)
        {
            for(int i = 0; i < l.Items.Count; i++)
            {
                if(l.Items[i].ToString() == s)
                    return true;
            }
            return false;
        }
        // عكس عناصر القائمة
        void revers(ListBox l)
        {
            for(int i=l.Items.Count-1; i >= 0; i--)
            {
                l.Items.Add(l.Items[i]);
                l.Items.Remove(l.Items[i]);
            }
        }
        // تفعيل الزر < 
        void setEnabled()
        {
            button2.Enabled = listBox1.SelectedIndex > -1;
        }
    }
}
