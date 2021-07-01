using System.Collections.Generic;
using System;

namespace DeckOfCards.Models
{
    public class Deck
    {
        static string [] suits = {"Spades", "Hearts", "Clubs", "Diamonds"};
        List<Card> Cards = new List<Card>();

        public Deck()
        {
            Reset();
        }
        public void Reset()
        {
            Cards.Clear();
            foreach(string s in suits)
            {
                for(int i =1; i<= 13; i++)
                {
                    Cards.Add(new Card(s,i));

                }
            }
                
            }

        public void Shuffle()
        {
            for(int i = 0; i< Cards.Count; i++)
            {
                Random rand = new Random ();

                int randIdx = rand.Next(Cards.Count);
                Card temp= Cards [i];
                Cards [i]= Cards[randIdx];
                Cards[randIdx]= temp;
            }
        }

        public void ShowCards()
        {
            foreach (Card c in Cards)
            {
                c.Display();
                
            }
            Console.WriteLine("");

        }

        public Card Deal()
        {
            Card c = Cards[0];
            Cards.RemoveAt(0);
            return c;
        }
    }

    }
