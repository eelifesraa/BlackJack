using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public abstract class Gamer
    {
        public string Name { get; set; }
        public List<Card> CardList { get; set; }

        public Gamer(string Name)
        {
            this.Name = Name;
            this.CardList = new List<Card>();
        }
    }
}
