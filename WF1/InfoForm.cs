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

        public String PhoneNumber
        {
            get { return textBoxPN.Text; }
            set { textBoxPN.Text = value; }
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
        List<int> _marks;
        public List<int> Marks
        {
            get
            {
                return _marks;
            }
            set
            {
                _marks = value;
                var lstString = value.Select(x => x.ToString()).ToList();
                MarktextBox3.Text = String.Join(", ", lstString);
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void AddNewMarkbutton_Click(object sender, EventArgs e)
        {
            try
            {
                _marks.Add(int.Parse(AddMarktextBox4.Text));
            }
            catch (Exception)
            {
                AddMarktextBox4.Text = String.Empty;
            }
            AddMarktextBox4.Clear();

        }
        private void TEachertextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
