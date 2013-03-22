namespace BitcoinPOS
{
    partial class frmDonate
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
            this.lblIntro = new System.Windows.Forms.Label();
            this.lnkAddress = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Location = new System.Drawing.Point(81, 22);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(186, 13);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Thank you for considering a donation.\r\n";
            // 
            // lnkAddress
            // 
            this.lnkAddress.AutoSize = true;
            this.lnkAddress.Location = new System.Drawing.Point(61, 62);
            this.lnkAddress.Name = "lnkAddress";
            this.lnkAddress.Size = new System.Drawing.Size(223, 13);
            this.lnkAddress.TabIndex = 1;
            this.lnkAddress.TabStop = true;
            this.lnkAddress.Text = "14hSGGYXa85UbjryvkdMFKwJe3McFi6Ww9";
            this.lnkAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddress_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BitcoinPOS.Properties.Resources.donateQR;
            this.pictureBox1.Location = new System.Drawing.Point(67, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmDonate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 298);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnkAddress);
            this.Controls.Add(this.lblIntro);
            this.Name = "frmDonate";
            this.Text = "Donate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.LinkLabel lnkAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}