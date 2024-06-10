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
    public partial class Review : UserControl
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);
        public Review()
        {
            InitializeComponent();
        }
        public string username { get; set; }
        public void clearFields()
        {
            feedback.Text = "";
        }

        private void submit_feedback_Click(object sender, EventArgs e)
        {
            if (feedback.Text == "")
            {
                MessageBox.Show("Please write feedback", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (con.State == ConnectionState.Closed)
                {
                        try
                        {
                            con.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE users SET feedback = @feedback" +
                                " WHERE username = @username";

                            using (SqlCommand cmd = new SqlCommand(updateData, con))
                            {
                                cmd.Parameters.AddWithValue("@feedback", feedback.Text.Trim());                        
                                cmd.Parameters.AddWithValue("@username",username);

                                cmd.ExecuteNonQuery();


                                MessageBox.Show("Thankyou for writing feedback!"
                                    , "Thankyou Message", MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
               
            }
        }
    }
    

