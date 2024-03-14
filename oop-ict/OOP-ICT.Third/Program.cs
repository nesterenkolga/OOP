using OOP_ICT.First.Models;
using OOP_ICT.Second.Models;

namespace OOP_ICT.Third;


class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();
        BlackjackCasino casino = new BlackjackCasino(bank);

        ICardFactory cardFactory = new StandardCardFactory();
        IGameFactory gameFactory = new StandardGameFactory();

        PlayerAccount player1Account = new PlayerAccount(1000);
        PlayerAccount player2Account = new PlayerAccount(500);

        BlackjackGameBuilder builder = new BlackjackGameBuilder(gameFactory, cardFactory, casino);
        BlackjackGame game = builder.WithDeck()
                                    .WithPlayer("Player 1", new BasicCardStrategy(), player1Account)
                                    .WithPlayer("Player 2", new AdvancedCardStrategy(), player2Account)
                                    .WithDealer(new DealerCardStrategy())
                                    .Build();

        game.Play();
    }
}