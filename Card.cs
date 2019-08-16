using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Holdem
{
    class Card
    {
        private int number;
        private Kind _kind;

        public int getNumber()
        {
            return number;
        }

        public void setNumber(int num)
        {
            number = num;
        }

        public Kind getKind()
        {
            return _kind;
        }

        public void setKind(int num)
        {
            if (num == 0)
            {
                _kind = new Diamond();
            }
            if (num == 1)
            {
                _kind = new Hearts();
            }
            if (num == 2)
            {
                _kind = new Spade();
            }
            if (num == 3)
            {
                _kind = new Club();
            }
        }

        public string getCard()
        {
            String s = "cards_icons/" + _kind.getKind() + "_" + number.ToString() + ".PNG";
            return s;
        }

        public int calcCardScore()
        {
            int temp;

            temp = _kind.getKindAsInt() * 13 + number;

            return temp;
        }
    }

}
