using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogWindow
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }
        
        public String Login
        {
            get {
                return tbLogin.Text;
            }
            set {
                tbLogin.Text = value;
            }
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
    }
}
