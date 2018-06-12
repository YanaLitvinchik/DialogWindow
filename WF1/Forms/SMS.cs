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
    public partial class SMS : Form
    {
        public SMS(List<Teacher> teachers)
        {
            InitializeComponent();
            comboBoxPhoneNumber.DataSource = teachers;
            comboBoxPhoneNumber.DisplayMember = "PhoneNumberTeachers";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public String PhoneN
        {
            get
            {
                return comboBoxPhoneNumber.Text;
            }
            set
            {
                comboBoxPhoneNumber.Text = value;
            }
        }
        public String NameUser
        {
            get
            {
                return textBoxName.Text; 
            }
            set
            {
                textBoxName.Text = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxINPUTsms.Clear();
            Random r = new Random();
            string s1 = "Is it your code? It is not a code. Is a peace of shit. You will never become a developer. My grandma coded better than you.";
            string s2 = "What does it smell? Hey, it is you again with your bidlokod. Get out and burn in hell";
            string s3 = "I don't speak with javistami.Go home and cry ";
            string s4 = "Klepach is better than Chumak";
            switch (r.Next(4))
            {
                case (0):
                    textBoxINPUTsms.Text = s1;
                    break;
                case (1):
                    textBoxINPUTsms.Text = s2;
                    break;
                case (2):
                    textBoxINPUTsms.Text = s3;
                    break;
                case (3):
                    textBoxINPUTsms.Text = s4;
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
