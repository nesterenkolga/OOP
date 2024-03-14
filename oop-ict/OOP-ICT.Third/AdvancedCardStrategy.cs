using OOP_ICT.First.Models;
using OOP_ICT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Third;

public class AdvancedCardStrategy : ICardStrategy
{
    public bool ShouldDrawCard(IPlayer player)
    {
        if (player.Score < 12)
        {
            return true;
        }
        else if (player.Score < 17)
        {
            foreach (Card card in player.Hand)
            {
                if (card.Rank == Rank.Ace)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
