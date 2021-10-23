using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutDownRestartLockLogOff
{
    public partial class FrmMakeSales : Form
    {
        public FrmMakeSales()
        {
            InitializeComponent();
            loadComboList();
            DisplaySales();
        }

        private CafeMonitoringEntities dbContext = new CafeMonitoringEntities();
        private static string constring = ConfigurationManager.ConnectionStrings["cafeDb"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadComboList()
        {
            try
            {
                var credlists = (from c in dbContext.Credential
                           where c.IsSold != true && c.IsUsed != true
                           select new
                           {
                               c.Id, 
                               Credential = c.Duration +" "+ c.Username + "-" + c.Password,
                           }).OrderByDescending(d=>d.Id).ToList();

                cmbCredential.DisplayMember = "Credential";
                cmbCredential.ValueMember = "Id";

                cmbCredential.DataSource = credlists;
            } 
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DisplaySales()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT Credential.Id AS Credential_Id,Sales.FirstName,Sales.LastName,Credential.Price, Credential.Duration, Credential.Username, " +
                    "Credential.Password,Convert(varchar, Credential.IsUsed) AS IsUsed, Convert(varchar, Credential.IsSold) AS IsSold, " +
                    "Credential.DateUsed, Sales.DateSold, Credential.DateCreated from Credential, Sales Where Credential.Id = Sales.CredentialId", con);
                adapt.Fill(dt);
                dgvListSales.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmMakeSales_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int credentialId = int.Parse(cmbCredential.SelectedValue.ToString());
                if (credentialId > 0)
                {
                    if (txtFirstName.Text != "" && txtLastName.Text != "")
                    {
                        var sale = new Sales()
                        {
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            CredentialId = credentialId,
                            DateSold = DateTime.Now,
                        };

                        dbContext.Sales.Add(sale);
                        int result = dbContext.SaveChanges();

                        if (result > 0)
                        {
                            var cred = dbContext.Credential.Where(c => c.Id == credentialId).FirstOrDefault();

                            //update credential
                            cred.IsSold = true;
                            int result2 = dbContext.SaveChanges();

                            if (result2 > 0)
                            {
                                MessageBox.Show("Credential has been Sold Successfully!", "Credential Sold");
                                cmbCredential.DataSource = null;
                                cmbCredential.Items.Clear();
                                loadComboList();
                                DisplaySales();
                            }
                            else
                            {
                                MessageBox.Show("An Error Occurred While trying to Update the Database", "Database Error!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("An Error Occurred While trying to Create the Record in the Database", "Database Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("FirstName/LastName cannot be Empty", "Input Validation Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a Credential", "No Credential Selected!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCredentialList_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAdmin().Show();
            Visible = false;
        }

        private void clearFields()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
