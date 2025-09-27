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
    public partial class ViewAppointment : Form
    {

        private string adminUsername;
        private string adminNid;
        public void Refresh()
        {
            try
            {

               
                string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
             
                string query = "select * from Appointment";
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
        public ViewAppointment(string username, string nid)
        {
            InitializeComponent();
            this.adminUsername = username;
            this.adminNid = nid; 
            Refresh();
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

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            tbsearch.Clear();
            MessageBox.Show("Appointment list refreshed!");
            tbsearch.Clear();


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchText = tbsearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter an Appointment ID to search.");
                return;
            }

            string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT * 
                FROM Appointment
                WHERE CAST(A_Id AS NVARCHAR) LIKE @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", "%" + searchText + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvView.AutoGenerateColumns = true;
                        dgvView.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No appointments found matching this ID.");
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



        private void ViewAppointment_Load(object sender, EventArgs e)
        {

        }

    }
}
