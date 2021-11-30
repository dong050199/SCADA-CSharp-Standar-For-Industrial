using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SymbolFactoryDotNet;
using Newtonsoft.Json;

namespace PLC_Config
{
    public partial class MOTOR_FACEPLATE : Form
    {

        int value;
        const int sampleSize = 800;
        private string now;
        private DateTime nowDataTime;
        string[] row;
        public bool FixedFault = true;
        public bool Running = true;

        private string[] TimeStamp = new string[sampleSize];
        private double[] dataSeriesA = new double[sampleSize];
        private double[] dataSeriesB = new double[sampleSize];
        private double[] dataSeriesC = new double[sampleSize];

        public MOTOR Parent;
        Chart_Config chart_config;
        public MOTOR_FACEPLATE(MOTOR parent)
        {
            Parent = parent;
            InitializeComponent();
            chart_config = new Chart_Config();

            chart_config.initChart(chart_Faceplate, TimeStamp, dataSeriesA, dataSeriesB, dataSeriesC, sampleSize, now);
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            lb_Name.Text = Parent.Name;
            if (Parent.Mode == 1)
            {
                lb_Mode.Text = "MAN";
            }
            if (Parent.Mode == 2)
            {
                lb_Mode.Text = "AUTO";
            }
            Console.WriteLine(Parent.RunFeedBack);
            if (Parent.RunFeedBack)
            {
                sb_Motor.DiscreteValue1 = true;
                sb_Motor.DiscreteValue2 = false;
            }
            else if (Parent.Fault)
            {
                sb_Motor.DiscreteValue1 = false;
                sb_Motor.DiscreteValue2 = true;
            }
            else
            {
                sb_Motor.DiscreteValue1 = false;
                sb_Motor.DiscreteValue2 = false;
            }
            chart_config.updateChart(chart_Faceplate, TimeStamp, dataSeriesA, dataSeriesB, dataSeriesC, sampleSize, now, Parent.RunFeedBack, Parent.Fault);
            UpdateAlarm(Parent.RunFeedBack, Parent.Fault);
        }

        public class MqttData
        {
            public string TimeStamp { get; set; }
            public string Name { get; set; }
            public string RunFeedBack { get; set; }
            public string Fault { get; set; }
            public string Mode { get; set; }
        }
        public void AlarmSendToDatabase(string[] stringArray)
        {
            string jsonstring = JsonConvert.SerializeObject(stringArray);
            jsonstring.Replace('[', '{');
            jsonstring.Replace(']', '}');
            

            
            mqttPub.MQTT_PublicJsonString("103.82.22.121", 1883, "dongdeptrai", "scada1", "username here", "password here", jsonstring);
        }
        MQTT_Publish mqttPub;
        public void UpdateAlarm(bool run,bool fault)
        {
            mqttPub = new MQTT_Publish();
            if (run)
            {
                if (!Running)
                {
                    now = JsonConvert.SerializeObject(DateTime.Now);
                    Running = true;
                    row = new string[] { $"{Parent.Name}", $"{Parent.RunFeedBack}", $"{!FixedFault}", $"{Parent.Mode}", now };
                    dataGridView1.Rows.Add(row);
                    MqttData data = new MqttData();
                    data.Name = Parent.Name;
                    data.RunFeedBack = Parent.RunFeedBack.ToString();
                    data.Fault = Parent.Fault.ToString();
                    data.TimeStamp = now;
                    data.Mode = Parent.Mode.ToString();
                    mqttPub.MQTT_PublishObject("103.82.22.121", 1883, "dongdeptrai", "scada1", "username here", "password here", data);
                }
            }
            else
            {
                if (!fault)
                {
                    if (Running)
                    {
                        now = JsonConvert.SerializeObject(DateTime.Now);
                        Running = false;
                        row = new string[] { $"{Parent.Name}", $"{Parent.RunFeedBack}", $"{!FixedFault}", $"{Parent.Mode}", now };
                        dataGridView1.Rows.Add(row);
                        MqttData data = new MqttData();
                        data.Name = Parent.Name;
                        data.RunFeedBack = Parent.RunFeedBack.ToString();
                        data.Fault = Parent.Fault.ToString();
                        data.TimeStamp = now;
                        data.Mode = Parent.Mode.ToString();
                        mqttPub.MQTT_PublishObject("103.82.22.121", 1883, "dongdeptrai", "scada1", "username here", "password here", data);
                    }
                }

                else
                {
                    if (FixedFault)
                    {
                        now = JsonConvert.SerializeObject(DateTime.Now);
                        FixedFault = false;
                        row = new string[] { $"{Parent.Name}", $"{Parent.RunFeedBack}", $"{!FixedFault}", $"{Parent.Mode}", now };
                        dataGridView1.Rows.Add(row);

                        MqttData data = new MqttData();
                        data.Name = Parent.Name;
                        data.RunFeedBack = Parent.RunFeedBack.ToString();
                        data.Fault = Parent.Fault.ToString();
                        data.TimeStamp = now;
                        data.Mode = Parent.Mode.ToString();
                        mqttPub.MQTT_PublishObject("103.82.22.121", 1883, "dongdeptrai", "scada1", "username here", "password here", data);
                    }
                }
            }


        }

        public void updateChart(bool run,bool fault)
        {
            chart_Faceplate.Series[0].Points.Clear();
            chart_Faceplate.Series[1].Points.Clear();
            chart_Faceplate.Series[2].Points.Clear();
            for (int i = 0; i < sampleSize - 1; i++)
            {
                dataSeriesA[i] = dataSeriesA[i + 1];
                dataSeriesB[i] = dataSeriesB[i + 1];
                dataSeriesC[i] = dataSeriesC[i + 1];
                TimeStamp[i] = TimeStamp[i + 1];
                chart_Faceplate.Series[0].Points.AddXY(TimeStamp[i], dataSeriesA[i]);
                chart_Faceplate.Series[1].Points.AddXY(TimeStamp[i], dataSeriesB[i]);
                chart_Faceplate.Series[2].Points.AddXY(TimeStamp[i], dataSeriesC[i]);
            }
            nowDataTime = DateTime.Now;
            now = nowDataTime.ToString("hh:mm:ss");
            TimeStamp[sampleSize - 1] = now;
            if (run)
            {
                if (!Running)
                {
                    Running = true;
                    row = new string[] { $"{Parent.Name}", $"{Parent.RunFeedBack}", $"{!FixedFault}", $"{Parent.Mode}", now };
                    dataGridView1.Rows.Add(row);
                }
                dataSeriesA[sampleSize - 1] = 0;
                dataSeriesB[sampleSize - 1] = 0;
                dataSeriesC[sampleSize - 1] = 1;
            }
            else
            {
                if (!fault)
                {
                    if (Running)
                    {
                        Running = false;
                        row = new string[] { $"{Parent.Name}", $"{Parent.RunFeedBack}", $"{!FixedFault}", $"{Parent.Mode}", now };
                        dataGridView1.Rows.Add(row);
                    }
                    dataSeriesA[sampleSize - 1] = 0;
                    dataSeriesB[sampleSize - 1] = 1;
                    dataSeriesC[sampleSize - 1] = 0;
                }
                else
                {
                    if (FixedFault)
                    {
                        FixedFault = false;
                        row = new string[] { $"{Parent.Name}", $"{Parent.RunFeedBack}", $"{!FixedFault}", $"{Parent.Mode}", now };
                        dataGridView1.Rows.Add(row);

                    }
                    dataSeriesA[sampleSize - 1] = 1;
                    dataSeriesB[sampleSize - 1] = 0;
                    dataSeriesC[sampleSize - 1] = 0;
                }
            }
            chart_Faceplate.Series[0].Points.AddXY(now, dataSeriesA[sampleSize - 1]);
            chart_Faceplate.Series[1].Points.AddXY(now, dataSeriesB[sampleSize - 1]);
            chart_Faceplate.Series[2].Points.AddXY(now, dataSeriesC[sampleSize - 1]);
        }

        private void MOTOR_FACEPLATE_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void cbb_SelectMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_SelectMode.SelectedItem.ToString() == "MAN")
            {
                Parent.Write_Device("Mode", 1);
            }
            if (cbb_SelectMode.SelectedItem.ToString() == "AUTO")
            {
                Parent.Write_Device("Mode", 2);
            }
        }

        private void bt_Start_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.Write_Device("Start", false);
        }

        private void bt_Start_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.Write_Device("Start", true);
        }

        private void bt_Stop_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.Write_Device("Stop", false);
        }

        private void bt_Stop_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.Write_Device("Stop", true);
        }

        private void bt_Reset_MouseUp(object sender, MouseEventArgs e)
        {
            Parent.Write_Device("Reset", false);
        }

        private void bt_Reset_MouseDown(object sender, MouseEventArgs e)
        {
            Parent.Write_Device("Stop", true);
        }

        private void bt_Export_Click(object sender, EventArgs e)
        {
            GridView_ExcelExport export = new GridView_ExcelExport(dataGridView1);
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_Control.Show();
            panel_Chart.Hide();
            panel_Alarm.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_Control.Hide();
            panel_Chart.Show();
            panel_Alarm.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_Control.Hide();
            panel_Chart.Hide();
            panel_Alarm.Show();
        }
    }
}
