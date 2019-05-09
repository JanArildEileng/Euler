using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace jae.euler.test.level03
{
    public class E071OrderedFractionsUnitTest
    {

        [Fact]
        public void Test_1()
        {
            var sut = new E071OrderedFractions();
            Assert.Equal(2, sut.GetNumeratorLeftOf(dmax: 8, rightNumerator: 3, rightDenominator: 7));
        }

        [Fact]
        public void Solution()
        {
            /*
           By listing the set of reduced proper fractions for 
           d ≤ 1,000,000 in ascending order of size, 
           find the numerator of the fraction immediately to the left of 3/7.
            */
        


            var sut = new E071OrderedFractions();
            Assert.Equal(428570, sut.GetNumeratorLeftOf(dmax: 1000000, rightNumerator: 3, rightDenominator: 7));

            /*
              Congratulations, the answer you gave to problem 71 is correct.
              You are the 25498th person to have solved this problem.
             This problem had a difficulty rating of 10%. 
            */
        }
    }
}
