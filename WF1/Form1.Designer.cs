namespace WF1
{
    partial class Form1
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.TeacherscomboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(179, 150);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(179, 206);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(26, 95);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(120, 199);
            this.listBoxStudents.TabIndex = 2;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);
            this.listBoxStudents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxStudents_MouseDoubleClick);
            // 
            // TeacherscomboBox1
            // 
            this.TeacherscomboBox1.FormattingEnabled = true;
            this.TeacherscomboBox1.Location = new System.Drawing.Point(25, 54);
            this.TeacherscomboBox1.Name = "TeacherscomboBox1";
            this.TeacherscomboBox1.Size = new System.Drawing.Size(121, 21);
            this.TeacherscomboBox1.TabIndex = 3;
            this.TeacherscomboBox1.SelectedIndexChanged += new System.EventHandler(this.TeacherscomboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teachers :";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(179, 262);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeButton.TabIndex = 5;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 310);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeacherscomboBox1);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.ComboBox TeacherscomboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeButton;
    }
}

