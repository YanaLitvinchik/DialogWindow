namespace WF1
{
    partial class InfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TEachertextBox1 = new System.Windows.Forms.TextBox();
            this.StudenttextBox2 = new System.Windows.Forms.TextBox();
            this.MarktextBox3 = new System.Windows.Forms.TextBox();
            this.AddMarktextBox4 = new System.Windows.Forms.TextBox();
            this.AddNewMarkbutton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marks";
            // 
            // TEachertextBox1
            // 
            this.TEachertextBox1.Location = new System.Drawing.Point(135, 40);
            this.TEachertextBox1.Name = "TEachertextBox1";
            this.TEachertextBox1.Size = new System.Drawing.Size(100, 20);
            this.TEachertextBox1.TabIndex = 3;
            this.TEachertextBox1.TextChanged += new System.EventHandler(this.TEachertextBox1_TextChanged);
            // 
            // StudenttextBox2
            // 
            this.StudenttextBox2.Location = new System.Drawing.Point(135, 83);
            this.StudenttextBox2.Name = "StudenttextBox2";
            this.StudenttextBox2.Size = new System.Drawing.Size(100, 20);
            this.StudenttextBox2.TabIndex = 4;
            // 
            // MarktextBox3
            // 
            this.MarktextBox3.Location = new System.Drawing.Point(135, 124);
            this.MarktextBox3.Name = "MarktextBox3";
            this.MarktextBox3.Size = new System.Drawing.Size(100, 20);
            this.MarktextBox3.TabIndex = 5;
            // 
            // AddMarktextBox4
            // 
            this.AddMarktextBox4.Location = new System.Drawing.Point(34, 185);
            this.AddMarktextBox4.Name = "AddMarktextBox4";
            this.AddMarktextBox4.Size = new System.Drawing.Size(100, 20);
            this.AddMarktextBox4.TabIndex = 6;
            // 
            // AddNewMarkbutton
            // 
            this.AddNewMarkbutton.Location = new System.Drawing.Point(160, 183);
            this.AddNewMarkbutton.Name = "AddNewMarkbutton";
            this.AddNewMarkbutton.Size = new System.Drawing.Size(75, 23);
            this.AddNewMarkbutton.TabIndex = 7;
            this.AddNewMarkbutton.Text = "Add";
            this.AddNewMarkbutton.UseVisualStyleBackColor = true;
            this.AddNewMarkbutton.Click += new System.EventHandler(this.AddNewMarkbutton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(95, 235);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 270);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddNewMarkbutton);
            this.Controls.Add(this.AddMarktextBox4);
            this.Controls.Add(this.MarktextBox3);
            this.Controls.Add(this.StudenttextBox2);
            this.Controls.Add(this.TEachertextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TEachertextBox1;
        private System.Windows.Forms.TextBox StudenttextBox2;
        private System.Windows.Forms.TextBox MarktextBox3;
        private System.Windows.Forms.TextBox AddMarktextBox4;
        private System.Windows.Forms.Button AddNewMarkbutton;
        private System.Windows.Forms.Button CloseButton;
    }
}