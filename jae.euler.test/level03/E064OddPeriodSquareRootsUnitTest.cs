using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace jae.euler.test.level03
{
    public class E064OddPeriodSquareRootsUnitTest
    {

       
        /*  
        The first ten continued fraction representations of(irrational) square roots are:
        2–√=[1;(2)], period=1
        3–√=[1;(1,2)], period=2
        5–√=[2;(4)], period=1
        6–√=[2;(2,4)], period=2
        7–√=[2;(1,1,1,4)], period=4
        8–√=[2;(1,4)], period=2
        10−−√=[3;(6)], period=1
        11−−√=[3;(3,6)], period=2
        12−−√=[3;(2,6)], period=2
        13−−√=[3;(1,1,1,1,6)], period=5
        */

        [Theory]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 0)]
        [InlineData(5, 1)]
        [InlineData(6, 2)]
        [InlineData(7, 4)]
        [InlineData(8, 2)]
        [InlineData(10, 1)]
        [InlineData(11, 2)]
        [InlineData(12, 2)]
        [InlineData(13, 5)]
        [InlineData(23, 4)]

        public void Test_ContinuedFractionPeriodes(int number,int expectedPeriodes)
        {
            var sut = new E064OddPeriodSquareRoots();
            Assert.Equal(expectedPeriodes, sut.GetPeriodsOfSquareRoot(number));
        }



        [Fact]
        public void TestContinuedFraction23()
        {
            var sut = new E064OddPeriodSquareRoots();
            Assert.Equal(4, sut.GetPeriodsOfSquareRoot(23));
        }


        [Fact]
        public void Test0()
        {
            /*
            Exactly four continued fractions, for N≤13, have an odd period.       */
            var sut = new E064OddPeriodSquareRoots();

            Assert.Equal(4, sut.GetNumberOfOddPeriodes(N: 13));

        }



        [Fact]
        public void Solution()
        {
            /*
               How many continued fractions for N≤10000 have an odd period?
            */

            var sut = new E064OddPeriodSquareRoots();

            Assert.Equal(1322, sut.GetNumberOfOddPeriodes(N: 10000));

            /*
             Congratulations, the answer you gave to problem 64 is correct.

            You are the 19094th person to have solved this problem.
            */
        }
    }
}
