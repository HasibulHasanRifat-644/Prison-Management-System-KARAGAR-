using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace PrisonManagementSystem_KARAGOR_
{
    public partial class Equipment : Form
    {
        private string staffNid;
        private string staffName;

        public Equipment()
        {
            InitializeComponent();
        }
        public Equipment(string name,string nid)
        {
            InitializeComponent();
            this.staffNid = nid;
            this.staffName = name;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff(staffName,staffNid);
            staff.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // ORDER BUTTON
        {
            
            List<Tuple<string, int>> orderedItems = new List<Tuple<string, int>>();
            bool orderSuccessful = false;

           
            try
            {
                string ConnectionString = @"Data Source = MSI\SQLEXPRESS; Initial Catalog = PMSdb; Integrated Security = True;";
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            
                            var equipmentNameCell = row.Cells[0].Value;
                            var quantityCell = row.Cells[1].Value;

                            if (equipmentNameCell != null && quantityCell != null)
                            {
                                string equipmentName = equipmentNameCell.ToString();
                                int quantity;

                           
                                if (int.TryParse(quantityCell.ToString(), out quantity) && quantity > 0)
                                {
                                    
                                    string query = "INSERT INTO Equipment (E_name, E_quantity, E_date ,Nid) VALUES (@name, @quantity, @date ,@nid)";

                                  
                                    using (SqlCommand command = new SqlCommand(query, connection))
                                    {
                                       
                                        command.Parameters.AddWithValue("@name", equipmentName);
                                        command.Parameters.AddWithValue("@quantity", quantity);
                                        command.Parameters.AddWithValue("@date", DateTime.Now.Date);
                                        command.Parameters.AddWithValue("@nid", staffNid);

                              
                                        command.ExecuteNonQuery();

                                      
                                        orderedItems.Add(new Tuple<string, int>(equipmentName, quantity));
                                    }
                                }
                            }
                        }
                    }
                }
                orderSuccessful = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                orderSuccessful = false;
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                orderSuccessful = false;
            }

            
            if (orderedItems.Any() && orderSuccessful)
            {
                StringBuilder orderSummary = new StringBuilder();
                orderSummary.AppendLine("The following items have been successfully ordered:");

                foreach (var item in orderedItems)
                {
                    orderSummary.AppendLine($"• {item.Item1}: {item.Item2}");
                }

                MessageBox.Show(orderSummary.ToString(), "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!orderedItems.Any() && orderSuccessful)
            {
                MessageBox.Show("Please add equipment to your order before clicking 'Order'.", "No Items to Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
