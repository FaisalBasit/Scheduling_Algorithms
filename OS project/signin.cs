using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Configuration;
using System.Data.SqlClient;

namespace OS_project
{
    public partial class signin : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
        public signin()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Conformation Messaage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
                this.Hide();
            }
        }
        public static bool IsUserLoggedIn { get; private set; } = false;
        private void login_button_Click(object sender, EventArgs e)
        {
            

        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            sign_up signUpForm = new sign_up();
            signUpForm.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && pass.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from users where username=@username and pass =@pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@pass", pass.Text);

                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    int usernameIndex = dr.GetOrdinal("username");
                    int nameIndex = dr.GetOrdinal("name"); // Retrieve the index of the "name" column
                    int paidIndex = dr.GetOrdinal("paid");


                    while (dr.Read())
                    {
                        string username = dr.GetString(usernameIndex);
                        string name = dr.GetString(nameIndex);
                        string paid=dr.GetString(paidIndex);



                        MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        IsUserLoggedIn = true;
                        
                        Form1 mainForm = new Form1
                        {
                            username1 = username,
                            name1 = name,
                            paid1=paid

                        };

                        mainForm.Show();

                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please fill both fields!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
            
        }

        private void sign_up_Click_1(object sender, EventArgs e)
        {
            sign_up su = new sign_up();
            su.Show();
            this.Hide();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }
    }
}
