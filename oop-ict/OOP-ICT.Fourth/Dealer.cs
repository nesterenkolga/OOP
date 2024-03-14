using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Fourth;

public class Dealer
{
    private List<string> deck;

    public Dealer()
    {
        deck = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
    }

    public void ShuffleDeck()
    {
        Random rng = new Random();
        int n = deck.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            string value = deck[k];
            deck[k] = deck[n];
            deck[n] = value;
        }
    }

    public string DealCard()
    {
        string card = deck[0];
        deck.RemoveAt(0);
        return card;
    }
}
