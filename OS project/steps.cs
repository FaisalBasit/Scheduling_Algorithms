using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_project
{
    public partial class steps : Form
    {

        public steps()
        {
            InitializeComponent();
        }
        int Process_Burst, X = 16, t = 0, Y = 16, temp = 0, sum = 0;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculate cal = new Calculate();
            cal.Show();
        }

        private void GanttChart_Enter(object sender, EventArgs e)
        {

        }
        public void DisplayProcessDetails(Process process, int index)
        {
            string stepDetails = $"Process {process.P_id}:      " +
                                 $"Waiting Time = ( Turnaround Time - Burst Time ) = {process.Pwaiting_time}      " +
                                 $"Turnaround Time = ( Completion Time - Arrival Time ) = {process.PturnAround_time}";
            stepsListBox.Items.Add(stepDetails);
        }


        public void printGanttChart(List<Process> ganttChart)
        {
            int num = 0;
            TextBox textBox6 = new TextBox();
            GanttChart.Controls.Add(textBox6);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new System.Drawing.Size(25, 25);
            textBox6.BackColor = ganttChart[0].process_color;
            textBox6.Location = new System.Drawing.Point(Y, 59);
            textBox6.Text = (0.ToString());

            for (; num < ganttChart.Count; num++)
            {
                if (num < (ganttChart.Count - 1))
                {
                    if (ganttChart[num].P_id != ganttChart[num + 1].P_id)
                    {
                        TextBox textBox2 = new TextBox();
                        GanttChart.Controls.Add(textBox2);
                        textBox2.Name = "textBox2";
                        textBox2.ReadOnly = true;
                        textBox2.Size = new System.Drawing.Size(25, 25);
                        textBox2.BackColor = ganttChart[num].process_color;
                        textBox2.Location = new System.Drawing.Point(Y, 59);
                        textBox2.Text = (num.ToString());

                        TextBox textBox5 = new TextBox();
                        GanttChart.Controls.Add(textBox5);
                        textBox5.Name = "textBox5";
                        textBox5.ReadOnly = true;
                        textBox5.Size = new System.Drawing.Size(25, 25);
                        textBox5.BackColor = ganttChart[num + 1].process_color;
                        textBox5.Location = new System.Drawing.Point((Y + textBox2.Width), 59);
                        textBox5.Text = ((num + 1).ToString());
                    }
                    Y += 25;
                }
                if (num == (ganttChart.Count - 1))
                {
                    TextBox textBox7 = new TextBox();
                    GanttChart.Controls.Add(textBox7);
                    textBox7.ReadOnly = true;
                    textBox7.Name = "textBox7";
                    textBox7.Size = new System.Drawing.Size(25, 25);
                    if (num != 0)
                        textBox7.BackColor = ganttChart[num - 1].process_color;
                    else
                        textBox7.BackColor = ganttChart[num].process_color;
                    textBox7.Location = new System.Drawing.Point(Y, 59);
                    textBox7.Text = ((num+1).ToString());
                }
            }
        }

        public void printGanttChart1(List<Process> ganttChart, List<Process> Process_List)
        {
            //int num = Process_List[0].arrival_time;

            //System.Windows.Forms.TextBox textBox6 = new System.Windows.Forms.TextBox();
            //GanttChart.Controls.Add(textBox6);
            //textBox6.Name = "textBox6";
            //textBox6.ReadOnly = true;
            //textBox6.Size = new System.Drawing.Size(25, 25);
            //textBox6.BackColor = ganttChart[0].process_color;
            //textBox6.Location = new System.Drawing.Point(X, 38);
            //textBox6.Text = (num.ToString());

            for (int i = 0; i < Process_List.Count; i++)
            {
                               
                X = (X + (25 * Process_List[i].burst_time )-25);
                System.Windows.Forms.TextBox textBox7 = new System.Windows.Forms.TextBox();
                GanttChart.Controls.Add(textBox7);
                textBox7.Name = "textBox7";
                textBox7.ReadOnly = true;
                textBox7.Size = new System.Drawing.Size(25, 25);
                textBox7.BackColor = ganttChart[0].process_color;            
                textBox7.Location = new System.Drawing.Point(X, 38);
                textBox7.Text = (Process_List[i].completion_time.ToString());
                X=X+25;
               
                
            }  
                
            
        }
        private void steps_Load(object sender, EventArgs e)
        {
      
        }
    }
}
