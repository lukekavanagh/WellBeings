using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellBeings
{
    public class Cards
    {
        public List<Card> CardDeck { get; set; }
       
        public Cards()
        {
            this.CardDeck=  new List<Card>();
            CardDeck.Add(new Card(){CardText = "Express your honest feelings to your best friend" });
            CardDeck.Add(new Card(){CardText = "Not building a wall but making a brick"});
            CardDeck.Add(new Card(){CardText = "Discover the recipes you are using and abandon them"});
            CardDeck.Add(new Card(){CardText = "How would someone you admire approach the situation?"});
            CardDeck.Add(new Card(){CardText = "Once the search is in progress something will be found"});
        }
    }

    public class Card
    {
        public string CardText { get; set; }
    }
}
