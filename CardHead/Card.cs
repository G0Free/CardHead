using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardHead
{
    enum CardType { Hearts, Tiles, Clovers, Pikes }
    abstract class Card
    {
        int IDNumber;
        CardType cardType;
        string description;
    }
}
