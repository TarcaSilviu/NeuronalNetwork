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
    public partial class FirstScreen : Form
    {
        public FirstScreen()
        {
            InitializeComponent();
            GeneratedData.GenerateList();
            NormalisedData.NormaliseData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneratedData generatedData = new GeneratedData(GeneratedData.dataList);
            generatedData.ShowDialog();
        }

        private void normalisedListBtn_Click(object sender, EventArgs e)
        {
            NormalisedData normalisedData = new NormalisedData(NormalisedData.normalisedData);
            normalisedData.ShowDialog();
        }

        private void graphBtn_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph();
            graph.ShowDialog();
        }

        private void testListBtn_Click(object sender, EventArgs e)
        {
            GeneratedData generatedData = new GeneratedData(GeneratedData.testList);
            generatedData.ShowDialog();
        }

        private void normalisedTestBtn_Click(object sender, EventArgs e)
        {
            NormalisedData normalisedData = new NormalisedData(NormalisedData.normalisedTestData);
            normalisedData.ShowDialog();
        }
    }
}
