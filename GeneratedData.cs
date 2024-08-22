using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LumenWorks.Framework.IO.Csv;
using Microsoft.VisualBasic.FileIO;

namespace IAProiect3
{
    public partial class GeneratedData : Form
    {

        public static List<SurveyData> dataList;
        public static List<SurveyData> allDataList;
        public static List<SurveyData> testList;

        public GeneratedData(List<SurveyData> input_list)
        {
            InitializeComponent();
            GenerateList();
            LoadData(input_list);
        }

        public static void GenerateList()
        {
            allDataList = new List<SurveyData>();
            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\TarcaSilviu\Desktop\IAProiect3\Data\SomervilleHappinessSurvey2015.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.ReadFields();
       
                while (!parser.EndOfData)
                {                    
                   string[] fields = parser.ReadFields();
                    allDataList.Add(new SurveyData(double.Parse(fields[1]), double.Parse(fields[2]), double.Parse(fields[3]), double.Parse(fields[4]), double.Parse(fields[5]), double.Parse(fields[6]), int.Parse(fields[0])));
                                        
                }
            }
            Random rand = new Random();
            var shuffled = allDataList.OrderBy(_ => rand.Next()).ToList();


            dataList = new List<SurveyData>();
            testList = new List<SurveyData>();
            for (int i = 0; i < 100; i++)
            {
                dataList.Add(new SurveyData(allDataList[i].q1, allDataList[i].q2, allDataList[i].q3, allDataList[i].q4, allDataList[i].q5, allDataList[i].q6, allDataList[i].result));
            }
            for (int i = 100; i < 142; i++)
            {
                testList.Add(new SurveyData(allDataList[i].q1, allDataList[i].q2, allDataList[i].q3, allDataList[i].q4, allDataList[i].q5, allDataList[i].q6, allDataList[i].result));
            }
        }

        private void LoadData(List<SurveyData> input_list)
        {
       
            trainingDataGridView.DataSource = input_list.ToList();
        }
    }
}
