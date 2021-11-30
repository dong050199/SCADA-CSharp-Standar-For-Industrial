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

namespace TrainingSCADA
{
    public partial class DataLoger : Form
    {
        public DataLoger()
        {
            InitializeComponent();
        }
        string MongoDB_ConnectionString = "Connection string here";
        private void bt_Search_Click(object sender, EventArgs e)
        {
            GridView_MongoDB view = new GridView_MongoDB();
            view.GridView_MongoDB1(MongoDB_ConnectionString, "DongTest", "dong", dtpk_StartDate, dtpk_StopDate, dataGridView1);
        }

        private void bt_Excel_Click(object sender, EventArgs e)
        {
            GridView_ExcelExport export = new GridView_ExcelExport(dataGridView1);
        }

        private void bt_Alarm_Click(object sender, EventArgs e)
        {
            GridView_MongoDB view = new GridView_MongoDB();
            view.GridView_MongoDB2(MongoDB_ConnectionString, "DongTest", "dong01", dtpk_StartDate, dtpk_StopDate, dataGridView1);
        }
    }
}
