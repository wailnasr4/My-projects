using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wail.lecture_10.dig_2
{
    public partial class showStudents : Form
    {
        public showStudents()
        {
            InitializeComponent();
        }
        private void showStudents_Load(object sender, EventArgs e)
        {
            loadstudent();
            listBox1.SelectedIndexChanged += findSelected;
            listBox2.SelectedIndexChanged += findSelected;
            listBox3.SelectedIndexChanged += findSelected;

        }
        public static int index = -1;
        void findSelected(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                index = listBox3.SelectedIndex = listBox2.SelectedIndex = listBox1.SelectedIndex = ((ListBox)sender).SelectedIndex;
                pictureBox1.Image = Image.FromFile(addStudent.s[index].GetImgPath());
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                editStudent f = new editStudent();
                f.ShowDialog();
                listBox1.Items[index] = addStudent.s[index].Getnumber();
                listBox2.Items[index] = addStudent.s[index].GetName();
                listBox3.Items[index] = addStudent.s[index].GetBirthdate();
                pictureBox1.Image = Image.FromFile(addStudent.s[index].GetImgPath());
            }
            //Form form = new Form();
            //form.Size = new Size(800, 350);
            //Button btnedit = new Button();
            //btnedit.Text = "edit";
            //btnedit.Size = new Size(80, 40);
            //btnedit.Font = new Font;
            //form.Controls.Add(btnedit);
            //form.ShowDialog();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
        void loadstudent()
        {
            for(int i = 0; i < addStudent.count; i++)
            {
                listBox1.Items.Add(addStudent.s[i].Getnumber().ToString());
                listBox2.Items.Add(addStudent.s[i].GetName().ToString());
                listBox3.Items.Add(addStudent.s[i].GetBirthdate().ToString());

                pictureBox1.Image = Image.FromFile(addStudent.s[i].GetImgPath());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                listBox3.Items.Remove(listBox3.SelectedItem);
                for (int i = index; i < addStudent.count; i++)
                    addStudent.s[i] = addStudent.s[i + 1];
                addStudent.count--;
                if (addStudent.count >= 1)
                {
                    pictureBox1.Image = Image.FromFile(addStudent.s[0].GetImgPath());
                    listBox1.SelectedIndex = listBox2.SelectedIndex = listBox3.SelectedIndex = 0;
                }
                else
                    pictureBox1.Image = null;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            pictureBox1.Image = null;
        }
    }
}
