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
    public partial class frm_ShowData_Of_Students : Form
    {
        public frm_ShowData_Of_Students()
        {
            InitializeComponent();
        }

        private void lb_Name_Click(object sender, EventArgs e)
        {

        }
        void LoadAllDtat()
        {
            lb_Name.Text = Form1.student.Git_Name();
            lb_Coolag.Text += ":"+ Form1.student.Git_Coolag();
            lb_Ksm.Text += ":" + Form1.student.Git_Kasm();
            lb_Level.Text += ":" + Form1.student.Git_Lavel();
            lb_Tirm.Text += ":" + Form1.student.Git_Tirm();
            pictureBox1.Image = Image.FromFile(Form1.student.Git_Image_Path());
        }
        private void frm_ShowData_Of_Students_Load(object sender, EventArgs e)
        {
            this.Size = new Size(499, 379);
            LoadAllDtat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(890, 379);
        }
    }
}
