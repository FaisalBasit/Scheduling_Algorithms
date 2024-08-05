using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OS_project
{
    public partial class pro : Form
    {
        public string username { get; set; }
        public string paid { get; set; }
        public string cardnum { get; set; }
        public string cardexpirydate { get; set; }
        public int cvv { get; set; }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);

       
        //regular expression for Union Pay Card
        string Union = "^(62[0-9]{14,17})$$";
        //regular expression for Visa Card 
        string visa = "^4[0-9]{12}(?:[0-9]{3})?$";
        //regular expression for Visa Master Card 
        string visaMaster = "^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14})$";
        //regular expression for Mastercard: 
        string Mastercard = "^(5[1-5][0-9]{14}|2(22[1-9][0-9]{12}|2[3-9][0-9]{13}|[3-6][0-9]{14}|7[0-1][0-9]{13}|720[0-9]{12}))$";
        //regular expression for CVN
        string cvnpattern = @"^\d{3}$";
        //regular expression for expiry date
        string expiry = @"^\d{2}\/\d{2}$";
        public pro()
        {
            InitializeComponent();
        }

        private void Card_Number_Leave(object sender, EventArgs e)
        {
            string cardNumber = Card_Number.Text;
            bool isValid = false;

            if (Regex.IsMatch(Card_Number.Text, visa))
            {
                isValid = true;
            }


            else if (Regex.IsMatch(Card_Number.Text, visaMaster) == false)
            {
                isValid = true;
            }


            else if (Regex.IsMatch(Card_Number.Text, Mastercard) == false)
            {
                isValid = true;
            }

            else if (Regex.IsMatch(Card_Number.Text, Union) == false)
            {
                isValid = true;
            }
            if (!isValid)
            {
                errorProvider1.SetError(Card_Number, "Invalid card number!");
            }
            else
            {
                // Clear all error providers
                errorProvider1.Clear();

            }
        }

        private void CVV_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(CVV.Text, cvnpattern) == false)
            {
                errorProvider2.SetError(this.CVV, "Invalid Card validation value(CVV)!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void CVV_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CardExpiry_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(CardExpiry.Text, expiry) == false)
            {
                errorProvider3.SetError(this.CVV, "Invalid format!, write in this format DD/YY");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void CardExpiry_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(Card_Number.Text, visa) &&
                !Regex.IsMatch(Card_Number.Text, visaMaster) &&
                !Regex.IsMatch(Card_Number.Text, Mastercard) &&
                !Regex.IsMatch(Card_Number.Text, Union))
            {
                
                errorProvider1.SetError(Card_Number, "Invalid card number!");
            }
            else if (!Regex.IsMatch(CardExpiry.Text, expiry))
            {
               
                errorProvider2.SetError(CardExpiry, "Invalid format! Write in this format DD/YY");
            }
            else if (!Regex.IsMatch(CVV.Text, cvnpattern))
            {
                errorProvider3.SetError(CVV, "Invalid Card validation number (CVN)!");
            }
            else
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
                                string updateQuery = "UPDATE users SET paid = @paid , cardnum = @cardnum, cvv = @cvv , cardexpirydate  = @cardexpirydate WHERE username = @username";
                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                                {
                                    updateCmd.Parameters.AddWithValue("@paid", "yes");
                                    updateCmd.Parameters.AddWithValue("@cardnum", Card_Number.Text);
                                    updateCmd.Parameters.AddWithValue("@cvv", CVV.Text);
                                    updateCmd.Parameters.AddWithValue("@cardexpirydate", CardExpiry.Text);
                                    updateCmd.Parameters.AddWithValue("@username", username);

                                    updateCmd.ExecuteNonQuery();

                                    MessageBox.Show("Payment successful! Thank you.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                  




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
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Conformation Messaage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                this.Hide();
             

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

