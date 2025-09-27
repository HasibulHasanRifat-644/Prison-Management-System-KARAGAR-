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
    public partial class UpdateFamily : Form
    {
        private string FamilyNID;
        private string PrisonerNID;
        private string F_relation;
        private string FamilyUsername;

        public UpdateFamily(string familyUsername, string prisonerNID, string f_Relation, string familyNID)
        {
            InitializeComponent();
            
            this.FamilyUsername = familyUsername;
            this.PrisonerNID = prisonerNID;
            this.F_relation = f_Relation;
            this.FamilyNID = familyNID;

           
            this.tbnid.ReadOnly = true;
            this.tbprisoner.ReadOnly = true;
            this.tbpass.UseSystemPasswordChar = true; 
            this.tbnid.Text = familyNID;
            this.tbprisoner.Text = prisonerNID;

           
        }

     
        public void Clear()
        {
            tbname.Clear();
            tbnid.Clear();
            tbpass.Clear();
            tbdob.Clear();
            tbrelation.Clear();
            tbprisoner.Clear();
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

        private void btnback_Click(object sender, EventArgs e)
        {
            Family family = new Family(FamilyUsername, PrisonerNID, F_relation, FamilyNID);
            family.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbname.Text) || string.IsNullOrEmpty(tbpass.Text) || string.IsNullOrEmpty(tbdob.Text) || string.IsNullOrEmpty(tbrelation.Text))
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

                    string query = "UPDATE Family SET F_name = @F_name, F_pass = @F_pass, F_dob = @F_dob, F_relation = @F_relation WHERE F_nid = @F_nid";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@F_name", tbname.Text);
                        cmd.Parameters.AddWithValue("@F_pass", tbpass.Text);

                        DateTime dateOfBirth;
                        if (DateTime.TryParse(tbdob.Text, out dateOfBirth))
                        {
                            cmd.Parameters.AddWithValue("@F_dob", dateOfBirth);
                        }
                        else
                        {
                            MessageBox.Show("Invalid date format. Please enter a valid date (e.g., YYYY-MM-DD).", "Date Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        cmd.Parameters.AddWithValue("@F_relation", tbrelation.Text);
                        cmd.Parameters.AddWithValue("@F_nid", tbnid.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfully Updated.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Check the NID value.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
            }
        }

        private void lbprisoner_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}