using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace jae.euler.test.level03
{
    public class E054PokerHandsUnitTest
    {

        private string[]  GetHandsFromFile()
        {
            return  File.ReadAllLines("DataFiles\\p054_poker.txt");                 
        }

        [Fact]
        public void TestFile()
        {
            string[] lines = GetHandsFromFile();
            Assert.Equal(1000, lines.Length);
        }

        [Theory]
        [InlineData("8C TS KC 9H 4S", PokerHandRanking.HighCard)]
        [InlineData("8D 3S 5D 5C AH", PokerHandRanking.OnePair)]      
        [InlineData("5C AD 5D AC 9C", PokerHandRanking.TwoPairs)]
        [InlineData("5C AD 5D KC 5H", PokerHandRanking.ThreeofaKind)]
        [InlineData("5C KD 5D KC 5H", PokerHandRanking.FullHouse)]
        [InlineData("5C 5S 5D KC 5H", PokerHandRanking.FourofaKind)]
        [InlineData("2C 3S 4H 5C 6H", PokerHandRanking.Straight)]
        [InlineData("2C TC 8C 5C AC", PokerHandRanking.Flush)]
        [InlineData("7C 8C 4C 5C 6C", PokerHandRanking.StraightFlush)]

        public void Test_RankPokerHand(string hand, PokerHandRanking expectedValue)
        {
            var sut = new E054PokerHands();
            Assert.Equal(expectedValue, sut.RankPokerHand(hand));
        }

        [Fact]
        public void Test_CompareAllHands()
        {
            var sut = new E054PokerHands();
            string[] lines = GetHandsFromFile();
            foreach(var line in lines)
            {
                sut.FirstPlayerWins(line);
            }         
        }


        [Fact]
        public void Test1()
        {
            /*
             * 8C TS KC 9H 4S 7D 2S 5D 3S AC
            */
            string[] lines = GetHandsFromFile();

            var sut = new E054PokerHands();
            /* 8C TS KC 9H 4S  K high
             * 7D 2S 5D 3S AC  A high
             */
            Assert.False(sut.FirstPlayerWins(lines[0]));
            /*
            5C AD 5D AC 9C  2 pair
            7C 5H 8D TD KS  K hih
            */
            Assert.True(sut.FirstPlayerWins(lines[1]));
        }
     

        [Fact]
        public void Solution()
        {
            /*
                How many hands does Player 1 win?
            */
            string[] lines = GetHandsFromFile();
            var sut = new E054PokerHands();

            Assert.Equal(376, sut.GetFirstPlayerWins(lines));

            /*
                Congratulations, the answer you gave to problem 54 is correct.
                You are the 31167th person to have solved this problem.
            */
        }
    }


}
