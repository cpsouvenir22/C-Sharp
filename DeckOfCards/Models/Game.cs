using System.Collections.Generic;

namespace DeckOfCards.Models
{
    public static class Game
    {
        public static List<Player> RoundOne(Deck cards, List<Player> players, int numOfCards)
        {
            foreach(Player p in players)
            {
                for (int i=1; i<=numOfCards; i++)
                {
                    p.Hand.Add(cards.Deal());
                }
                p.ShowHand();
            }
            return players;
        }
    }
}