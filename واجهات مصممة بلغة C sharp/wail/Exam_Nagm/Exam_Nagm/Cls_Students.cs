using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Nagm
{
    public class Cls_Students
    {
        private string Name;
        private string Coolag;
        private string Kasm;
        private string Image_Path;
        private string Level;
        private string Tirm;

        public void Set_Name(string name)
        {
            this.Name = name;
        }
        public string Git_Name() => Name;
        public void Set_Coolag(string coolag)
        {
            this.Coolag = coolag;
        }
        public string Git_Coolag() => Coolag;

        public void Set_Kasm(string k)
        {
            this.Kasm = k;
        }
        public string Git_Kasm() =>Kasm;
        public void Set_Image_Path(string image)
        {
            this.Image_Path = image;
        }
        public string Git_Image_Path() => Image_Path;
        public void Set_Level(string level)
        {
            this.Level = level;
        }
        public string Git_Lavel() => Level;
        public void Set_Tirm(string tirm)
        {
            this.Tirm = tirm;
        }
        public string Git_Tirm() => Tirm;

    }
}
