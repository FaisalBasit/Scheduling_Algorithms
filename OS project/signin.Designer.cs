namespace OS_project
{
    partial class signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.sign_up = new Guna.UI.WinForms.GunaAdvenceButton();
            this.login = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pass = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new Guna.UI.WinForms.GunaTextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.sign_up);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(317, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 430);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(43, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 121;
            this.label1.Text = "Ready to Login";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(289, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 120;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // sign_up
            // 
            this.sign_up.AnimationHoverSpeed = 0.07F;
            this.sign_up.AnimationSpeed = 0.03F;
            this.sign_up.BackColor = System.Drawing.Color.Transparent;
            this.sign_up.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.sign_up.BorderColor = System.Drawing.Color.Transparent;
            this.sign_up.BorderSize = 1;
            this.sign_up.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.sign_up.CheckedBorderColor = System.Drawing.Color.Black;
            this.sign_up.CheckedForeColor = System.Drawing.Color.White;
            this.sign_up.CheckedImage = null;
            this.sign_up.CheckedLineColor = System.Drawing.Color.DimGray;
            this.sign_up.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.sign_up.ForeColor = System.Drawing.Color.White;
            this.sign_up.Image = null;
            this.sign_up.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sign_up.ImageSize = new System.Drawing.Size(20, 20);
            this.sign_up.LineColor = System.Drawing.Color.White;
            this.sign_up.Location = new System.Drawing.Point(30, 16);
            this.sign_up.Name = "sign_up";
            this.sign_up.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.sign_up.OnHoverBorderColor = System.Drawing.Color.Black;
            this.sign_up.OnHoverForeColor = System.Drawing.Color.White;
            this.sign_up.OnHoverImage = null;
            this.sign_up.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.sign_up.OnPressedColor = System.Drawing.Color.Black;
            this.sign_up.Radius = 8;
            this.sign_up.Size = new System.Drawing.Size(118, 34);
            this.sign_up.TabIndex = 119;
            this.sign_up.Text = "Sign Up";
            this.sign_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click_1);
            // 
            // login
            // 
            this.login.AnimationHoverSpeed = 0.07F;
            this.login.AnimationSpeed = 0.03F;
            this.login.BackColor = System.Drawing.Color.Transparent;
            this.login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.login.BorderColor = System.Drawing.Color.Transparent;
            this.login.BorderSize = 1;
            this.login.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.login.CheckedBorderColor = System.Drawing.Color.Black;
            this.login.CheckedForeColor = System.Drawing.Color.White;
            this.login.CheckedImage = null;
            this.login.CheckedLineColor = System.Drawing.Color.DimGray;
            this.login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Image = null;
            this.login.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login.ImageSize = new System.Drawing.Size(20, 20);
            this.login.LineColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(69, 307);
            this.login.Name = "login";
            this.login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.login.OnHoverForeColor = System.Drawing.Color.White;
            this.login.OnHoverImage = null;
            this.login.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.login.OnPressedColor = System.Drawing.Color.Black;
            this.login.Radius = 8;
            this.login.Size = new System.Drawing.Size(170, 34);
            this.login.TabIndex = 118;
            this.login.Text = "Login";
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.Transparent;
            this.pass.BaseColor = System.Drawing.Color.White;
            this.pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.pass.BorderSize = 2;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.FocusedBaseColor = System.Drawing.Color.White;
            this.pass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pass.Location = new System.Drawing.Point(47, 251);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '●';
            this.pass.Radius = 10;
            this.pass.Size = new System.Drawing.Size(221, 27);
            this.pass.TabIndex = 116;
            this.pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.label2.Location = new System.Drawing.Point(44, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 117;
            this.label2.Text = "Password";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.BaseColor = System.Drawing.Color.White;
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.username.BorderSize = 2;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.FocusedBaseColor = System.Drawing.Color.White;
            this.username.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.username.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username.Location = new System.Drawing.Point(47, 184);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.Radius = 10;
            this.username.Size = new System.Drawing.Size(221, 27);
            this.username.TabIndex = 113;
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.label.Location = new System.Drawing.Point(44, 165);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(71, 16);
            this.label.TabIndex = 114;
            this.label.Text = "Username";
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 430);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaTextBox username;
        private System.Windows.Forms.Label label;
        private Guna.UI.WinForms.GunaTextBox pass;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaAdvenceButton sign_up;
        private Guna.UI.WinForms.GunaAdvenceButton login;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
    }
}