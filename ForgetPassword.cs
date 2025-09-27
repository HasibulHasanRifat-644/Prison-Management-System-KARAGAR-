using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();

            lblpriid.Hide();
            txtpriid.Hide();
            lblpripass.Hide();
            txtpripass.Hide();

            lblnewpass.Hide();
            txtnewpass.Hide();
            btnchange.Hide();
        }

        private void cmbrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnchange_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnewpass.Text))
            {
                MessageBox.Show("Please enter a new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtnewpass.Text.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                String conc = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=PMSdb;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(conc))
                {
                    conn.Open();

                    string query = "";
                    SqlCommand cmd;

                    if (cmbrole.Text == "FAMILY")
                    {
                       
                        query = "UPDATE Family SET F_pass = @NewPassword WHERE F_nid = @F_nid AND Pri_nid = @Pri_nid";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@NewPassword", txtnewpass.Text);
                        cmd.Parameters.AddWithValue("@F_nid", txtid.Text); // The Family NID
                        cmd.Parameters.AddWithValue("@Pri_nid", txtpriid.Text); // The Prisoner NID
                    }
                    else if (cmbrole.Text == "STAFF" || cmbrole.Text == "ADMIN")
                    {
                      
                        query = "UPDATE Admin_Staff SET Pass = @NewPassword WHERE Nid = @Id AND Name = @Name AND Role = @Role";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@NewPassword", txtnewpass.Text);
                        cmd.Parameters.AddWithValue("@Id", txtid.Text);
                        cmd.Parameters.AddWithValue("@Name", txtname.Text);
                        cmd.Parameters.AddWithValue("@Role", cmbrole.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SignIn signInForm = new SignIn();
                        signInForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncontinue_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtname.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                string.IsNullOrWhiteSpace(txtid.Text) ||
                string.IsNullOrWhiteSpace(cmbrole.Text) ||
                (cmbrole.Text.Equals("FAMILY") &&
                 (string.IsNullOrWhiteSpace(txtpriid.Text) || string.IsNullOrWhiteSpace(txtpripass.Text))))
            {
                MessageBox.Show("All fields must be filled!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ID must be 4 digit integer
            if (!Regex.IsMatch(txtid.Text, @"^\d{4}$"))
            {
                MessageBox.Show("ID must be exactly 4 digits!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string role = cmbrole.Text;
            bool isValid = false;

            try
            {
                string conc = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=PMSdb;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(conc))
                {
                    conn.Open();

                    if (role.Equals("STAFF") || role.Equals("ADMIN"))
                    {
                        string query = "SELECT COUNT(*) FROM Admin_Staff WHERE Name=@Name AND DOB=@DOB AND Nid=@Id AND Role=@Role";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", txtname.Text);
                            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.Date);
                            cmd.Parameters.AddWithValue("@Id", txtid.Text);
                            cmd.Parameters.AddWithValue("@Role", cmbrole.Text);

                            int count = (int)cmd.ExecuteScalar();
                            if (count > 0) isValid = true;
                        }
                    }
                    else if (role.Equals("FAMILY"))
                    {
                        
                        string query = @"
                            SELECT COUNT(*) 
                            FROM Family f
                            INNER JOIN Prisoner p ON f.Pri_nid = p.Pri_nid
                            WHERE f.F_name=@Name 
                              AND f.F_dob=@DOB 
                              AND f.F_nid=@Id 
                              AND p.Pri_nid=@PriNid 
                              AND p.Pri_pass=@PriPass";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", txtname.Text);
                            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.Date);
                            cmd.Parameters.AddWithValue("@Id", txtid.Text);
                            cmd.Parameters.AddWithValue("@PriNid", txtpriid.Text);
                            cmd.Parameters.AddWithValue("@PriPass", txtpripass.Text);

                            int count = (int)cmd.ExecuteScalar();
                            if (count > 0) isValid = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            if (isValid)
            {
                lblnewpass.Show();
                txtnewpass.Show();
                btnchange.Show();
            }
            else
            {
                MessageBox.Show("Provided information does not match our records.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbrole_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbrole.Text.Equals("FAMILY"))
            {
                lblpriid.Show();
                txtpriid.Show();
                lblpripass.Show();
                txtpripass.Show();
            }
            else
            {
                lblpriid.Hide();
                txtpriid.Hide();
                lblpripass.Hide();
                txtpripass.Hide();
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            SignIn si = new SignIn();
            si.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}