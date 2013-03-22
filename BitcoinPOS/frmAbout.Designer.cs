namespace BitcoinPOS
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblIncluded = new System.Windows.Forms.Label();
            this.btnDonate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(12, 25);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(597, 65);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = resources.GetString("lblCopyright.Text");
            this.lblCopyright.Click += new System.EventHandler(this.lblCopyright_Click);
            // 
            // lblIncluded
            // 
            this.lblIncluded.AutoSize = true;
            this.lblIncluded.Location = new System.Drawing.Point(15, 118);
            this.lblIncluded.Name = "lblIncluded";
            this.lblIncluded.Size = new System.Drawing.Size(703, 91);
            this.lblIncluded.TabIndex = 1;
            this.lblIncluded.Text = resources.GetString("lblIncluded.Text");
            // 
            // btnDonate
            // 
            this.btnDonate.Location = new System.Drawing.Point(275, 259);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(170, 92);
            this.btnDonate.TabIndex = 2;
            this.btnDonate.Text = "&Donate";
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 420);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.lblIncluded);
            this.Controls.Add(this.lblCopyright);
            this.Name = "frmAbout";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblIncluded;
        private System.Windows.Forms.Button btnDonate;
    }
}