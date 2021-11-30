using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class TASK
    {

        public SCADA Parent;
        public string Name;
        public List<TAG> TAGS = new List<TAG>();
        int Period;
        System.Timers.Timer UpdateTimer = null;
        System.Timers.Timer MonitorTimer = null;
        
        public TASK(string name, int period)
        {
            Name = name;
            Period = period;
        }
        public void AddTag(TAG tag)
        {
            tag.Parent = this;
            TAGS.Add(tag);
        }

        public TAG FindTag(string name)
        {
            TAG tag = null;
            for(int i=0; i< TAGS.Count; i++)
            {
                tag = TAGS[i];
                if(tag.Name == name)
                {
                    return tag;
                }
            }

            return null;
        }

        public void Engine()
        {
            UpdateTimer = new System.Timers.Timer(Period);
            UpdateTimer.AutoReset = true;
            UpdateTimer.Elapsed += UpdateTimer_Elapsed;
            UpdateTimer.Start();

            MonitorTimer = new System.Timers.Timer(1000);
            MonitorTimer.AutoReset = true;
            MonitorTimer.Elapsed += MonitorTimer_Elapsed;
            MonitorTimer.Start();
        }

        private void MonitorTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine(Parent.S7500.level_blk.level);
            Console.WriteLine(Parent.S7500.level_blk.level1);
        }

        private void UpdateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            TAG tag;
            for(int i = 0; i < TAGS.Count; i++)
            {
                tag = TAGS[i];
                string[] temp = tag.Address.Split('.');
                string obj = temp[0];
                string signal = temp[1];
                switch (obj)
                {
                    case "Motor_1_1":
                        switch (signal)
                        {
                            case "Mode":
                                tag.Value = Parent.S7500.Motor_1_1.Mode;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "RunFeedBack":
                                tag.Value = Parent.S7500.Motor_1_1.RunFeedBack;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Fault":
                                tag.Value = Parent.S7500.Motor_1_1.Fault;
                                tag.TimeStamp = DateTime.Now;
                                break;
                        }
                        break;

                    case "Level":
                        switch (signal)
                        {
                            case "0":
                                tag.Value = Parent.S7500.level_blk.level;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "1":
                                tag.Value = Parent.S7500.level_blk.level1;
                                tag.TimeStamp = DateTime.Now;
                                
                                break;
                        }
                        break;

                    case "CtrlPanel":
                        switch (signal)
                        {
                            case "HI":
                                tag.Value = Parent.S7500.ctrlPanel.HI;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "LO":
                                tag.Value = Parent.S7500.ctrlPanel.LO;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "HI1":
                                tag.Value = Parent.S7500.ctrlPanel.HI1;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "LO1":
                                tag.Value = Parent.S7500.ctrlPanel.LO1;
                                tag.TimeStamp = DateTime.Now;
                                break;
                        }
                        break;

                    case "Motor_1_2":
                        switch (signal)
                        {
                            case "Mode":
                                tag.Value = Parent.S7500.Motor_1_2.Mode;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "RunFeedBack":
                                tag.Value = Parent.S7500.Motor_1_2.RunFeedBack;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Fault":
                                tag.Value = Parent.S7500.Motor_1_2.Fault;
                                tag.TimeStamp = DateTime.Now;
                                break;
                        }
                        break;

                    case "Motor_2_1":
                        switch (signal)
                        {
                            case "Mode":
                                tag.Value = Parent.S7500.Motor_2_1.Mode;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "RunFeedBack":
                                tag.Value = Parent.S7500.Motor_2_1.RunFeedBack;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Fault":
                                tag.Value = Parent.S7500.Motor_2_1.Fault;
                                tag.TimeStamp = DateTime.Now;
                                break;
                        }
                        break;


                    case "Motor_2_2":
                        switch (signal)
                        {
                            case "Mode":
                                tag.Value = Parent.S7500.Motor_2_2.Mode;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "RunFeedBack":
                                tag.Value = Parent.S7500.Motor_2_2.RunFeedBack;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Fault":
                                tag.Value = Parent.S7500.Motor_2_2.Fault;
                                tag.TimeStamp = DateTime.Now;
                                break;
                        }
                        break;

                    case "Mixer_1":
                        switch (signal)
                        {
                            case "Mode":
                                tag.Value = Parent.S7500.Mixer_1.Mode;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "RunFeedBack":
                                tag.Value = Parent.S7500.Mixer_1.RunFeedBack;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Fault":
                                tag.Value = Parent.S7500.Mixer_1.Fault;
                                tag.TimeStamp = DateTime.Now;
                                break;
                        }
                        break;

                    case "Valve_3_1":
                        switch (signal)
                        {
                            case "Mode":
                                tag.Value = Parent.S7500.Valve_3_1.Mode;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "RunFeedBack":
                                tag.Value = Parent.S7500.Valve_3_1.RunFeedBack;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Fault":
                                tag.Value = Parent.S7500.Valve_3_1.Fault;
                                tag.TimeStamp = DateTime.Now;
                                break;
                        }
                        break;

                    case "Valve_3_2":
                        switch (signal)
                        {
                            case "Mode":
                                tag.Value = Parent.S7500.Valve_3_2.Mode;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "RunFeedBack":
                                tag.Value = Parent.S7500.Valve_3_2.RunFeedBack;
                                tag.TimeStamp = DateTime.Now;
                                break;
                            case "Fault":
                                tag.Value = Parent.S7500.Valve_3_2.Fault;
                                tag.TimeStamp = DateTime.Now;
                                break;
                        }
                        break;

                }
            }
        }
    }
}
