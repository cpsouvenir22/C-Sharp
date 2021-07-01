using System;

namespace DeckOfCards.Models
{
    public class Card
    {
        public string StringVal;

        public int Val;

        public string Suit;

        
        public Card(string suit, int val)
        {
            Suit= suit;
            Val= val;

            switch(val)
            {
                case 1:
                StringVal= "Ace";
                break;

                case 11:
                StringVal = "Jack";
                break;

                case 12:
                StringVal= "Queen";
                break;

                case 13:
                StringVal= "King";
                break;

                default:
                    StringVal = val.ToString();
                    break;
            }
        } 
        public void Display()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            if(Suit == "Spades" || Suit == "Clubs")
                Console.ForegroundColor = ConsoleColor.Black;
            else
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine ($"\t\t\t\t ***** \t {StringVal} of {Suit}: {Val} ***** \t\t\t\t");
            Console.ResetColor();
        }
    
    }

}