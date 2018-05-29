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
    public partial class Modless : Form
    {
        EventHandler<String> _dataChanged;
        public event EventHandler<String> DataChanged
        {
            add
            {
                _dataChanged += value;
            }
            remove
            {
                _dataChanged -= value;
            }
        }

        public Modless()
        {
            InitializeComponent();
        }

        private void Modless_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }


        public String Data
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _dataChanged?.Invoke(this, Data);
        }
    }
}
