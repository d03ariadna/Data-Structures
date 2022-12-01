using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Vehicles
    {
        public char type { get; set; }
        public string year { get; set; }
        public string brand { get; set; }
        public string description { get; set; }
        public string wheels { get; set; }
        public string color { get; set; }

        public Vehicles()
         {
            type = ' ';
            year = " ";
            brand = "";
            description = "";
            wheels = "";
            color = "";



        }
    }

    
}
