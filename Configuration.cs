using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAProiect3
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }

        private void hiddenLayersNU_ValueChanged(object sender, EventArgs e)
        {
            switch (hiddenLayersNU.Value)
            {
                case 1:
                    hiddenLayer1NeuronsNU.Enabled = true;
                    hiddenLayer2NeuronsNU.Enabled = false;
                    hiddenLayer3NeuronsNU.Enabled = false;

                    Graph.HiddenLayers = 1;
                    break;
                case 2:
                    hiddenLayer1NeuronsNU.Enabled = true;
                    hiddenLayer2NeuronsNU.Enabled = true;
                    hiddenLayer3NeuronsNU.Enabled = false;

                    Graph.HiddenLayers = 2;
                    break;
                case 3:
                    hiddenLayer1NeuronsNU.Enabled = true;
                    hiddenLayer2NeuronsNU.Enabled = true;
                    hiddenLayer3NeuronsNU.Enabled = true;

                    Graph.HiddenLayers = 3;
                    break;
            }
        }

        private void hiddenLayer1NeuronsNU_ValueChanged(object sender, EventArgs e)
        {
            Graph.HiddenLayer1 = (int)hiddenLayer1NeuronsNU.Value;
        }

        private void hiddenLayer2NeuronsNU_ValueChanged(object sender, EventArgs e)
        {
            Graph.HiddenLayer2 = (int)hiddenLayer2NeuronsNU.Value;
        }

        private void hiddenLayer3NeuronsNU_ValueChanged(object sender, EventArgs e)
        {
            Graph.HiddenLayer3 = (int)hiddenLayer3NeuronsNU.Value;
        }

        private void learningRateNU_ValueChanged(object sender, EventArgs e)
        {
            Graph.learning_rate = (double)learningRateNU.Value;
        }

        private void epsilonNU_ValueChanged(object sender, EventArgs e)
        {
            Graph.desired_error = (double)epsilonNU.Value;
        }
    }
}
