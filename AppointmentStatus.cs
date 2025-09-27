using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class AppointmentStatus : Form
    {
        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=PMSdb;Integrated Security=True;";
        private string PrisonerNID;
       
        private string F_Relation;
        private string FamilyNID;
        private string FamilyUsername;
        
        

        public AppointmentStatus(string familyUsername, string prisonerNID, string f_Relation, string familyNID)
        {
            InitializeComponent();
            this.Load += AppointmentStatus_Load;
            this.FamilyUsername = familyUsername;
            this.PrisonerNID = prisonerNID;
            this.F_Relation = f_Relation;
            this.FamilyNID = familyNID;
            LoadAppointments();
            F_Relation = f_Relation;
            tbprisonernid.Text = prisonerNID;
        }

        public AppointmentStatus()
        {
            InitializeComponent();
            this.Load += AppointmentStatus_Load;
            LoadAppointments();

        }


  
        private void AppointmentStatus_Load(object sender, EventArgs e)
        {
        }

        
        private void LoadAppointments(string prisonerId = "")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT Req_date, Req_status, Pri_nid FROM Appointment WHERE 1=1";
                SqlCommand cmd = new SqlCommand();

                if (!string.IsNullOrEmpty(prisonerId))
                {
                    sql += " AND Pri_nid LIKE @Prisonerid";
                    cmd.Parameters.AddWithValue("@Prisonerid", $"%{prisonerId}%");
                }
                else
                {
                    sql += " AND Pri_nid = @PrisonerID";
                    cmd.Parameters.AddWithValue("@PrisonerID", PrisonerNID);
                }

                sql += " ORDER BY Req_status DESC";

                cmd.CommandText = sql;
                cmd.Connection = conn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvView.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    string message = !string.IsNullOrEmpty(prisonerId)
                        ? "No appointments found for this prisoner ID."
                        : "No appointments found for the current prisoner.";
                    MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Search button
        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            string prisonerId = tbprisonernid.Text.Trim();
            LoadAppointments(prisonerId);
        }

     
        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
         // tbprisonernid.Text = "";
            LoadAppointments();
            MessageBox.Show("Refreshed!");
        }

        private void dgvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string value = dgvView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                MessageBox.Show($"You clicked: {value}");
            }
        }

        // Cancel appointment button
        private void btncancel_Click_1(object sender, EventArgs e)
        {
            if (dgvView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to cancel.");
                return;
            }

            DataGridViewRow selectedRow = dgvView.SelectedRows[0];

            string date = selectedRow.Cells["Req_date"].Value?.ToString();
            string status = selectedRow.Cells["Req_status"].Value?.ToString();
            string prisonerId = selectedRow.Cells["Pri_nid"].Value?.ToString();

            if (string.IsNullOrEmpty(date) || string.IsNullOrEmpty(status) || string.IsNullOrEmpty(prisonerId))
            {
                MessageBox.Show("Invalid appointment data selected.");
                return;
            }

            if (status == "CANCELED" || status == "REJECTED")
            {
                MessageBox.Show("This appointment cannot be cancelled (already cancelled or rejected).");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "UPDATE Appointment SET Req_status = @Status WHERE Pri_nid = @id AND Req_date = @Date";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", "CANCELED");
                    cmd.Parameters.AddWithValue("@id", prisonerId);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Appointment cancelled!");
            LoadAppointments();
        }

        // Back button
        private void btnback_Click_1(object sender, EventArgs e)
        {
            Family family = new Family(FamilyUsername,PrisonerNID, F_Relation , FamilyNID);
            family.Show();
            this.Hide();
        }

        // Exit button
        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
