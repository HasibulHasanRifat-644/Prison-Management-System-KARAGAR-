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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Homepage_Pic_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();   
          
        }

      
        private void Sign_In_Click(object sender, EventArgs e)
        {
            SignIn signinForm = new SignIn();  
            signinForm.Show();                 
            this.Hide();                       
        }

        private void Sign_Up_Click(object sender, EventArgs e)
        {
            SignUp signupForm = new SignUp();  
            signupForm.Show();                 
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
