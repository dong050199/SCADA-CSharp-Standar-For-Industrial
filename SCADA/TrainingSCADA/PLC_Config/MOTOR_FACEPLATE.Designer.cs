
namespace PLC_Config
{
    partial class MOTOR_FACEPLATE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MOTOR_FACEPLATE));
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.lb_Mode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.bt_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_SelectMode = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.panel_Chart = new System.Windows.Forms.Panel();
            this.chart_Faceplate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_Alarm = new System.Windows.Forms.Panel();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Export = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Run = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sb_Motor = new SymbolFactoryDotNet.StandardControl();
            this.panel_Control.SuspendLayout();
            this.panel_Chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Faceplate)).BeginInit();
            this.panel_Alarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Motor)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 250;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // lb_Mode
            // 
            this.lb_Mode.AutoSize = true;
            this.lb_Mode.Location = new System.Drawing.Point(101, 40);
            this.lb_Mode.Name = "lb_Mode";
            this.lb_Mode.Size = new System.Drawing.Size(35, 13);
            this.lb_Mode.TabIndex = 37;
            this.lb_Mode.Text = "####";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Current Mode";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(235, 162);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(35, 13);
            this.lb_Name.TabIndex = 35;
            this.lb_Name.Text = "####";
            // 
            // bt_Reset
            // 
            this.bt_Reset.Location = new System.Drawing.Point(5, 151);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(163, 35);
            this.bt_Reset.TabIndex = 34;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_Reset_MouseDown);
            this.bt_Reset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_Reset_MouseUp);
            // 
            // bt_Stop
            // 
            this.bt_Stop.Location = new System.Drawing.Point(5, 110);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(163, 35);
            this.bt_Stop.TabIndex = 33;
            this.bt_Stop.Text = "Stop";
            this.bt_Stop.UseVisualStyleBackColor = true;
            this.bt_Stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_Stop_MouseDown);
            this.bt_Stop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_Stop_MouseUp);
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(5, 69);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(163, 35);
            this.bt_Start.TabIndex = 32;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_Start_MouseDown);
            this.bt_Start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_Start_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select Mode";
            // 
            // cbb_SelectMode
            // 
            this.cbb_SelectMode.FormattingEnabled = true;
            this.cbb_SelectMode.Items.AddRange(new object[] {
            "AUTO",
            "MAN"});
            this.cbb_SelectMode.Location = new System.Drawing.Point(99, 3);
            this.cbb_SelectMode.Name = "cbb_SelectMode";
            this.cbb_SelectMode.Size = new System.Drawing.Size(176, 21);
            this.cbb_SelectMode.TabIndex = 30;
            this.cbb_SelectMode.SelectedIndexChanged += new System.EventHandler(this.cbb_SelectMode_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 35);
            this.button3.TabIndex = 29;
            this.button3.Text = "Alarm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 28;
            this.button2.Text = "Chart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "Control";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_Control
            // 
            this.panel_Control.Controls.Add(this.sb_Motor);
            this.panel_Control.Controls.Add(this.cbb_SelectMode);
            this.panel_Control.Controls.Add(this.label1);
            this.panel_Control.Controls.Add(this.lb_Mode);
            this.panel_Control.Controls.Add(this.bt_Start);
            this.panel_Control.Controls.Add(this.label3);
            this.panel_Control.Controls.Add(this.bt_Stop);
            this.panel_Control.Controls.Add(this.lb_Name);
            this.panel_Control.Controls.Add(this.bt_Reset);
            this.panel_Control.Location = new System.Drawing.Point(2, 42);
            this.panel_Control.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(330, 190);
            this.panel_Control.TabIndex = 39;
            // 
            // panel_Chart
            // 
            this.panel_Chart.Controls.Add(this.chart_Faceplate);
            this.panel_Chart.Location = new System.Drawing.Point(7, 38);
            this.panel_Chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Chart.Name = "panel_Chart";
            this.panel_Chart.Size = new System.Drawing.Size(330, 190);
            this.panel_Chart.TabIndex = 40;
            // 
            // chart_Faceplate
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Faceplate.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Faceplate.Legends.Add(legend1);
            this.chart_Faceplate.Location = new System.Drawing.Point(2, 2);
            this.chart_Faceplate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart_Faceplate.Name = "chart_Faceplate";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series1.Legend = "Legend1";
            series1.Name = "FAULT";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series2.Legend = "Legend1";
            series2.Name = "STOP";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
            series3.Legend = "Legend1";
            series3.Name = "START";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chart_Faceplate.Series.Add(series1);
            this.chart_Faceplate.Series.Add(series2);
            this.chart_Faceplate.Series.Add(series3);
            this.chart_Faceplate.Size = new System.Drawing.Size(326, 188);
            this.chart_Faceplate.TabIndex = 0;
            this.chart_Faceplate.Text = "chart1";
            // 
            // panel_Alarm
            // 
            this.panel_Alarm.Controls.Add(this.bt_Delete);
            this.panel_Alarm.Controls.Add(this.bt_Export);
            this.panel_Alarm.Controls.Add(this.dataGridView1);
            this.panel_Alarm.Location = new System.Drawing.Point(4, 40);
            this.panel_Alarm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Alarm.Name = "panel_Alarm";
            this.panel_Alarm.Size = new System.Drawing.Size(330, 190);
            this.panel_Alarm.TabIndex = 41;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(165, 157);
            this.bt_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(163, 31);
            this.bt_Delete.TabIndex = 2;
            this.bt_Delete.Text = "Delete";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Export
            // 
            this.bt_Export.Location = new System.Drawing.Point(2, 157);
            this.bt_Export.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Export.Name = "bt_Export";
            this.bt_Export.Size = new System.Drawing.Size(159, 31);
            this.bt_Export.TabIndex = 1;
            this.bt_Export.Text = "Export";
            this.bt_Export.UseVisualStyleBackColor = true;
            this.bt_Export.Click += new System.EventHandler(this.bt_Export_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Device,
            this.Run,
            this.Fault,
            this.Mode,
            this.Time});
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(326, 151);
            this.dataGridView1.TabIndex = 0;
            // 
            // Device
            // 
            this.Device.HeaderText = "Device";
            this.Device.MinimumWidth = 7;
            this.Device.Name = "Device";
            this.Device.Width = 60;
            // 
            // Run
            // 
            this.Run.HeaderText = "Running";
            this.Run.MinimumWidth = 8;
            this.Run.Name = "Run";
            this.Run.Width = 60;
            // 
            // Fault
            // 
            this.Fault.HeaderText = "Fault";
            this.Fault.MinimumWidth = 7;
            this.Fault.Name = "Fault";
            this.Fault.Width = 60;
            // 
            // Mode
            // 
            this.Mode.HeaderText = "Mode";
            this.Mode.MinimumWidth = 7;
            this.Mode.Name = "Mode";
            this.Mode.Width = 60;
            // 
            // Time
            // 
            this.Time.HeaderText = "TimeStamp";
            this.Time.MinimumWidth = 7;
            this.Time.Name = "Time";
            this.Time.Width = 80;
            // 
            // sb_Motor
            // 
            this.sb_Motor.AnalogIntValue1 = ((short)(0));
            this.sb_Motor.AnalogValue1 = 0D;
            this.sb_Motor.AnimationMode = SymbolFactoryNetEngine.AnimationModeOptions.DiscreteColorFill;
            this.sb_Motor.BackStyle = SymbolFactoryNetEngine.BackStyleOptions.Transparent;
            this.sb_Motor.BandsCollection.Add(new SymbolFactoryNetEngine.Band(0D, 0, false, SymbolFactoryNetEngine.BandStyleOptions.Shaded, System.Drawing.Color.Lime, "Band1"));
            this.sb_Motor.BlinkColor = System.Drawing.Color.Red;
            this.sb_Motor.Category = "1PMP.cat2";
            this.sb_Motor.DebugData = new SymbolFactoryDotNet.DebugClass(resources.GetString("sb_Motor.DebugData"));
            this.sb_Motor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sb_Motor.Location = new System.Drawing.Point(210, 56);
            this.sb_Motor.Name = "sb_Motor";
            this.sb_Motor.Size = new System.Drawing.Size(87, 95);
            this.sb_Motor.SymbolHandle = ((long)(26978524));
            this.sb_Motor.TabIndex = 38;
            // 
            // MOTOR_FACEPLATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 235);
            this.Controls.Add(this.panel_Control);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_Chart);
            this.Controls.Add(this.panel_Alarm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MOTOR_FACEPLATE";
            this.Text = "MOTOR_FACEPLATE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MOTOR_FACEPLATE_FormClosing);
            this.panel_Control.ResumeLayout(false);
            this.panel_Control.PerformLayout();
            this.panel_Chart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Faceplate)).EndInit();
            this.panel_Alarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Motor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label lb_Mode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_SelectMode;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel panel_Chart;
        private System.Windows.Forms.Panel panel_Alarm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Faceplate;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Export;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Run;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fault;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private SymbolFactoryDotNet.StandardControl sb_Motor;
    }
}