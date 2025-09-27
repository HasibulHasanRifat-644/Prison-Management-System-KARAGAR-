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
    public partial class UpdateStaff : Form
    {
        private string staffUsername;
        private string staffNid;
        public UpdateStaff(string username , string nid)
        {
            InitializeComponent();
            this.staffUsername = username;
            this.staffNid = nid;
            this.tbnid.Text = staffNid;
            this.tbnid.ReadOnly = true;

            this.tbpass.UseSystemPasswordChar = true;
        }

       
        public UpdateStaff()
        {
            InitializeComponent();
           
            this.tbpass.UseSystemPasswordChar = true;
        }

        public void Clear()
        {
            tbname.Clear();
            tbnid.Clear();
            tbpass.Clear();
            tbdob.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff(staffUsername,staffNid);
            staff.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbname.Text) || string.IsNullOrEmpty(tbpass.Text) || string.IsNullOrEmpty(tbdob.Text))
            {
                MessageBox.Show("Please fill out all the fields before updating.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=PMSdb;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE Admin_Staff SET Name = @Name, Pass = @Pass, DOB = @DOB WHERE Nid = @Nid";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", tbname.Text);
                        cmd.Parameters.AddWithValue("@Pass", tbpass.Text);

                        if (DateTime.TryParse(tbdob.Text, out DateTime dateOfBirth))
                        {
                            cmd.Parameters.AddWithValue("@DOB", dateOfBirth);
                        }
                        else
                        {
                            MessageBox.Show("Invalid date format. Please enter a valid date (e.g., YYYY-MM-DD).", "Date Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                      
                        cmd.Parameters.AddWithValue("@Nid", tbnid.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. The specified NID might not exist.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during the update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cbshow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow.Checked)
            {
                tbpass.UseSystemPasswordChar = false;
            }
            else
            {
                tbpass.UseSystemPasswordChar = true;
            }
        }
    }
}