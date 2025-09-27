using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class ViewCell : Form
    {
        private string adminUsername;
        private string adminNid;
        public void Refresh()
        {
            try
            {

                string connectionString = @"Data Source =  MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "select * from Cell";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvView.AutoGenerateColumns = true;
                dgvView.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

       

        public ViewCell(string username, string nid)
        {
            InitializeComponent();
            tbid.ReadOnly = false; 
            this.adminUsername = username;
            this.adminNid = nid;
            Refresh();
         
        }
        public void Clear()
        {
            tbname.Clear();
            tbid.Clear();
            tbcount.Clear();
        
        }

       
        private void label3_Click(object sender, EventArgs e)
        {

        }



     

        

      
     

        private void ViewCell_Load(object sender, EventArgs e)
        {

        }

        private void lblview_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {

            try
            {
                string searchText = tbsearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    MessageBox.Show("Please enter a Cell ID to search.");
                    return;
                }

                string connectionString = @"Data Source= MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Cell WHERE C_id LIKE @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", "%" + searchText + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                      
                        dgvView.AutoGenerateColumns = true;
                        dgvView.DataSource = dt;

                        if (dt.Rows.Count > 0)
                        {
                       
                            DataRow row = dt.Rows[0];
                            tbid.Text = row["C_id"].ToString();
                            tbname.Text = row["C_name"].ToString();
                            tbcount.Text = row["C_count"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No Cell found matching this ID.");
                            Clear();                   
                            dgvView.DataSource = null;  
                        }
                    }
                }

                tbsearch.Clear(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            tbsearch.Clear();
            Clear();
            MessageBox.Show("Cell list refreshed!");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin(adminUsername, adminNid);
            ad.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source =  MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "INSERT INTO Cell (C_name, C_count) VALUES ('" + tbname.Text + "',  " + tbcount.Text + ")";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Refresh();
                Clear();
                MessageBox.Show("Added to the database");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            if (tbid.Text == "")
            {
                MessageBox.Show("Please select a row first:");

            }


            else
            {
                string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "update Cell set C_name='" + tbname.Text + "',C_count=" + tbcount.Text + " where C_id=" + tbid.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Refresh();
                Clear();
                MessageBox.Show("Updated to the database");

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "")
                MessageBox.Show("Please select a row first:");
            else
            {
                string connectionString = @"Data Source =  MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "delete from Cell where C_id=" + tbid.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Refresh();
                Clear();
                MessageBox.Show("Deleted from the database");

            }
        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbid.Text = dgvView.Rows[e.RowIndex].Cells[0].Value?.ToString();
                tbname.Text = dgvView.Rows[e.RowIndex].Cells[1].Value?.ToString();
                tbcount.Text = dgvView.Rows[e.RowIndex].Cells[2].Value?.ToString();
                tbid.ReadOnly = true;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


