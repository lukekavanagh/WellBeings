using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellBeings
{
    public class ToughLoveBeing
    {
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public Card NewCardDeck { get; set; }

        public ToughLoveBeing()
        {
            this.NewCardDeck = new Card();
            Console.WriteLine("Hey there I'm Claudia, I'm known for my Tough Love./nTough Love may be hard to give, but it is a necessity of life and assurance of positive growth");

        }
    }
}
