using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.First.Models;

public interface IPlayer
{
    string Name { get; }
    IList<Card> Hand { get; }
    int Score { get; }
    bool IsBusted { get; }
    public PlayerAccount Account { get; }
    void DrawCard(IDeck deck);
    void ClearHand();
    bool ShouldDrawCard();
    void PlaceBet(decimal bet);
    void PayWinnings(decimal winnings);
}
