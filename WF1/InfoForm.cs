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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }
        public String NameT
        {
            get
            {
                return TEachertextBox1.Text;
            }
            set
            {
                TEachertextBox1.Text = value;
            }
        }
        public String NameStudent
        {
            get
            {
                return StudenttextBox2.Text;
            }
            set
            {
                StudenttextBox2.Text = value;
            }
        }
        public List<int> Marks
        {
            get
            {
                return MarktextBox3.Text.ToArray().ToList();
            }
            set
            {
                MarktextBox3.Text = value;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddNewMarkbutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TEachertextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
