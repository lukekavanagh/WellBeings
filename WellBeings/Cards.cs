using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WellBeings
{
    class Cards
    {
        public List<Card> CardDeck { get; set; }
        public Cards()
        {
            
        }
    }

    public class Card
    {
        public string CardText { get; set; }
    }
}
