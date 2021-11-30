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

namespace PLC_Config
{
    public class Chart_Config
    {
        public void initChart(Chart chart, string[] timestamp, double[] dataseriesA, double[] dataseriesB, double[] dataseriesC, int sample, string now)
        {
            chart.Series[0].BorderWidth = 4;
            chart.Series[1].BorderWidth = 4;
            chart.Series[2].BorderWidth = 4;
            chart.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;
            chart.ChartAreas[0].AxisY.Maximum = 1;
            chart.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 8, FontStyle.Bold);
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            chart.Series[0].Color = System.Drawing.Color.Yellow;
            chart.Series[1].Color = System.Drawing.Color.Red;
            chart.Series[2].Color = System.Drawing.Color.Green;
            for (int i = 0; i < sample; i++)
            {
                dataseriesA[i] = 0;
                dataseriesB[i] = 0;
                dataseriesC[i] = 0;
                DateTime nowDataTime = DateTime.Now;
                now = nowDataTime.ToString("HH:mm:ss");
                timestamp[i] = now;
            }
        }
        public void updateChart(Chart chart, string[] timestamp, double[] dataseriesA, double[] dataseriesB, double[] dataseriesC, int sample, string now,bool run,bool fault)
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            chart.Series[2].Points.Clear();
            for (int i = 0; i < sample - 1; i++)
            {
                dataseriesA[i] = dataseriesA[i + 1];
                dataseriesB[i] = dataseriesB[i + 1];
                dataseriesC[i] = dataseriesC[i + 1];
                timestamp[i] = timestamp[i + 1];
                chart.Series[0].Points.AddXY(timestamp[i], dataseriesA[i]);
                chart.Series[1].Points.AddXY(timestamp[i], dataseriesB[i]);
                chart.Series[2].Points.AddXY(timestamp[i], dataseriesC[i]);
            }
            DateTime nowDataTime = DateTime.Now;
            now = nowDataTime.ToString("hh:mm:ss");
            timestamp[sample - 1] = now;
            if (run)
            {
                dataseriesA[sample - 1] = 0;
                dataseriesB[sample - 1] = 0;
                dataseriesC[sample - 1] = 1;
            }
            else
            {
                if (!fault)
                {
                    dataseriesA[sample - 1] = 0;
                    dataseriesB[sample - 1] = 1;
                    dataseriesC[sample - 1] = 0;
                }
                else
                {
                    dataseriesA[sample - 1] = 1;
                    dataseriesB[sample - 1] = 0;
                    dataseriesC[sample - 1] = 0;
                }
            }
            chart.Series[0].Points.AddXY(now, dataseriesA[sample - 1]);
            chart.Series[1].Points.AddXY(now, dataseriesB[sample - 1]);
            chart.Series[2].Points.AddXY(now, dataseriesC[sample - 1]);
        }

    }
}
