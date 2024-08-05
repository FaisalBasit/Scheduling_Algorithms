using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Linq.Expressions;
using Guna.UI2.WinForms.Suite;

namespace OS_project
{

    public partial class Calculate : UserControl
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);

        public steps stepInstance;

        public string username { get; set; }
        public string paid { get; set; }
        public Calculate()
        {
            InitializeComponent();
            FCFS.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            RR.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

        }

        private void Calculate_Load(object sender, EventArgs e)
        {
            //TQ.Enabled = false;
            tq_label.Hide();
            TQ.Hide();
            title.Text = "First come first serve";
        }


        List<Process> Process_List = new List<Process>(), ganttChart = new List<Process>();
        List<int> Arrival_time = new List<int>(); List<int> burst_time = new List<int>();
        List<int> flag = new List<int>(); List<int> service_time = new List<int>();
        //int Process_ID, Process_Arrival;
        int Process_ID, Process_Arrival, Process_Quantum, pervAlgo;
        int complete = 0, shortest = 0, finish_time, minimum;
        int Process_Burst, X = 16, t = 0, Y = 16, temp = 0, sum = 0;


        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (RR.Checked)
            {
                //TQ.Enabled = true;
                TQ.Show();
                tq_label.Show();
                title.Text = "Round Robin";
            }
            else
            {
                //TQ.Enabled = false;
                tq_label.Hide();
                TQ.Hide();
                title.Text = "First come first serve";
            }
        }

        private void Clear_process_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Remove all Process?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                total_turnAround_time = total_waiting_time = 0; X = Y = 16; temp = sum = t = Process_Burst = 0;  pervAlgo = 0;
                insert = checke = false;
                Process_List.Clear(); ganttChart.Clear(); 
                burst_time.Clear(); Arrival_time.Clear(); service_time.Clear();
                cal_display1.Rows.Clear();
                cal_display1.Refresh();
                cal_display2.Rows.Clear();
                cal_display2.Refresh();
                AverageWT.Text = AverageTAT.Text = "";
                processid.Text = (1.ToString());
                ArrivalTime.Text = BurstTime.Text = (0.ToString());
                
                if (Process_List.Count > 0)
                {
                    stepInstance.GanttChart.Controls.Clear();
                }
                
            }
        }

      

        private void show_steps_Click_1(object sender, EventArgs e)
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
                            // Proceed to show the steps form
                            if (Process_List.Count > 0)
                            {
                                stepInstance.Show();
                            }
                            else
                            {
                                MessageBox.Show("Please insert and calculate process first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Upgrade to pro", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void AverageTAT_Click(object sender, EventArgs e)
        {

        }

        private void show_steps_Click(object sender, EventArgs e)
        {
            //stepInstance.Show();
            //this.Hide();
            //steps cal = new steps();

            //stepInstance.Show();
            // stepInstance.BringToFront();
            // cal.BringToFront();
        }

        private void processid_Click(object sender, EventArgs e)
        {

        }

        private void FCFS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RR_CheckedChanged(object sender, EventArgs e)
        {

        }

        bool checke = false; bool insert = false; // check for same Process IDs

       
        float total_waiting_time = 0f, total_turnAround_time = 0f;
        string[] row = new string[20]; // for displaying the result
        private void Add_Process_Click(object sender, EventArgs e)
        {
            cal_display1.Visible = false;
            cal_display2.Visible = true;
            Process_ID = Convert.ToInt32(processid.Value);
            Process_Burst = Convert.ToInt32(BurstTime.Text);
            Process_Arrival = Convert.ToInt32(ArrivalTime.Text);
            for (int i = 0; i < Process_List.Count; i++)
            {
                if (Process_List[i].P_id == Process_ID)
                    checke = true;
            }
            if (checke == true)
            {
                MessageBox.Show("Two process can't have same Process ID = "
                        + Convert.ToString(Process_ID)
                        + ", at a same time \n Please Enter Process ID again", "Error");
                checke = false;
                return;
            }
            else
            {
                Process_List.Add(new Process(Process_ID, Process_Burst, Process_Arrival));
                row = new[]
                            {
                              Convert.ToString(Process_List[Process_List.Count - 1].P_id),
                              Convert.ToString(Process_List[Process_List.Count - 1].arrival_time),
                              Convert.ToString(Process_List[Process_List.Count - 1].burst_time),
                              "   --",
                              "   --",
                              "   --"
                            };
            }
            cal_display2.Rows.Add(row);

            checke = false;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e) //  Calculate BUTTON !!!
        {
            if (Process_List.Count == 0)
            {
                MessageBox.Show("Please! Insert data first.", "Error");
                return;
            }
            Process_Quantum = Convert.ToInt32(TQ.Value);

            if (pervAlgo == 0)
            {
                if (RR.Checked)
                {
                    if (Process_Quantum == 0)
                    {
                        MessageBox.Show(null, "QUANTUM = 0 !\nEnter QUANTUM and press RUN.", "Invalid Input");
                        return;
                    }
                    else
                        RoundRobin(Process_List, Process_Quantum);
                }
                else if (FCFS.Checked)
                    FCFSTime(Process_List, Process_List.Count);
              
            }
            else
            {
               
                if (pervAlgo != 1 && RR.Checked)
                {
                    if (Process_Quantum == 0)
                    {
                        MessageBox.Show(null, "QUANTUM = 0 !\nEnter QUANTUM and press RUN.", "Invalid Input");
                        return;
                    }
                    else
                    {
                        total_turnAround_time = total_waiting_time = 0; X = Y = 16; temp = sum = t = Process_Burst = 0;
                        complete = 0; shortest = 0; finish_time = 0; minimum = 0; insert = checke = false;
                        ganttChart.Clear(); flag.Clear();
                        burst_time.Clear(); Arrival_time.Clear(); service_time.Clear();
                        cal_display1.Rows.Clear();
                        cal_display1.Refresh();
                        AverageWT.Text = AverageTAT.Text = "";
                        stepInstance.GanttChart.Controls.Clear();
                        RoundRobin(Process_List, Process_Quantum);
                    }
                }
                else
                {
                    total_turnAround_time = total_waiting_time = 0; X = Y = 16; temp = sum = t = Process_Burst = 0;
                    complete = 0; shortest = 0; finish_time = 0; minimum = 0; insert = checke = false;
                    ganttChart.Clear(); flag.Clear();
                    burst_time.Clear(); Arrival_time.Clear(); service_time.Clear();
                    cal_display1.Rows.Clear();
                    cal_display1.Refresh();
                    AverageWT.Text = AverageTAT.Text = "";
                    stepInstance.GanttChart.Controls.Clear();

                  
                    if (FCFS.Checked)
                        FCFSTime(Process_List, Process_List.Count);
                
                }
            }
         

            cal_display2.Visible = false;
            cal_display1.Visible = true;
            Process_List = Process_List.OrderBy(i => i.P_id).ToList();
            for (int i = 0; i < Process_List.Count; i++)
            {
                row = new[]
                {
                     Convert.ToString(Process_List[i].P_id),
                     Convert.ToString(Process_List[i].arrival_time),
                     Convert.ToString(Process_List[i].burst_time),
                     Convert.ToString(Process_List[i].completion_time),
                     Convert.ToString(Process_List[i].PturnAround_time),
                     Convert.ToString(Process_List[i].Pwaiting_time)
                 };
                cal_display1.Rows.Add(row);

            }
            if ((total_turnAround_time / Process_List.Count) == 0)
                AverageTAT.Text = "0.00";
            else
                AverageTAT.Text = (total_turnAround_time / Process_List.Count).ToString("#.##");

            if ((total_waiting_time / Process_List.Count) == 0)
                AverageWT.Text = "0.00";
            else
                AverageWT.Text = (total_waiting_time / Process_List.Count).ToString("#.##");

        }


        public void RoundRobin(List<Process> Process_List, int quantum)
        {
            stepInstance = new steps();
            pervAlgo = 1;
            Process_List = Process_List.OrderBy(i => i.arrival_time).ToList();
            for (int i = 0; i < Process_List.Count(); i++)
            {
                Arrival_time.Add(Process_List[i].arrival_time);
                burst_time.Add(Process_List[i].burst_time); // making new burst time list
            }

            while (true)
            {
                checke = true;
                for (int i = 0; i < Process_List.Count; i++)
                {
                    // these condition for if arivaltime !=0 && check that if there come before qtime 
                    if (Arrival_time[i] <= t)
                    {
                        if (Arrival_time[i] <= quantum)
                        {
                            if (burst_time[i] > 0)
                            {
                                checke = false;
                                if (burst_time[i] > quantum)
                                {
                                    // make decrease the b time 
                                    t = t + quantum;
                                    burst_time[i] = burst_time[i] - quantum;
                                    Arrival_time[i] = Arrival_time[i] + quantum;
                                    for (int h = 0; h < quantum; h++)
                                    {
                                        ganttChart.Add(Process_List[i]);
                                        //printing Gantt chart
                                        System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                                        stepInstance.GanttChart.Controls.Add(textBox1);
                                        textBox1.Size = new System.Drawing.Size(25, 25);
                                        textBox1.Text = ("P" + Convert.ToString(Process_List[i].P_id));
                                        textBox1.Location = new System.Drawing.Point(X, 34);
                                        textBox1.BackColor = Process_List[i].process_color;
                                        textBox1.Name = "textBox1";
                                        textBox1.ReadOnly = true;
                                        X += textBox1.Width;
                                    }
                                }
                                else
                                {
                                    // for last time 
                                    t = t + burst_time[i];
                                    for (int h = 0; h < burst_time[i]; h++)
                                    {
                                        ganttChart.Add(Process_List[i]);
                                        //printing Gantt chart
                                        System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                                        stepInstance.GanttChart.Controls.Add(textBox1);
                                        textBox1.Size = new System.Drawing.Size(25, 25);
                                        textBox1.Text = ("P" + Convert.ToString(Process_List[i].P_id));
                                        textBox1.Location = new System.Drawing.Point(X, 34);
                                        textBox1.BackColor = Process_List[i].process_color;
                                        textBox1.Name = "textBox1";
                                        textBox1.ReadOnly = true;
                                        X += textBox1.Width;
                                    }
                                    // store completion time
                                    Process_List[i].completion_time = t;
                                    // store turn around time 
                                    Process_List[i].PturnAround_time = t - Process_List[i].arrival_time;
                                    // store wait time 
                                    Process_List[i].Pwaiting_time = t - Process_List[i].burst_time - Process_List[i].arrival_time;
                                    burst_time[i] = 0;
                                }

                               
                            }
                        }
                        else if (Arrival_time[i] > quantum)
                        {
                            // if any process has a lesser arrival time
                            for (int j = 0; j < Process_List.Count; j++)
                            {
                                // compare 
                                if (Arrival_time[j] < Arrival_time[i])
                                {
                                    if (burst_time[j] > 0)
                                    {
                                        checke = false;
                                        if (burst_time[j] > quantum)
                                        {
                                            t = t + quantum;
                                            burst_time[j] = burst_time[j] - quantum;
                                            Arrival_time[j] = Arrival_time[j] + quantum;
                                            for (int h = 0; h < quantum; h++)
                                            {
                                                ganttChart.Add(Process_List[j]);
                                                //printing Gantt chart
                                                System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                                                stepInstance.GanttChart.Controls.Add(textBox1);
                                                textBox1.Size = new System.Drawing.Size(25, 25);
                                                textBox1.Text = ("P" + Convert.ToString(Process_List[j].P_id));
                                                textBox1.Location = new System.Drawing.Point(X, 34);
                                                textBox1.BackColor = Process_List[j].process_color;
                                                textBox1.Name = "textBox1";
                                                textBox1.ReadOnly = true;
                                                X += textBox1.Width;
                                            }
                                        }
                                        else
                                        {
                                            t = t + burst_time[j];
                                            for (int h = 0; h < burst_time[j]; h++)
                                            {
                                                ganttChart.Add(Process_List[j]);
                                                //printing Gantt chart
                                                System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                                                stepInstance.GanttChart.Controls.Add(textBox1);
                                                textBox1.Size = new System.Drawing.Size(25, 25);
                                                textBox1.Text = ("P" + Convert.ToString(Process_List[j].P_id));
                                                textBox1.Location = new System.Drawing.Point(X, 34);
                                                textBox1.BackColor = Process_List[j].process_color;
                                                textBox1.Name = "textBox1";
                                                textBox1.ReadOnly = true;
                                                X += textBox1.Width;
                                            }
                                            Process_List[j].completion_time = t;
                                            Process_List[j].PturnAround_time = t - Process_List[j].arrival_time;
                                            Process_List[j].Pwaiting_time = t - Process_List[j].burst_time - Process_List[j].arrival_time;
                                            burst_time[j] = 0;
                                        }

                                       
                                    }
                                }
                            }

                            // now the previous process according to
                            // ith is process
                            if (burst_time[i] > 0)
                            {
                                checke = false;
                                // Check for greater
                                if (burst_time[i] > quantum)
                                {
                                    t = t + quantum;
                                    burst_time[i] = burst_time[i] - quantum;
                                    Arrival_time[i] = Arrival_time[i] + quantum;
                                    for (int h = 0; h < quantum; h++)
                                    {
                                        ganttChart.Add(Process_List[i]);
                                        //printing Gantt chart
                                        System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                                        stepInstance.GanttChart.Controls.Add(textBox1);
                                        textBox1.Size = new System.Drawing.Size(25, 25);
                                        textBox1.Text = ("P" + Convert.ToString(Process_List[i].P_id));
                                        textBox1.Location = new System.Drawing.Point(X, 34);
                                        textBox1.BackColor = Process_List[i].process_color;
                                        textBox1.Name = "textBox1";
                                        textBox1.ReadOnly = true;
                                        X += textBox1.Width;
                                    }
                                }
                                else
                                {
                                    t = t + burst_time[i];
                                    for (int h = 0; h < burst_time[i]; h++)
                                    {
                                        ganttChart.Add(Process_List[i]);
                                        //printing Gantt chart
                                        System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                                        stepInstance.GanttChart.Controls.Add(textBox1);
                                        textBox1.Size = new System.Drawing.Size(25, 25);
                                        textBox1.Text = ("P" + Convert.ToString(Process_List[i].P_id));
                                        textBox1.Location = new System.Drawing.Point(X, 34);
                                        textBox1.BackColor = Process_List[i].process_color;
                                        textBox1.Name = "textBox1";
                                        textBox1.ReadOnly = true;
                                        X += textBox1.Width;
                                    }
                                    Process_List[i].completion_time = t;
                                    Process_List[i].PturnAround_time = t - Process_List[i].arrival_time;
                                    Process_List[i].Pwaiting_time = t - Process_List[i].burst_time - Process_List[i].arrival_time;
                                    burst_time[i] = 0;
                                }

                               
                                
                            }
                        }
                    }
                    // if no process is come on these critical 
                    else if (Arrival_time[i] > t)
                    {
                        t++;
                        i--;
                    }
                }
                // for exit the while loop 
                if (checke)
                {
                    break;
                }
            }

            for (int i = 0; i < Process_List.Count; i++)
            {
                total_waiting_time += Process_List[i].Pwaiting_time;
                total_turnAround_time += Process_List[i].PturnAround_time;
                stepInstance.DisplayProcessDetails(Process_List[i], i);
            }
            stepInstance.printGanttChart(ganttChart);
        }



        public void FCFSTime(List<Process> Process_List, int n)
        {
            stepInstance = new steps();
            pervAlgo = 0;

            Process_List = Process_List.OrderBy(i => i.arrival_time).ToList();
            int current_time = 0;
   
           
            // calculating waiting time  

            for (int i = 0; i < n; i++)
            {
                

                if (current_time < Process_List[i].arrival_time)
                {
                    current_time = Process_List[i].arrival_time;
                }
                Process_List[i].completion_time = current_time + Process_List[i].burst_time;
                Process_List[i].PturnAround_time = Process_List[i].completion_time - Process_List[i].arrival_time;
                Process_List[i].Pwaiting_time = Process_List[i].PturnAround_time - Process_List[i].burst_time;

                current_time = Process_List[i].completion_time;

                

                 // Display details for each process

                
                //printing Gant chart
                for (int z = 0; z < Process_List[i ].burst_time; z++)
                {
                    ganttChart.Add(Process_List[i]);
                    System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                    stepInstance.GanttChart.Controls.Add(textBox1);
                    textBox1.Size = new System.Drawing.Size(25, 25);
                    textBox1.Text = ("P" + Convert.ToString(Process_List[i].P_id));
                    textBox1.Location = new System.Drawing.Point(X, 19);
                    textBox1.BackColor = Process_List[ i].process_color;
                    textBox1.Name = "textBox1";
                    textBox1.ReadOnly = true;
                    X += textBox1.Width;
                }
            }
            

            for (int j = 0; j < n; j++)
            {
                stepInstance.DisplayProcessDetails(Process_List[j], j);
                total_waiting_time += Process_List[j].Pwaiting_time;
                total_turnAround_time += Process_List[j].PturnAround_time;
            }
            stepInstance.printGanttChart1(ganttChart,Process_List);

        }


    }


}
