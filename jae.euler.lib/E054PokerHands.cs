using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public enum PokerHandRanking
    {
        HighCard, OnePair, TwoPairs, ThreeofaKind, Straight, Flush, FullHouse, FourofaKind, StraightFlush, RoyalFlush
    }
 
    public class E054PokerHands
    {
        public int GetFirstPlayerWins(string[] lines)
        {
            return lines.ToList().Where(line => FirstPlayerWins(line)).Count();
        }

        public bool FirstPlayerWins(string line)
        {
            string firstHand = line.Substring(0, 14);
            string secondHand = line.Substring(15);

            PokerHandRanking firstPlayerRank = RankPokerHand(firstHand);
            PokerHandRanking secondPlayerRank = RankPokerHand(secondHand);

            if (firstPlayerRank != secondPlayerRank)
                return (firstPlayerRank > secondPlayerRank);
       
            return FirstPlayerBestHandWhenEqual(firstHand, secondHand, firstPlayerRank);

            throw new Exception($"Cant decide winner {line}");
        }


        public PokerHandRanking RankPokerHand(string hand)
        {
            List<int> values = GetCardValues(hand);

            var rank = PokerHandRanking.HighCard;

            var hasStraight = HasStraight(values);
            if (hasStraight)
                rank = PokerHandRanking.Straight;

            var hasFlush = HasFlush(hand);
            if (hasFlush)
                rank = PokerHandRanking.Flush;

            if (hasStraight && hasFlush)
                rank = PokerHandRanking.StraightFlush;


            //if not straigh or flush
            if ( rank== PokerHandRanking.HighCard)
            {
                if (HasMultiKinds(values, 2,1))             
                    rank = PokerHandRanking.OnePair;
                else if (HasMultiKinds(values, 2, 2))
                    rank = PokerHandRanking.TwoPairs;
                
                if (HasMultiKinds(values, 3))
                {
                    rank = PokerHandRanking.ThreeofaKind;
                    if (HasMultiKinds(values, 2))
                        rank = PokerHandRanking.FullHouse;
                }
                
                if (HasMultiKinds(values, 4))
                    rank = PokerHandRanking.FourofaKind;
            }
      
            return rank;
        }

 
        private bool HasFlush(string hand)
        {
            List<char> suits = new List<char>{ hand[1], hand[4], hand[7], hand[10], hand[13] };
            return suits.All(e => e == suits[0]);
        }

        private bool HasStraight(List<int> values)
        {
            return values.Distinct().Count()==5 && ((values[0] + 4) == values[4]);        
        }      

        private bool HasMultiKinds(List<int> values,int countOfKinds,int expectedSets=1)
        {
            var pairs = values.GroupBy(e => e).Where(g => g.Count() == countOfKinds);
            return pairs.Count() == expectedSets;
        }


        private int GetsMultiKindsValue(List<int> values, int countOfKinds, int expectedSets = 1)
        {
            var pairs = values.GroupBy(e => e).Where(g => g.Count() == countOfKinds).ToList();
            return pairs[0].Key;
        }

        private List<int> GetCardValues(string hand)
        {
            List<char> charliste = new List<char> { hand[0], hand[3], hand[6], hand[9], hand[12] };
            return  charliste.Select(c => ConvertCardValue(c)).OrderBy(e => e).ToList();
        }
     
        private bool FirstPlayerBestHandWhenEqual(string firstHand, string secondHand, PokerHandRanking value)
        {
            List<int> cardvalues1 = GetCardValues(firstHand);
            List<int> cardvalues2 = GetCardValues(secondHand);

            switch(value)
            {             
                case PokerHandRanking.HighCard:
                case PokerHandRanking.Straight:
                    {
                        for (int i = 4; i >= 0; i--)
                        {
                             if (cardvalues1[i] != cardvalues2[i])
                                return (cardvalues1[i] > cardvalues2[i]);
                        }

                        throw new Exception($"Cant decide Both {value}");
                    }

                case PokerHandRanking.OnePair:
                    {

                        int pairValue1 = GetsMultiKindsValue(cardvalues1, 2);
                        int pairValue2 = GetsMultiKindsValue(cardvalues2, 2);
                        if (pairValue1 != pairValue2)
                            return (pairValue1 > pairValue2);
 
                        return FirstPlayerBestHandWhenEqual(firstHand, secondHand, PokerHandRanking.HighCard);
                    }
             
                default:
                    throw new Exception($"Not implemented test for Both {value}");

            }
        }


        private int ConvertCardValue(char a)
        {
            switch(a)
            {
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
                case 'T': return 10;
                case 'J': return 11;
                case 'Q': return 12;
                case 'K': return 13;
                case 'A': return 14;           
            }
            throw new Exception("Illegal cardvalue");
        }
   
    }
}
