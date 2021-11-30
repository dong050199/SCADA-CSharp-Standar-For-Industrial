using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class Data_Logger
    {
        public object Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Motor_1_1_State { get; set; }
        public string Motor_1_2_State { get; set; }
        public string Motor_2_1_State { get; set; }
        public string Motor_2_2_State { get; set; }
        public string Mixer_1_State { get; set; }
        public string Valve_3_1_State { get; set; }
        public string Valve_3_2_State { get; set; }
    }
}
