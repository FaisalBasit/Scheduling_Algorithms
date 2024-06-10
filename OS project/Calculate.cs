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

namespace OS_project
{

    public partial class Calculate : UserControl
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["EMS"].ConnectionString);

        private steps stepInstance;

        public string username { get; set; }
        public string paid { get; set; }
        public Calculate()
        {
            InitializeComponent();
          
        }




        List<Process> Process_List = new List<Process>(), ganttChart = new List<Process>();
        List<int> Arrival_time = new List<int>(); List<int> burst_time = new List<int>();
        List<int> flag = new List<int>(); List<int> service_time = new List<int>();
        int Process_ID, Process_Priorty, Process_Arrival, Process_Quantum, pervAlgo;
        int Process_Burst, X = 16, t = 0, Y = 16, temp = 0, sum = 0;

        private void Clear_process_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Remove all Process?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                total_turnAround_time = total_waiting_time = 0; X = Y = 16; temp = sum = t = Process_Burst = 0;
                complete = 0; shortest = 0; finish_time = 0; minimum = 0; insert = checke = false;
                Process_List.Clear(); ganttChart.Clear(); flag.Clear(); pervAlgo = 0;
                burst_time.Clear(); Arrival_time.Clear(); service_time.Clear();
                cal_display1.Rows.Clear();
                cal_display1.Refresh();
                cal_display2.Rows.Clear();
                cal_display2.Refresh();
                AverageWT.Text = AverageTAT.Text = "";
                stepInstance.GanttChart.Controls.Clear();
            }
        }

        private void Calculate_Load(object sender, EventArgs e)
        {

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

                        Form1 parentForm = this.FindForm() as Form1;
                        if (parentForm != null)
                        {
                            if (paidStatus == "yes")
                            {
                                parentForm.ShowSteps();
                            }
                            else
                            {
                                //parentForm.ShowUpgrade();
                                MessageBox.Show("Upgrade to pro", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        bool checke = false; bool insert = false; // check for same Process IDs

        int complete = 0, shortest = 0, finish_time, minimum;
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
                Process_List.Add(new Process(Process_ID, Process_Burst, Process_Arrival, Process_Priorty));
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

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (Process_List.Count == 0)
            {
                MessageBox.Show("Please! Insert data first.", "Error");
                return;
            }
            FCFSTime(Process_List, Process_List.Count);

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
                     Convert.ToString(Process_List[i].compeletion_time),
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
        public void FCFSTime(List<Process> Process_List, int n)
        {
            stepInstance = new steps();

            Process_List = Process_List.OrderBy(i => i.arrival_time).ToList();
            for (int i = 0; i < n; i++)
            {
                service_time.Add(i);
            }
            Process_List[0].Pwaiting_time = 0;
            Process_List[0].PturnAround_time = Process_List[0].burst_time;
            // calculating waiting time  

            for (int i = 1; i < n; i++)
            {
                // Add burst time of previous processes
                service_time[i] = service_time[i - 1] + Process_List[i - 1].burst_time;

                //Find waiting time for current process =
                //sum - at[i];


                Process_List[i].Pwaiting_time = service_time[i] - Process_List[i].arrival_time;
                Process_List[i].PturnAround_time = Process_List[i].burst_time + Process_List[i].Pwaiting_time;
                if (Process_List[i].Pwaiting_time < 0)
                {
                    Process_List[i].Pwaiting_time = 0;
                }

                //stepInstance.Show();
                //stepInstance.MyFunction();
                //printing Gant chart
                for (int z = 0; z < Process_List[i - 1].burst_time; z++)
                {
                    ganttChart.Add(Process_List[i - 1]);
                    System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                    stepInstance.GanttChart.Controls.Add(textBox1);
                    textBox1.Size = new System.Drawing.Size(25, 25);
                    textBox1.Text = ("P" + Convert.ToString(Process_List[i - 1].P_id));
                    textBox1.Location = new System.Drawing.Point(X, 19);
                    textBox1.BackColor = Process_List[i - 1].process_color;
                    textBox1.Name = "textBox1";
                    textBox1.ReadOnly = true;
                    X += textBox1.Width;
                }
            }
            for (int z = 0; z < Process_List[n - 1].burst_time; z++)
            {
                ganttChart.Add(Process_List[n - 1]);
                System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
                stepInstance.GanttChart.Controls.Add(textBox1);
                textBox1.Size = new System.Drawing.Size(25, 25);
                textBox1.Text = ("P" + Convert.ToString(Process_List[n - 1].P_id));
                textBox1.Location = new System.Drawing.Point(X, 19);
                textBox1.BackColor = Process_List[n - 1].process_color;
                textBox1.Name = "textBox1";
                textBox1.ReadOnly = true;
                X += textBox1.Width;
            }

            for (int j = 0; j < n; j++)
            {
                total_waiting_time += Process_List[j].Pwaiting_time;
                total_turnAround_time += Process_List[j].PturnAround_time;
            }
            stepInstance.printGanttChart(ganttChart);

        }


    }


}
