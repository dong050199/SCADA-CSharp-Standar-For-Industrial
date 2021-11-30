using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;

namespace PLC_Config
{
    public class GridView_MongoDB
    {
        string ConnectionString;
        string Database;
        string Collection;
        DateTime StartTime;
        DateTime EndTime;
        
        public void GridView_MongoDB1(string connection_string, string database_name, string collection_name, DateTimePicker start_time, DateTimePicker end_time,DataGridView dataGridView)
        {
            ConnectionString = connection_string;
            Database = database_name;
            Collection = collection_name;
            StartTime = start_time.Value;
            EndTime = end_time.Value;
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(Database);
            var collection = database.GetCollection<Data_Logger>(Collection);
            BindingList<Data_Logger> doclist = new BindingList<Data_Logger>();
            var min = StartTime;
            var max = EndTime;
            foreach (var deger in collection.Find(x => x.TimeStamp > min && x.TimeStamp < max).ToList())
            {
                doclist.Add(deger);
                Application.DoEvents();
            }
            dataGridView.DataSource = doclist;
        }

        public class DataAlarm
        {
            public object Id { get; set; }
            public DateTime TimeStamp { get; set; }
            public string Name { get; set; }
            public string RunFeedBack { get; set; }
            public string Fault { get; set; }
            public string Mode { get; set; }
        }

        DataAlarm data = new DataAlarm();
        public void GridView_MongoDB2(string connection_string, string database_name, string collection_name, DateTimePicker start_time, DateTimePicker end_time, DataGridView dataGridView)
        {
            ConnectionString = connection_string;
            Database = database_name;
            Collection = collection_name;
            StartTime = start_time.Value;
            EndTime = end_time.Value;
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(Database);
            var collection = database.GetCollection<DataAlarm>(Collection);
            BindingList<DataAlarm> doclist = new BindingList<DataAlarm>();
            var min = StartTime;
            var max = EndTime;
            foreach (var deger in collection.Find(x => x.TimeStamp > min && x.TimeStamp < max).ToList())
            {
                doclist.Add(deger);
                Application.DoEvents();
            }
            dataGridView.DataSource = doclist;
        }
    }
}
