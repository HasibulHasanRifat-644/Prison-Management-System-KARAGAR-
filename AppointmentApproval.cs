using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class AppointmentApproval : Form
    {
        private string staffUsername;
        private string staffNid;
        public AppointmentApproval(string username, string nid)
        {
            InitializeComponent();
            this.staffUsername = username;
            this.staffNid = nid;
            txtappoint.ReadOnly = false;
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
                    string query = "select * from Appointment WHERE Req_status = 'REQUESTING' OR Req_status = 'ACCEPTED' OR Req_status = 'REJECTED' ";
                    SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dgvView.AutoGenerateColumns = true;
                    dgvView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void ClearFields()
        {
            txtappoint.Clear();
            txtschedule.Clear();
            txtid.Clear();
            txtrelation.Clear();
        }

        private void btnaccept_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Appointment SET Req_status = 'ACCEPTED' WHERE A_id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtappoint.Text.Trim()));

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Appointment Accepted!");
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("No appointment found with this ID.");
                    }
                }
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnreject_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Appointment SET Req_status = 'REJECTED' WHERE A_id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtappoint.Text.Trim()));

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Appointment Rejected!");
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("No appointment found with this ID.");
                    }
                }
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            Staff staff = new Staff(staffUsername, staffNid);
            staff.Show();
            this.Hide();
        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvView.Rows[e.RowIndex];
                txtappoint.Text = row.Cells["A_id"].Value?.ToString();
                txtid.Text = row.Cells["Pri_nid"].Value?.ToString();
                txtschedule.Text = row.Cells["Req_date"].Value?.ToString();
                txtrelation.Text = row.Cells["F_relation"].Value?.ToString();
            }
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            string searchId = tbsearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchId))
            {
                DataTable dt = dgvView.DataSource as DataTable;
                if (dt != null)
                {
                    dt.DefaultView.RowFilter = $"Convert(A_id, 'System.String') LIKE '%{searchId}%'";

                    if (dt.DefaultView.Count > 0)
                    {
                        DataRowView row = dt.DefaultView[0];
                        txtappoint.Text = row["A_id"].ToString();
                        txtid.Text = row["Pri_nid"].ToString();
                        txtschedule.Text = row["Req_date"].ToString();
                        txtrelation.Text = row["F_relation"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Appointment ID not found!", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
            }
            tbsearch.Clear();
        }

        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            if (dgvView.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = string.Empty;
            }
            ClearFields();
        }
    }
}