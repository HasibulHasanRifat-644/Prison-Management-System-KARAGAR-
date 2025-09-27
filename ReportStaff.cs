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
    public partial class ReportStaff : Form
    {
        private string familyUsername;
        private string prisonerNID;
        private string F_Relation;
        private string familyNID;

        public ReportStaff()
        {
            InitializeComponent();
        }

       
        public ReportStaff(string fUsername,string priNid, string fRelation, string fNid)
        {
            InitializeComponent();
            this.familyUsername = fUsername;
            this.prisonerNID = priNid;
            this.F_Relation = fRelation;
            this.familyNID = fNid;
            txtfname.Text = fUsername;
            txtnid.Text = fNid;
        }

        private void ReportStaff_Load(object sender, EventArgs e)
        {
        }

        private void btnback_Click(object sender, EventArgs e)
        {
           
            Family family = new Family(familyUsername, prisonerNID, F_Relation, familyNID);
            family.Show();
            this.Hide();
        }

        private void btnsubmit_Click_1(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Please enter the Staff Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Focus();
                return;
            }
            if (int.TryParse(txtname.Text, out _))
            {
                MessageBox.Show("Staff Name cannot be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtname.Focus();
                return;
            }

          
            if (string.IsNullOrWhiteSpace(rtbdetails.Text))
            {
                MessageBox.Show("Please enter report details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbdetails.Focus();
                return;
            }

           
            string staffName = txtname.Text.Trim();
            string details = rtbdetails.Text.Trim();
            DateTime reportDate = DateTime.Now;

            string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string checkStaffQuery = "SELECT COUNT(*) FROM Admin_Staff WHERE Name = @StaffName";
                    SqlCommand checkStaffCmd = new SqlCommand(checkStaffQuery, conn);
                    checkStaffCmd.Parameters.AddWithValue("@StaffName", staffName);
                    int staffExists = (int)checkStaffCmd.ExecuteScalar();

                    if (staffExists == 0)
                    {
                        MessageBox.Show("Wrong Staff Name! Please enter a valid staff name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtname.Focus();
                        return;
                    }

                    
                    string insertQuery = "INSERT INTO ReportStaff (Name, F_nid,F_name, RS_date, RS_details) " +
                                         "VALUES (@Name, @FNid,@FName, @RDate, @Details)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@Name", staffName);
                    insertCmd.Parameters.AddWithValue("@FNid", this.familyNID);
                    insertCmd.Parameters.AddWithValue("@FName", this.familyUsername);
                    insertCmd.Parameters.AddWithValue("@RDate", reportDate);
                    insertCmd.Parameters.AddWithValue("@Details", details);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Report Submitted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    txtname.Clear();
                    rtbdetails.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}