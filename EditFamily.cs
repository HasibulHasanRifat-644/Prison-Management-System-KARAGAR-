using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class EditFamily : Form
    {
        private string adminName;
        private string adminNid;
        public void Refresh()
        {
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "select * from Family";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adp.Fill(ds);
                        DataTable dt = ds.Tables[0];
                        dgvView.AutoGenerateColumns = true;
                        dgvView.DataSource = dt;
                        tbnid.ReadOnly = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbname.Text = dgvView.Rows[e.RowIndex].Cells[0].Value?.ToString();
                tbnid.Text = dgvView.Rows[e.RowIndex].Cells[1].Value?.ToString();
                tbpass.Text = dgvView.Rows[e.RowIndex].Cells[2].Value?.ToString();
                tbdob.Text = dgvView.Rows[e.RowIndex].Cells[3].Value?.ToString();
                tbrelation.Text = dgvView.Rows[e.RowIndex].Cells[4].Value?.ToString();
                tbprisoner.Text = dgvView.Rows[e.RowIndex].Cells[5].Value?.ToString();
                tbnid.ReadOnly = true;
            }
        }

        public EditFamily(string username, string nid)
        {
            InitializeComponent();
            this.adminName = username;
            this.adminNid = nid;
            tbnid.ReadOnly = false;
            Refresh();
        }

        public void Clear()
        {
            tbname.Clear();
            tbnid.Clear();
            tbpass.Clear();
            tbdob.Clear();
            tbrelation.Clear();
            tbprisoner.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(adminName,adminNid);
            admin.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            tbsearch.Clear();
            MessageBox.Show("Family list refreshed!");
            Clear();
            tbnid.ReadOnly = false;
        }

        private void lbdob_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e) // UPDATE BUTTON
        {
            if (string.IsNullOrEmpty(tbnid.Text))
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

           
            if (!int.TryParse(tbnid.Text, out int familyNid) || !int.TryParse(tbprisoner.Text, out int prisonerNid))
            {
                MessageBox.Show("Family NID and Prisoner NID must be valid numbers.");
                return;
            }

            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                 
                    string query = "UPDATE Family SET F_name = @Name, F_pass = @Password, F_dob = @DOB, F_relation = @Relation, Pri_nid = @Pri_nid WHERE F_nid = @Nid";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", string.IsNullOrWhiteSpace(tbname.Text) ? (object)DBNull.Value : tbname.Text);
                        cmd.Parameters.AddWithValue("@Password", string.IsNullOrWhiteSpace(tbpass.Text) ? (object)DBNull.Value : tbpass.Text);

                     
                        if (DateTime.TryParse(tbdob.Text, out DateTime dob))
                        {
                            cmd.Parameters.AddWithValue("@DOB", dob);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@DOB", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@Relation", string.IsNullOrWhiteSpace(tbrelation.Text) ? (object)DBNull.Value : tbrelation.Text);
                        cmd.Parameters.AddWithValue("@Pri_nid", prisonerNid);
                        cmd.Parameters.AddWithValue("@Nid", familyNid);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Updated to the database.");
                        }
                        else
                        {
                            MessageBox.Show("No family member found with the specified NID.");
                        }

                        Refresh();
                        Clear();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e) // DELETE BUTTON
        {
            if (string.IsNullOrEmpty(tbnid.Text))
            {
                MessageBox.Show("Please select a row first.");
                return;
            }
            if (!int.TryParse(tbnid.Text, out int familyNid))
            {
                MessageBox.Show("NID must be a valid number.");
                return;
            }

            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                
                    string query = "DELETE FROM Family WHERE F_nid = @Nid";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nid", familyNid);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted from the database");
                        }
                        else
                        {
                            MessageBox.Show("No family member found with the specified NID.");
                        }
                    }
                }
                Refresh();
                Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e) // ADD BUTTON
        {
            // Validate NID and Pri_nid
            if (!int.TryParse(tbnid.Text, out int familyNid) || !int.TryParse(tbprisoner.Text, out int prisonerNid))
            {
                MessageBox.Show("Family NID and Prisoner NID must be valid numbers.");
                return;
            }

            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Family WHERE Pri_nid = @Pri_nid";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Pri_nid", prisonerNid);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {

                            MessageBox.Show("Prisoner NID is already assigned with another family member.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                  
                    string insertQuery = "INSERT INTO Family (F_name, F_nid, F_pass, F_dob, F_relation, Pri_nid) VALUES (@Name, @Nid, @Password, @DOB, @Relation, @Pri_nid)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", string.IsNullOrWhiteSpace(tbname.Text) ? (object)DBNull.Value : tbname.Text);
                        cmd.Parameters.AddWithValue("@Nid", familyNid);
                        cmd.Parameters.AddWithValue("@Password", string.IsNullOrWhiteSpace(tbpass.Text) ? (object)DBNull.Value : tbpass.Text);

                        if (DateTime.TryParse(tbdob.Text, out DateTime dob))
                        {
                            cmd.Parameters.AddWithValue("@DOB", dob);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@DOB", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@Relation", string.IsNullOrWhiteSpace(tbrelation.Text) ? (object)DBNull.Value : tbrelation.Text);
                        cmd.Parameters.AddWithValue("@Pri_nid", prisonerNid);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added to the database");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                Refresh();
                Clear();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchText = tbsearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a Family NID to search.");
                return;
            }

            

            string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                 
                    string query = "SELECT * FROM Family WHERE CAST(F_nid AS NVARCHAR) LIKE @nid";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@nid", "%" + searchText + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dgvView.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No Family Member found with a matching NID.");
                            dgvView.DataSource = null;
                            Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                tbsearch.Clear();
            }
        }

        private void EditFamily_Load(object sender, EventArgs e)
        {
            
        }
    }
}