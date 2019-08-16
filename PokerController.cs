using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Holdem
{
    class PokerController
    {\
        public bool checkRegister = false;
        public Player player = new Player();
        public Player checkUser = new Player();
        public Player registeredUser = new Player();
        private List<Card> board = new List<Card>();
        private int activeNumber = 0;
        public List<Player> players;
        private Deck deck;
        private int tablePot = 0;
        private int smallBlind = 5;
        private int roundCount = 0;
        private int gameCount = 0;
        private int blindCounter = 0;
        private bool boardActive = false;
        private List<TournamentOne> tourlist = new List<TournamentOne>();
        Random c = new Random();
        int wf = 0;
        int activePlayersNumber = 9;
        
        public PokerController()
        {

            players = new List<Player>();
            deck = new Deck();
        }
        public bool getBoardActivity()
        {

            return boardActive;
        }
        public string getPlayerName(int i)
        {
            return players[i].getName();
        }

        public void addPlayer(Player p)
        {
            players.Add(p);
        }

        public bool checkIfActive(int i)
        {
            return players[i].checkIfActive();
        }

        public void deal()
        {
            deck = new Deck();
            for (int i = 0; i < 9; i++)
            {
                deck.deal(players[i]);
            }
        }

        public string getPlayerCard(int i)
        {
            return players[i].getCard(0);
        }
        public string getPlayerSecondCard(int i)
        {
            return players[i].getCard(1);
        }
        public string getBoardCard(int i)
        {
            return board[i].getCard();
        }








        // game looop STARTS HERE
        public void gameLoop(TournamentOne f)
        {
            if (gameCount > 1 && roundCount ==0)
            {
                board = new List<Card>();
                smallBlind = smallBlind * gameCount;
                
            }
            
            // simulates every computer player one round
            if (roundCount <= 0)
            {

                    players[blindCounter].setChips((players[0].getChips()) - smallBlind);
                    players[blindCounter+1].setChips((players[0].getChips()) - smallBlind * 2);
                    players[blindCounter].setPlayerPot(smallBlind);
                    players[blindCounter+1].setPlayerPot(smallBlind * 2);
                    blindCounter = blindCounter + 1;
                    if (blindCounter > 9)
                    {
                        blindCounter = 0;
                    }
                for (int i = 1; i < 9; i++)
                {
                    if (players[i].checkIfActive())
                    {
                        computerPlayerTalk(players[i]);
                    }
                }
                roundCount = roundCount + 1;
                TournamentOne newForm = new TournamentOne();
                tourlist.Add(newForm);
                tourlist[tourlist.Count() - 1].Show();
                if ((tourlist.Count() - 2) < 0)
                {
                    f.Close();
                }
                else
                {
                    tourlist[tourlist.Count() - 2].Close();
                }
            }
            else if (roundCount == 1)
            {
                for (int i = 1; i < 9; i++)
                {
                    if (players[i].checkIfActive())
                    {
                        computerPlayerTalk(players[i]);
                    }
                }
                board = deck.dealBoard();
                boardActive = true;
                roundCount = roundCount + 1;
                TournamentOne newForm = new TournamentOne();
                tourlist.Add(newForm);
                tourlist[tourlist.Count() - 1].Show();
                if ((tourlist.Count() - 2) < 0)
                {
                    f.Hide();
                }
                else
                {
                    tourlist[tourlist.Count() - 2].Close();
                }
            }
            else if (roundCount == 2)
            {
                for (int i = 1; i < 9; i++)
                {
                    if (players[i].checkIfActive())
                    {
                        computerPlayerTalk(players[i]);
                    }
                }
                roundCount = roundCount + 1;
                TournamentOne newForm = new TournamentOne();
                tourlist.Add(newForm);
                tourlist[tourlist.Count() - 1].Show();
                if ((tourlist.Count() - 2) < 0)
                {
                    f.Hide();
                }
                else
                {
                    tourlist[tourlist.Count() - 2].Close();
                }
            }
            else if (roundCount == 3)
            {
                for (int i = 1; i < 9; i++)
                {
                    if (players[i].checkIfActive())
                    {
                        computerPlayerTalk(players[i]);
                    }
                }
                roundCount = roundCount + 1;
                TournamentOne newForm = new TournamentOne();
                tourlist.Add(newForm);
                tourlist[tourlist.Count() - 1].Show();
                if ((tourlist.Count() - 2) < 0)
                {
                    f.Hide();
                }
                else
                {
                    tourlist[tourlist.Count() - 2].Close();
                }
            }
            else if (roundCount == 4)
            {
                for (int i = 1; i < 9; i++)
                {
                    if (players[i].checkIfActive())
                    {
                        computerPlayerTalk(players[i]);
                    }
                }
                roundCount = roundCount + 1;
                TournamentOne newForm = new TournamentOne();
                tourlist.Add(newForm);
                tourlist[tourlist.Count() - 1].Show();
                if ((tourlist.Count() - 2) < 0)
                {
                    f.Hide();
                }
                else
                {
                    tourlist[tourlist.Count() - 2].Close();
                }

            }
            else if(roundCount >4)
            {
                for (int i = 1; i < 9; i++)
                {
                    if (players[i].checkIfActive())
                    {
                        computerPlayerTalk(players[i]);
                    }
                    if (activePlayersNumber < 2)
                    {
                        roundCount = 0;
                    }
                }
                for(int j = 0; j<9; j++)
                {
                    if (!players[j].checkIfActive())
                    {
                        activePlayersNumber = activePlayersNumber - 1;
                    }
                }
                if (activePlayersNumber == 0)
                {
                    if ((tourlist.Count() - 2) < 0)
                    {
                        f.Hide();
                    }
                    else
                    {
                        tourlist[tourlist.Count() - 2].Close();
                    }
                }
                for (int i = 0; i < 9; i++)
                {
                    players[i].setPlayerPot(players[i].getPlayerPot());
                }
                roundCount = 0;
                activePlayersNumber = 9;
                gameCount = gameCount + 1;
                boardActive = false;
                TournamentOne newForm = new TournamentOne();
                tourlist.Add(newForm);
                tourlist[tourlist.Count() - 1].Show();
                if ((tourlist.Count() - 2) < 0)
                {
                    f.Close();
                }
                else
                {
                    tourlist[tourlist.Count() - 2].Close();
                }
            }

        }//end of gameLoop() method.






        public void initializeGame(TournamentOne f)
        {
            if (gameCount == 0)
            {
                board = new List<Card>();
                players = new List<Player>();
                for (int i = 0; i < 9; i++)
                {
                    Player p = new Player();
                    p.setName("Player " + i.ToString());
                    addPlayer(p);
                    f.Refresh();//se kathe round
                }
                gameCount = gameCount + 1;
            }
                
            else
            {
                 
                for (int i = 0; i < 9; i++)
                {
                    if (players[i].getChips() > 0)
                    {
                        players[i].setPlayerToActive();
                        activeNumber++;
                    }
                    else
                        players[i].setInnactive();
                }
                if (activeNumber == 1)
                {
                    winner();
                    TournamentOne asd = new TournamentOne();
                    tourlist.Add(asd);
                    initializeGame(tourlist[tourlist.Count()]);
                    gameCount = 0;
                    
                    smallBlind = 0;
                    boardActive = false;
                    board = new List<Card>();
                }
                activeNumber = 0;
            }

            TournamentOne newForm = new TournamentOne();
            tourlist.Add(newForm);
            tourlist[tourlist.Count() - 1].Show();
                f.Close();

            deal();
        }//end of gameLoop

        public void winner()
        {
            for (int i = 0; i < 9; i++)
            {
                if (players[i].checkIfActive())
                {
                    players[i].setMoney(1000);
                }
            }
        }
        public void check()
        {

        }

        public void fold()
        {
            players[0].setInnactive();
        }

        public void playerRaise()
        {
            int temp = 0;
            temp = smallBlind * 4;
            players[0].setPlayerPot(temp);
            players[0].reducePlayerChips(temp);
        }
        public void raise(Player p,int raiseValue)
        {
            int temp = 0;
            temp = smallBlind * raiseValue-2;
            p.setPlayerPot(temp);
            p.reducePlayerChips(temp);
        }

        public void call()
        {
            players[0].setChips(tablePot);
        }
        public void computerPlayerTalk(Player p)
        {
            if (p.checkIfActive())
            {
                wf = c.Next(0, 6);
                if (wf == 0)
                {
                    p.setInnactive();
                }
                if (wf == 1)
                {
                    check();
                }
                if (wf >= 2)
                {
                    raise(p, wf);
                }
            }
            
        }


        public int getPlayerChips(int i)
        {
           return players[i].getChips();
        }

        public int getPlayerPot(int i)
        {
            return players[i].getPlayerPot();
        }
        public bool registered()
        {
            return checkRegister;
        }
        public bool getRegistered()
        {
            return checkRegister;
        }
        public void setRegistered(bool reg)
        {
            checkRegister = reg;
        }
        public void setRegisteredName(string name)
        {
            registeredUser.setName(name);
        }
        public void setRegisteredPass(string pass)
        {
            registeredUser.setPass(pass);
        }
        public int getGameCount()
        {
            return gameCount;
        }

    }
}
