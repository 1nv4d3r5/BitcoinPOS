using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BitcoinPOS
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void lblCopyright_Click(object sender, EventArgs e)
        {

        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            var df = new frmDonate();
            df.Show();
        }
    }
}
