using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ICT.First.Models;

public interface IDealer : IPlayer
{
    bool ShouldDrawCard();
}
