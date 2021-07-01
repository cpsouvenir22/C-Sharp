using System.Collections.Generic;
using System;


namespace DeckOfCards.Models
{
    public class Player
    {
        public string Name;
        
        public List<Card> Hand;
        
        public Player (string name)
        {
            Name = name;
            Hand= new List<Card>();
        }

        public Card Draw(Deck cards)
        {
            Card c = cards.Deal();
            Hand.Add(c);
            return c;
        }

        public Card Discard (int idx)
        {
            Card c = Hand[idx];
            if (c==null)
            {
                Console.WriteLine("You have an empty hand, player!!");
                return null;
            }
                
            
            else
            {
                Hand.RemoveAt(idx);
                return c;
            }
                

            
        }

        public void ShowHand()
        {

            Console.WriteLine ($"{Name} has:");
            foreach (Card c in Hand)
            {
                c.Display();
                
            }
            Console.WriteLine("");

        }
    }
}