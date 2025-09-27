using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class Family : Form
    {
        private string familyUsername;
        private string prisonerNID;
        private string F_Relation;
        private string familyNID;

      
        public Family(string username, string Pri_nid, string F_relation, string f_nid)
        {
            InitializeComponent();
            this.familyUsername = username;
            this.prisonerNID = Pri_nid;
            this.F_Relation = F_relation;
            this.familyNID = f_nid;
            lbPrinid.Text = prisonerNID;
            lbname.Text = "Welcome, " + familyUsername.ToUpper() + "!";
        

            string connectionString = @"Data Source=MSI\SQLEXPRESS; Initial Catalog=PMSdb; Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Pri_status, Trial_date, Verdict, Release_date FROM Prisoner WHERE Pri_nid = @PrisonerNid";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PrisonerNid", prisonerNID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                             
                                lbStatus.Text = reader["Pri_status"].ToString();
                                lbTrial.Text = reader["Trial_date"].ToString();
                                lbVerdict.Text = reader["Verdict"].ToString();
                                lbRelease.Text = reader["Release_date"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Prisoner data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading prisoner data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) // REQUEST BUTTON
        {
            
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=PMSdb;Integrated Security=True;";

           
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                   
                    conn.Open();

                   
                    string checkQuery = "SELECT COUNT(*) FROM Appointment WHERE Pri_nid = @Pri_nid AND F_relation = @F_relation AND (Req_status = 'Requesting' OR Req_status = 'Approved')";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Pri_nid", prisonerNID);
                        checkCmd.Parameters.AddWithValue("@F_relation", F_Relation);
                        int existingAppointments = (int)checkCmd.ExecuteScalar();

                        if (existingAppointments > 0)
                        {
                            MessageBox.Show("You already have a pending or approved appointment. Please check the status page.", "Appointment Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                   
                    string query = "INSERT INTO Appointment (F_relation, Req_date, Req_status, Pri_nid) VALUES (@F_relation, @A_date, @Status, @Pri_nid)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (string.IsNullOrWhiteSpace(F_Relation))
                        {
                            MessageBox.Show("Family relation is missing. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; 
                        }

                        cmd.Parameters.AddWithValue("@F_relation", F_Relation);
                        cmd.Parameters.AddWithValue("@A_date", appointment.Value.Date);
                        cmd.Parameters.AddWithValue("@Status", "REQUESTING");
                        cmd.Parameters.AddWithValue("@Pri_nid", prisonerNID);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Appointment Successfully Placed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
           
            AppointmentStatus appointmentStatusForm = new AppointmentStatus(familyUsername,prisonerNID, F_Relation,familyNID);
            appointmentStatusForm.Show();
            this.Hide();
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
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "delete from Family where Pri_nid=" + prisonerNID + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Account Successfully Deleted");
            HomePage hp = new HomePage();
            hp.Show();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UpdateFamily uf = new UpdateFamily(familyUsername, prisonerNID, F_Relation,familyNID);
            uf.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportStaff rs = new ReportStaff(familyUsername, prisonerNID, F_Relation, familyNID);
            rs.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show(
            "Punishment – to restrict freedom as a consequence of crime.\r\n\r\nRehabilitation – to help prisoners change their behavior and return to society.\r\n\r\nProtection of Society – keeping dangerous criminals away from the public.\r\n\r\nDeterrence – discouraging others from committing crimes.",
            " Main Objectives of Prison",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                return;
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
          "Families usually need to apply for permission before visiting.\r\n\r\nOnly immediate family members (parents, spouse, children, siblings) are allowed in most cases.\r\n\r\n\r\n\r\nID proof is required at the gate (like NID, passport, driving license).\r\n\r\nAll visitors go through security checks before entering.\r\n\r\n\r\n\r\nFamilies may be allowed to send clothes, medicines, or money, but only through official approval.\r\n\r\nFood from outside is usually restricted",
          "Rules & Regulations of Prison",
          MessageBoxButtons.OK,
          MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                return;
            }
        }

        private void Family_Load(object sender, EventArgs e)
        {

        }
    }
}