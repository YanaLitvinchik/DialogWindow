using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window2
{
    public partial class MainWindow : Form
    {
        //create
        Modless wnd = new Modless();
        public MainWindow()
        {
            wnd.DataChanged += Wnd_DataChanged;
            InitializeComponent();
        }

        private void Wnd_DataChanged(object sender, string e)
        {
            Text = e;
        }

        private void bShow_Click(object sender, EventArgs e)
        {

            //show visual
            wnd.Show();


        }
    }
}
