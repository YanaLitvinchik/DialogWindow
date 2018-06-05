using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF1
{
    public partial class Form1 : Form
    {
        List<Student> student;
        List<Teacher> teacher;
        BindingSource bs = new BindingSource();
        public Form1()
        {
            student = new List<Student>();
            teacher = new List<Teacher>();
            student.Add(new Student("Vladimir", "Dmitrievich", "Klepach", new DateTime(1988, 4, 18), new List<int> { 1, 2, 3, 4}));
            student.Add(new Student("Yana", "Dmitrievich", "Klepach", new DateTime(1998, 4, 18), new List<int> { 4,3,2,1}));
            student.Add(new Student("Dima", "Dmitrievich", "Klepach", new DateTime(1988, 4, 18), new List<int> {1,2,3,4 }));
            teacher.Add(new Teacher("Li Y.V."));
            teacher.Add(new Teacher("Zulu B.E."));
            teacher.Add(new Teacher("Alpha D.T."));
            InitializeComponent();
            TeacherscomboBox1.Items.AddRange(teacher.ToArray());
            TeacherscomboBox1.DisplayMember = "TeachersName";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var wnd = new Dialog(teacher);
            wnd.SelectedTeacher = TeacherscomboBox1.SelectedItem as Teacher;
            Add(wnd);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            student.Remove(listBoxStudents.SelectedItem as Student);
            bs.ResetBindings(false);
        }
        private void listBoxStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var wnd1 = new InfoForm();
            wnd1.NameT = (TeacherscomboBox1.Text);
            wnd1.NameStudent = listBoxStudents.Text;
            wnd1.Marks = (listBoxStudents.SelectedItem as Student).Marks;
            var result = wnd1.ShowDialog();
        }
        private void Add(Dialog wnd)
        {
            wnd.Names = (listBoxStudents.SelectedItem as Student).Name;
            wnd.SName = (listBoxStudents.SelectedItem as Student).SecondName;
            wnd.SurnameName = (listBoxStudents.SelectedItem as Student).Surname;
            var result = wnd.ShowDialog();
            if (result == DialogResult.OK)
            {
                student.Add(new Student()
                {
                    SecondName = wnd.SName,
                    Surname = wnd.SurnameName,
                    Name = wnd.Names
                });
                bs.ResetBindings(false);

            }
        }

        private void TeacherscomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            //student.Clear();
            //student.Add(new Student() { Name = "asdsd" });

            //bs.ResetBindings(false);
            listBoxStudents.Items.Clear();
            foreach (var item in student)
            {
                listBoxStudents.Items.Add(item);
            }
        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
