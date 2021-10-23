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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private CafeMonitoringEntities dbContext = new CafeMonitoringEntities();

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAdminLogin().Show();
            Visible = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            ShowInTaskbar = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != "" && txtUsername.Text != "")
                {
                    var credential = dbContext.Credential.Where(c => c.Username == txtUsername.Text && c.Password == txtPassword.Text).FirstOrDefault();

                    if (credential != null)
                    {
                        if (credential.IsUsed == false)
                        {
                            string firstName = string.Empty;
                            string lastName = string.Empty;

                            var user = dbContext.Sales.Where(c => c.CredentialId == credential.Id).FirstOrDefault();

                            if (user != null)
                            {
                                firstName = user.FirstName;
                                lastName = user.LastName;
                            }

                            credential.IsUsed = true;
                            credential.DateUsed = DateTime.Now;

                            var result = dbContext.SaveChanges();

                            if (result > 0)
                            {
                                //pass the minutes to the frmTimer Constructor;
                                int h = 0;
                                int m = 0;
                                int minutes = int.Parse(credential.Duration);

                                if (minutes < 60)
                                {
                                    m = minutes; //minutes
                                }
                                if (minutes == 60)
                                {
                                    h = 1; //1 hour
                                }
                              
                                new FrmTimerCount(h,m, firstName,lastName).Show();
                                Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("An Error Occurred While trying to Update the Record in the Database", "Database Error!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("This Credential has been used, Kindly Conatct the Administrator", "Used Credentials");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password!", "Invalid User Credentials");
                    }
                }
                else
                {
                    MessageBox.Show("Username/Password must not be empty", "Input Validation Error!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
