namespace OS_project
{
    partial class Review
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Review));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.feedback = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submit_feedback = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(58, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Write feedback about us.";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(345, 27);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(66, 54);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 18;
            this.gunaPictureBox1.TabStop = false;
            // 
            // feedback
            // 
            this.feedback.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback.Location = new System.Drawing.Point(63, 148);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(792, 171);
            this.feedback.TabIndex = 17;
            this.feedback.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.label3.Location = new System.Drawing.Point(404, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 54);
            this.label3.TabIndex = 16;
            this.label3.Text = "Feedback";
            // 
            // submit_feedback
            // 
            this.submit_feedback.AnimationHoverSpeed = 0.07F;
            this.submit_feedback.AnimationSpeed = 0.03F;
            this.submit_feedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.submit_feedback.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.submit_feedback.BorderColor = System.Drawing.Color.Transparent;
            this.submit_feedback.BorderSize = 1;
            this.submit_feedback.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.submit_feedback.CheckedBorderColor = System.Drawing.Color.Black;
            this.submit_feedback.CheckedForeColor = System.Drawing.Color.White;
            this.submit_feedback.CheckedImage = null;
            this.submit_feedback.CheckedLineColor = System.Drawing.Color.DimGray;
            this.submit_feedback.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.submit_feedback.ForeColor = System.Drawing.Color.White;
            this.submit_feedback.Image = null;
            this.submit_feedback.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.submit_feedback.ImageSize = new System.Drawing.Size(20, 20);
            this.submit_feedback.LineColor = System.Drawing.Color.White;
            this.submit_feedback.Location = new System.Drawing.Point(357, 346);
            this.submit_feedback.Name = "submit_feedback";
            this.submit_feedback.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.submit_feedback.OnHoverBorderColor = System.Drawing.Color.Black;
            this.submit_feedback.OnHoverForeColor = System.Drawing.Color.White;
            this.submit_feedback.OnHoverImage = null;
            this.submit_feedback.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.submit_feedback.OnPressedColor = System.Drawing.Color.Black;
            this.submit_feedback.Radius = 8;
            this.submit_feedback.Size = new System.Drawing.Size(200, 37);
            this.submit_feedback.TabIndex = 131;
            this.submit_feedback.Text = "Submit";
            this.submit_feedback.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.submit_feedback.Click += new System.EventHandler(this.submit_feedback_Click);
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.submit_feedback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.label3);
            this.Name = "Review";
            this.Size = new System.Drawing.Size(924, 426);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.RichTextBox feedback;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaAdvenceButton submit_feedback;
    }
}
