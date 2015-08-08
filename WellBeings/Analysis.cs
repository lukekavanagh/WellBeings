using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellBeings
{
    public class Emotion
    {
        public double negative { get; set; }
        public double positive { get; set; }
    }

    public class Analysis
    {
        public string version { get; set; }
        public bool success { get; set; }
        public int statusCode { get; set; }
        public string errorMessage { get; set; }
        public int textCoverage { get; set; }
        public Emotion cls1 { get; set; }
    }
}
