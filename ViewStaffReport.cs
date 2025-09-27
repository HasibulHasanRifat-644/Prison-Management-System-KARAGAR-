 using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class ViewStaffReport : Form
    {
        private string adminUsername;
        private string adminNid;
        public ViewStaffReport(string username, string nid)
        {
            InitializeComponent();
            this.adminUsername = username;
            this.adminNid = nid; 
            SetTextboxesReadOnly();
            this.Load += ViewReport_Load;
        }

        
        private void SetTextboxesReadOnly()
        {
            txtid.ReadOnly = true;
            txtfname.ReadOnly = true;
            txtnid.ReadOnly = true;
            txtrdate.ReadOnly = true;
            txtsname.ReadOnly = true;
            txtsid.ReadOnly = true;
            rtbdetails.ReadOnly = true;
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            LoadReports();
        }

        
        public void LoadReports()
        {
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                    R.RS_id, 
                    R.Name, 
                    A.Nid AS Staff_nid, 
                    R.RS_details, 
                    R.RS_date, 
                    R.F_nid,
                    R.F_name
                FROM ReportStaff R
                LEFT JOIN Admin_Staff A ON R.Name = A.Name";
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

        // Clear all textboxes
        public void ClearFields()
        {
            txtid.Clear();
            txtfname.Clear();
            txtnid.Clear();
            txtrdate.Clear();
            txtsname.Clear();
            txtsid.Clear();
            rtbdetails.Clear();
        }

        // Exit button
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            string searchText = tbsearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a Report ID to search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvView.DataSource is DataTable dt)
            {
               
                dt.DefaultView.RowFilter = $"Convert(RS_id, 'System.String') LIKE '%{searchText}%'";

                if (dt.DefaultView.Count == 0)
                {
                    MessageBox.Show("No report found matching the given Report ID!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 
                    LoadReports();
                    ClearFields();
                }
                else
                {
                 
                    dgvView.ClearSelection();
                    dgvView.Rows[0].Selected = true;
                    dgvView.CurrentCell = dgvView.Rows[0].Cells[0];
                    dgvView_CellContentClick(dgvView, new DataGridViewCellEventArgs(0, 0));
                }

              
                tbsearch.Clear();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin(adminUsername, adminNid);
            ad.Show();
            this.Hide();
        }

        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            LoadReports();
            ClearFields();
            tbsearch.Clear();
        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvView.Rows[e.RowIndex];
                txtid.Text = row.Cells["RS_id"].Value?.ToString();
                txtrdate.Text = row.Cells["RS_date"].Value?.ToString();
                rtbdetails.Text = row.Cells["RS_details"].Value?.ToString();
                txtsname.Text = row.Cells["Name"].Value?.ToString();
                txtnid.Text = row.Cells["F_nid"].Value?.ToString();
                txtfname.Text = row.Cells["F_name"].Value?.ToString();
                txtsid.Text = row.Cells["Staff_nid"].Value?.ToString();
            }
        }
    }
}