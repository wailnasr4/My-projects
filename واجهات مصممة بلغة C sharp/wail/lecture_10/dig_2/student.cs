using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wail.lecture_10.dig_2
{
    public class student
    {
        private int number;
        private string name;
        private string birthdate;
        private string imgpath;

        public void SetNumber(int number)
        {
            this.number = number;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetBirthdate(string birthdate)
        {
            this.birthdate = birthdate;
        }
        public void SetImgPath(string imgpath)
        {
            this.imgpath = imgpath;
        }
        public int Getnumber()
        {
            return number;
        }
        public string GetName() => name;
        public string GetBirthdate() => birthdate;
        public string GetImgPath() => imgpath;

    }
}
