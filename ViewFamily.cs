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
    public partial class ViewFamily : Form
    {
        private string staffUsername;
        private string staffNid; 

       
        public ViewFamily(string username, string nid)
        {
            InitializeComponent();
            this.staffUsername = username;
            this.staffNid = nid;
            LoadFamilyData();
        }


      
        private void LoadFamilyData()
        {
            try
            {
                string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void tbsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = tbsearch.Text.Trim();

                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Please enter a Prisoner NID to search Family member.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string connectionString = @"Data Source= MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                 
                    string query = "SELECT * FROM Family WHERE Pri_nid LIKE @nid";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@nid", "%" + searchText + "%");

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        dgvView.AutoGenerateColumns = true;
                        dgvView.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No Family member found matching this Prisoner NID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnrefresh_Click(object sender, EventArgs e)
        {
           
            LoadFamilyData();
            MessageBox.Show("Family list refreshed!");
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

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}