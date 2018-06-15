using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    class Program
    {
        public class Card { }

        public class Deck
        {
            public ICollection<Card> Cards { get; private set; }

            public Card this[int index]
            {
                get { return Cards.ElementAt(index); }
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
