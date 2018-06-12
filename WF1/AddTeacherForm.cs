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
    public partial class AddTeacherForm : Form
    {

        public AddTeacherForm()
        {
            InitializeComponent();
        }
        public String TeachersName
        {
            get
            {
                return textBoxAddTeacher.Text;
            }
            set
            {
                textBoxAddTeacher.Text = value;
            }
        }

        private void textBoxAddTeacher_TextChanged(object sender, EventArgs e)
        {

        }

        private void CencelAddTeacherbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            textBoxAddTeacher.Clear();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
