using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class Admin : Form
    {
        private string adminUsername;
        private string adminNid;

      
        public Admin(string username, string nid)
        {
            InitializeComponent();
            this.adminUsername = username;
            this.adminNid = nid;
            lbname.Text = "Welcome, " + adminUsername.ToUpper() + "!";
            count();
        }

       
        public Admin()
        {
            InitializeComponent();
        }

        public void count()
        {
            string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
            int staffCount = 0;
            int prisonerCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string staffQuery = "SELECT COUNT(*) FROM Admin_Staff WHERE Role='STAFF'";
                    using (SqlCommand staffCommand = new SqlCommand(staffQuery, connection))
                    {
                        staffCount = (int)staffCommand.ExecuteScalar();
                    }

                    string prisonerQuery = "SELECT COUNT(*) FROM Prisoner";
                    using (SqlCommand prisonerCommand = new SqlCommand(prisonerQuery, connection))
                    {
                        prisonerCount = (int)prisonerCommand.ExecuteScalar();
                    }
                }
                string summaryText = $"Staff: {staffCount} | Prisoners: {prisonerCount}";
                label1.Text = summaryText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "Error loading data.";
            }
        }

      

        private void btnback_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnprisoners_Click(object sender, EventArgs e)
        {
            EditPrisoners ep = new EditPrisoners(adminUsername , adminNid);
            ep.Show();
            this.Hide();
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            EditStaff es = new EditStaff(adminUsername,adminNid);
            es.Show();
            this.Hide();
        }

        private void btnfamily_Click(object sender, EventArgs e)
        {
            EditFamily ef = new EditFamily(adminUsername,adminNid);
            ef.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewEquipment viewEquipment = new ViewEquipment(adminUsername, adminNid);
            viewEquipment.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAppointment viewAppointment = new ViewAppointment(adminUsername, adminNid);
            viewAppointment.Show();
            this.Hide();
        }

        private void lbname_Click(object sender, EventArgs e)
        {
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to DELETE your Account Permanently?",
                "Save Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                SaveChanges();
            }
        }

        private void SaveChanges()
        {
            string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                  
                    string query = "DELETE FROM Admin_Staff WHERE Nid = @adminNid";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@adminNid", adminNid);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Your Account Successfully Deleted");
                HomePage hp = new HomePage();
                hp.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting account: " + ex.Message);
            }
        }

        private void btncell_Click(object sender, EventArgs e)
        {
            ViewCell viewCell = new ViewCell(adminUsername, adminNid);
            viewCell.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UpdateAdmin ua = new UpdateAdmin(adminUsername, adminNid);
            ua.Show();
            this.Hide();
        }

        private void btnstaffreport_Click(object sender, EventArgs e)
        {
            ViewStaffReport vr = new ViewStaffReport(adminUsername, adminNid);
            vr.Show();
            this.Hide();
        }

        private void btnprisonerreport_Click(object sender, EventArgs e)
        {
           
            ViewPrisonerReport vpr = new ViewPrisonerReport(adminUsername, adminNid);
            vpr.Show();
            this.Hide();
        }
    }
}