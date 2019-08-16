using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Holdem
{
    class Player
    {
        private List<Card> playerCards = new List<Card>();
        private bool active;
        private string name;
        private string password;
        private int chips;
        private int playerPot = 0;
        private int money = 5000;
        private int logAttempts = 0;



        public Player()
        {
            active = true;
            playerCards = new List<Card>();
            name = "aaaa";
            chips = 2000;
        }
        public void setPass(string pass)
        {
            password = pass;
        }
        public string getPass()
        {
            return password;
        }
        public void setMoney(int x)
        {
            money = money + x;
        }
        public void setChips(int chips)
        {
            this.chips = chips;
        }
        public void setPlayerToActive()
        {
            active = true;
        }
        public int getChips()
        {
            return chips;
        }
        public int getPlayerPot()
        {
            return playerPot;
        }
        public void setLogAttempts(int logAttempts)
        {
            this.logAttempts = logAttempts;
        }


        public string getName()
        {
            return name;
        }

        public void reducePlayerChips(int raiseAmount)
        {
            chips = chips - raiseAmount;
        }
        public void setPlayerChips(int amount)
        {
            chips = chips - amount;
        }
        public void setPlayerPot(int pot)
        {
            playerPot = playerPot + pot;
        }

        public string getCard(int i)
        {
            return playerCards[i].getCard();
        }

        public void setName(string s)
        {
            name = s;
        }

        public void addCard(Card c)
        {
            playerCards.Add(c);
        }

        public bool checkIfActive()
        {
            return active;
        }

        public void playerTalk()
        {
            //click button!!!! EDW DEITE KIRIE AMBATZOGLOU!!! :)


        }

        public void setPlayerCards(List<Card> listCard)
        {
            playerCards = listCard;
        }
        public bool haveChips()
        {
            if (chips > 0)
                return true;
            else
                return false;

        }

        public void setInnactive()
        {
             active = false;
        }

        public bool checkData(Player checkUser)
        {
            if (checkUser.getName() == this.getName() && checkUser.getPass() == this.getPass() && this.getLogAttempts() < 3)
            {
                return true;
            }
            else
                this.increaseLogAttempts();
            return false;
        }
        public void increaseLogAttempts()
        {

            this.logAttempts = logAttempts + 1;
        }
        public int getLogAttempts()
        {
            if (logAttempts < 3)
            {
                return logAttempts;
            }
            else
                return 3;
        }
    }
}
