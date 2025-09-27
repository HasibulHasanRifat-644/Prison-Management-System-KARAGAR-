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
using System.Xml.Linq;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class EditPrisoners : Form
    {

        private string adminName;
        private string adminNid;
        public void Refresh()
        {
            try
            {

                string connectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "select * from Prisoner";
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
                tbname.Text = dgvView.Rows[e.RowIndex].Cells[1].Value?.ToString();
                tbnid.Text = dgvView.Rows[e.RowIndex].Cells[0].Value?.ToString();
                tbprisoner.Text = dgvView.Rows[e.RowIndex].Cells[2].Value?.ToString();
                tbpass.Text = dgvView.Rows[e.RowIndex].Cells[3].Value?.ToString();
                tbstatus.Text = dgvView.Rows[e.RowIndex].Cells[4].Value?.ToString();
                tbcrime.Text = dgvView.Rows[e.RowIndex].Cells[5].Value?.ToString();
                tbverdict.Text = dgvView.Rows[e.RowIndex].Cells[6].Value?.ToString();
                tbtrial.Text = dgvView.Rows[e.RowIndex].Cells[7].Value?.ToString();
                tbrelease.Text = dgvView.Rows[e.RowIndex].Cells[8].Value?.ToString();
                //tbnid.ReadOnly = true;
                tbprisoner.ReadOnly = true;

            }
        }


        public EditPrisoners(string username, string nid)
        {
            InitializeComponent();
            this.adminName = username;
            this.adminNid = nid;
            Refresh();
            tbnid.ReadOnly = false;
            tbprisoner.ReadOnly = true;

            


        }

        public void Clear()
        {
            tbname.Clear();
            tbnid.Clear();
            tbprisoner.Clear();
            tbpass.Clear();
            tbstatus.Clear();
            tbcrime.Clear();
            tbverdict.Clear();
            tbrelease.Clear();
            tbtrial.Clear();

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
            MessageBox.Show("Prisoner list refreshed!");
            Clear();
            tbnid.ReadOnly= false;

        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (tbnid.Text == "")
            {
                MessageBox.Show("Please select a row first:");

            }


            else
            {
                if (!int.TryParse(tbnid.Text, out int priNid))
                {
                    MessageBox.Show(" Prisoner NID must be valid numbers.");
                    return;
                }

                string connectionString = @"Data Source =  MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "update Prisoner set Pri_name='" + tbname.Text + "',Pri_pass='" + tbpass.Text + "',Pri_status='" + tbstatus.Text + "',Crime='" + tbcrime.Text + "',Verdict='" + tbverdict.Text + "',Trial_date='" + tbtrial.Text +"',Release_date='" + tbrelease.Text + "' where Pri_nid=" + tbnid.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Refresh();
                Clear();
                MessageBox.Show("Updated to the database");
                Refresh();

            }

        }



        private void button3_Click(object sender, EventArgs e)//DELETE BUTTON
        {
            if (tbnid.Text == "")
                MessageBox.Show("Please select a row first:");
            else
            {
                string connectionString = @"Data Source =  MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "delete from Prisoner where Pri_nid=" + tbnid.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Refresh();
                Clear();
                MessageBox.Show("Deleted from the database");
                Refresh();

            }
        }


        private void button1_Click(object sender, EventArgs e) // ADD BUTTON
        {
            try
            {
                if (!int.TryParse(tbnid.Text, out int priNid))
                {
                    MessageBox.Show(" Prisoner NID must be valid numbers.");
                    return;
                }

                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Prisoner (Pri_name, Pri_nid, Pri_pass, Pri_status, Crime, Verdict, Trial_date, Release_date) VALUES (@name, @nid, @pass, @status, @crime, @verdict, @trial, @release)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@name", tbname.Text);

                        if (string.IsNullOrWhiteSpace(tbnid.Text))
                        {
                            cmd.Parameters.AddWithValue("@nid", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@nid", int.Parse(tbnid.Text));
                        }

                        cmd.Parameters.AddWithValue("@pass", tbpass.Text);
                        cmd.Parameters.AddWithValue("@status", tbstatus.Text);
                        cmd.Parameters.AddWithValue("@crime", tbcrime.Text);
                        cmd.Parameters.AddWithValue("@verdict", tbverdict.Text);

                        
                        if (string.IsNullOrWhiteSpace(tbtrial.Text))
                        {
                            cmd.Parameters.AddWithValue("@trial", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@trial", DateTime.Parse(tbtrial.Text));
                        }

                        if (string.IsNullOrWhiteSpace(tbrelease.Text))
                        {
                            cmd.Parameters.AddWithValue("@release", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@release", DateTime.Parse(tbrelease.Text));
                        }

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added to the database");

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
        private void lblview_Click(object sender, EventArgs e)
        {

        }








        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchText = tbsearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a Prisoner ID to search.");
                return;
            }

            string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Prisoner WHERE Pri_id LIKE @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", "%" + searchText + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            dgvView.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No prisoner found matching this ID.");
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



       

        private void EditPrisoners_Load(object sender, EventArgs e)
        {

        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditPrisoners_Load_1(object sender, EventArgs e)
        {

        }
    }
    }

