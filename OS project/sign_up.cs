using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace OS_project
{
    public partial class sign_up : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        SqlConnection con;

        public sign_up()
        {
            InitializeComponent();
            con = new SqlConnection(cs);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void num_of_process_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) ||
                string.IsNullOrEmpty(username.Text) ||
                string.IsNullOrEmpty(pass.Text))
            {
                MessageBox.Show("Please fill all blank fields!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();
                    string checkUser = "SELECT COUNT(*) FROM users WHERE username = @username";
                    using (SqlCommand checkCmd = new SqlCommand(checkUser, con))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username.Text.Trim());
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show(username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO users (name, username, pass,paid) VALUES (@name, @username, @pass,@paid)";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                            {
                                insertCmd.Parameters.AddWithValue("@name", name.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@username", username.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@pass", pass.Text.Trim());
                                insertCmd.Parameters.AddWithValue("@paid", "no");

                                insertCmd.ExecuteNonQuery();

                                MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                signin si = new signin();
                                si.Show();
                                this.Close();
                            }
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}