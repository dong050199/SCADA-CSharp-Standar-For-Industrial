using System;
using System.Collections.Generic;
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
    public class GridView_ExcelExport
    {
        public DataGridView dataTable;
        public GridView_ExcelExport(DataGridView table)
        {
            dataTable = table;

            if (dataTable.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass XcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataTable.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dataTable.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        if (dataTable.Rows[i].Cells[j].Value != null)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dataTable.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }
    }
}
