using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class Vertex
    {
        public string item { get; set; }
        public int reff { get; set; }

        public Dictionary<Vertex, int> links = new Dictionary<Vertex, int>();


    }
}
