using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galery
{
    public partial class Form1 : Form
    {
        List<GaleryData> PicturesSave = new List<GaleryData>();
        List<GaleryData> Pictures = new List<GaleryData>();
        int CurrentPictures;

        public Form1()
        {
            InitializeComponent();
        }
        private void BFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                TPath.Text = folderBrowserDialog1.SelectedPath;
            UpdateListFiles();
        }
        private void UpdateListFiles()
        {
            CurrentPictures = 0;

            if (TPath.Text != "" && Directory.Exists(TPath.Text))
            {
                DirectoryInfo InfoDir = new DirectoryInfo(TPath.Text);
                Pictures.Clear();
                listBox1.Items.Clear();
                foreach (var item in InfoDir.EnumerateFiles())
                {
                    if (item.Extension == ".png" || item.Extension == ".jpg" || item.Extension == ".gif")
                    {
                        listBox1.Items.Add(item.Name);
                        Pictures.Add(new GaleryData { FullName = item.FullName, Name = item.Name });
                    }
                }

                if (Pictures.Count > 0)
                {
                    radioButtonFirst.Visible = radioButtonSecond.Visible = radioButton3.Visible = radioButton4.Visible = radioButton5.Visible = true;
                    textBoxComm.Visible = Comment.Visible = true;
                    PictureBox.Image = Image.FromFile(Pictures[0].FullName);
                    PicturesSave.AddRange(Pictures);
                }
                else
                {
                    radioButtonFirst.Visible = radioButtonSecond.Visible = radioButton3.Visible = radioButton4.Visible = radioButton5.Visible = false;
                    textBoxComm.Visible = Comment.Visible = false;
                }

                FilterPicture();
            }
        }
        private void FilterPicture()
        {
            var filter = PicturesSave.Distinct() as List<GaleryData>;
            PicturesSave = filter;
        }

        private void BNext_Click(object sender, EventArgs e)
        {
            if (CurrentPictures < Pictures.Count() - 1)
            {
                CurrentPictures++;
                PictureBox.Image = Image.FromFile(Pictures[CurrentPictures].FullName);
                SetValue();
            }
        }

        private void BPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPictures > 0)
            {
                CurrentPictures--;
                PictureBox.Image = Image.FromFile(Pictures[CurrentPictures].FullName);
                SetValue();
            }
        }
        private void SetValue()
        {
            if (PicturesSave.Exists(x => x.Name == Pictures[CurrentPictures].Name))
            {
                var SelItem = PicturesSave.First(x => x == Pictures[CurrentPictures]);
                this.Comment.Text = SelItem.Comment;
                switch (SelItem.Mark)
                {
                    case 1:
                        this.radioButtonFirst.Checked = true;
                        break;
                    case 2:
                        this.radioButtonSecond.Checked = true;
                        break;
                    case 3:
                        this.radioButton3.Checked = true;
                        break;
                    case 4:
                        this.radioButton4.Checked = true;
                        break;
                    case 5:
                        this.radioButton5.Checked = true;
                        break;
                }
            }
            else
            {
                Comment.Text = "";
                radioButtonFirst.Checked = radioButtonSecond.Checked = radioButton3.Checked = radioButton4.Checked = radioButton5.Checked = false;
            }
        }
        private void Comment_Leave(object sender, EventArgs e)
        {
            var selItem = Pictures.First(x => x.Name == Pictures[CurrentPictures].Name);
            selItem.Comment = Comment.Text;
        }
    }
}
