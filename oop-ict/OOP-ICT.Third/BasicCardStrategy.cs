using OOP_ICT.First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Third;

public class BasicCardStrategy : ICardStrategy
{
    public bool ShouldDrawCard(IPlayer player)
    {
        return player.Score < 17;
    }
}

