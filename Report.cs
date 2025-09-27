using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class Report : Form
    {
        
        private static List<string> updatedPrisoners = new List<string>();

        private string staffUsername;
        private string staffNid;

        public Report(string username, string nid)
        {
            InitializeComponent();
            this.staffUsername = username;
            this.staffNid = nid;
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

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            
            string prisonerId = tbid.Text.Trim();

            if (string.IsNullOrEmpty(prisonerId))
            {
                MessageBox.Show("Enter prisoner ID");
                return;
            }

            
            if (updatedPrisoners.Contains(prisonerId))
            {
                MessageBox.Show("This prisoner's status has already been updated in this session.", "Update Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!rdbgreen.Checked && !rdbred.Checked)
            {
                MessageBox.Show("Select Green or Red");
                return;
            }

            try
            {
                string status = rdbgreen.Checked ? "GREEN" : "RED";
                string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                  
                    string getPrisonerDataQuery = "SELECT Pri_nid, Pri_name, Pri_status FROM Prisoner WHERE Pri_id = @priId";

                    string prisonerNid = null;
                    string prisonerName = null;
                    string currentStatus = null; 

                    using (SqlCommand getCmd = new SqlCommand(getPrisonerDataQuery, conn))
                    {
                        getCmd.Parameters.AddWithValue("@priId", prisonerId);

                        using (SqlDataReader reader = getCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                prisonerNid = reader["Pri_nid"].ToString();
                                prisonerName = reader["Pri_name"].ToString();
                                currentStatus = reader["Pri_status"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No prisoner found with that ID. Report not created.");
                                return;
                            }
                        }
                    }

                    if (currentStatus.Equals(status, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show($"Prisoner status is already {status}.", "No Change Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    
                    string updatePrisonerQuery = "UPDATE Prisoner SET Pri_status = @status WHERE Pri_id = @priId";
                    using (SqlCommand cmd = new SqlCommand(updatePrisonerQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@priId", prisonerId);
                        cmd.ExecuteNonQuery();
                    }

                    
                    string insertReportQuery = "INSERT INTO PrisonerReports (R_date, Pri_nid, Staff_id, Pri_name) VALUES (@reportDate, @priNid, @staffId, @priName)";
                    using (SqlCommand cmd1 = new SqlCommand(insertReportQuery, conn))
                    {
                        cmd1.Parameters.AddWithValue("@reportDate", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd1.Parameters.AddWithValue("@priNid", prisonerNid);
                        cmd1.Parameters.AddWithValue("@staffId", staffNid);
                        cmd1.Parameters.AddWithValue("@priName", prisonerName);
                        cmd1.ExecuteNonQuery();

                      
                        updatedPrisoners.Add(prisonerId);

                        MessageBox.Show("Prisoner updated and report logged successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}   