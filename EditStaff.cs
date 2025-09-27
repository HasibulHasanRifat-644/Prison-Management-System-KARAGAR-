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
    public partial class EditStaff : Form
    {
        private string adminName;
        private string adminNid;
        public void Refresh()
        {
            try
            {

                string connectionString = @"Data Source =  MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "select NID , Name , Pass , DOB , ManagerID from Admin_Staff where Role = 'STAFF' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvView.AutoGenerateColumns = true;
                dgvView.DataSource = dt;
                tbnid.ReadOnly = false;


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
                tbname.Text = dgvView.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                tbnid.Text = dgvView.Rows[e.RowIndex].Cells["NID"].Value?.ToString();
                tbpass.Text = dgvView.Rows[e.RowIndex].Cells["Pass"].Value?.ToString();
                tbdob.Text = dgvView.Rows[e.RowIndex].Cells["DOB"].Value?.ToString();
                tbmanager.Text = dgvView.Rows[e.RowIndex].Cells["ManagerID"].Value?.ToString();
                tbnid.ReadOnly = true;
            }
        }


        public void Clear()
        {
            tbname.Clear();
            tbnid.Clear();
            tbpass.Clear();
            tbdob.Clear();
            tbmanager.Clear();

        }

        public EditStaff(string username, string nid)
        {
            InitializeComponent();
            this.adminName = username;
            this.adminNid = nid;
           tbnid.ReadOnly = false;
            Refresh();

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
            MessageBox.Show("Staff list refreshed!");
            Clear();
           tbnid.ReadOnly = false;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchText = tbsearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a Staff NID to search.");
                return;
            }

            string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Name, Nid, Pass, DOB, ManagerID FROM Admin_Staff WHERE Nid LIKE @nid AND Role = 'STAFF'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nid", $"%{searchText}%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dgvView.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No Staff found matching this NID.");
                            dgvView.DataSource = null;
                            Refresh();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                tbsearch.Clear();
            }
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Admin_Staff (Role, Name, Nid, Pass, DOB, ManagerID) VALUES (@Role, @Name, @Nid, @Password, @DOB, @ManagerID)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        

                        cmd.Parameters.AddWithValue("@Role", "STAFF");

                        cmd.Parameters.AddWithValue("@Name", string.IsNullOrWhiteSpace(tbname.Text) ? (object)DBNull.Value : tbname.Text);

                        if (string.IsNullOrWhiteSpace(tbnid.Text))
                        {
                            cmd.Parameters.AddWithValue("@Nid", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Nid", int.Parse(tbnid.Text));
                        }

                        cmd.Parameters.AddWithValue("@Password", string.IsNullOrWhiteSpace(tbpass.Text) ? (object)DBNull.Value : tbpass.Text);

                        cmd.Parameters.AddWithValue("@DOB", string.IsNullOrWhiteSpace(tbdob.Text) ? (object)DBNull.Value : tbdob.Text);

                        if (string.IsNullOrWhiteSpace(tbmanager.Text))
                        {
                            cmd.Parameters.AddWithValue("@ManagerID", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ManagerID", int.Parse(tbmanager.Text));
                        }

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added to the database");

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
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbnid.Text))
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string query = "UPDATE Admin_Staff SET Name = @Name, Pass = @Password, DOB = @DOB, Role = @Role, ManagerID = @ManagerID WHERE Nid = @Nid";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@Name", tbname.Text);
                        cmd.Parameters.AddWithValue("@Password", tbpass.Text); 
                        cmd.Parameters.AddWithValue("@DOB", tbdob.Text);
                        cmd.Parameters.AddWithValue("@Role", "STAFF");
                        cmd.Parameters.AddWithValue("@ManagerID", tbmanager.Text);
                        cmd.Parameters.AddWithValue("@Nid", tbnid.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Updated to the database.");
                        }
                        else
                        {
                            MessageBox.Show("No staff member found with the specified ID.");
                        }

                        Refresh();
                        Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {

            if (tbnid.Text == "")
                MessageBox.Show("Please select a row first:");
            else
            {
                string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "delete from Admin_Staff where Nid =" + tbnid.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Refresh();
                Clear();
                MessageBox.Show("Deleted from the database");
                Refresh();

            }

        }

        private void EditStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
