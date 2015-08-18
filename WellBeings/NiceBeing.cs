using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WellBeings
{
    public class NiceBeing
    {
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public NiceCards NewCardDeck { get; set; }

        public NiceBeing()
        {
            this.NewCardDeck = new NiceCards();
            Console.WriteLine(
                "Hey there, I'm a WellBeing, I'm here to help you.\n\nPlease give me a name so that we can become more acquainted with one another.");
            this.Name = Console.ReadLine();
            Console.WriteLine("\nCool man! My name is " + this.Name);
            Console.WriteLine("\nSo what's your name champ?\n");
            this.OwnerName = Console.ReadLine();
            
        }

        public async Task<string> AnalyseInput(string text)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://uclassify.com/browse/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("uClassify/sentiment/ClassifyText?readkey=c1bpk3CCyKXE&output=json&version=1.01&text=" + text);

                if (response.IsSuccessStatusCode)
                {
                    //Product product = await response.Content.ReadAsAsync > Product > ()
                    Analysis analysis = await response.Content.ReadAsAsync<Analysis>();
                    //var jsonString = await response.Content.ReadAsStringAsync();
                    //var analysis = JsonConvert.DeserializeObject<Analysis>(jsonString);
                    if (analysis.cls1.positive > analysis.cls1.negative)
                    {
                        return "positive";
                    }
                    return "negative";
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }


        public async Task<List<string>> AnalyseParagraph(string paragraph)
        {
            List<string> keywords = new List<string>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://access.alchemyapi.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response =
                    await client.GetAsync("calls/text/TextGetRankedKeywords?apikey=16448f817093a00b3ad66467f27687f625af7c88&outputMode=json&text='" + paragraph + "'");

                if (response.IsSuccessStatusCode)
                {
                    ParagraphAnalysis paragraphAnalysis = await response.Content.ReadAsAsync<ParagraphAnalysis>();
                    for (int i = 0; i < paragraphAnalysis.keywords.Count; i++)
                    {
                        //Console.WriteLine(paragraphAnalysis.keywords[i].text);
                        keywords.Add(paragraphAnalysis.keywords[i].text);
                    }
                    return keywords;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        public Card GetCard()
        {
            Random random = new Random();
            var randomCard = this.NewCardDeck.CardDeck[random.Next(0,5)];
            return randomCard;
        }


    }
}
