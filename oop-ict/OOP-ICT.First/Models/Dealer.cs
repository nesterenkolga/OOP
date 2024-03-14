using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.First.Models;

public class Dealer : IDealer
{
    public string Name => "Dealer";
    public IList<Card> Hand { get; private set; }
    public int Score => CalculateScore();
    public bool IsBusted => Score > 21;

    public PlayerAccount Account => throw new NotImplementedException();

    private ICardStrategy cardStrategy;

    public Dealer(ICardStrategy cardStrategy)
    {
        Hand = new List<Card>();
        this.cardStrategy = cardStrategy;
    }

    public void DrawCard(IDeck deck)
    {
        Hand.Add(deck.DealCard());
    }

    public void ClearHand()
    {
        Hand.Clear();
    }

    public bool ShouldDrawCard()
    {
        return cardStrategy.ShouldDrawCard(this);
    }

    private int CalculateScore()
    {
        int score = 0;
        int acesCount = 0;

        foreach (Card card in Hand)
        {
            if (card.Rank == Rank.Ace)
            {
                acesCount++;
            }
            else if (card.Rank >= Rank.Ten)
            {
                score += 10;
            }
            else
            {
                score += (int)card.Rank + 1;
            }
        }

        while (acesCount > 0)
        {
            if (score + 11 <= 21)
            {
                score += 11;
            }
            else
            {
                score += 1;
            }
            acesCount--;
        }

        return score;
    }

    public void PlaceBet(decimal bet)
    {
        throw new NotImplementedException();
    }

    public void PayWinnings(decimal winnings)
    {
        throw new NotImplementedException();
    }
}
