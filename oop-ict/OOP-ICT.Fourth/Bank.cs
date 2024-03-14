using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Fourth;

public class Bank
{
    protected decimal balance;

    public virtual void Deposit(decimal amount)
    {
        balance += amount;    }

    public virtual bool Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return true;
        }
        return false;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
