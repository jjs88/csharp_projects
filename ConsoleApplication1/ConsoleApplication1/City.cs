using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class City
    {
        public string name { get; set; }
        public double distance { get; set; }

        public City (string name, double distance)
        {
            this.name = name;
            this.distance = distance;
        }
    }
}
