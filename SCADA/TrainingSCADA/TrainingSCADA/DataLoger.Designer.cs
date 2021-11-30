
namespace TrainingSCADA
{
    partial class DataLoger
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpk_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpk_StopDate = new System.Windows.Forms.DateTimePicker();
            this.bt_Search = new System.Windows.Forms.Button();
            this.bt_Alarm = new System.Windows.Forms.Button();
            this.bt_Excel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(829, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // dtpk_StartDate
            // 
            this.dtpk_StartDate.Location = new System.Drawing.Point(641, 12);
            this.dtpk_StartDate.Name = "dtpk_StartDate";
            this.dtpk_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpk_StartDate.TabIndex = 1;
            // 
            // dtpk_StopDate
            // 
            this.dtpk_StopDate.Location = new System.Drawing.Point(641, 38);
            this.dtpk_StopDate.Name = "dtpk_StopDate";
            this.dtpk_StopDate.Size = new System.Drawing.Size(200, 20);
            this.dtpk_StopDate.TabIndex = 2;
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(523, 12);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(112, 46);
            this.bt_Search.TabIndex = 3;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_Alarm
            // 
            this.bt_Alarm.Location = new System.Drawing.Point(287, 12);
            this.bt_Alarm.Name = "bt_Alarm";
            this.bt_Alarm.Size = new System.Drawing.Size(112, 46);
            this.bt_Alarm.TabIndex = 4;
            this.bt_Alarm.Text = "Alarm History";
            this.bt_Alarm.UseVisualStyleBackColor = true;
            this.bt_Alarm.Click += new System.EventHandler(this.bt_Alarm_Click);
            // 
            // bt_Excel
            // 
            this.bt_Excel.Location = new System.Drawing.Point(405, 12);
            this.bt_Excel.Name = "bt_Excel";
            this.bt_Excel.Size = new System.Drawing.Size(112, 46);
            this.bt_Excel.TabIndex = 5;
            this.bt_Excel.Text = "Export Excel";
            this.bt_Excel.UseVisualStyleBackColor = true;
            this.bt_Excel.Click += new System.EventHandler(this.bt_Excel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Loger";
            // 
            // DataLoger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Excel);
            this.Controls.Add(this.bt_Alarm);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.dtpk_StopDate);
            this.Controls.Add(this.dtpk_StartDate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DataLoger";
            this.Text = "DataLoger";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpk_StartDate;
        private System.Windows.Forms.DateTimePicker dtpk_StopDate;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Button bt_Alarm;
        private System.Windows.Forms.Button bt_Excel;
        private System.Windows.Forms.Label label1;
    }
}