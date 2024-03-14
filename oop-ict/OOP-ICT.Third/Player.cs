using OOP_ICT.First.Models;
using OOP_ICT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Third;

public class Player : IPlayer
{
    public string Name { get; }
    public IList<Card> Hand { get; private set; }
    public int Score => CalculateScore();
    public bool IsBusted => Score > 21;
    private ICardStrategy cardStrategy;
    public PlayerAccount Account { get; private set; }

    public Player(string name, ICardStrategy cardStrategy, PlayerAccount account)
    {
        Name = name;
        Hand = new List<Card>();
        this.cardStrategy = cardStrategy;
        this.Account = account;
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

    public void PlaceBet(decimal bet)
    {
        if (Account.TryWithdraw(bet))
        {
        }
        else
        {
            Console.WriteLine($"Insufficient funds for a bet {bet}");
        }
    }

    public void PayWinnings(decimal winnings)
    {
        Account.Deposit(winnings);
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
}
