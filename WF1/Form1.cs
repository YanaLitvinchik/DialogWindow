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
        BindingSource bs = new BindingSource();
        public Form1()
        {
            student = new List<Student>();
            student.Add(new Student("Vladimir", "Dmitrievich", "Klepach", new DateTime(1988, 4, 18)));
            student.Add(new Student("Yana", "Dmitrievich", "Klepach", new DateTime(1988, 4, 18)));
            student.Add(new Student("Dima", "Dmitrievich", "Klepach", new DateTime(1988, 4, 18)));
            InitializeComponent();
            bs.DataSource = student;
            listBoxStudents.DataSource = bs;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var wnd = new Dialog();
            Add(wnd);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            student.Remove(listBoxStudents.SelectedItem as Student);
            bs.ResetBindings(false);
        }
        private void listBoxStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var wnd = new Dialog();
            Add(wnd);
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
    }
}
