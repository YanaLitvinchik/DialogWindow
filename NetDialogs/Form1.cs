﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            //colorDialog1.Color
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            //fontDialog1.Font
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "All data|*.*|text|*.txt|X-files|*.xml;*.docx";
            openFileDialog1.ShowDialog();
            //openFileDialog1.FileName
            //openFileDialog1.FileNames
            //openFileDialog1.SafeFileName
            //openFileDialog1.SafeFileNames
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            //saveFileDialog1.FileName
        }

        private void button5_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            //folderBrowserDialog1.SelectedPath
        }
    }
}
