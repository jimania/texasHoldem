using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Poker_Holdem
{
    class HandCalculator
    { 

        int straitFlush = 775892;
        int fourOfKind  = 775723;
        int fullHousre = 775554;
        int flush = 404261;
        int straight = 404248;
        int threeOfKind = 402051;
        int twoPair = 399854;
        int onePair = 371293;
        int highCard = 0;


        int[] arrayP0 = new int[13] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
        int[] arrayP1 = new int[13] {0, 13, 26, 39, 52, 65, 78, 91, 104, 117, 130, 143, 156};
        int[] arrayP2 = new int[13] { 0, 169, 338, 507, 676, 845, 1014, 1183, 1352, 1521, 1690, 1859, 2028 };
        int[] arrayP3 = new int[13] { 0, 2197, 4394, 6591, 8788, 10985, 13182, 15379, 17576, 19773, 21970, 24167, 26364 };
        int[] arrayP4 = new int[13] { 0, 28561, 57122, 85683, 114244, 142805, 171366, 199927, 228488, 257049, 285610, 314171, 342732 };
        int[] arrayP5 = new int[13] { 0, 371293, 742586, 1113879, 1485172, 1856465, 2227758, 2599051, 2970344, 3341637, 3712930, 4084223, 4455516 };

        int[] arrayStraightFlush = new int[13];
        int[] arrayStraight = new int[13];

        int rank(Card[] deck, Card[] hand)
        {

            int[] sequence = new int[7];
            int[] card = new int[7];

            int checkFlush = 0;
            int checkStraightFlush = 0;
            int checkStraight = 0;

            int[] arrayFlushCards = new int[7];
            int flushKind = -1;
            int straightBiggerCard = -1;
            int straightFlushBiggerCard = -1;
            int checkThreeOfKind = -1;
            int checkFourOfKind = -1;

            int[] arrayPair = new int[2];
            arrayPair[0] = -1;
            arrayPair[1] = -1;

            // na deis poio apo ta dyo einai sequence

            card[0] = deck[0].calcCardScore() % 13;
            card[1] = deck[1].calcCardScore() % 13;
            card[2] = deck[2].calcCardScore() % 13;
            card[3] = deck[3].calcCardScore() % 13;
            card[4] = deck[4].calcCardScore() % 13;
            card[5] = deck[5].calcCardScore() % 13;
            card[6] = deck[6].calcCardScore() % 13;

            sequence[0] = deck[0].calcCardScore() / 13;
            sequence[1] = deck[1].calcCardScore() / 13;
            sequence[2] = deck[2].calcCardScore() / 13;
            sequence[3] = deck[3].calcCardScore() / 13;
            sequence[4] = deck[4].calcCardScore() / 13;
            sequence[5] = deck[5].calcCardScore() / 13;
            sequence[6] = deck[6].calcCardScore() / 13;


            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6 - i; j++)
                {
                    if (card[j + 1] < card[j])
                    {
                        int temp1 = card[j];
                        int temp2 = sequence[j];

                        card[j] = card[j + 1];
                        card[j + 1] = temp1;

                        sequence[j] = sequence[j + 1];
                        sequence[j + 1] = temp2;
                    }
                }
            }

            // Count suits
            int suit1 = 0;
            int suit2 = 0;
            int suit3 = 0;
            int suit4 = 0;

            for (int i = 0; i < 7; i++)
            {
                if (sequence[i] == 0)
                    suit1++;
                else if (sequence[i] == 1)
                    suit2++;
                else if (sequence[i] == 2)
                    suit3++;
                else
                    suit4++;
            }

            //Check flush
            if (suit1 > 4)
            {
                flushKind = 0;
                checkFlush = 1;
            }
            else if (suit2 > 4)
            {
                flushKind = 1;
                checkFlush = 1;
            }
            else if (suit3 > 4)
            {
                flushKind = 2;
                checkFlush = 1;
            }
            else if (suit4 > 4)
            {
                flushKind = 3;
                checkFlush = 1;
            }
            else
                checkFlush = 0;

            //check straight flush
            if (checkFlush == 1)
            {
                for (int f = 0; f < 7; f++)
                {
                    arrayFlushCards[f] = -1;
                }
                for (int x = 0, y = 6; y >= 0; y--)
                {
                    if (sequence[y] == flushKind)
                    {
                        arrayFlushCards[x++] = card[y];
                    }
                }


                for (int f = 0; f < 13; f++)
                {
                    arrayStraightFlush[f] = 0;
                }
                for (int g = 0; g < 7 && arrayFlushCards[g] != -1; g++)
                {
                    arrayStraightFlush[arrayFlushCards[g]]++;
                }

                int straightFlushCount = 0;
                checkStraightFlush = 0;
                for (int i = 0; i < 13; i++)
                {
                    if (arrayStraightFlush[i] == 0)
                    {
                        straightFlushCount++;
                        if (straightFlushCount >= 5)
                        {
                            checkStraightFlush = 1;
                            straightFlushBiggerCard = i;
                        }
                    }
                    else
                    {
                        straightFlushCount = 0;
                    }
                }
            }

            // straight flush:
            if (checkStraightFlush == 1)
            {
                return (straitFlush + straightFlushBiggerCard);
            }


            //check for a straight or 4 of a kind:

            for (int i = 0; i < 13; i++)
                arrayStraight[i] = 0;

            for (int i = 0; i < 7; i++)
            {
                arrayStraight[card[i]]++;
                if (arrayStraight[card[i]] == 4)
                {
                    checkFourOfKind = card[i];
                }
            }

            int straightCount = 0;
            checkStraight = 0;
            for (int i = 0; i < 13; i++)
            {
                if (arrayStraight[i] == 0)
                {
                    straightCount++;
                    if (straightCount >= 5)
                    {
                        checkStraight = 1;
                        straightBiggerCard = i;
                    }
                }
                else
                    straightCount = 0;
            }



            // Four of a kind
            if (checkFourOfKind != -1)
            {
                int kicker;
                int i = 7;
                while (card[--i] == checkFourOfKind) { }
                kicker = card[i];
                return (fourOfKind + arrayP1[checkThreeOfKind] + kicker);
            }

            //Check for trips and pairs
            else
            {//if(fourple == -1)
                for (int i = 12; i >= 0; i--)
                {
                    if (arrayStraight[i] == 3)
                        if (checkThreeOfKind == -1)
                            checkThreeOfKind = i;
                        else
                        {  // 2nd triple means no pairs possible, but full house definite.
                            // so use high trip as the triple and the low trip as the pair for the full house.
                            arrayPair[0] = i;
                        }

                    else if (arrayStraight[i] == 2)
                    {
                        if (arrayPair[0] == -1)
                            arrayPair[0] = i;
                        else if (arrayPair[1] == -1)
                            arrayPair[1] = i;
                    }
                }
            }

            // Full house
            if (checkThreeOfKind != -1 && arrayPair[0] != -1)
            {
                return (fullHousre + arrayP1[checkThreeOfKind] + arrayPair[0]);
            }

            // flush:
            else if (checkFlush == 1)
            {
                return (flush + arrayP4[arrayFlushCards[0]] + arrayP3[arrayFlushCards[1]] + arrayP2[arrayFlushCards[2]] + arrayP1[arrayFlushCards[3]] + arrayFlushCards[4]);
            }

            // three of a kind:
            if (checkThreeOfKind != -1)
            {
                int kicker1, kicker2;
                int i = 6;
                while (card[i] == checkThreeOfKind) { i--; }
                kicker1 = card[i--];
                while (card[i] == checkThreeOfKind) { i--; }
                kicker2 = card[i];

                return (threeOfKind + arrayP2[checkThreeOfKind] + arrayP1[kicker1] + kicker2);
            }

            // Double pair
            else if (arrayPair[1] != -1)
            {
                int kicker;
                int i = 6;
                while (card[i] == arrayPair[0] || card[i] == arrayPair[1]) { i--; }
                kicker = card[i];

                return (twoPair + arrayP2[arrayPair[0]] + arrayP1[arrayPair[1]] + kicker);
            }

            // Pair
            else if (arrayPair[0] != -1)
            {
                int kicker1;
                int kicker2;
                int kicker3;

                int i = 6;
                while (card[i] == arrayPair[0]) { i--; }
                kicker1 = card[i--];
                while (card[i] == arrayPair[0]) { i--; }
                kicker2 = card[i--];
                while (card[i] == arrayPair[0]) { i--; }
                kicker3 = card[i];

                return (onePair + arrayP3[arrayPair[0]] + arrayP2[kicker1] + arrayP1[kicker2] + kicker3);
            }

            // High card:
            else
                return (highCard + arrayP4[card[6]] + arrayP3[card[5]] + arrayP2[card[4]] + arrayP1[card[3]] + card[2]);
        }
    }
}
