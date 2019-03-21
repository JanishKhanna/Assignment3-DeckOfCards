using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Game
    {
        public MyCards MyCards { get; set; } = new MyCards();
        public static List<Card> Cards { get; set; } = new List<Card>();

        public void Start()
        {            
            Menu();
            Console.ReadLine();
        }


        private void Menu()
        {
            Console.WriteLine("1. Shuffle Cards");
            Console.WriteLine("2. Deal one card");
            Console.WriteLine("3. Deal all card");
            
            var Input = Console.ReadLine();

            if (Input == "1")
            {
                MyCards.ShuffleCards();
            }
            if (Input == "2")
            {
                MyCards.DealOneCard();
            }
            if (Input == "3")
            {
                if (Cards.Any())
                {
                    Cards.Clear();
                    Console.WriteLine(Cards.Count + " are Left");
                }
                else
                {
                    Console.WriteLine("There are no cards to deal.");
                }

            }
            
            Menu();
            Console.ReadLine();
        }
    }
}
