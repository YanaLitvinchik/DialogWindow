namespace WF1
{
    partial class SMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMS));
            this.labelName = new System.Windows.Forms.Label();
            this.buttonSendSms = new System.Windows.Forms.Button();
            this.textBoxINPUTsms = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.comboBoxPhoneNumber = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ClearButton = new System.Windows.Forms.Button();
            this.labelSymbols = new System.Windows.Forms.Label();
            this.labelCountSMS = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(67, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // buttonSendSms
            // 
            this.buttonSendSms.Location = new System.Drawing.Point(67, 324);
            this.buttonSendSms.Name = "buttonSendSms";
            this.buttonSendSms.Size = new System.Drawing.Size(75, 23);
            this.buttonSendSms.TabIndex = 1;
            this.buttonSendSms.Text = "Send";
            this.buttonSendSms.UseVisualStyleBackColor = true;
            // 
            // textBoxINPUTsms
            // 
            this.textBoxINPUTsms.Location = new System.Drawing.Point(67, 136);
            this.textBoxINPUTsms.Multiline = true;
            this.textBoxINPUTsms.Name = "textBoxINPUTsms";
            this.textBoxINPUTsms.Size = new System.Drawing.Size(246, 135);
            this.textBoxINPUTsms.TabIndex = 2;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(67, 9);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.labelPhoneNumber.TabIndex = 5;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // comboBoxPhoneNumber
            // 
            this.comboBoxPhoneNumber.FormattingEnabled = true;
            this.comboBoxPhoneNumber.Location = new System.Drawing.Point(67, 40);
            this.comboBoxPhoneNumber.Name = "comboBoxPhoneNumber";
            this.comboBoxPhoneNumber.Size = new System.Drawing.Size(155, 21);
            this.comboBoxPhoneNumber.TabIndex = 6;
            this.comboBoxPhoneNumber.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(238, 324);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // labelSymbols
            // 
            this.labelSymbols.AutoSize = true;
            this.labelSymbols.Location = new System.Drawing.Point(67, 287);
            this.labelSymbols.Name = "labelSymbols";
            this.labelSymbols.Size = new System.Drawing.Size(46, 13);
            this.labelSymbols.TabIndex = 8;
            this.labelSymbols.Text = "Symbols";
            // 
            // labelCountSMS
            // 
            this.labelCountSMS.AutoSize = true;
            this.labelCountSMS.Location = new System.Drawing.Point(238, 287);
            this.labelCountSMS.Name = "labelCountSMS";
            this.labelCountSMS.Size = new System.Drawing.Size(33, 13);
            this.labelCountSMS.TabIndex = 9;
            this.labelCountSMS.Text = "SMS:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(417, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 228);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Press ME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Creative text messages ->";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(67, 105);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(155, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // SMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 417);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCountSMS);
            this.Controls.Add(this.labelSymbols);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.comboBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxINPUTsms);
            this.Controls.Add(this.buttonSendSms);
            this.Controls.Add(this.labelName);
            this.Name = "SMS";
            this.Text = "SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonSendSms;
        private System.Windows.Forms.TextBox textBoxINPUTsms;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxPhoneNumber;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label labelSymbols;
        private System.Windows.Forms.Label labelCountSMS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
    }
}