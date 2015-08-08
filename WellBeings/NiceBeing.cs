using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WellBeings
{
    public class NiceBeing
    {
        public string Name { get; set; }
        public string OwnerName { get; set; }

        public NiceBeing()
        {
            Console.WriteLine(
                "Hey there, I'm a WellBeing, I'm here to help you. Please give me a name so that we can become more acquainted with one another.");
            this.Name = Console.ReadLine();
            Console.WriteLine("Cool man! My name is " + this.Name);
            Console.WriteLine("So what's your name champ?");
            this.OwnerName = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + this.OwnerName + "!" +
                              "\nHow are you feeling today? Winning? Losing? Inbetweening?");
        }

        public async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://uclassify.com/browse/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("uClassify/sentiment/ClassifyText?readkey=c1bpk3CCyKXE&output=json&version=1.01&text=tired");

                if (response.IsSuccessStatusCode)
                {
                    //Product product = await response.Content.ReadAsAsync > Product > ()
                    var resp = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(resp);
                }
            }
        }
    }

//       public string AnalyseInput(string input)
//       {
           
//       }
//    }

}
