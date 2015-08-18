using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WellBeings
{
    class Program
    {
        static void Main(string[] args)
        {
            ToughLoveBeing newBeing = new ToughLoveBeing();
            Console.WriteLine("Nice to meet you " + newBeing.OwnerName + "!\n" + "\nHow are you feeling today? Winning? Losing? Inbetweening?\n");
            //var feeling = Console.ReadLine(); 
            //var gaugeFeeling = newBeing.AnalyseInput(feeling);
            //gaugeFeeling.Wait();
            //Console.WriteLine(gaugeFeeling.Result);
            var paragraphTest = Console.ReadLine(); 
            var keywordList = newBeing.AnalyseParagraph(paragraphTest);
            keywordList.Wait();
            string words = "";
            for (int i = 0; i < keywordList.Result.Count; i++)
            {
                words = words + keywordList.Result[i] + ", ";
            }
            var keywordString = words.Trim(',', ' ');
            Console.WriteLine("Thanks for telling me about " + keywordString + ".\nHere is a card to increase the meaning of your existence.\n" );
            Thread.Sleep(3000);
            Console.WriteLine(newBeing.GetCard().CardText);
            Console.ReadLine();
        }
    }
}
