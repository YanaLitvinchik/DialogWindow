using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF1
{
    class Student
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student()
        {

        }
        public Student(string _name,string _secondname, string _surname, DateTime data )
        {
            this.Name = _name;
            this.SecondName = _secondname;
            this.Surname = _surname;
            this.DateOfBirth = data;
        }
        public override string ToString()
        {
            return $"{Surname} {Name}"; 
        }
    }
}
