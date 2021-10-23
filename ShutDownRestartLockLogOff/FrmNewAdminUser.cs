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
    public partial class FrmNewAdminUser : Form
    {
        public FrmNewAdminUser()
        {
            InitializeComponent();
            DisplayData();
        }

        private CafeMonitoringEntities dbContext = new CafeMonitoringEntities();
        private static string constring = ConfigurationManager.ConnectionStrings["cafeDb"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAdmin().Show();
            Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLastName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtFirstName.Text != "")
                {
                    var admin = dbContext.Admin.Where(a => a.Username == txtUserName.Text).FirstOrDefault();
                    if (admin == null)
                    {
                        var newAdm = new Admin()
                        {
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            Username = txtUserName.Text,
                            Password = txtPassword.Text,
                        };

                        dbContext.Admin.Add(newAdm);
                        int result  = dbContext.SaveChanges();

                        if (result > 0)
                        {
                            MessageBox.Show("Admin Created Successfully", "Successful Creation!");
                            clearFields();
                            DisplayData();
                        }
                        else
                        {
                            MessageBox.Show("An Error Occuured When Trying to Save to the Database", "Database Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("An Admin with this Username Already Exists", "Duplicate Error!");
                    }
                }
                else
                {
                    MessageBox.Show("Textboxes must not be empty", "Input Validation Error");
                }
              
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void FrmNewAdminUser_Load(object sender, EventArgs e)
        {

        }

        private void clearFields()
        {
            txtLastName.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtFirstName.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Admin", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    cmd = new SqlCommand("delete Admin where Id=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayData();
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    if (txtLastName.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtFirstName.Text != "")
                    {
                        string firstName = txtFirstName.Text;
                        string lastName = txtLastName.Text;
                        string username = txtUserName.Text;
                        string password = txtPassword.Text;

                        cmd = new SqlCommand("update Admin set FirstName=@firstName,LastName=@lastName,Username=@username, Password=@password where Id=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@firstName", firstName);
                        cmd.Parameters.AddWithValue("@lastName", lastName);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record Updated Successfully!");
                        DisplayData();
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Textboxes must not be empty", "Input Validation Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
