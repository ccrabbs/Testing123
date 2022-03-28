using System;
using System.Collections.Generic;
using System.Linq;

namespace Testing123
{
    internal class Deck
    {
        // Program.cs
        // The Main() method

        List<Card> Cards = new();


        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
        internal Deck()
        {
            var startingDeck = from s in Suits()
                               from r in Ranks()
                               select new { Suit = s, Rank = r };

            // Display each card that we've generated and placed in startingDeck in the console
            foreach (var card in startingDeck)
            {
                Card newCard = new (card.Rank, card.Suit);
                Cards.Add(newCard);
            }
        }
        internal void DisplayDeck()
        {
            foreach(var card in Cards)
                Console.WriteLine("{0}, {1}",card.Rank, card.Suit);
        }
    }
}
