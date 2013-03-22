using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BitcoinPOS.Properties;

namespace BitcoinPOS
{
    public partial class MDIParent : Form
    {

        private int _childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            var childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + _childFormNumber++;
            childForm.Show();
        }

        private void UpdateBalance()
        {
            var bll = new BusinessLogicLayer.Wallet();
            lblBalance.Text = Resources.MDIParent_timUpdateBalance_Tick_Balance___ + bll.GetBalance().ToString(CultureInfo.InvariantCulture);
        }

        private void LaunchChild(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    var fileName = openFileDialog.FileName;
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    string FileName = saveFileDialog.FileName;
                }
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new frmAbout();
            about.Show();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            UpdateBalance();
            LaunchChild(new frmMain());
        }

        private void timUpdateBalance_Tick(object sender, EventArgs e)
        {
            UpdateBalance();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchChild(new frmNewTransaction());
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchChild(new frmNewCustomer());
        }

        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchChild(new frmNewAddress());
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchChild(new frmNewProduct());
        }

        private void transactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LaunchChild(new frmOpenTransaction());
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LaunchChild(new frmOpenCustomer());
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LaunchChild(new frmOpenAddress());
        }

        private void productToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LaunchChild(new frmOpenProduct());
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchChild(new frmOptions());
        }
    }
}
