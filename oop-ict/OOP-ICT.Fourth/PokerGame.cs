using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Fourth;

public class PokerGame
{
    private PokerBank bank;
    private List<Player> players;
    private Dealer dealer;

    public PokerGame()
    {
        bank = new PokerBank();
        players = new List<Player>();
        dealer = new Dealer();
    }

    public void StartNewGame()
    {
        Console.WriteLine("New game started!");
        dealer.ShuffleDeck();
        foreach (Player player in players)
        {
            player.Hand = new List<string> { dealer.DealCard(), dealer.DealCard() };
        }
    }

    public void DealCards()
    {
        foreach (Player player in players)
        {
            player.Hand.Add(dealer.DealCard());
        }
    }

    public void GetBets()
    {
        foreach (Player player in players)
        {
            decimal bet = player.PlaceBet();
            if (bank.CheckPlayerBalance(bet))
            {
                bank.Withdraw(bet);
            }
            else
            {
                Console.WriteLine($"{player.Name} can't place a bet {bet}, because there aren't enough money.");
            }
        }
    }

    public void CompareHands()
    {
        // Logic for comparing hands and determining the winner
    }

    public void PayWinner()
    {
        // Logic for paying the winner
    }

    public void ChargeLosers()
    {
        // Logic for charging the losers
    }
}
