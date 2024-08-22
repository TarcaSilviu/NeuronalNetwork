using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAProiect3
{
    public class SurveyData
    {
        public double q1 { get; set; }
        public double q2 { get; set; }
        public double q3 { get; set; }
        public double q4 { get; set; }
        public double q5 { get; set; }
        public double q6 { get; set; }
        public int result { get; set; }

        public SurveyData(double q1, double q2, double q3, double q4, double q5, double q6, int result)
        {
            this.q1 = q1;
            this.q2 = q2;
            this.q3 = q3;
            this.q4 = q4;
            this.q5 = q5;
            this.q6 = q6;
            this.result = result;
        }
    }
}
