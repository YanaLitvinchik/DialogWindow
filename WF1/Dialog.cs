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
        public Dialog()
        {
            InitializeComponent();
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
    }
}
