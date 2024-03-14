using OOP_ICT.First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Second.Models;

public class BlackjackCasino
{
    private const decimal BlackjackPayout = 1.5m;
    private Bank bank;

    public BlackjackCasino(Bank bank)
    {
        this.bank = bank;
    }

    public void PayOutWin(PlayerAccount account, decimal bet)
    {
        bank.DepositToAccount(account, bet * 2);
    }

    public void TakeLoss(PlayerAccount account, decimal bet)
    {
        bank.WithdrawFromAccount(account, bet);
    }

    public void HandleBlackjack(PlayerAccount account, decimal bet)
    {
        bank.DepositToAccount(account, bet * BlackjackPayout);
    }
}
