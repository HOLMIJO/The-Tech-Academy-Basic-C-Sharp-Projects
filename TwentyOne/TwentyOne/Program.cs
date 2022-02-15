using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Becca", "Joe", "Brandon" };
            //game.ListPlayers();
            //Console.ReadLine();

            List<string> players = new List<string>() { "Becca", "Joe", "Brandon" };
            foreach (string player in players)
            {
                Console.WriteLine(player);
                Console.ReadLine();
            }

            //Deck Deck = new Deck();
            //Deck.Shuffle(3);

            //foreach (Card card in Deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}

            //Console.WriteLine(Deck.Cards.Count);
            //Console.ReadLine();
        }
    }
}
