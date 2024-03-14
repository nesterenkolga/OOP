using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Fourth;

public class PokerBank : Bank
{
    public override void Deposit(decimal amount)
    {
        base.Deposit(amount);
    }

    public override bool Withdraw(decimal amount)
    {
        return base.Withdraw(amount);
    }

    public bool CheckPlayerBalance(decimal bet)
    {
        return balance >= bet;
    }
}
