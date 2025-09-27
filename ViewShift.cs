using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class ViewShift : Form
    {
        private string staffUsername;
        private string staffNid;

    
        private static DataTable allShifts = GetShiftData();
        private static DataRow selectedShiftRow = null;

        public ViewShift(string username, string nid)
        {
            InitializeComponent();
            this.staffUsername = username;
            this.staffNid = nid;

            
            if (selectedShiftRow == null)
            {
                DisplayRandomShift();
            }
            else
            {
              
                FillShiftTextBoxes(selectedShiftRow);
            }
        }

  
        private void DisplayRandomShift()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, allShifts.Rows.Count);

            selectedShiftRow = allShifts.Rows[randomIndex];
            FillShiftTextBoxes(selectedShiftRow);
        }

     
        private void FillShiftTextBoxes(DataRow shiftRow)
        {
           
            tbwork.Text = shiftRow["Work ID"].ToString();
            tbduty.Text = shiftRow["Duty"].ToString();
            tblocation.Text = shiftRow["Location"].ToString();
            tbstart.Text = shiftRow["Start Time"].ToString();
            tbend.Text = shiftRow["End Time"].ToString();
            tbreport.Text = shiftRow["Reported To"].ToString();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
            Staff staff = new Staff(staffUsername, staffNid);
            staff.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
        private static DataTable GetShiftData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Work ID", typeof(string));
            dt.Columns.Add("Duty", typeof(string));
            dt.Columns.Add("Location", typeof(string));
            dt.Columns.Add("Start Time", typeof(string));
            dt.Columns.Add("End Time", typeof(string));
            dt.Columns.Add("Reported To", typeof(string));

            dt.Rows.Add("10", "Cell Block Patrol", "West", "08:00 AM", "04:00 PM", "Musfiqur Rahman");
            dt.Rows.Add("20", "Kitchen Duty", "East", "06:00 AM", "02:00 PM", "Farhan Sadik Arnob");
            dt.Rows.Add("30", "Medical Ward Guard", "Infirmary", "02:00 PM", "10:00 PM", "Tanvir Rahman");
            dt.Rows.Add("40", "Visitor Check-in", "Meeting Area", "09:00 AM", "05:00 PM", "Ashiqur Rahman");
            dt.Rows.Add("50", "Yard Supervision", "South", "10:00 AM", "06:00 PM", "Montasir Hossain Adib");
            dt.Rows.Add("60", "Security Monitoring", "Control Room", "12:00 PM", "08:00 PM", "Hridoy Bhuiyan");
            dt.Rows.Add("70", "Maintenance Rounds", "North", "07:00 AM", "03:00 PM", "MD.Tahmiduzzaman");
            dt.Rows.Add("80", "Canteen Management", "Canteen", "11:00 AM", "07:00 PM", "Rakib Ul Islam");

            return dt;
        }

        private void ViewShift_Load(object sender, EventArgs e)
        {
            
        }
    }
}