using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

namespace BitcoinPOS
{
    public partial class frmDonate : Form
    {
        public frmDonate()
        {
            InitializeComponent();
        }

        private void lnkAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("bitcoin:"+lnkAddress.Text.ToString(CultureInfo.InvariantCulture));
        }
    }
}
