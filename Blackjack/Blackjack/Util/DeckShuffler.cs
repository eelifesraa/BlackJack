using Blackjack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Util
{
    public static class DeckShuffler
    {
        private static Random random = new Random();
        /*
         * Deste icerisindeki kartlar karistirilir.
         */
        public static void ShuffleDeck(List<Card> CardList)
        {
            int n = CardList.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card card = CardList[k];
                CardList[k] = CardList[n];
                CardList[n] = card;
            }
        }
    }
}
