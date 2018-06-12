namespace WF1
{
    partial class AddTeacherForm
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
            this.labelAddTeacher = new System.Windows.Forms.Label();
            this.textBoxAddTeacher = new System.Windows.Forms.TextBox();
            this.CencelAddTeacherbutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddTeacher
            // 
            this.labelAddTeacher.AutoSize = true;
            this.labelAddTeacher.Location = new System.Drawing.Point(12, 25);
            this.labelAddTeacher.Name = "labelAddTeacher";
            this.labelAddTeacher.Size = new System.Drawing.Size(215, 13);
            this.labelAddTeacher.TabIndex = 0;
            this.labelAddTeacher.Text = "Add techer\'s name(example : Klepach V.D.) ";
            // 
            // textBoxAddTeacher
            // 
            this.textBoxAddTeacher.Location = new System.Drawing.Point(15, 58);
            this.textBoxAddTeacher.Name = "textBoxAddTeacher";
            this.textBoxAddTeacher.Size = new System.Drawing.Size(212, 20);
            this.textBoxAddTeacher.TabIndex = 1;
            this.textBoxAddTeacher.TextChanged += new System.EventHandler(this.textBoxAddTeacher_TextChanged);
            // 
            // CencelAddTeacherbutton
            // 
            this.CencelAddTeacherbutton.Location = new System.Drawing.Point(15, 109);
            this.CencelAddTeacherbutton.Name = "CencelAddTeacherbutton";
            this.CencelAddTeacherbutton.Size = new System.Drawing.Size(75, 23);
            this.CencelAddTeacherbutton.TabIndex = 2;
            this.CencelAddTeacherbutton.Text = "Add";
            this.CencelAddTeacherbutton.UseVisualStyleBackColor = true;
            this.CencelAddTeacherbutton.Click += new System.EventHandler(this.CencelAddTeacherbutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(152, 109);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(75, 23);
            this.Closebutton.TabIndex = 3;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 148);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.CencelAddTeacherbutton);
            this.Controls.Add(this.textBoxAddTeacher);
            this.Controls.Add(this.labelAddTeacher);
            this.Name = "AddTeacherForm";
            this.Text = "AddTeacherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddTeacher;
        private System.Windows.Forms.TextBox textBoxAddTeacher;
        private System.Windows.Forms.Button CencelAddTeacherbutton;
        private System.Windows.Forms.Button Closebutton;
    }
}