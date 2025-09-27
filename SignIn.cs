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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            tbnid.KeyPress += tbnid_KeyPress;
            tbprisonernid.Hide();
            lbprisonernid.Hide();
            lbrelation.Hide();
            cbrelation.Hide();
        }

        private bool ValidateCredentials(string username, string password, string role, string nid)
        {
            try
            {
                if (!int.TryParse(nid, out int nidValue))
                {
                    MessageBox.Show("NID must be a numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                String conc = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=PMSdb;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(conc))
                {
                    conn.Open();

                    String query = "SELECT COUNT(*) FROM Admin_Staff WHERE Nid = @Nid AND Name = @Name AND Pass = @Pass AND Role = @Role";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", username);
                        cmd.Parameters.AddWithValue("@Pass", password);
                        cmd.Parameters.AddWithValue("@Role", role);
                        cmd.Parameters.AddWithValue("@Nid", nidValue);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        
        private bool TryGetFamilyData(string username, string password, string nid, string prisonernid, string f_relation, out string pri_nid)
        {
            pri_nid = string.Empty;

            try
            {
                if (!int.TryParse(nid, out int nidValue))
                {
                    MessageBox.Show("NID must be a numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!int.TryParse(prisonernid, out int priValue))
                {
                    MessageBox.Show("Prisoner's NID must be a numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                String conc = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=PMSdb;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(conc))
                {
                    conn.Open();

                   
                    String query = "SELECT Pri_nid FROM Family WHERE F_nid = @Nid AND F_name = @Name AND F_pass = @Pass AND Pri_nid = @PrisonerNid AND F_relation = @Relation";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", username);
                        cmd.Parameters.AddWithValue("@Pass", password);
                        cmd.Parameters.AddWithValue("@Nid", nidValue);
                        cmd.Parameters.AddWithValue("@PrisonerNid", priValue);
                        cmd.Parameters.AddWithValue("@Relation", f_relation);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               
                                pri_nid = reader["Pri_nid"].ToString();
                                return true;
                            }
                            else
                            {
                                return false; // No matching record found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private bool IsNidValid(string nid)
        {
            return nid.Length == 4 && nid.All(char.IsDigit);
        }

        private bool IsPasswordValid(string pass)
        {
            return pass.Length >= 4;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
         
            lbluname.Text = "";
            lblnid.Text = "";
            lblpass.Text = "";
            lblRole.Text = "";

            string username = tbname.Text;
            string password = tbpass.Text;
            string role = cbrole.Text;
            string nid = tbnid.Text;
            string prisonernid = tbprisonernid.Text;
            string F_relation = cbrelation.Text;

            bool hasError = false;


            if (tbname.Text == "" && tbnid.Text == "" && tbpass.Text == "" && cbrole.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                if (string.IsNullOrWhiteSpace(username))
                {
                    lbluname.Text = "Username is required!";
                    lbluname.ForeColor = Color.Red;
                    hasError = true;
                }
                else if (!username.All(char.IsLetter))  
                {
                    lbluname.Text = "Username must contain only letters.";
                    lbluname.ForeColor = Color.Red;
                    hasError = true;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    lblpass.Text = "Password is required!";
                    lblpass.ForeColor = Color.Red;
                    hasError = true;
                }

                if (string.IsNullOrWhiteSpace(nid))
                {
                    lblnid.Text = "NID is required!";
                    lblnid.ForeColor = Color.Red;
                    hasError = true;
                }

                if (cbrole.SelectedIndex == -1)
                {
                    lblRole.Text = "Role is required!";
                    lblRole.ForeColor = Color.Red;
                    hasError = true;
                }
                if (!IsNidValid(nid))
                {
                    lblnid.Text = "NID must be exactly 4 numeric digits.";
                    lblnid.ForeColor = Color.Red;
                    hasError = true;
                }

                if (!IsPasswordValid(password))
                {
                    lblpass.Text = "Password must be at least 4 characters.";
                    lblpass.ForeColor = Color.Red;
                    hasError = true;
                }

                if (role.Equals("FAMILY"))
                {

                    // Prisoner NID
                    if (string.IsNullOrWhiteSpace(prisonernid))
                    {
                        lblprinid.Text = "Prisoner's NID is required!";
                        lblprinid.ForeColor = Color.Red;
                        hasError = true;
                    }
                    else if (!IsNidValid(prisonernid))
                    {
                        lblprinid.Text = "Prisoner's NID must be exactly 4 digits!";
                        lblprinid.ForeColor = Color.Red;
                        hasError = true;
                    }
                    else
                    {
                        lblprinid.Text = ""; 
                    }

                    // Relation
                    if (string.IsNullOrWhiteSpace(F_relation))
                    {
                        lblrltn.Text = "Please select a valid relation.";
                        lblrltn.ForeColor = Color.Red;
                        hasError = true;
                    }
                    else
                    {
                        lblrltn.Text = ""; 
                    }
                }
                else
                {
                    
                    lblprinid.Text = "";
                    lblrltn.Text = "";
                }
                if (hasError) return; 

             
                if (string.IsNullOrWhiteSpace(cbrole.Text) ||
    (cbrole.Text != "ADMIN" && cbrole.Text != "STAFF" && cbrole.Text != "FAMILY"))
                {
                    lblRole.Text = "Please select a valid role!";
                    lblRole.ForeColor = Color.Red;
                    hasError = true;
                }
                else
                {
                    lblRole.Text = ""; 
                }

                try
                {
                    if (role.Equals("ADMIN"))
                    {
                        if (ValidateCredentials(username, password, role, nid))
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Admin adminForm = new Admin(username, nid);
                            adminForm.Show();
                            this.Hide();
                        }

                    }
                    else if (role.Equals("STAFF"))
                    {
                        if (ValidateCredentials(username, password, role, nid))
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Staff staffForm = new Staff(username, nid);
                            staffForm.Show();
                            this.Hide();
                        }

                    }
                    else if (role.Equals("FAMILY"))
                    {
                        string prisonerNid;
                       
                        if (TryGetFamilyData(username, password, nid, prisonernid, F_relation, out prisonerNid))
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            Family FamilyForm = new Family(username, prisonerNid, F_relation, nid);
                            FamilyForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            
                            MessageBox.Show("Invalid credentials! Please check your details.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    else
                    {

                        MessageBox.Show("Invalid credentials! Please check your username, password, and role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message,
                                     "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
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

        private void tbnid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void cbrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = cbrole.Text;

            if (role.Equals("FAMILY"))
            {
                this.lbprisonernid.Show();
                this.tbprisonernid.Show();
                this.lbrelation.Show();
                this.cbrelation.Show();
            }

            if (role.Equals("ADMIN") || role.Equals("STAFF"))
            {
                lbprisonernid.Hide();
                tbprisonernid.Hide();
                lbrelation.Hide();
                cbrelation.Hide();
            }
        }

        private void lbforget_Click(object sender, EventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.Show();
            this.Hide();
        }

        private void btback_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbforget_Click_1(object sender, EventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.Show();
            this.Hide();
        }

        private void bd_Logo_Click(object sender, EventArgs e)
        {

        }
    }
}