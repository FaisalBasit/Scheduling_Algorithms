using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace OS_project
{
    public class Process
    {
        // atirbutes of "Process" typ object
        public int P_id,burst_time,arrival_time, Pwaiting_time, PturnAround_time,completion_time; 
       // public static Random rand = new Random();
        public Color process_color = new Color();

   
        public Process(int id, int b_time, int a_time)
        {
            P_id = id;
            burst_time = b_time;
            arrival_time = a_time;
            PturnAround_time = 0;
            Pwaiting_time = 0;
            completion_time = 0;
            process_color = Color.White;
        }
    }
}
