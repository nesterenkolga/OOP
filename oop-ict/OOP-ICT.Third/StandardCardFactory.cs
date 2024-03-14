using OOP_ICT.First.Models;
using OOP_ICT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.Third;

public class StandardCardFactory : ICardFactory
{
    public Card CreateCard(Suit suit, Rank rank)
    {
        return new Card(suit, rank);
    }
}