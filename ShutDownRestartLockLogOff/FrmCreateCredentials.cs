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
    public partial class FrmCreateCredentials : Form
    {
        public FrmCreateCredentials()
        {
            InitializeComponent();
            DisplayData();
        }

        private CafeMonitoringEntities dbContext = new CafeMonitoringEntities();
        private static string constring = ConfigurationManager.ConnectionStrings["cafeDb"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        SqlCommand cmd;
        SqlDataAdapter adapt;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCreateCredentials_Load(object sender, EventArgs e)
        {
            cmbDuration.Items.Add("10");
            cmbDuration.Items.Add("15");
            cmbDuration.Items.Add("20");
            cmbDuration.Items.Add("25");
            cmbDuration.Items.Add("30");
            cmbDuration.Items.Add("35");
            cmbDuration.Items.Add("40");
            cmbDuration.Items.Add("45");
            cmbDuration.Items.Add("50");
            cmbDuration.Items.Add("55");
            cmbDuration.Items.Add("60");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDuration.SelectedIndex.ToString() != "" && txtQuantity.Text != "" && txtPrice.Text != "")
                {
                    int quantity = int.Parse(txtQuantity.Text);
                    long countCred = dbContext.Credential.Count();

                    if (quantity >= 1)
                    {
                        for (int i = 1; i <= quantity; i++)
                        {
                            var credentials = new Credential()
                            {
                                Price = txtPrice.Text,
                                Duration = cmbDuration.SelectedItem.ToString(),
                                Username = $"Cafe-User-{countCred + i}",
                                Password = RandomNumberGen.GenerateRandomValues(),
                                DurationSecs = "",
                                IsUsed = false,
                                IsSold = false,
                                DateCreated = DateTime.Now,
                            };

                            dbContext.Credential.Add(credentials);
                        }

                        dbContext.SaveChangesAsync();
                        MessageBox.Show("Credentials Created Successfully!", "Success");
                        clear_Fields();
                        DisplayData();
                    }
                    else
                    {
                        MessageBox.Show("Quantity cannot be less than 1", "Input Validation Error");
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

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void clear_Fields()
        {
            txtQuantity.Text = "";
            txtPrice.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_Fields();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select Id,Price,Duration,Username,Password,CONVERT(varchar, IsUsed) AS Used,CONVERT(varchar, IsSold) AS Sold, DateUsed,DateCreated from Credential", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAdmin().Show();
            Visible = false;
        }
    }
}
