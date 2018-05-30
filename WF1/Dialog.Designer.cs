namespace WF1
{
    partial class Dialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NametextBox1 = new System.Windows.Forms.TextBox();
            this.SNtextBox2 = new System.Windows.Forms.TextBox();
            this.SurnametextBox3 = new System.Windows.Forms.TextBox();
            this.TeachercomboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Correct";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(104, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cencel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(83, 197);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SecondN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data";
            // 
            // NametextBox1
            // 
            this.NametextBox1.Location = new System.Drawing.Point(121, 101);
            this.NametextBox1.Name = "NametextBox1";
            this.NametextBox1.Size = new System.Drawing.Size(126, 20);
            this.NametextBox1.TabIndex = 7;
            this.NametextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SNtextBox2
            // 
            this.SNtextBox2.Location = new System.Drawing.Point(121, 132);
            this.SNtextBox2.Name = "SNtextBox2";
            this.SNtextBox2.Size = new System.Drawing.Size(126, 20);
            this.SNtextBox2.TabIndex = 8;
            // 
            // SurnametextBox3
            // 
            this.SurnametextBox3.Location = new System.Drawing.Point(121, 165);
            this.SurnametextBox3.Name = "SurnametextBox3";
            this.SurnametextBox3.Size = new System.Drawing.Size(126, 20);
            this.SurnametextBox3.TabIndex = 9;
            // 
            // TeachercomboBox1
            // 
            this.TeachercomboBox1.FormattingEnabled = true;
            this.TeachercomboBox1.Location = new System.Drawing.Point(121, 39);
            this.TeachercomboBox1.Name = "TeachercomboBox1";
            this.TeachercomboBox1.Size = new System.Drawing.Size(121, 21);
            this.TeachercomboBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Teacher";
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 496);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TeachercomboBox1);
            this.Controls.Add(this.SurnametextBox3);
            this.Controls.Add(this.SNtextBox2);
            this.Controls.Add(this.NametextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Dialog";
            this.Text = "Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NametextBox1;
        private System.Windows.Forms.TextBox SNtextBox2;
        private System.Windows.Forms.TextBox SurnametextBox3;
        private System.Windows.Forms.ComboBox TeachercomboBox1;
        private System.Windows.Forms.Label label5;
    }
}