using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellBeings
{
    public class ToughLoveCards
    {
        public List<ToughCard> CardDeck { get; set;}

        public ToughLoveCards()
        {
            this.CardDeck = new List<ToughCard>();
            CardDeck.Add(new ToughCard() { CardText = "“An acquaintance merely enjoys your company, a fair-weather companion flatters when all is well....\n" +
                                                 "\n....a true friend has your best interests at heart and the pluck to tell you what you need to hear." });
            CardDeck.Add(new ToughCard() { CardText = "If you truly loved someone you won't become their enemy. You will become their guardian angel."});
            CardDeck.Add(new ToughCard() { CardText = "Never pretend to be something you are not, especially to be accepted.\n" +
                                                 "Be loved for who you are, it will be tough at times but worth it."});
            CardDeck.Add(new ToughCard() { CardText = "When someone is hard on you it may have very little to do with you." });
            CardDeck.Add(new ToughCard() { CardText = "Tough love and brutal truth from strangers are far more valuable than Band-Aids and half-truths from invested friends....\n" +
                                                 "\nwho don’t want to see you suffer any more than you have." });
        }

        public class ToughCard
        {
            public string CardText { get; set;}
        }
    }
}
