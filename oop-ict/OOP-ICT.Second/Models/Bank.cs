using OOP_ICT.First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Second.Models;

public class Bank
{
    public void DepositToAccount(PlayerAccount account, decimal amount)
    {
        account.Deposit(amount);
    }

    public bool WithdrawFromAccount(PlayerAccount account, decimal amount)
    {
        return account.TryWithdraw(amount);
    }

    public bool CheckSufficientFunds(PlayerAccount account, decimal amount)
    {
        return account.Balance >= amount;
    }
}