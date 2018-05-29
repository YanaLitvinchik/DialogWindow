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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bShowDialog_Click(object sender, EventArgs e)
        {
            //Create
            var wnd = new Dialog();
            //send data to DialogWindw
            wnd.Login = "Good morning!";
            if (wnd.ShowDialog() == DialogResult.OK)
            {
                //receive data from DialogWindw
                lResult.Text = wnd.Login;
            }
            //close
            wnd.Dispose();
            //wnd.Close();
        }
    }
}
