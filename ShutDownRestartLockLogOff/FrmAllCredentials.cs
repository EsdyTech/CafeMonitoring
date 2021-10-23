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
    public partial class FrmAllCredentials : Form
    {
        public FrmAllCredentials()
        {
            InitializeComponent();
            DisplayData();
        }

        private static string constring = ConfigurationManager.ConnectionStrings["cafeDb"].ConnectionString;
        SqlConnection con = new SqlConnection(constring);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;

        private CafeMonitoringEntities dbContext = new CafeMonitoringEntities();

        private void FrmAllCredentials_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void ClearData()
        {
            ID = 0;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != 0)
                {
                    cmd = new SqlCommand("delete Credential where Id=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayData();
                    ClearData();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAdmin().Show();
            Visible = false;
        }
    }
}
