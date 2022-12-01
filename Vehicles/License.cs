using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class License
    {
        public int keyCode { get; set; }
        public DateTime ini_Date { get; set; }
        public DateTime exp_Date { get; set; }
        public Boolean status { get; set; }
        public char type { get; set; }


        public License()
        {
            this.keyCode = 0;
            this.ini_Date = DateTime.Today;
            this.exp_Date = DateTime.Today;
            this.status = true;
            this.type = ' ';
        }

    }
}
