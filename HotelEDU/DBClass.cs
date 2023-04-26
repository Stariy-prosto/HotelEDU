using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelEDU
{
    internal class DBClass
    {
        private string ConnectionString { get; set; }

        public DBClass(string ConnectionString) 
        {
            this.ConnectionString = ConnectionString;
        }
    }
}
