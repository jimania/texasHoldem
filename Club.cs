using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Holdem
{
    class Club : Kind
    {
        public override string getKind() { return "club"; }
        public override int getKindAsInt() { return 0; }
    }
}
