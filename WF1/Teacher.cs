using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF1
{
    public class Teacher
    {
        public string TeachersName { get; set; }
        public Teacher()
        {

        }
        public Teacher(string _teachername)
        {
            this.TeachersName = _teachername;
        }
        public override string ToString()
        {
            return $"{TeachersName}";
        }
    }

}

