using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAProiect3
{
    public class Layer
    {
        public List<Neuron> hidden_layer;

        public Layer()
        {
            hidden_layer = new List<Neuron>();
        }
    }
}
