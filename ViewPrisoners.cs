using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class ViewPrisoners : Form
    {
        private string staffUsername;
        private string staffNid;
        public ViewPrisoners(string username, string nid)
        {
            InitializeComponent();
            this.staffUsername = username;
            this.staffNid = nid;
            RefreshData();
        }

      
        public void RefreshData()
        {
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "select * from Prisoner";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        dgvView.AutoGenerateColumns = true;
                        dgvView.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
            MessageBox.Show("Prisoner list refreshed!");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
           
            Staff staff = new Staff(staffUsername, staffNid);
            staff.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = tbsearch.Text.Trim();
                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Please enter a Prisoner ID to search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                 
                    string query = "SELECT * FROM Prisoner WHERE Pri_id LIKE @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@id", "%" + searchText + "%");
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        dgvView.AutoGenerateColumns = true;
                        dgvView.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No prisoner found with this ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                tbsearch.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewPrisoners_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}