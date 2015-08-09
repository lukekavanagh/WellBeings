using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellBeings
{
    class Program
    {
        static void Main(string[] args)
        {
            NiceBeing newBeing = new NiceBeing();
            Console.WriteLine("Nice to meet you " + newBeing.OwnerName + "!" + "\nHow are you feeling today? Winning? Losing? Inbetweening?");
            //var feeling = Console.ReadLine(); 
            //var gaugeFeeling = newBeing.AnalyseInput(feeling);
            //gaugeFeeling.Wait();
            //Console.WriteLine(gaugeFeeling.Result);
            var paragraphTest = Console.ReadLine(); 
            var keywords = newBeing.AnalyseParagraph(paragraphTest);
            keywords.Wait();
            Console.WriteLine(keywords.Result);
            Console.ReadLine();
        }
    }
}
