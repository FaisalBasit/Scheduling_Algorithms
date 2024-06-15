namespace OS_project
{
    partial class steps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(steps));
            this.GanttChart = new System.Windows.Forms.GroupBox();
            this.back = new Guna.UI.WinForms.GunaAdvenceButton();
            this.stepsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaHScrollBar1 = new Guna.UI.WinForms.GunaHScrollBar();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.GanttChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // GanttChart
            // 
            this.GanttChart.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.GanttChart.BackColor = System.Drawing.Color.Transparent;
            this.GanttChart.Controls.Add(this.gunaHScrollBar1);
            this.GanttChart.Location = new System.Drawing.Point(48, 47);
            this.GanttChart.Name = "GanttChart";
            this.GanttChart.Size = new System.Drawing.Size(827, 126);
            this.GanttChart.TabIndex = 0;
            this.GanttChart.TabStop = false;
            this.GanttChart.Enter += new System.EventHandler(this.GanttChart_Enter);
            // 
            // back
            // 
            this.back.AnimationHoverSpeed = 0.07F;
            this.back.AnimationSpeed = 0.03F;
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.back.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.back.BorderColor = System.Drawing.Color.Transparent;
            this.back.BorderSize = 1;
            this.back.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.back.CheckedBorderColor = System.Drawing.Color.Black;
            this.back.CheckedForeColor = System.Drawing.Color.White;
            this.back.CheckedImage = null;
            this.back.CheckedLineColor = System.Drawing.Color.DimGray;
            this.back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Image = null;
            this.back.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.back.ImageSize = new System.Drawing.Size(20, 20);
            this.back.LineColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(334, 377);
            this.back.Name = "back";
            this.back.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(63)))), ((int)(((byte)(89)))));
            this.back.OnHoverBorderColor = System.Drawing.Color.Black;
            this.back.OnHoverForeColor = System.Drawing.Color.White;
            this.back.OnHoverImage = null;
            this.back.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.back.OnPressedColor = System.Drawing.Color.Black;
            this.back.Radius = 8;
            this.back.Size = new System.Drawing.Size(200, 37);
            this.back.TabIndex = 131;
            this.back.Text = "Back";
            this.back.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // stepsListBox
            // 
            this.stepsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stepsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.stepsListBox.FormattingEnabled = true;
            this.stepsListBox.ItemHeight = 17;
            this.stepsListBox.Location = new System.Drawing.Point(48, 220);
            this.stepsListBox.Name = "stepsListBox";
            this.stepsListBox.Size = new System.Drawing.Size(827, 119);
            this.stepsListBox.TabIndex = 132;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.label4.Location = new System.Drawing.Point(44, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 133;
            this.label4.Text = "Ghantt Chart";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(115)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(44, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 134;
            this.label1.Text = "Steps";
            // 
            // gunaHScrollBar1
            // 
            this.gunaHScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaHScrollBar1.LargeChange = 10;
            this.gunaHScrollBar1.Location = new System.Drawing.Point(0, 116);
            this.gunaHScrollBar1.Maximum = 100;
            this.gunaHScrollBar1.Name = "gunaHScrollBar1";
            this.gunaHScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaHScrollBar1.Size = new System.Drawing.Size(827, 10);
            this.gunaHScrollBar1.TabIndex = 0;
            this.gunaHScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaHScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaHScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(864, 220);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(10, 119);
            this.gunaVScrollBar1.TabIndex = 135;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // steps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(924, 426);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stepsListBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.GanttChart);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(220, 220);
            this.Name = "steps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.steps_Load);
            this.GanttChart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox GanttChart;
        private Guna.UI.WinForms.GunaAdvenceButton back;
        private System.Windows.Forms.ListBox stepsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaHScrollBar gunaHScrollBar1;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
    }
}