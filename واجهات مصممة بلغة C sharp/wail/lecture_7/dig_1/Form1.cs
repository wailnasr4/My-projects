using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_7.dig_1
{
    public partial class Form1 : Form
    {
        Button btn;
        TextBox txt;
        ListBox lst;
        Label lbl;

        public Form1()
        {
            InitializeComponent();
             btn = new Button();
             txt = new TextBox();
             lst = new ListBox();
             lbl = new Label();
        }
        public Form1(string b,string t,string l)
        {
            InitializeComponent();
            btn = new Button();
            txt = new TextBox();
            lst = new ListBox();
            lbl = new Label();
            btn.Text = b;
            txt.Text = t;
            lbl.Text = l;
        }
        public void set(string b,string t,string l)
        {
            this.btn.Text = b;
            this.txt.Text = t;
            this.lbl.Text = l;
        }
       
        public void digit()
        {
            btn.Top = 30;btn.Left = 25;lst.Top = 60;
            txt.Top = 10;lbl.Left = 110;lbl.Top = 10;
            txt.Left = lst.Left = 10;
        }
        public void visual()
        {
            this.Controls.Add(btn);
            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            this.Controls.Add(lst);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 g = new Form1("wail", "mohmd", "ahmed");
            g.digit();
            g.visual();
            g.Show();
            g.Size=new Size(400, 300);

            Form1 f = new Form1("ali", "nzar", "ahmed");
            f.digit();
            f.visual();
            f.Show();



        }
    }
}
