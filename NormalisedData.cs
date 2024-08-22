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
    public partial class NormalisedData : Form
    {
        public static List<SurveyData> normalisedData;
        public static List<SurveyData> normalisedTestData;
        public NormalisedData(List<SurveyData> input_list)
        {
            InitializeComponent();
            LoadData(input_list);
        }
        public static void NormaliseData()
        {
            normalisedData = new List<SurveyData>();
            foreach (SurveyData x in GeneratedData.dataList)
            {
                SurveyData temp = new SurveyData(0,0,0,0,0,0,x.result);
                
                temp.q1 = (x.q1 - 1) / (5 - 1);
                temp.q2 = (x.q2 - 1) / (5 - 1);
                temp.q3 = (x.q3 - 1) / (5 - 1);
                temp.q4 = (x.q4 - 1) / (5 - 1);
                temp.q5 = (x.q5 - 1) / (5 - 1);
                temp.q6 = (x.q6 - 1) / (5 - 1);
                normalisedData.Add(temp);
            }

            normalisedTestData = new List<SurveyData>();
            foreach (SurveyData x in GeneratedData.testList)
            {
                SurveyData temp = new SurveyData(0, 0, 0, 0, 0, 0, x.result);

                temp.q1 = (x.q1 - 1) / (5 - 1);
                temp.q2 = (x.q2 - 1) / (5 - 1);
                temp.q3 = (x.q3 - 1) / (5 - 1);
                temp.q4 = (x.q4 - 1) / (5 - 1);
                temp.q5 = (x.q5 - 1) / (5 - 1);
                temp.q6 = (x.q6 - 1) / (5 - 1);
                normalisedTestData.Add(temp);
            }
        }
        public void LoadData(List<SurveyData> input_list)
        {
            normalisedDataGridView.DataSource = input_list.ToList();
        }
    }
}
