using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Poker_Holdem
{
    class Deck
    {
        private Card[] Card = new Card[52];
        private Random card = new Random();
        int current_card;
        public Deck()
        {
            for (int i = 0; i < 52; i++)
            {
                Card[i] = new Card();
                Card[i].setNumber(card.Next(0, 13));
                Card[i].setKind(card.Next(0, 4));

                int k = i;

                // This is a loop that checks if the current card was alredy exists. 
                while (k > 0)
                {
                    k = k - 1;
     
                    if (Card[i].getNumber() == Card[k].getNumber() && Card[i].getKind().getKind() == Card[k].getKind().getKind())
                    {
                        Card[i].setNumber(card.Next(0, 13));
                        Card[i].setKind(card.Next(0, 4));
                        k = i;
                    }
                }
            }

            for(int i = 0; i < 52; i++)
            {
                Console.WriteLine(Card[i].getKind().getKind() + " " + Card[i].getNumber());
            }


        }

        public void deal(Player player)
        {
            List<Card> cardsList = new List<Card>();
            for (int i = current_card; i < current_card +2; i++)
            {
                cardsList.Add(getDeckCard(i));
                
            }
            player.setPlayerCards(cardsList);
            current_card = current_card + 2;


        }

        public List<Card> dealBoard()
        {
            List<Card> cardsList = new List<Card>();
            for (int i = current_card; i <current_card+ 5; i++)
            {
                cardsList.Add(getDeckCard(i));
            }
            return cardsList;
        }

        public int getCurrentCard()
        {
            return current_card;
        }

        public Card getDeckCard(int i)
        {
            return Card[i];
        }
    }
}
