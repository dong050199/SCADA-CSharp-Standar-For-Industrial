using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class TAG
    {
        public string Name;
        public string Address;
        public object Value;
        public DateTime TimeStamp;
        public TASK Parent;

        public TAG(string name, string add)
        {
            Name = name;
            Address = add;
        }
    }
}
