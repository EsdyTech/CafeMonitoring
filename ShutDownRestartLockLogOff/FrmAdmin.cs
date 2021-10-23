using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDownRestartLockLogOff
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCreateCredentials().Show();
            Visible = false;
        }

        private void allCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAllCredentials().Show();
            Visible = false;
        }

        private void allSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMakeSales().Show();
            Visible = false;
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewAdminUser().Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAdminLogin().Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
