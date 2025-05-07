using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace wail.lecture_7
{
     class student:person
    {
        private int id;
        private string name;
        static string gender;
        public static string address;
        //person p;
        public person myperson;
        student()
        {
            id = 0;
            name = "";
            gender = "";
            address = "";
        }
        public student(int id,string name,string g)
        {
            this.id = id;
            this.name = name;
            gender = g;
            MessageBox.Show(id.ToString() + " " + name + " " + gender);
        }
        private void setid(int id)
        {
            this.id = id;
        }
        public void setname(string name)
        {
            this.name = name;
        }
        public int getid()
        {
            return id;
        }
        public string getname()
        {
            return name;
        }
        public string getgender() => gender;
        public static void setaddress(string add)
        {
            address = add;
        }
        private static string getaddress()
        {
            return address;
        }
        public void setfirstlastname(string first,string last)
        {
            myperson.setfirstname(first);
            myperson.lastname = last;
        }
        public string getlastfirstname()
        {
            return myperson.getfirstname() + " " + myperson.lastname;
        }
    }
   
}

