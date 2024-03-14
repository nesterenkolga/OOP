using OOP_ICT.First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Third;

public interface IGameFactory
{
    IDeck CreateDeck(ICardFactory cardFactory);
    IPlayer CreatePlayer(string name, ICardStrategy cardStrategy, PlayerAccount account);
    IDealer CreateDealer(ICardStrategy cardStrategy);
}
