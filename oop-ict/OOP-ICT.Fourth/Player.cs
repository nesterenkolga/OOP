using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Fourth;

public class Player
{
    public string Name { get; set; }
    public List<string> Hand { get; set; }
    private decimal balance;

    public Player(string name, decimal initialBalance)
    {
        Name = name;
        balance = initialBalance;
        Hand = new List<string>();
    }

    public decimal PlaceBet()
    {
        decimal bet = 10;
        if (balance >= bet)
        {
            balance -= bet;
            return bet;
        }
        else
        {
            return 0;
        }
    }
}




