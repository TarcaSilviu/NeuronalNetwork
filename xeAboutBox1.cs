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
    public partial class xeAboutBox1 : Form
    {
        public static List<SurveyData> normlisedExecutionData;
        public xeAboutBox1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Graph.executionData[0].q1 = (double)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Graph.executionData[0].q2 = (double)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Graph.executionData[0].q3 = (double)numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Graph.executionData[0].q4 = (double)numericUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            Graph.executionData[0].q5 = (double)numericUpDown5.Value;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            Graph.executionData[0].q6 = (double)numericUpDown6.Value;
        }
        private void compute_result()
        {
            normlisedExecutionData = new List<SurveyData>();

            foreach (SurveyData x in Graph.executionData)
            {
                SurveyData temp = new SurveyData(0, 0, 0, 0, 0, 0, x.result);

                temp.q1 = (x.q1 - 1) / (5 - 1);
                temp.q2 = (x.q2 - 1) / (5 - 1);
                temp.q3 = (x.q3 - 1) / (5 - 1);
                temp.q4 = (x.q4 - 1) / (5 - 1);
                temp.q5 = (x.q5 - 1) / (5 - 1);
                temp.q6 = (x.q6 - 1) / (5 - 1);
                normlisedExecutionData.Add(temp);
            }

            Graph.compute(normlisedExecutionData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compute_result();
            resultTxtBox.Text=Graph.output_neurons_list[0].activation_output.ToString();
        }
    }
}
