using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Holdem
{
    class Diamond : Kind
    {
        public override string getKind() { return "diamond";}
        public override int getKindAsInt() { return 1; }
    }
}
