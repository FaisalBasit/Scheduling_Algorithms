using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace OS_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public string name1 { get; set; }
        public string username1 { get; set; }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            controlpanel.Controls.Clear();
            controlpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            home cal = new home();
            addUserControl(cal);
            welcome.Text = "Welcome, " + Convert.ToString(name1);


        }

        private void cal_main_Click(object sender, EventArgs e)
        {
            Calculate cal = new Calculate();
            addUserControl(cal);

        }

        private void upgrade_main_Click(object sender, EventArgs e)
        {
            Upgrade cal = new Upgrade();
            addUserControl(cal);
        }

        private void Review_main_Click(object sender, EventArgs e)
        {
            Review cal = new Review();
            addUserControl(cal);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Conformation Messaage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();
             
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            home cal = new home();
            addUserControl(cal);
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                signin signinForm = new signin();
                signinForm.Show();
                this.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void controlpanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
