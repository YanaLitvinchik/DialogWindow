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
            student.Add(new Student("Vladimir", "Dmitrievich", "Klepach", new DateTime(1988, 4, 18), new List<int> { 1, 2, 3, 4}, "0631894543"));
            student.Add(new Student("Yana", "Dmitrievich", "Klepach", new DateTime(1998, 4, 18), new List<int> { 4,3,2,1}, "0631894543"));
            student.Add(new Student("Dima", "Dmitrievich", "Klepach", new DateTime(1988, 4, 18), new List<int> {1,2,3,4 }, "0631894543"));
            teacher.Add(new Teacher("Li Y.V.", "0631894543"));
            teacher.Add(new Teacher("Zulu B.E.", "0631894543"));
            teacher.Add(new Teacher("Alpha D.T.", "0631894543"));
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
            wnd.PhoneNumberStudent = (listBoxStudents.SelectedItem as Student).PhoneNumberStudent;
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
        TextBox addteacher;

        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            addteacher = new TextBox();
            addteacher.Location = new Point(AddTeacherButton.Location.X, AddTeacherButton.Location.Y+AddTeacherButton.Size.Height+1);
            addteacher.Size = AddTeacherButton.Size;
            addteacher.Parent = this;
            //teacher.Add(new Teacher(addteacher.Text));
            //addteacher.Clear();
            addteacher.KeyDown += Addteacher_KeyDown;
        }

        private void Addteacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                teacher.Add(new Teacher(addteacher.Text, "0631894543"));
                TeacherscomboBox1.Items.Add(addteacher.Text);
                addteacher.Dispose();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var wnd = new SMS();
            wnd.Show();
        }

       
    }
}
