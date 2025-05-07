using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using wail.lecture_7;

namespace wail
{
    internal static class Program 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
         [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new lecture_6.dig_5.Form1());
            //Application.Run(new lecture_9.dig_2.Form1());



            //student s4 = new student();
            //s4.lastname = "bbb";
            //MessageBox.Show(s4.lastname);
            //s4.setfirstname("ali");
            //MessageBox.Show(s4.getfirstname());


            //person p = new person();
            //p.lastname = "wail";
            //p.setfirstname("welcam");
            //MessageBox.Show(p.getfirstname() + " " + p.lastname);


            //    student s = new student(1, "wail", "male");
            //    int id = s.getid();
            //    MessageBox.Show(id.ToString());

            //    s.setname("wail");
            //    string name = s.getname();
            //    MessageBox.Show(name);

            //    MessageBox.Show(new student(1,"aymen","male").getid().ToString());

            //    student s2 = new student(1000, "dog", "animale");
            //    MessageBox.Show(s.getid().ToString());
            //    MessageBox.Show(s2.getid().ToString());

            //    student.setaddress("ibb");
            //    MessageBox.Show(student.address);
            //    student.setaddress("taiz");
            //    MessageBox.Show(student.address);

            //}
        }
    }
}

//Application.EnableVisualStyles();
//Application.SetCompatibleTextRenderingDefault(false);
//Application.Run(new lecture_2.dig_1.Form1());
