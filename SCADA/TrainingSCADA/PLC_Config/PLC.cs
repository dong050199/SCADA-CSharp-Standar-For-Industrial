using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7.Net;

namespace PLC_Config
{
    public class PLC
    {
        public string IPAddress;
        public short Rack;
        public short Slot;
        public CpuType PLCType;
        public int Period;
        System.Timers.Timer ReadPLCTimer = new System.Timers.Timer();
        public Plc thePLC;
        public SCADA Parent;

        public MOTOR Motor_1_1 = new MOTOR("Motor_1_1");
        public MOTOR Motor_1_2 = new MOTOR("Motor_1_2");
        public MOTOR Motor_2_1 = new MOTOR("Motor_2_1");
        public MOTOR Motor_2_2 = new MOTOR("Motor_2_2");
        public MOTOR Mixer_1 = new MOTOR("Mixer_1");
        public MOTOR Valve_3_1 = new MOTOR("Valve_3_1");
        public MOTOR Valve_3_2 = new MOTOR("Valve_3_2");


        public PLC(CpuType cputype, string ip, short rack, short slot, int UpdatePeriod)
        {
            PLCType = cputype;
            IPAddress = ip;
            Rack = rack;
            Slot = slot;
            Period = UpdatePeriod;
            thePLC = new Plc(PLCType, IPAddress, Rack, Slot);
            try
            {
                thePLC.Open();
            }
            catch
            {
                Console.WriteLine("Error when open PLC Pls check connection");
            }
            ReadPLCTimer.Interval = Period;
            ReadPLCTimer.Elapsed += ReadPLCTimer_Elapsed;
            ReadPLCTimer.Start();
        }

        public void Write_PLC(string tag, object value)
        {
            switch (tag)
            {
                case "START":
                    thePLC.Write("DB9.DBX0.4", (bool)value);
                    break;
                case "STOP":
                    thePLC.Write("DB9.DBX0.5", (bool)value);
                    break;
                case "Motor_1_1.Start":
                    thePLC.Write("DB1.DBX2.0", (bool)value);
                    break;
                case "Motor_1_1.Stop":
                    thePLC.Write("DB1.DBX2.1", (bool)value);
                    break;
                case "Motor_1_1.Reset":
                    thePLC.Write("DB1.DBX2.5", (bool)value);
                    break;
                case "Motor_1_1.Mode":
                    thePLC.Write("DB1.DBW0", Convert.ToInt32(value));
                    break;

                case "Motor_1_2.Start":
                    thePLC.Write("DB2.DBX2.0", (bool)value);
                    break;
                case "Motor_1_2.Stop":
                    thePLC.Write("DB2.DBX2.1", (bool)value);
                    break;
                case "Motor_1_2.Reset":
                    thePLC.Write("DB2.DBX2.5", (bool)value);
                    break;
                case "Motor_1_2.Mode":
                    thePLC.Write("DB2.DBW0", Convert.ToInt32(value));
                    break;

                case "Motor_2_1.Start":
                    thePLC.Write("DB3.DBX2.0", (bool)value);
                    break;
                case "Motor_2_1.Stop":
                    thePLC.Write("DB3.DBX2.1", (bool)value);
                    break;
                case "Motor_2_1.Reset":
                    thePLC.Write("DB3.DBX2.5", (bool)value);
                    break;
                case "Motor_2_1.Mode":
                    thePLC.Write("DB3.DBW0", Convert.ToInt32(value));
                    break;

                case "Motor_2_2.Start":
                    thePLC.Write("DB4.DBX2.0", (bool)value);
                    break;
                case "Motor_2_2.Stop":
                    thePLC.Write("DB4.DBX2.1", (bool)value);
                    break;
                case "Motor_2_2.Reset":
                    thePLC.Write("DB4.DBX2.5", (bool)value);
                    break;
                case "Motor_2_2.Mode":
                    thePLC.Write("DB4.DBW0", Convert.ToInt32(value));
                    break;

                case "Mixer_1.Start":
                    thePLC.Write("DB5.DBX2.0", (bool)value);
                    break;
                case "Mixer_1.Stop":
                    thePLC.Write("DB5.DBX2.1", (bool)value);
                    break;
                case "Mixer_1.Reset":
                    thePLC.Write("DB5.DBX2.5", (bool)value);
                    break;
                case "Mixer_1.Mode":
                    thePLC.Write("DB5.DBW0", Convert.ToInt32(value));
                    break;

                case "Valve_3_1.Start":
                    thePLC.Write("DB6.DBX2.0", (bool)value);
                    break;
                case "Valve_3_1.Stop":
                    thePLC.Write("DB6.DBX2.1", (bool)value);
                    break;
                case "Valve_3_1.Reset":
                    thePLC.Write("DB6.DBX2.5", (bool)value);
                    break;
                case "Valve_3_1.Mode":
                    thePLC.Write("DB6.DBW0", Convert.ToInt32(value));
                    break;

                case "Valve_3_2.Start":
                    thePLC.Write("DB7.DBX2.0", (bool)value);
                    break;
                case "Valve_3_2.Stop":
                    thePLC.Write("DB7.DBX2.1", (bool)value);
                    break;
                case "Valve_3_2.Reset":
                    thePLC.Write("DB7.DBX2.5", (bool)value);
                    break;
                case "Valve_3_2.Mode":
                    thePLC.Write("DB7.DBW0",Convert.ToInt32(value));
                    break;
            }
        }

        public class LevelBlock
        {
            public ushort level { get; set; }
            public ushort level1 { get; set; }
        }

        public class ControlPanel
        {
            public bool HI1 { get; set; }
            public bool LO1 { get; set; }
            public bool HI { get; set; }
            public bool LO { get; set; }
            public bool START { get; set; }
            public bool STOP { get; set; }

        }

        public ControlPanel Control1 = new ControlPanel();
        public LevelBlock level_blk = new LevelBlock();
        public ControlPanel ctrlPanel = new ControlPanel();
        private void ReadPLCTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (thePLC.IsConnected)
            {
                try
                {
                    thePLC.ReadClass(Motor_1_1, 1);
                    thePLC.ReadClass(Motor_1_2, 2);
                    thePLC.ReadClass(Motor_2_1, 3);
                    thePLC.ReadClass(Motor_2_2, 4);
                    thePLC.ReadClass(Mixer_1, 5);
                    thePLC.ReadClass(Valve_3_1, 6);
                    thePLC.ReadClass(Valve_3_2, 7);
                    thePLC.ReadClass(level_blk, 14);
                    thePLC.ReadClass(ctrlPanel, 9);
                }
                catch
                {
                    Console.WriteLine("The PLC not or never connected");
                }
            }
        }
    }
}
