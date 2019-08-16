using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Holdem
{
    class Hearts : Kind
    {
        public override string getKind() { return "hearts"; }
        public override int getKindAsInt() { return 2; }
    }
}
