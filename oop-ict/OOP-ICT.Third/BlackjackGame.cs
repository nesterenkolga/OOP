using OOP_ICT.First.Models;
using OOP_ICT.Second.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Third;

class BlackjackGame
{
    private IDeck deck;
    private List<IPlayer> players;
    private IDealer dealer;
    private BlackjackCasino casino;

    public BlackjackGame(IDeck deck, List<IPlayer> players, IDealer dealer, BlackjackCasino casino)
    {
        this.deck = deck;
        this.players = players;
        this.dealer = dealer;
        this.casino = casino;
    }

    public void Play()
    {
        foreach (IPlayer player in players)
        {
            player.ClearHand();
        }
        dealer.ClearHand();

        deck.Shuffle();

        foreach (IPlayer player in players)
        {
            player.DrawCard(deck);
            player.DrawCard(deck);
        }
        dealer.DrawCard(deck);
        dealer.DrawCard(deck);

        foreach (IPlayer player in players)
        {
            Console.WriteLine($"Step {player.Name}:");
            while (!player.IsBusted && player.ShouldDrawCard())
            {
                player.DrawCard(deck);
                Console.WriteLine($"Cards {player.Name}: {string.Join(", ", player.Hand)}");
                Console.WriteLine($"Points {player.Name}: {player.Score}");
            }
        }

        Console.WriteLine("Dealer's step:");
        while (dealer.ShouldDrawCard())
        {
            dealer.DrawCard(deck);
            Console.WriteLine($"Dealer's cards: {string.Join(", ", dealer.Hand)}");
            Console.WriteLine($"Dealer's points: {dealer.Score}");
        }

        foreach (IPlayer player in players)
        {
            if (player.IsBusted)
            {
                Console.WriteLine($"{player.Name} too much!");
                casino.TakeLoss(player.Account, 333);
            }
            else if (dealer.IsBusted)
            {
                Console.WriteLine($"{player.Name} win!");
                casino.PayOutWin(player.Account, 111);
            }
            else if (player.Score > dealer.Score)
            {
                Console.WriteLine($"{player.Name} win!");
                casino.PayOutWin(player.Account, 111);
            }
            else if (player.Score < dealer.Score)
            {
                Console.WriteLine($"{player.Name} lose");
                casino.TakeLoss(player.Account, 111);
            }
            else
            {
                Console.WriteLine($"{player.Name} played in a draw!");
            }
        }
    }
}

