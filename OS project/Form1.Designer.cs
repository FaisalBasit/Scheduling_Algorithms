namespace OS_project
{
    partial class Form1
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.home = new Guna.UI.WinForms.GunaAdvenceButton();
            this.log_out = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Review_main = new Guna.UI.WinForms.GunaAdvenceButton();
            this.upgrade_main = new Guna.UI.WinForms.GunaAdvenceButton();
            this.cal_main = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Dashboard_Button = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gunaAdvenceButton3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.gunaAdvenceButton2);
            this.panel1.Controls.Add(this.gunaAdvenceButton1);
            this.panel1.Controls.Add(this.Dashboard_Button);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 143);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.welcome);
            this.panel2.Controls.Add(this.home);
            this.panel2.Controls.Add(this.log_out);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.Review_main);
            this.panel2.Controls.Add(this.upgrade_main);
            this.panel2.Controls.Add(this.cal_main);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 162);
            this.panel2.TabIndex = 83;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(298, 14);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(171, 23);
            this.welcome.TabIndex = 84;
            this.welcome.Text = "Welcome, Faisal";
            // 
            // home
            // 
            this.home.AnimationHoverSpeed = 0.07F;
            this.home.AnimationSpeed = 0.03F;
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.BaseColor = System.Drawing.Color.Transparent;
            this.home.BorderColor = System.Drawing.Color.White;
            this.home.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.home.Checked = true;
            this.home.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.home.CheckedBorderColor = System.Drawing.Color.White;
            this.home.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.home.CheckedImage = ((System.Drawing.Image)(resources.GetObject("home.CheckedImage")));
            this.home.CheckedLineColor = System.Drawing.Color.White;
            this.home.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.ImageOffsetX = 15;
            this.home.ImageSize = new System.Drawing.Size(30, 30);
            this.home.LineColor = System.Drawing.Color.Transparent;
            this.home.LineTop = 3;
            this.home.Location = new System.Drawing.Point(249, 95);
            this.home.Name = "home";
            this.home.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.home.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.home.OnHoverForeColor = System.Drawing.Color.White;
            this.home.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("home.OnHoverImage")));
            this.home.OnHoverLineColor = System.Drawing.Color.White;
            this.home.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.home.Size = new System.Drawing.Size(145, 48);
            this.home.TabIndex = 83;
            this.home.Text = "Home";
            this.home.TextOffsetX = 2;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // log_out
            // 
            this.log_out.AnimationHoverSpeed = 0.07F;
            this.log_out.AnimationSpeed = 0.03F;
            this.log_out.BaseColor = System.Drawing.Color.White;
            this.log_out.BorderColor = System.Drawing.Color.Black;
            this.log_out.CheckedBaseColor = System.Drawing.Color.White;
            this.log_out.CheckedBorderColor = System.Drawing.Color.Black;
            this.log_out.CheckedForeColor = System.Drawing.Color.White;
            this.log_out.CheckedImage = null;
            this.log_out.CheckedLineColor = System.Drawing.SystemColors.Desktop;
            this.log_out.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.log_out.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.log_out.Image = null;
            this.log_out.ImageSize = new System.Drawing.Size(20, 20);
            this.log_out.LineColor = System.Drawing.Color.Transparent;
            this.log_out.Location = new System.Drawing.Point(790, 14);
            this.log_out.Name = "log_out";
            this.log_out.OnHoverBaseColor = System.Drawing.Color.White;
            this.log_out.OnHoverBorderColor = System.Drawing.Color.Black;
            this.log_out.OnHoverForeColor = System.Drawing.Color.Black;
            this.log_out.OnHoverImage = null;
            this.log_out.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.log_out.OnPressedColor = System.Drawing.Color.Black;
            this.log_out.Radius = 15;
            this.log_out.Size = new System.Drawing.Size(89, 38);
            this.log_out.TabIndex = 1;
            this.log_out.Text = "Logout";
            this.log_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(896, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Review_main
            // 
            this.Review_main.AnimationHoverSpeed = 0.07F;
            this.Review_main.AnimationSpeed = 0.03F;
            this.Review_main.BackColor = System.Drawing.Color.Transparent;
            this.Review_main.BaseColor = System.Drawing.Color.Transparent;
            this.Review_main.BorderColor = System.Drawing.Color.White;
            this.Review_main.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.Review_main.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.Review_main.CheckedBorderColor = System.Drawing.Color.White;
            this.Review_main.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.Review_main.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Review_main.CheckedImage")));
            this.Review_main.CheckedLineColor = System.Drawing.Color.White;
            this.Review_main.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Review_main.ForeColor = System.Drawing.Color.White;
            this.Review_main.Image = ((System.Drawing.Image)(resources.GetObject("Review_main.Image")));
            this.Review_main.ImageOffsetX = 8;
            this.Review_main.ImageSize = new System.Drawing.Size(30, 30);
            this.Review_main.LineColor = System.Drawing.Color.Transparent;
            this.Review_main.LineTop = 3;
            this.Review_main.Location = new System.Drawing.Point(699, 95);
            this.Review_main.Name = "Review_main";
            this.Review_main.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Review_main.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.Review_main.OnHoverForeColor = System.Drawing.Color.White;
            this.Review_main.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Review_main.OnHoverImage")));
            this.Review_main.OnHoverLineColor = System.Drawing.Color.White;
            this.Review_main.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.Review_main.Size = new System.Drawing.Size(145, 48);
            this.Review_main.TabIndex = 82;
            this.Review_main.Text = "Feedback";
            this.Review_main.Click += new System.EventHandler(this.Review_main_Click);
            // 
            // upgrade_main
            // 
            this.upgrade_main.AnimationHoverSpeed = 0.07F;
            this.upgrade_main.AnimationSpeed = 0.03F;
            this.upgrade_main.BackColor = System.Drawing.Color.Transparent;
            this.upgrade_main.BaseColor = System.Drawing.Color.Transparent;
            this.upgrade_main.BorderColor = System.Drawing.Color.White;
            this.upgrade_main.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.upgrade_main.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.upgrade_main.CheckedBorderColor = System.Drawing.Color.White;
            this.upgrade_main.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.upgrade_main.CheckedImage = ((System.Drawing.Image)(resources.GetObject("upgrade_main.CheckedImage")));
            this.upgrade_main.CheckedLineColor = System.Drawing.Color.White;
            this.upgrade_main.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgrade_main.ForeColor = System.Drawing.Color.White;
            this.upgrade_main.Image = ((System.Drawing.Image)(resources.GetObject("upgrade_main.Image")));
            this.upgrade_main.ImageOffsetX = 9;
            this.upgrade_main.ImageSize = new System.Drawing.Size(30, 30);
            this.upgrade_main.LineColor = System.Drawing.Color.Transparent;
            this.upgrade_main.LineTop = 3;
            this.upgrade_main.Location = new System.Drawing.Point(550, 95);
            this.upgrade_main.Name = "upgrade_main";
            this.upgrade_main.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.upgrade_main.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.upgrade_main.OnHoverForeColor = System.Drawing.Color.White;
            this.upgrade_main.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("upgrade_main.OnHoverImage")));
            this.upgrade_main.OnHoverLineColor = System.Drawing.Color.White;
            this.upgrade_main.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.upgrade_main.Size = new System.Drawing.Size(145, 48);
            this.upgrade_main.TabIndex = 81;
            this.upgrade_main.Text = "Upgrade";
            this.upgrade_main.Click += new System.EventHandler(this.upgrade_main_Click);
            // 
            // cal_main
            // 
            this.cal_main.AnimationHoverSpeed = 0.07F;
            this.cal_main.AnimationSpeed = 0.03F;
            this.cal_main.BackColor = System.Drawing.Color.Transparent;
            this.cal_main.BaseColor = System.Drawing.Color.Transparent;
            this.cal_main.BorderColor = System.Drawing.Color.White;
            this.cal_main.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.cal_main.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.cal_main.CheckedBorderColor = System.Drawing.Color.White;
            this.cal_main.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.cal_main.CheckedImage = ((System.Drawing.Image)(resources.GetObject("cal_main.CheckedImage")));
            this.cal_main.CheckedLineColor = System.Drawing.Color.White;
            this.cal_main.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_main.ForeColor = System.Drawing.Color.White;
            this.cal_main.Image = ((System.Drawing.Image)(resources.GetObject("cal_main.Image")));
            this.cal_main.ImageOffsetX = 7;
            this.cal_main.ImageSize = new System.Drawing.Size(30, 30);
            this.cal_main.LineColor = System.Drawing.Color.Transparent;
            this.cal_main.LineTop = 3;
            this.cal_main.Location = new System.Drawing.Point(400, 95);
            this.cal_main.Name = "cal_main";
            this.cal_main.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.cal_main.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.cal_main.OnHoverForeColor = System.Drawing.Color.White;
            this.cal_main.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("cal_main.OnHoverImage")));
            this.cal_main.OnHoverLineColor = System.Drawing.Color.White;
            this.cal_main.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.cal_main.Size = new System.Drawing.Size(144, 48);
            this.cal_main.TabIndex = 80;
            this.cal_main.Text = "Calculate";
            this.cal_main.Click += new System.EventHandler(this.cal_main_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1009, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(189, 134);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedImage = null;
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.SystemColors.Desktop;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.gunaAdvenceButton3.Image = null;
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(790, 14);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.Radius = 15;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(89, 38);
            this.gunaAdvenceButton3.TabIndex = 1;
            this.gunaAdvenceButton3.Text = "Login";
            this.gunaAdvenceButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(896, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageOffsetX = 5;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.LineTop = 3;
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(614, 95);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.OnHoverImage")));
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(145, 48);
            this.gunaAdvenceButton2.TabIndex = 82;
            this.gunaAdvenceButton2.Text = "Review";
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageOffsetX = 5;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.LineTop = 3;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(465, 95);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.OnHoverImage")));
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(145, 48);
            this.gunaAdvenceButton1.TabIndex = 81;
            this.gunaAdvenceButton1.Text = "Upgrade";
            // 
            // Dashboard_Button
            // 
            this.Dashboard_Button.AnimationHoverSpeed = 0.07F;
            this.Dashboard_Button.AnimationSpeed = 0.03F;
            this.Dashboard_Button.BackColor = System.Drawing.Color.Transparent;
            this.Dashboard_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Dashboard_Button.BorderColor = System.Drawing.Color.White;
            this.Dashboard_Button.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.Dashboard_Button.Checked = true;
            this.Dashboard_Button.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.Dashboard_Button.CheckedBorderColor = System.Drawing.Color.White;
            this.Dashboard_Button.CheckedForeColor = System.Drawing.Color.WhiteSmoke;
            this.Dashboard_Button.CheckedImage = ((System.Drawing.Image)(resources.GetObject("Dashboard_Button.CheckedImage")));
            this.Dashboard_Button.CheckedLineColor = System.Drawing.Color.White;
            this.Dashboard_Button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_Button.ForeColor = System.Drawing.Color.White;
            this.Dashboard_Button.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard_Button.Image")));
            this.Dashboard_Button.ImageOffsetX = 5;
            this.Dashboard_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Dashboard_Button.LineColor = System.Drawing.Color.Transparent;
            this.Dashboard_Button.LineTop = 3;
            this.Dashboard_Button.Location = new System.Drawing.Point(314, 95);
            this.Dashboard_Button.Name = "Dashboard_Button";
            this.Dashboard_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Dashboard_Button.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.Dashboard_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.Dashboard_Button.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("Dashboard_Button.OnHoverImage")));
            this.Dashboard_Button.OnHoverLineColor = System.Drawing.Color.White;
            this.Dashboard_Button.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.Dashboard_Button.Size = new System.Drawing.Size(145, 48);
            this.Dashboard_Button.TabIndex = 80;
            this.Dashboard_Button.Text = "Calculate";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1009, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // controlpanel
            // 
            this.controlpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlpanel.Location = new System.Drawing.Point(0, 143);
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Size = new System.Drawing.Size(924, 426);
            this.controlpanel.TabIndex = 110;
            this.controlpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.controlpanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(924, 569);
            this.Controls.Add(this.controlpanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaAdvenceButton Dashboard_Button;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaAdvenceButton log_out;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI.WinForms.GunaAdvenceButton Review_main;
        private Guna.UI.WinForms.GunaAdvenceButton upgrade_main;
        private Guna.UI.WinForms.GunaAdvenceButton cal_main;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel controlpanel;
        private Guna.UI.WinForms.GunaAdvenceButton home;
        private System.Windows.Forms.Label welcome;
    }
}

