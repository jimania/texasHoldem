using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Holdem
{
    class Spade : Kind
    {
        public override string getKind() { return "spade";}
        public override int getKindAsInt() { return 3; }
    }
}
