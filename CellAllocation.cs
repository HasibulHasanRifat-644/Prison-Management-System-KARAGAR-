using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class CellAllocation : Form
    {
        private string staffUsername;
        private string staffNid;
        public CellAllocation(string username, string nid)
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
                   
                    string query = "SELECT P.Pri_id, P.Pri_name, P.Pri_status, C.C_name, C.C_count FROM Prisoner P JOIN PrisonerCell PC ON P.Pri_nid = PC.pri_nid JOIN Cell C ON PC.C_id = C.C_id";
                    SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
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
            tbname.Clear();
            tbid.Clear();
        }

        private void CellAllocation_Load(object sender, EventArgs e) { }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
            ClearFields();
            MessageBox.Show("Cell Allocation list refreshed");
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = tbsearch.Text.Trim();
                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Please enter a Prisoner ID to search.");
                    return;
                }

                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                 
                    string query = "SELECT P.Pri_id, P.Pri_name, P.Pri_status, C.C_name, C.C_count FROM Prisoner P JOIN PrisonerCell PC ON P.Pri_nid = PC.pri_nid JOIN Cell C ON PC.C_id = C.C_id WHERE P.Pri_id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", searchText);
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

        private void btnback_Click(object sender, EventArgs e)
        {
            
            Staff s = new Staff(staffUsername, staffNid);
            s.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbid.Text = dgvView.Rows[e.RowIndex].Cells["Pri_id"].Value?.ToString();
          
                tbname.Text = dgvView.Rows[e.RowIndex].Cells["C_name"].Value?.ToString();
                //tbid.ReadOnly = true;
            }
        }

        private void allot_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbid.Text) || string.IsNullOrEmpty(tbname.Text))
            {
                MessageBox.Show("Please select a prisoner and a cell to allocate.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

         
            string prisonerId = tbid.Text;
            string newCellName = tbname.Text;

            string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                string oldCellId = null;
                string newCellId = null;
                string prisonerNid = null; 

                try
                {
              
                    string getPrisonerNidQuery = "SELECT Pri_nid FROM Prisoner WHERE Pri_id = @PriId";
                    using (SqlCommand getPriNidCmd = new SqlCommand(getPrisonerNidQuery, conn, transaction))
                    {
                        getPriNidCmd.Parameters.AddWithValue("@PriId", prisonerId);
                        object result = getPriNidCmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Prisoner with the provided ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }
                        prisonerNid = result.ToString();
                    }

                   
                    string getNewCellIdQuery = "SELECT C_id FROM Cell WHERE C_name = @NewCellName";
                    using (SqlCommand getNewCmd = new SqlCommand(getNewCellIdQuery, conn, transaction))
                    {
                        getNewCmd.Parameters.AddWithValue("@NewCellName", newCellName);
                        newCellId = getNewCmd.ExecuteScalar()?.ToString();
                        if (newCellId == null)
                        {
                            MessageBox.Show("The selected cell name does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                            return;
                        }
                    }

                   
                    string getOldCellQuery = "SELECT C_id FROM PrisonerCell WHERE pri_nid = @PriNid";
                    using (SqlCommand getOldCmd = new SqlCommand(getOldCellQuery, conn, transaction))
                    {
                        getOldCmd.Parameters.AddWithValue("@PriNid", prisonerNid);
                        oldCellId = getOldCmd.ExecuteScalar()?.ToString();
                    }

                    if (oldCellId != null)
                    {
                  
                        string updateQuery = "UPDATE PrisonerCell SET C_id = @NewCellId WHERE pri_nid = @PriNid";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@NewCellId", newCellId);
                            updateCmd.Parameters.AddWithValue("@PriNid", prisonerNid);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                   
                        string insertQuery = "INSERT INTO PrisonerCell (pri_nid, C_id) VALUES (@PriNid, @NewCellId)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
                        {
                            insertCmd.Parameters.AddWithValue("@PriNid", prisonerNid);
                            insertCmd.Parameters.AddWithValue("@NewCellId", newCellId);
                            insertCmd.ExecuteNonQuery();
                        }
                    }

                    if (!string.IsNullOrEmpty(oldCellId) && oldCellId != newCellId)
                    {
                        string updateOldCellCount = "UPDATE Cell SET C_count = C_count - 1 WHERE C_id = @OldCellId";
                        using (SqlCommand recountOldCmd = new SqlCommand(updateOldCellCount, conn, transaction))
                        {
                            recountOldCmd.Parameters.AddWithValue("@OldCellId", oldCellId);
                            recountOldCmd.ExecuteNonQuery();
                        }
                    }

                  
                    if (oldCellId != newCellId)
                    {
                        string updateNewCellCount = "UPDATE Cell SET C_count = C_count + 1 WHERE C_id = @NewCellId";
                        using (SqlCommand recountNewCmd = new SqlCommand(updateNewCellCount, conn, transaction))
                        {
                            recountNewCmd.Parameters.AddWithValue("@NewCellId", newCellId);
                            recountNewCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    RefreshData();
                    ClearFields();
                    MessageBox.Show("Prisoner allocated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}