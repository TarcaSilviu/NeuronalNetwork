using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAProiect3
{
    public class Input
    {
        public static int n = 1;
        public double x { get; set; }
        public double w { get; set; }
        public Input(double x, double w)
        {
            n += 1;
            this.x = x;
            this.w = w;
        }
    }
}
