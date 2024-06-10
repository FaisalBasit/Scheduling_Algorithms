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
            this.GanttChart = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // GanttChart
            // 
            this.GanttChart.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.GanttChart.Location = new System.Drawing.Point(66, 38);
            this.GanttChart.Name = "GanttChart";
            this.GanttChart.Size = new System.Drawing.Size(732, 149);
            this.GanttChart.TabIndex = 0;
            this.GanttChart.TabStop = false;
            this.GanttChart.Text = "Gantt Chart";
            this.GanttChart.Enter += new System.EventHandler(this.GanttChart_Enter);
            // 
            // steps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.GanttChart);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "steps";
            this.Size = new System.Drawing.Size(924, 426);
            this.Load += new System.EventHandler(this.steps_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox GanttChart;
    }
}
