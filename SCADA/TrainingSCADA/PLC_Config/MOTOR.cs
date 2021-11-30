using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class MOTOR
    {
        public string Name;
        public ushort Mode { get; set; }
        public bool Start { get; set; }
        public bool Stop { get; set; }
        public bool RunCondition { get; set; }
        public bool StopCondition { get; set; }
        public bool RunFeedBack { get; set; }
        public bool Reset { get; set; }
        public byte data2 { get; set; }
        public bool CMD { get; set; }
        public bool Fault { get; set; }


        int Period = 250;
        System.Timers.Timer UpdateTimer = null;
        public SCADA Parent;
        public MOTOR(string name)
        {
            Name = name;
        }

        public void Engine()
        {
            UpdateTimer = new System.Timers.Timer(Period);
            UpdateTimer.AutoReset = true;
            UpdateTimer.Elapsed += UpdateTimer_Elapsed;
            UpdateTimer.Start();
        }

        public void Write_Device(string tag,object value)
        {
            Console.WriteLine(Name);
            Console.WriteLine(tag);
            Console.WriteLine(value);
            switch (Name)
            {
                
                case "Motor_1_1":
                    
                    switch (tag)
                    {

                        case "Start":
                            Parent.S7500.Write_PLC("Motor_1_1.Start", value);
                            break;
                        case "Stop":
                            Parent.S7500.Write_PLC("Motor_1_1.Stop", value);
                            break;
                        case "Reset":
                            Parent.S7500.Write_PLC("Motor_1_1.Reset", value);
                            break;
                        case "Mode":
                            Parent.S7500.Write_PLC("Motor_1_1.Mode", value);
                            Console.WriteLine("cai quan que");
                            break;
                    }
                    break;

                case "Motor_1_2":
                    switch (tag)
                    {
                        case "Start":
                            Parent.S7500.Write_PLC("Motor_1_2.Start", value);
                            break;
                        case "Stop":
                            Parent.S7500.Write_PLC("Motor_1_2.Stop", value);
                            break;
                        case "Reset":
                            Parent.S7500.Write_PLC("Motor_1_2.Reset", value);
                            break;
                        case "Mode":
                            Parent.S7500.Write_PLC("Motor_1_2.Mode", value);
                            break;
                    }
                    break;

                case "Motor_2_1":
                    switch (tag)
                    {
                        case "Start":
                            Parent.S7500.Write_PLC("Motor_2_1.Start", value);
                            break;
                        case "Stop":
                            Parent.S7500.Write_PLC("Motor_2_1.Stop", value);
                            break;
                        case "Reset":
                            Parent.S7500.Write_PLC("Motor_2_1.Reset", value);
                            break;
                        case "Mode":
                            Parent.S7500.Write_PLC("Motor_2_1.Mode", value);
                            break;
                    }
                    break;

                case "Motor_2_2":
                    switch (tag)
                    {
                        case "Start":
                            Parent.S7500.Write_PLC("Motor_2_2.Start", value);
                            break;
                        case "Stop":
                            Parent.S7500.Write_PLC("Motor_2_2.Stop", value);
                            break;
                        case "Reset":
                            Parent.S7500.Write_PLC("Motor_2_2.Reset", value);
                            break;
                        case "Mode":
                            Parent.S7500.Write_PLC("Motor_2_2.Mode", value);
                            break;
                    }
                    break;

                case "Mixer_1":
                    switch (tag)
                    {
                        case "Start":
                            Parent.S7500.Write_PLC("Mixer_1.Start", value);
                            break;
                        case "Stop":
                            Parent.S7500.Write_PLC("Mixer_1.Stop", value);
                            break;
                        case "Reset":
                            Parent.S7500.Write_PLC("Mixer_1.Reset", value);
                            break;
                        case "Mode":
                            Parent.S7500.Write_PLC("Mixer_1.Mode", value);
                            break;
                    }
                    break;

                case "Valve_3_1":
                    switch (tag)
                    {
                        case "Start":
                            Parent.S7500.Write_PLC("Valve_3_1.Start", value);
                            break;
                        case "Stop":
                            Parent.S7500.Write_PLC("Valve_3_1.Stop", value);
                            break;
                        case "Reset":
                            Parent.S7500.Write_PLC("Valve_3_1.Reset", value);
                            break;
                        case "Mode":
                            Parent.S7500.Write_PLC("Valve_3_1.Mode", value);
                            break;
                    }
                    break;

                case "Valve_3_2":
                    switch (tag)
                    {
                        case "Start":
                            Parent.S7500.Write_PLC("Valve_3_2.Start", value);
                            break;
                        case "Stop":
                            Parent.S7500.Write_PLC("Valve_3_2.Stop", value);
                            break;
                        case "Reset":
                            Parent.S7500.Write_PLC("Valve_3_2.Reset", value);
                            break;
                        case "Mode":
                            Parent.S7500.Write_PLC("Valve_3_2.Mode", value);
                            break;
                    }
                    break;
            }
        }
        private void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            PLC plc = Parent.S7500;
            if(Name == "Motor_1_1")
            {
                Mode = plc.Motor_1_1.Mode;
                RunFeedBack = plc.Motor_1_1.RunFeedBack;
                Fault = plc.Motor_1_1.Fault;
            }
            if (Name == "Motor_1_2")
            {
                Mode = plc.Motor_1_2.Mode;
                RunFeedBack = plc.Motor_1_2.RunFeedBack;
                Fault = plc.Motor_1_2.Fault;
            }
            if (Name == "Motor_2_1")
            {
                Mode = plc.Motor_2_1.Mode;
                RunFeedBack = plc.Motor_2_1.RunFeedBack;
                Fault = plc.Motor_2_1.Fault;
            }
            if (Name == "Motor_2_2")
            {
                Mode = plc.Motor_2_2.Mode;
                RunFeedBack = plc.Motor_2_2.RunFeedBack;
                Fault = plc.Motor_2_2.Fault;
            }
            if (Name == "Mixer_1")
            {
                Mode = plc.Mixer_1.Mode;
                RunFeedBack = plc.Mixer_1.RunFeedBack;
                Fault = plc.Mixer_1.Fault;
            }
            if (Name == "Valve_3_1")
            {
                Mode = plc.Valve_3_1.Mode;
                RunFeedBack = plc.Valve_3_1.RunFeedBack;
                Fault = plc.Valve_3_1.Fault;
            }
            if (Name == "Valve_3_2")
            {
                Mode = plc.Valve_3_2.Mode;
                RunFeedBack = plc.Valve_3_2.RunFeedBack;
                Fault = plc.Valve_3_2.Fault;
            }
        }
    }
}
