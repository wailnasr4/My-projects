using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Nagm
{
    public partial class frm_Data : Form
    {
        public frm_Data()
        {
            InitializeComponent();
        }
        //int index = Form1.index;
        void load_Student_Data()
        {
            lb_name.Text = Form1.student.Git_Name();
        }
          private void frm_Data_Load(object sender, EventArgs e)
          {
            load_Student_Data();
            txt_Coolag.Focus();
            btn_Save.Enabled =true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string level="لايوجد";
            bool l = false;
            string Trim="لايوجد";
            bool T =false;
           
            

            if (txt_Coolag.Text.Trim() != "" && txt_Ksm.Text.Trim() != "")
            {
               
            if(Ra_L1.Checked)
            {
                level = Ra_L1.Text;
                l = true;
            }
            else if(Ra_L2.Checked)
            {
                level = Ra_L2.Text;
                    l = true;
            }
            else if (Ra_L4.Checked)
            {
                level = Ra_L3.Text;
                    l = true;
            }
            else if (Ra_L3.Checked)
            {
                level = Ra_L4.Text;
                    l = true;
            }
            if(Ra_T1.Checked)
            {
                    Trim = Ra_T1.Text;
                    T = true;
            }
            else if(Ra_T2.Checked)
            {
                Trim = Ra_T2.Text;
                    T = true;
            }

                Form1.student.Set_Coolag(txt_Coolag.Text.Trim());
                Form1.student.Set_Kasm(txt_Ksm.Text.Trim());
                if (T && l)
                {
                    Form1.student.Set_Level(level);
                    Form1.student.Set_Tirm(Trim);
                }
                else
                {
                    MessageBox.Show("ادخل المستوئ والترم ");
                    return;
                }
                MessageBox.Show("Ok ");
                txt_Coolag.Clear();
                txt_Ksm.Clear();
                btn_Save.Enabled = false;
            }
            else
            {
                MessageBox.Show("ادخل الكلية والقسم ");
            }
        }
    }
}
