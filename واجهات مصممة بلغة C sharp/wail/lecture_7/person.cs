using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wail.lecture_7
{
    class person
    {
        string firstname;
        public string lastname;
        public void setfirstname(string n)
        {
            firstname = n;
        }
        public string getfirstname() => firstname;
    }
}
