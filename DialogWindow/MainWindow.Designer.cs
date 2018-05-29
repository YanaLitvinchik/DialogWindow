namespace DialogWindow
{
    partial class MainWindow
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
            this.bShowDialog = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bShowDialog
            // 
            this.bShowDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bShowDialog.Location = new System.Drawing.Point(13, 13);
            this.bShowDialog.Name = "bShowDialog";
            this.bShowDialog.Size = new System.Drawing.Size(259, 236);
            this.bShowDialog.TabIndex = 0;
            this.bShowDialog.Text = "SHOW\r\nDIALOG";
            this.bShowDialog.UseVisualStyleBackColor = true;
            this.bShowDialog.Click += new System.EventHandler(this.bShowDialog_Click);
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lResult.Location = new System.Drawing.Point(13, 256);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(70, 25);
            this.lResult.TabIndex = 1;
            this.lResult.Text = "label1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.bShowDialog);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bShowDialog;
        private System.Windows.Forms.Label lResult;
    }
}