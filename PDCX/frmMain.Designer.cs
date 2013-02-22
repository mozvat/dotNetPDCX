namespace PDCX
{
    partial class frmMain
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
            this.btnCredit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(364, 35);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(75, 23);
            this.btnCredit.TabIndex = 0;
            this.btnCredit.Text = "Credit";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 453);
            this.Controls.Add(this.btnCredit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Mercury PDCX Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCredit;
    }
}

