using jae.euler.lib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace jae.euler.test.level04
{
    public class E084MonopolyOddsUnitTest
    {




        [Fact]
        public void Test_0()
        {
            var sut = new E084MonopolyOdds(diceSides: 6);
            sut.RunSimulation(runs: 10000000);
            Assert.InRange(sut.GetHighestVisitProbability(), 2.46, 2.54);
        }


        [Fact]
        public void Test_01_ConsecutivdoublesActivated()
        {
            var sut = new E084MonopolyOdds(diceSides: 6);
            sut.ConsecutivdoublesActivated = true;
            sut.RunSimulation(runs: 10000000);
            Assert.InRange(sut.GetHighestVisitProbability(),2.8,2.9);
        }


        [Fact]
        public void Test_02_GotoJail()
        {
            var sut = new E084MonopolyOdds(diceSides: 6);
            sut.GotoJailActivated = true;
            sut.RunSimulation(runs: 1000000);
            Assert.InRange(sut.GetHighestVisitProbability(), 4.46, 5.54);
        }

        [Fact]
        public void Test_03_CommunityChest()
        {
            var sut = new E084MonopolyOdds(diceSides: 6);
            sut.CommunityChestActivated = true;
            sut.RunSimulation(runs: 1000000);
            Assert.InRange(sut.GetHighestVisitProbability(), 2.8, 3.2);
        }


        [Fact]
        public void Test_04_ChanceActivated()
        {
            var sut = new E084MonopolyOdds(diceSides: 6);
            sut.ChanceActivated = true;
            sut.RunSimulation(runs: 1000000);
            Assert.InRange(sut.GetHighestVisitProbability(), 2.7, 3.3);
        }



        [Fact]
        public void Test_popularSquares()
        {         
            var sut = new E084MonopolyOdds(diceSides: 6);
            sut.ConsecutivdoublesActivated = true;
            sut.GotoJailActivated = true;
            sut.CommunityChestActivated = true;
            sut.ChanceActivated = true;
            sut.RunSimulation(runs: 10000000);
            Assert.Equal("102400", sut.GetPopularSquares());
        }
      
        [Fact]
        public void Solution()
        {
            /*
               popular squares can be listed with the six-digit modal string: 102400.
               If, instead of using two 6-sided dice, two 4-sided dice are used, find the six-digit modal string.
            */

            var sut = new E084MonopolyOdds(diceSides: 4);
            sut.ConsecutivdoublesActivated = true;
            sut.GotoJailActivated = true;
            sut.CommunityChestActivated = true;
            sut.ChanceActivated = true;
            sut.RunSimulation(runs: 10000000);
            Assert.Equal("101524", sut.GetPopularSquares());


            /*
                Congratulations, the answer you gave to problem 84 is correct.
                You are the 10817th person to have solved this problem.
                This problem had a difficulty rating of 35%. 
            */
        }
    }
}
