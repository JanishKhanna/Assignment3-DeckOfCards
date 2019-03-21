using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class MyCards
    {
        public MyCards()
        {
            Cards = new List<Card>();
            foreach (var typeOfCard in Enum.GetValues(typeof(TypeOfCard)))
            {
                for (int z = 0; z < 13; z++)
                {
                    var card = new Card()
                    {
                        Name = $"{z + 1}",
                        TypeOfCard = (TypeOfCard)typeOfCard,
                    };
                    Cards.Add(card);
                }
            }
        }

        public List<Card> Cards { get; set; }

        public void ShuffleCards()
        {
            Cards = Cards.OrderBy(p => Guid.NewGuid()).ToList();

            Console.WriteLine("Cards Shuffled");
        }

        public void DealOneCard()
        {
            Random random = new Random();

            if (Cards.Any())
            {
                var removeCard = random.Next(0, Cards.Count + 1);
                var removedCard = Cards[removeCard];
                Cards.RemoveAt(removeCard);

                Console.WriteLine(removedCard.Name + " of " + removedCard.TypeOfCard + " Has been Removed.");
                Console.WriteLine(Cards.Count + " are Left.");
            }
            else
            {
                Console.WriteLine("There are no cards to Deal.");
            }
        }

    }
}
