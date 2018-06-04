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
    public partial class Dialog : Form
    {
        public Dialog(List<Teacher> teachers)
        {
            InitializeComponent();
            TeachercomboBox1.DataSource = teachers;
            TeachercomboBox1.DisplayMember = "TeachersName";
        }

        public String Names
        {
            get
            {
                return NametextBox1.Text;
            }
            set
            {
                NametextBox1.Text = value;
            }
        }

        public Teacher SelectedTeacher
        {
            get { return TeachercomboBox1.SelectedItem as Teacher; }
            set { TeachercomboBox1.SelectedItem = value; }
        }

        public String SName
        {
            get
            {
                return SNtextBox2.Text;
            }
            set
            {
                SNtextBox2.Text = value;
            }
        }
        public String SurnameName
        {
            get
            {
                return SurnametextBox3.Text;
            }
            set
            {
                SurnametextBox3.Text = value;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void bSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;                    
            this.Close();
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeachercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  TeachercomboBox1.Items.Clear();
        }

        private void TeachercomboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
