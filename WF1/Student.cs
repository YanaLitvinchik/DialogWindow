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
        public List<int> Marks { get; set; }
        public String PhoneNumberStudent { get; set; }

        public Student()
        {

        }
        public Student(string _name,string _secondname, string _surname, DateTime data, List<int> _marks, String _phonenumber )
        {
            this.Name = _name;
            this.SecondName = _secondname;
            this.Surname = _surname;
            this.DateOfBirth = data;
            this.Marks = new List<int>(){};
            this.PhoneNumberStudent = _phonenumber;
        }
        public override string ToString()
        {
            return $"{Surname} {Name}"; 
        }
    }
}
