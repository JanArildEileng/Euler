using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace jae.euler.test.level03
{
    public class E070TotientPermutationUnitTest
    {

        [Fact]
        public void Test_GetNWithMinTotient()
        {
            var sut = new E070TotientPermutation(1000000);
            Assert.Equal(783169, sut.GetNWithMinTotient());
        }

        [Fact]
        public void Solution()
        {
            /*
            Find the value of n, 1 < n < 10^7,
            for which φ(n) is a permutation of n 
            and the ratio n/φ(n) produces a minimum.
            */
            int upperlimit = 10000000;


            var sut = new E070TotientPermutation(upperlimit);
            Assert.Equal(8319823, sut.GetNWithMinTotient());

            /*
              Congratulations, the answer you gave to problem 70 is correct.
              You are the 19333rd person to have solved this problem.
              This problem had a difficulty rating of 20%. 

            */
        }
    }
}
