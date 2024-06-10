using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_project
{
    public partial class Upgrade : UserControl
    {
        public Upgrade()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);

       

        public string username { get; set; }
        public string paid { get; set; }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void upgrade_to_pro_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    string query = "SELECT paid FROM users WHERE username = @username";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        string paidStatus = (string)cmd.ExecuteScalar();

                        if (paidStatus == "yes")
                        {
                            MessageBox.Show("You have already paid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            pro paymentForm = new pro();
                            paymentForm.username = username; // Pass the username to the pro form
                            paymentForm.Show();
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
