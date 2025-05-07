using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_8.dig_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region طول النص كامل

        private void button1_Click(object sender, EventArgs e)
        {
            txtall_length.Text = txtall_text.Text.Trim().Length.ToString();
        }

        #endregion

        #region زر طول النص المحدد
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtall_text.SelectedText.Length > 0)
            {
                txtaselect_length.Text = txtall_text.SelectionLength.ToString();
            }
            else
            {
                MessageBox.Show("قم بتحديد النص");
                txtaselect_length.Text = "";
            }
        }
        #endregion

        #region زر عدد الكلمات
        private void button3_Click(object sender, EventArgs e)
        {
            string[] strword = txtall_text.Text.Trim().Split(' ');
            txtnum_word.Text = (strword.Length - 1).ToString();
        }
        #endregion

        #region زر حذف النص المحدد
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtall_text.SelectionLength > 0)
            {
                txtall_text.SelectedText = "";
            }
            else
                MessageBox.Show("قم بتحديد النص");
        }
        #endregion

        #region الغاء التحديد 
        private void button5_Click(object sender, EventArgs e)
        {
            txtall_text.SelectionLength = 0;
        }
        #endregion

        #region زر نسخ
        string myselectedtext = "";
        private void button6_Click(object sender, EventArgs e)
        {
            if (txtall_text.SelectedText.Length > 0)
            {
                myselectedtext = txtall_text.SelectedText;
            }
            else
                MessageBox.Show("لايوجد نص محدد");
        }
        #endregion

        #region قص 
        private void button7_Click(object sender, EventArgs e)
        {
            if (txtall_text.SelectedText.Length > 0)
            {
                txtall_text.SelectedText = null;
            }
            else
                MessageBox.Show("no fond selectedText");
        }

        #endregion

        #region لصق
        private void button15_Click(object sender, EventArgs e)
        {
            txtcopypast.Text += myselectedtext.Trim();
        }
        #endregion

        #region تنظيف
        private void button8_Click(object sender, EventArgs e)
        {
            txtall_text.Clear();
        }


        #endregion

        #region طول النص كامل بدون الفراغات
        private void button9_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < txtall_text.Text.Length; i++)
            {
                if (txtall_text.Text[i] != ' ')
                {
                    x++;
                }
            }
            MessageBox.Show(x.ToString());
        }
        #endregion

        #region طول النص المحدد بدون الفراغات
        private void button10_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < txtall_text.SelectedText.Length; i++)
            {
                if (txtall_text.SelectedText[i] != ' ')
                {
                    x++;
                }
            }
            MessageBox.Show(x.ToString());
        }
        #endregion

        #region زر استبدال
        private void button11_Click(object sender, EventArgs e)
        {
            if (txtall_text.SelectionLength > 0)
            {
                if (txtedite.Text.Trim() != "")
                {
                    txtall_text.SelectedText = txtedite.Text;
                }
                else
                    MessageBox.Show(" ادخل النص الجديد ");
            }
            else
                MessageBox.Show(" حدد النص المراد تعديلة ");
        }
        #endregion

        #region زر بحث 
        private void button12_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text.Trim() != "")
            {
                int index = txtall_text.Text.IndexOf(txtsearch.Text, 0);
                if (index > -1)
                {
                    txtall_text.SelectionStart = index;
                    txtall_text.SelectionLength = txtsearch.Text.Length;
                    txtall_text.Focus();
                }
                else
                    MessageBox.Show(" not found");
            }
            else
            {
                MessageBox.Show(" ادخل النص المراد البحث عنه ");
                txtsearch.Focus();
            }

        }

        #endregion

        #region زر بحث عن التالي
        private void button13_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text.Trim() != "")
            {
                int index = txtall_text.Text.IndexOf(txtsearch.Text,
                    txtall_text.SelectionStart +
                    txtall_text.SelectionLength);
                if (index > -1)
                {
                    txtall_text.Focus();
                    txtall_text.Select(index, txtsearch.Text.Length);
                }
                else
                    MessageBox.Show("not found");
            }
            else
            {
                MessageBox.Show(" ادخل النص المراد البحث عنه ");
                txtsearch.Focus();
            }
        }
        #endregion

        #region زر بحث عن السابق
        private void button14_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text.Trim() != "")
            {
                int index = txtall_text.Text.IndexOf(txtsearch.Text,
                    txtall_text.SelectionStart -
                    txtall_text.SelectionLength);
                if (index > -1)
                {
                    txtall_text.Focus();
                    txtall_text.Select(index, txtsearch.Text.Length);
                }
                else
                    MessageBox.Show("not found");
            }
            else
            {
                MessageBox.Show(" ادخل النص المراد البحث عنه ");
                txtsearch.Focus();
            }
        }
        #endregion

        #region زر تراجع
        private void button16_Click(object sender, EventArgs e)
        {
            txtall_text.Undo();
            txtcopypast.Undo();
        }
        #endregion

        #region زر عرض احرف الكلمة المحدده
        private void button17_Click(object sender, EventArgs e)
        {
            listBoxchar.Items.Clear();
            string s = txtall_text.SelectedText;
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
                listBoxchar.Items.Add(ch[i]);
        }
        #endregion

        #region زر عرض كلمات الجملة المحدده
        private void button18_Click(object sender, EventArgs e)
        {
            listBoxword.Items.Clear();
            string[] s = txtall_text.SelectedText.Split(' ');
            for (int i = 0; i < s.Length; i++)
                listBoxword.Items.Add(s[i]);
        }
        #endregion    
    }
}
