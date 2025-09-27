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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class SignUp : Form
    {
        public void Connect_A()
        {
            try
            {
                String conc = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                using (SqlConnection conn = new SqlConnection(conc))
                {
                    conn.Open();
                
                    String query = "INSERT INTO Admin_Staff (Name,Nid, DOB, Pass, Role) VALUES (@Name,@Nid, @DOB, @Pass, @Role )";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", tbname.Text);
                        cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@Pass", tbpass.Text);
                        cmd.Parameters.AddWithValue("@Nid", tbnid.Text);
                        cmd.Parameters.AddWithValue("@Role", cbrole.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void Connect_S()
        {
            try
            {
                String conc = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                using (SqlConnection conn = new SqlConnection(conc))
                {
                    conn.Open();
                   
                    String query = "INSERT INTO Admin_Staff (Name,Nid, DOB, Pass, Role , ManagerID) VALUES (@Name,@Nid, @DOB, @Pass, @Role , 101 )";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", tbname.Text);
                        cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@Pass", tbpass.Text);
                        cmd.Parameters.AddWithValue("@Nid", tbnid.Text);
                        cmd.Parameters.AddWithValue("@Role", cbrole.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public bool Connect_F()
        {
            try
            {
                String conc = @"Data Source= MSI\SQLEXPRESS;Initial Catalog=PMSdb;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(conc))
                {
                    conn.Open();

                  
                    String checkQuery = "SELECT COUNT(*) FROM Family WHERE Pri_nid = @Pid";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Pid", tbprisonerid.Text);
                        int existingCount = (int)checkCmd.ExecuteScalar();

                        if (existingCount > 0)
                        {
                            MessageBox.Show("This prisoner ID is already registered by another family member.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false; 
                        }
                    }

                    String query = "INSERT INTO Family (F_name, F_dob,F_nid, F_pass, F_relation ,Pri_nid) VALUES (@Name, @DOB,@Nid, @Pass, @Relation, @Pid)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", tbname.Text);
                        cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                        cmd.Parameters.AddWithValue("@Pass", tbpass.Text);
                        cmd.Parameters.AddWithValue("@Nid", tbnid.Text);
                        cmd.Parameters.AddWithValue("@Relation", cbrelation.Text);
                        cmd.Parameters.AddWithValue("@Pid", tbprisonerid.Text);
                        cmd.ExecuteNonQuery();
                    }

                    return true; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public SignUp()
        {
            InitializeComponent();
            lbrelation.Hide();
            cbrelation.Hide();
            lbprisonerid.Hide();
            tbprisonerid.Hide();
            lbprisonerpass.Hide();
            tbprisonerpass.Hide();
            cbpri.Hide();
            tbnid.KeyPress += tbnid_KeyPress;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void Nid_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void Pass_Click(object sender, EventArgs e)
        {
        }

        private void jail_Logo_Click(object sender, EventArgs e)
        {
        }

        private bool IsNidValid(string nid)
        {
            return nid.Length == 4 && nid.All(char.IsDigit);
        }

        private bool IsPasswordValid(string pass)
        {
            return pass.Length >= 4;
        }

        private bool IsAgeValid(DateTime dob)
        {
            var today = DateTime.Now.Date;
            int age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;
            return age >= 18;
        }

        private bool IsFieldEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /*
        private void CreateAccount_Click(object sender, EventArgs e)
        {
            // Clear all error labels first
            lblrole.Text = "";
            lblname.Text = "";
            lblnid.Text = "";
            lblpass.Text = "";
            lbldob.Text = "";
            lblpriid.Text = "";
            lblrltn.Text = "";
            lblpripass.Text = "";

            bool hasError = false;
            string role = cbrole.Text.Trim();
            string username = tbname.Text.Trim();
            string nid = tbnid.Text.Trim();
            string pass = tbpass.Text.Trim();
            string prisonerId = tbprisonerid.Text.Trim();
            string relation = cbrelation.Text.Trim();
            DateTime dob = dateTimePicker1.Value;

            if (tbname.Text == "" && tbnid.Text == "" && tbpass.Text == "" && cbrole.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                // Username
                if (string.IsNullOrWhiteSpace(username))
                {
                    lblname.Text = "Name is required!";
                    lblname.ForeColor = Color.Red;
                    hasError = true;
                }
                else if (!username.All(char.IsLetter))
                {
                    lblname.Text = "Name can contain only letters!";
                    hasError = true;
                }

                // NID
                if (string.IsNullOrWhiteSpace(nid))
                {
                    lblnid.Text = "NID is required!";
                    lblnid.ForeColor = Color.Red;
                    hasError = true;
                }
                if (!int.TryParse(nid, out int nidValue))
                {
                    lblnid.Text = "NID must be a numeric value!";
                    lblnid.ForeColor = Color.Red;
                    hasError = true;
                }


                else if (!IsNidValid(nid))
                {
                    lblnid.Text = "NID must be exactly 4 digits!";
                    lblnid.ForeColor = Color.Red;
                    hasError = true;
                }

                // Password
                if (string.IsNullOrWhiteSpace(pass))
                {
                    lblpass.Text = "Password is required!";
                    lblpass.ForeColor = Color.Red;
                    hasError = true;
                }
                else if (!IsPasswordValid(pass))
                {
                    lblpass.Text = "Password must be at least 4 characters!";
                    lblpass.ForeColor = Color.Red;
                    hasError = true;
                }

                // Role
                if (cbrole.SelectedIndex == -1)
                {
                    lblrole.Text = "Role is required!";
                    lblrole.ForeColor = Color.Red;
                    hasError = true;
                }

                // DOB / age
                if (!IsAgeValid(dob))
                {
                    lbldob.Text = "Must be 18 years or older!";
                    lbldob.ForeColor = Color.Red;
                    hasError = true;
                }

                // FAMILY-specific fields
                if (role.Equals("FAMILY"))
                {
                    if (string.IsNullOrWhiteSpace(prisonerId))
                    {
                        lblpriid.Text = "Prisoner ID is required!";
                        lblpriid.ForeColor = Color.Red;
                        hasError = true;
                    }
                    else if (!IsNidValid(prisonerId))
                    {
                        lblpriid.Text = "Prisoner ID must be exactly 4 digits!";
                        lblpriid.ForeColor = Color.Red;
                        hasError = true;
                    }

                    if (cbrelation.SelectedIndex == -1)
                    {
                        lblrltn.Text = "Relation is required!";
                        lblrltn.ForeColor = Color.Red;
                        hasError = true;
                    }

                    if (string.IsNullOrWhiteSpace(tbprisonerpass.Text))
                    {
                        lblpripass.Text = "Password is required!";
                        lblpripass.ForeColor = Color.Red;
                        hasError = true;
                    }
                    else if (!IsPasswordValid(tbprisonerpass.Text))
                    {
                        lblpripass.Text = "Password must be at least 4 characters!";
                        lblpripass.ForeColor = Color.Red;
                        hasError = true;
                    }
                }

                // Stop if any error
                if (hasError) return;

                // ✅ All validations passed → insert into DB
                if (role.Equals("ADMIN"))
                {
                    Connect_A();
                    MessageBox.Show("Admin account created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (role.Equals("STAFF"))
                {
                    Connect_S();
                    MessageBox.Show("Staff account created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (role.Equals("FAMILY"))
                {
                    if (Connect_F())
                    {
                        MessageBox.Show("Family account created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else return; // error already handled in Connect_F
                }

                // Clear form after success
                tbname.Clear();
                tbnid.Clear();
                tbpass.Clear();
                tbprisonerid.Clear();
                tbprisonerpass.Clear();
                cbrole.SelectedIndex = -1;
                cbrelation.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Now;

                // Go to SignIn
                SignIn signForm = new SignIn();
                signForm.Show();
                this.Hide();
            }
        }
        */
        private void lblsignup_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = cbrole.Text;

            if (role.Equals("FAMILY"))
            {
                this.lbrelation.Show();
                this.cbrelation.Show();
                this.lbprisonerid.Show();
                this.tbprisonerid.Show();
                lbprisonerpass.Show();
                tbprisonerpass.Show();
                cbpri.Show();
            }

            if (role.Equals("ADMIN") || role.Equals("STAFF"))
            {
                lbrelation.Hide();
                cbrelation.Hide();
                lbprisonerid.Hide();
                tbprisonerid.Hide();
                lbprisonerpass.Hide();
                tbprisonerpass.Hide();
                    cbpri.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void lbsignin_Click(object sender, EventArgs e)
        {
            SignIn si = new SignIn();
            si.Show();
            this.Hide();
        }

        private void lblprisonerpass_Click(object sender, EventArgs e)
        {
        }

        private void tbprisonerpass_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbprisonerid_Click(object sender, EventArgs e)
        {

        }
        private void tbnid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btcreate_Click(object sender, EventArgs e)
        {
            lblrole.Text = "";
            lblname.Text = "";
            lblnid.Text = "";
            lblpass.Text = "";
            lbldob.Text = "";
            lblpriid.Text = "";
            lblrltn.Text = "";
            lblpripass.Text = "";

            bool hasError = false;
            string role = cbrole.Text;
            string username = tbname.Text;
            string nid = tbnid.Text;
            string pass = tbpass.Text;
            string prisonerId = tbprisonerid.Text;
            string relation = cbrelation.Text;
            DateTime dob = dateTimePicker1.Value;

            if (tbname.Text == "" && tbnid.Text == "" && tbpass.Text == "" && cbrole.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                // Username
                if (string.IsNullOrWhiteSpace(username))
                {
                    lblname.Text = "Name is required!";
                    lblname.ForeColor = Color.Red;
                    hasError = true;
                }
                else if (!username.All(char.IsLetter))
                {
                    lblname.Text = "Name can contain only letters!";
                    lblname.ForeColor = Color.Red;
                    hasError = true;
                }

                // NID
                if (string.IsNullOrWhiteSpace(nid))
                {
                    lblnid.Text = "NID is required!";
                    lblnid.ForeColor = Color.Red;
                    hasError = true;
                }
                if (!int.TryParse(nid, out int nidValue))
                {
                    lblnid.Text = "NID must be a numeric value!";
                    lblnid.ForeColor = Color.Red;
                    hasError = true;
                }


                else if (!IsNidValid(nid))
                {
                    lblnid.Text = "NID must be exactly 4 digits!";
                    lblnid.ForeColor = Color.Red;
                    hasError = true;
                }

                // Password
                if (string.IsNullOrWhiteSpace(pass))
                {
                    lblpass.Text = "Password is required!";
                    lblpass.ForeColor = Color.Red;
                    hasError = true;
                }
                else if (!IsPasswordValid(pass))
                {
                    lblpass.Text = "Password must be at least 4 characters!";
                    lblpass.ForeColor = Color.Red;
                    hasError = true;
                }

                // Role
                if (cbrole.SelectedIndex == -1)
                {
                    lblrole.Text = "Role is required!";
                    lblrole.ForeColor = Color.Red;
                    hasError = true;
                }

                // DOB / age
                if (!IsAgeValid(dob))
                {
                    lbldob.Text = "Must be 18 years or older!";
                    lbldob.ForeColor = Color.Red;
                    hasError = true;
                }

             
                if (role.Equals("FAMILY"))
                {
                    if (string.IsNullOrWhiteSpace(prisonerId))
                    {
                        lblpriid.Text = "Prisoner ID is required!";
                        lblpriid.ForeColor = Color.Red;
                        hasError = true;
                    }
                    else if (!IsNidValid(prisonerId))
                    {
                        lblpriid.Text = "Prisoner ID must be exactly 4 digits!";
                        lblpriid.ForeColor = Color.Red;
                        hasError = true;
                    }

                    if (cbrelation.SelectedIndex == -1)
                    {
                        lblrltn.Text = "Relation is required!";
                        lblrltn.ForeColor = Color.Red;
                        hasError = true;
                    }

                    if (string.IsNullOrWhiteSpace(tbprisonerpass.Text))
                    {
                        lblpripass.Text = "Password is required!";
                        lblpripass.ForeColor = Color.Red;
                        hasError = true;
                    }
                    else if (!IsPasswordValid(tbprisonerpass.Text))
                    {
                        lblpripass.Text = "Password must be at least 4 characters!";
                        lblpripass.ForeColor = Color.Red;
                        hasError = true;
                    }
                }

                if (hasError) return;

            
                if (role.Equals("ADMIN"))
                {
                    Connect_A();
                    MessageBox.Show("Admin account created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (role.Equals("STAFF"))
                {
                    Connect_S();
                    MessageBox.Show("Staff account created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (role.Equals("FAMILY"))
                {
                    if (Connect_F())
                    {
                        MessageBox.Show("Family account created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else return;
                }

                // Clear form after success
                tbname.Clear();
                tbnid.Clear();
                tbpass.Clear();
                tbprisonerid.Clear();
                tbprisonerpass.Clear();
                cbrole.SelectedIndex = -1;
                cbrelation.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Now;

                // Go to SignIn
                SignIn signForm = new SignIn();
                signForm.Show();
                this.Hide();
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void lbsignin_Click_1(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
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

        private void cbpri_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbpri.Checked)
            {
              
                tbprisonerpass.UseSystemPasswordChar = false;
            }
            else
            {
                
                tbprisonerpass.UseSystemPasswordChar = true;
            }
        }
    }
}