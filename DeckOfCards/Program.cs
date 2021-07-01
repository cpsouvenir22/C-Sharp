using System;
using DeckOfCards.Models;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deck Of Cards");
            Deck Bicycle = new Deck ();
            Bicycle.Shuffle();
            List<Player> Players = new List<Player>()
            {
                new Player("Chris"),
                new Player("Mike")
            };

            Game.RoundOne(Bicycle, Players, 5);
        }
    }
}
