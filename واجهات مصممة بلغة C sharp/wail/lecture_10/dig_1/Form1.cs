using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace wail.lecture_10.dig_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBox1.Items.Add("*.png");
            //comboBox1.Items.Add("*.jpg");
            //comboBox1.Items.Add("*.jpeg");
            //comboBox1.Items.Add("*.txt");
            //comboBox1.SelectedIndex = 1;
        }

        private void drivelistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dirlistBox1.Path = drivelistBox1.Drive;
        }

        private void dirlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filelistBox1.Path = dirlistBox1.Path;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filelistBox1.Pattern = comboBox1.Text.Trim();

        }

        private void filelistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label1.Text = filelistBox1.Path + "\\" + filelistBox1.FileName;
            //label2.Text = Path.GetFileName(label1.Text);
            //label3.Text = Path.GetExtension(label1.Text);
            //if (label3.Text.Trim().ToLower() == ".txt")
            //{
            //    richTextBox1.Text = File.ReadAllText(label1.Text);
            //    pictureBox1.Image = null;
            //}
            //else if (label3.Text.ToLower() == ".png"||label3.Text.ToLower()==".jpg"
            //    ||label3.Text.ToLower()==".jpeg")
            //{
            //    pictureBox1.Image = Image.FromFile(label1.Text);
            //    richTextBox1.Text = "";
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drivelistBox1.Items.Clear();

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    drivelistBox1.Items.Add(drive.Name+"-"+drive.DriveType);
                }
            }
        }
    }
}
