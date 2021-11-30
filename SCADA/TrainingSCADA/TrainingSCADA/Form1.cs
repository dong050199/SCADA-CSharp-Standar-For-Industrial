using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLC_Config;
using Newtonsoft.Json;

namespace TrainingSCADA
{
    public partial class Form1 : Form
    {

        public SCADA Parent;
        public Form1(SCADA parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            TASK task = Program.Root.FindTask("Task_1");
            //TASK task = Parent.FindTask("Task_1");
            if(task != null)
            {
                TAG tag = task.FindTag("Motor_1_1_RunFeedBack");
                if(tag != null)
                {
                    sb_M_1_1.DiscreteValue1 = Convert.ToBoolean(tag.Value);
                }
                tag = task.FindTag("Motor_1_2_RunFeedBack");
                if (tag != null)
                {
                    sb_M_1_2.DiscreteValue1 = Convert.ToBoolean(tag.Value);
                }
                tag = task.FindTag("Motor_2_1_RunFeedBack");
                if (tag != null)
                {
                    sb_M_2_1.DiscreteValue1 = Convert.ToBoolean(tag.Value);
                }
                tag = task.FindTag("Motor_2_2_RunFeedBack");
                if (tag != null)
                {
                    sb_M_2_2.DiscreteValue1 = Convert.ToBoolean(tag.Value);
                }
                tag = task.FindTag("Valve_3_1_RunFeedBack");
                if (tag != null)
                {
                    sb_V_3_1.DiscreteValue1 = Convert.ToBoolean(tag.Value);
                }
                tag = task.FindTag("Valve_3_2_RunFeedBack");
                if (tag != null)
                {
                    sb_V_3_2.DiscreteValue1 = Convert.ToBoolean(tag.Value);
                }
                tag = task.FindTag("Level");
                if (tag != null)
                {
                    lb_Level.Text = Convert.ToString(tag.Value);
                }
                tag = task.FindTag("Level1");
                if (tag != null)
                {
                    lb_Level1.Text = Convert.ToString(tag.Value);
                }
                tag = task.FindTag("Mixer_1_RunFeedBack");
                if (tag != null)
                {
                    sb_Mixer.DiscreteValue1 = Convert.ToBoolean(tag.Value);
                    sb_SymbolMixer.DiscreteValue1 = Convert.ToBoolean(tag.Value);
                }
            }
        }

        private void sb_M_1_2_Click(object sender, EventArgs e)
        {
            MOTOR_FACEPLATE faceplate = Program.Root.MOTOR_FACEPLATES[1];
            faceplate.Show();
        }

        private void sb_M_1_1_Click(object sender, EventArgs e)
        {
            MOTOR_FACEPLATE faceplate = Program.Root.MOTOR_FACEPLATES[0];
            faceplate.Show();
        }

        private void sb_M_2_2_Click(object sender, EventArgs e)
        {
            MOTOR_FACEPLATE faceplate = Program.Root.MOTOR_FACEPLATES[3];
            faceplate.Show();
        }

        private void sb_M_2_1_Click(object sender, EventArgs e)
        {
            MOTOR_FACEPLATE faceplate = Program.Root.MOTOR_FACEPLATES[2];
            faceplate.Show();
        }

        private void sb_V_3_1_Click(object sender, EventArgs e)
        {
            MOTOR_FACEPLATE faceplate = Program.Root.MOTOR_FACEPLATES[5];
            faceplate.Show();
        }

        private void sb_V_3_2_Click(object sender, EventArgs e)
        {
            MOTOR_FACEPLATE faceplate = Program.Root.MOTOR_FACEPLATES[6];
            faceplate.Show();
        }

        private void sb_Start_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S7500.Write_PLC("START", false);
        }

        private void sb_Start_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.S7500.Write_PLC("START", true);
        }

        private void sb_Stop_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.S7500.Write_PLC("STOP", false);
        }

        private void sb_Stop_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.S7500.Write_PLC("STOP", true);
        }

        private void sb_SymbolMixer_Click(object sender, EventArgs e)
        {
            MOTOR_FACEPLATE faceplate = Program.Root.MOTOR_FACEPLATES[4];
            faceplate.Show();
        }
        
        private void TimerLogger_Tick(object sender, EventArgs e)
        {
            MQTT_data datamqtt = new MQTT_data();
            TASK task = null;
            task = Parent.FindTask("Task_1");
            if(task != null)
            {
                TAG tag = task.FindTag("Motor_1_1_Runcondition");
                if(tag != null)
                {
                    datamqtt.Motor_1_1_State = (bool)tag.Value;
                }
                tag = task.FindTag("Motor_1_2_Runcondition");
                if (tag != null)
                {
                    datamqtt.Motor_1_2_State = (bool)tag.Value;
                }
                tag = task.FindTag("Motor_2_1_Runcondition");
                if (tag != null)
                {
                    datamqtt.Motor_2_1_State = (bool)tag.Value;
                }
                tag = task.FindTag("Motor_2_2_Runcondition");
                if (tag != null)
                {
                    datamqtt.Motor_2_2_State = (bool)tag.Value;
                }
                tag = task.FindTag("Mixer_1_Runcondition");
                if (tag != null)
                {
                    datamqtt.Mixer_1_State = (bool)tag.Value;
                }
                tag = task.FindTag("Valve_3_1_Runcondition");
                if (tag != null)
                {
                    datamqtt.Valve_3_1_State = (bool)tag.Value;
                }
                tag = task.FindTag("Valve_3_2_Runcondition");
                if (tag != null)
                {
                    datamqtt.Valve_3_2_State = (bool)tag.Value;
                }
            }
            var settings = new JsonSerializerSettings { DateFormatString = "yyyy-MM-ddTHH:mm:ss.fffZ" };
            datamqtt.TimeStamp = JsonConvert.SerializeObject(DateTime.Now,settings);

            MQTT_Publish mqttPub = new MQTT_Publish();
            mqttPub.MQTT_PublishObject("103.82.22.121", 1883, "dongdeptrai", "scada", "username here", "password here", datamqtt);
        }
        
        private void bt_Data_Click(object sender, EventArgs e)
        {
            DataLoger dataloger = new DataLoger();
            dataloger.ShowDialog();
        }
    }
}
