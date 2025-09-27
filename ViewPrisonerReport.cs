using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class ViewPrisonerReport : Form
    {
        private string adminUsername;
        private string adminNid;
       

        public ViewPrisonerReport(string username, string nid)
        {
            InitializeComponent();
            this.adminUsername = username;
            this.adminNid = nid;

            SetTextboxesReadOnly();
            this.Load += ViewPrisonerReport_Load;
        }

        private void SetTextboxesReadOnly()
        {
            txtid.ReadOnly = true;     // Report Date
            txtpname.ReadOnly = true;  // Prisoner Name
            txtpid.ReadOnly = true;    // Prisoner ID (Pri_nid)
            txtstatus.ReadOnly = true; // Prisoner Status
            txtsname.ReadOnly = true;  // Staff Name
            txtsid.ReadOnly = true;    // Staff ID
        }

        private void ViewPrisonerReport_Load(object sender, EventArgs e)
        {
            LoadPrisonerReports();
        }

        public void LoadPrisonerReports()
        {
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            pr.R_id,
                            pr.R_date,
                            pr.Pri_name,
                            pr.Pri_nid,
                            p.Pri_status AS Status,
                            s.Name AS Staff_Name,
                            s.Nid AS Staff_Id
                        FROM PrisonerReports pr
                        INNER JOIN Prisoner p ON pr.Pri_nid = p.Pri_nid
                        INNER JOIN Admin_Staff s ON pr.Staff_id = s.Nid";

                    SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    dgvView.AutoGenerateColumns = true;
                    dgvView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }

        

        private void ClearFields()
        {
            txtid.Clear();
            txtpid.Clear();
            txtpname.Clear();
            txtsid.Clear();
            txtsname.Clear();
            txtstatus.Clear();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchText = tbsearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a Report ID or Prisoner ID to search.");
                return;
            }

            if (dgvView.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = $"Convert(R_id, 'System.String') LIKE '%{searchText}%' OR Convert(Pri_nid, 'System.String') LIKE '%{searchText}%'";

                if (dt.DefaultView.Count == 0)
                {
                    MessageBox.Show("No prisoner report found matching this ID.");
                    LoadPrisonerReports();
                    ClearFields();
                }
                else
                {
                    dgvView.ClearSelection();
                    dgvView.Rows[0].Selected = true;
                    dgvView.CurrentCell = dgvView.Rows[0].Cells[0];
                    dgvView_CellContentClick_1(dgvView, new DataGridViewCellEventArgs(0, 0));
                }
                tbsearch.Clear();
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            
            Admin ad = new Admin(adminUsername,adminNid);
            ad.Show();
            this.Hide();
        }

        private void dgvView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvView.Rows[e.RowIndex];

                if (row == null)
                {
                    MessageBox.Show("No data found for the selected row.");
                    return;
                }

                txtid.Text = row.Cells["R_date"].Value?.ToString();
                txtpname.Text = row.Cells["Pri_name"].Value?.ToString();
                txtpid.Text = row.Cells["Pri_nid"].Value?.ToString();
                txtstatus.Text = row.Cells["Status"].Value?.ToString();
                txtsname.Text = row.Cells["Staff_Name"].Value?.ToString();
                txtsid.Text = row.Cells["Staff_Id"].Value?.ToString();
            }
        }

        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            LoadPrisonerReports();
            ClearFields();
            tbsearch.Clear();
        }
    }
}