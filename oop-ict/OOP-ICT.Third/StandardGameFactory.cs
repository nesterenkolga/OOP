using OOP_ICT.First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Third;

public class StandardGameFactory : IGameFactory
{
    public IDeck CreateDeck(ICardFactory cardFactory)
    {
        return new StandardDeck(cardFactory);
    }

    public IPlayer CreatePlayer(string name, ICardStrategy cardStrategy, PlayerAccount account)
    {
        return new Player(name, cardStrategy, account);
    }

    public IDealer CreateDealer(ICardStrategy cardStrategy)
    {
        return new Dealer(cardStrategy);
    }
}
