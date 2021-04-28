using Blackjack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Util
{
    public static class DeckCreator
    {
        public static Deck CreateDecks()
        {
            Deck Deck = new Deck();
            List<Card> CardList = new List<Card>();
            int deckCount = 6;  // deste sayisi 

            /*
             * Yeni deste olusturulur.
             */

            for (int i = 0; i < deckCount; i++)
            {
                CardList.AddRange(new List<Card>()
                {
                new Card() { Value  = 2, Name = "Two Spades", Hidden=false},
                new Card() { Value = 3, Name = "Three Spades", Hidden=false},
                new Card() { Value = 4, Name =  "Four Spades", Hidden=false},
                new Card() { Value = 5, Name = "Five Spades", Hidden=false},
                new Card() { Value = 6, Name = "Six Spades", Hidden=false},
                new Card() { Value = 7, Name = "Seven Spades", Hidden=false},
                new Card() { Value = 8, Name = "Eight Spades", Hidden=false},
                new Card() { Value = 9, Name = "Nine Spades", Hidden=false},
                new Card() { Value = 10, Name = "Ten Spades", Hidden=false},
                new Card() { Value = 10, Name = "Jack Spades", Hidden=false},
                new Card() { Value = 10, Name = "Queen Spades", Hidden=false},
                new Card() { Value = 10, Name = "King Spades", Hidden=false},
                new Card() { Value = 11, Name = "Ace Spades", Hidden=false},

                new Card() { Value  = 2, Name = "Two Diamonds", Hidden=false},
                new Card() { Value = 3, Name = "Three Diamonds", Hidden=false},
                new Card() { Value = 4, Name =  "Four Diamonds", Hidden=false},
                new Card() { Value = 5, Name = "Five Diamonds", Hidden=false},
                new Card() { Value = 6, Name = "Six Diamonds", Hidden=false},
                new Card() { Value = 7, Name = "Seven Diamonds", Hidden=false},
                new Card() { Value = 8, Name = "Eight Diamonds", Hidden=false},
                new Card() { Value = 9, Name = "Nine Diamonds", Hidden=false},
                new Card() { Value = 10, Name = "Ten Diamonds", Hidden=false},
                new Card() { Value = 10, Name = "Jack Diamonds", Hidden=false},
                new Card() { Value = 10, Name = "Queen Diamonds", Hidden=false},
                new Card() { Value = 10, Name = "King Diamonds", Hidden=false},
                new Card() { Value = 11, Name = "Ace Diamonds", Hidden=false},

                new Card() { Value  = 2, Name = "Two Clubs", Hidden=false},
                new Card() { Value = 3, Name = "Three Clubs", Hidden=false},
                new Card() { Value = 4, Name =  "Four Clubs", Hidden=false},
                new Card() { Value = 5, Name = "Five Clubs", Hidden=false},
                new Card() { Value = 6, Name = "Six Clubs", Hidden=false},
                new Card() { Value = 7, Name = "Seven Clubs", Hidden=false},
                new Card() { Value = 8, Name = "Eight Clubs", Hidden=false},
                new Card() { Value = 9, Name = "Nine Clubs", Hidden=false},
                new Card() { Value = 10, Name = "Ten Clubs", Hidden=false},
                new Card() { Value = 10, Name = "Jack Clubs", Hidden=false},
                new Card() { Value = 10, Name = "Queen Clubs", Hidden=false},
                new Card() { Value = 10, Name = "King Clubs", Hidden=false},
                new Card() { Value = 11, Name = "Ace Clubs", Hidden=false},

                new Card() { Value  = 2, Name = "Two Hearts", Hidden=false},
                new Card() { Value = 3, Name = "Three Hearts", Hidden=false},
                new Card() { Value = 4, Name =  "Four Hearts", Hidden=false},
                new Card() { Value = 5, Name = "Five Hearts", Hidden=false},
                new Card() { Value = 6, Name = "Six Hearts", Hidden=false},
                new Card() { Value = 7, Name = "Seven Hearts", Hidden=false},
                new Card() { Value = 8, Name = "Eight Hearts", Hidden=false},
                new Card() { Value = 9, Name = "Nine Hearts", Hidden=false},
                new Card() { Value = 10, Name = "Ten Hearts", Hidden=false},
                new Card() { Value = 10, Name = "Jack Hearts", Hidden=false},
                new Card() { Value = 10, Name = "Queen Hearts", Hidden=false},
                new Card() { Value = 10, Name = "King Hearts", Hidden=false},
                new Card() { Value = 11, Name = "Ace Hearts", Hidden=false}
                });
                DeckShuffler.ShuffleDeck(CardList);
                Deck.CardStack = new Stack<Card>(CardList);
            }
            return Deck;
        }
    }
}
