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
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        private CafeMonitoringEntities dbContext = new CafeMonitoringEntities();
        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    var admin = dbContext.Admin.Where(a => a.Username == txtUsername.Text && a.Password == txtPassword.Text).FirstOrDefault();
                    if (admin != null)
                    {
                        new FrmAdmin().Show();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username/Password", "Login Error");
                    }
                }
                else
                {
                    MessageBox.Show("Username/Password must not be empty", "Input Validation Error!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
            Visible = false;
        }
    }
}
