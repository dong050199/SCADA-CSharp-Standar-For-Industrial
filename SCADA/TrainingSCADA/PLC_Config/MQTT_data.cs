using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class MQTT_data
    {
        public object TimeStamp { get; set; }
        public bool Motor_1_1_State { get; set; }
        public bool Motor_1_2_State { get; set; }
        public bool Motor_2_1_State { get; set; }
        public bool Motor_2_2_State { get; set; }
        public bool Mixer_1_State { get; set; }
        public bool Valve_3_1_State { get; set; }
        public bool Valve_3_2_State { get; set; }
    }
}
