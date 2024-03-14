using OOP_ICT.First.Models;
using OOP_ICT.Second.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Third;

class BlackjackGameBuilder
{
    private IGameFactory gameFactory;
    private ICardFactory cardFactory;
    private IDeck deck;
    private List<IPlayer> players = new List<IPlayer>();
    private IDealer dealer;
    private BlackjackCasino casino;

    public BlackjackGameBuilder(IGameFactory gameFactory, ICardFactory cardFactory, BlackjackCasino casino)
    {
        this.gameFactory = gameFactory;
        this.cardFactory = cardFactory;
        this.casino = casino;
    }

    public BlackjackGameBuilder WithDeck()
    {
        deck = gameFactory.CreateDeck(cardFactory);
        return this;
    }

    public BlackjackGameBuilder WithPlayer(string name, ICardStrategy cardStrategy, PlayerAccount account)
    {
        players.Add(gameFactory.CreatePlayer(name, cardStrategy, account));
        return this;
    }

    public BlackjackGameBuilder WithDealer(ICardStrategy cardStrategy)
    {
        dealer = gameFactory.CreateDealer(cardStrategy);
        return this;
    }

    public BlackjackGame Build()
    {
        return new BlackjackGame(deck, players, dealer, casino);
    }
}
