using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellBeings
{
    public class ParagraphAnalysis
    {
        public string status { get; set; }
        public string usage { get; set; }
        public string totalTransactions { get; set; }
        public string language { get; set; }
        public string text { get; set; }
        public List<Keyword> keywords { get; set; }
    }

    public class Keyword
    {
        public string relevance { get; set; }
        public Sentiment sentiment { get; set; }
        public string text { get; set; }
    }

    public class Sentiment
    {
        public string score { get; set; }
        public string type { get; set; }
    }
}

