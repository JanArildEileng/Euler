using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace jae.euler.test.level03
{
    public class E072CountingFractionsUnitTest
    {

        [Fact]
        public void Test_1()
        {
            var sut = new E072CountingFractions();
            Assert.Equal(21, sut.GetNumberOfProperFractions(dmax: 8));
        }

        [Fact]
        public void Solution()
        {
            /*
          How many elements would be contained in the set of reduced proper fractions for d ≤ 1,000,000?
            */

            var sut = new E072CountingFractions();
            Assert.Equal(303963552391, sut.GetNumberOfProperFractions(dmax: 1000000));

            /*
              Congratulations, the answer you gave to problem 72 is correct.
              You are the 19373rd person to have solved this problem.
              This problem had a difficulty rating of 20%.
            */
        }
    }
}
