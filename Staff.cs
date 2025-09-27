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
    public partial class Staff : Form
    {
        private string staffUsername;
        private string staffNid;
      

      
       
        public Staff(string username,string nid)
        {
            InitializeComponent();
            this.staffUsername = username;
            this.staffNid = nid;

            lbname.Text = "Welcome, " + staffUsername.ToUpper() + "!";

        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            ViewPrisoners vp = new ViewPrisoners(staffUsername,staffNid);
            vp.Show();
            this.Hide();
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

        private void btnshift_Click(object sender, EventArgs e)
        {
            ViewShift vs = new ViewShift(staffUsername, staffNid);
            vs.Show();
            this.Hide();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            Report re = new Report(staffUsername, staffNid);
            re.Show();
            this.Hide();
        }

        private void btnwork_Click(object sender, EventArgs e)
        {
            Assign asg = new Assign(staffUsername, staffNid);
            asg.Show();
            this.Hide();
        }

        private void btnrequest_Click(object sender, EventArgs e)
        {
         Equipment equp = new Equipment(staffUsername,staffNid);
            equp.Show();
            this.Hide();
        }

     
        private void lbname_Click(object sender, EventArgs e)
        {

        }

        private void btnappoint_Click(object sender, EventArgs e)
        {
            AppointmentApproval appointmentApproval = new AppointmentApproval(staffUsername, staffNid);
            appointmentApproval.Show();
            this.Hide();
        }

        private void Staff_Load(object sender, EventArgs e)
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

            switch (result)
            {
                case DialogResult.Yes:
                    SaveChanges();
                    break;
                case DialogResult.No:
                    break;
            }
        }


        private void SaveChanges()
        {
            string connectionString = @"Data Source = musfiqurshov\SQLEXPRESS01; Initial Catalog = PMSdb; Integrated Security = True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "delete from Admin_Staff where Nid=" + staffNid + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Account Successfully Deleted");
            HomePage hp = new HomePage();
            hp.Show();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewFamily vf = new ViewFamily(staffUsername, staffNid);
            vf.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            UpdateStaff us = new UpdateStaff(staffUsername, staffNid);
            us.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CellAllocation ca = new CellAllocation(staffUsername, staffNid);
            ca.Show();
            this.Hide();
        }
    }
}
