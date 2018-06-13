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
        private List<Student> students = new List<Student>();
        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }
        private List<Teacher> teachers = new List<Teacher>();

        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }
        public SMS()
        {
            InitializeComponent();
        }
        private Teacher teacher;
        public Teacher _Teacher
        {
            get { return teacher; }
            set
            {
                teacher = value;
                teacher.TeachersName = value.TeachersName;
                comboBoxPhoneNumber.Text = value.PhoneNumberTeacher;
            }
        }
        public int CountSymbols { get; set; }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public String PhoneN
        {
            get
            {
                return comboBoxPhoneNumber.SelectedItem.ToString();
            }
            set
            {
                comboBoxPhoneNumber.SelectedItem = value;
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
        private void Update()
        {
            labelSymbols.Text = textBoxINPUTsms.Text.Count().ToString();
           //if(textBoxINPUTsms.Text.Count()> 140)
                
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSendSms_Click(object sender, EventArgs e)
        {
           // Lib_SMS.SMSSender sender = new Lib_SMS.SMSSender("vladmir.klepach@gmail.com", "1qaz@WSX", "Yana");
            //var tmp = sender.Send(comboBoxPhoneNumber.Text, textBoxINPUTsms.Text);
        }

        private void textBoxINPUTsms_KeyPress(object sender, KeyPressEventArgs e)
        {
            Update();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBoxINPUTsms.Clear();
        }
    }
}
