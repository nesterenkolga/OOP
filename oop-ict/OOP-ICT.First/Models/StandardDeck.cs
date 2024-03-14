using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.First.Models;

public class StandardDeck : IDeck
{
    private List<Card> cards;
    private Random random;

    public StandardDeck(ICardFactory cardFactory)
    {
        cards = new List<Card>();
        random = new Random();

        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                cards.Add(cardFactory.CreateCard(suit, rank));
            }
        }
    }

    public Card DealCard()
    {
        int index = random.Next(cards.Count);
        Card card = cards[index];
        cards.RemoveAt(index);
        return card;
    }

    public void Shuffle()
    {
        List<Card> shuffledCards = new List<Card>(cards);
        cards.Clear();

        while (shuffledCards.Count > 0)
        {
            int index = random.Next(shuffledCards.Count);
            cards.Add(shuffledCards[index]);
            shuffledCards.RemoveAt(index);
        }
    }
}