using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace jae.euler.test.level03
{
    public class E069TotientMaximumUnitTest
    {
      
        [Fact]
        public void Test_1()
        {
            /*
                 It can be seen that n=6 produces a maximum n/φ(n) for n ≤ 10.         
            */
            var sut = new E069TotientMaximum(10);
            Assert.Equal(6, sut.GetNWithMaxTotient());
        }

        [Fact]
        public void Solution()
        {
            /*
            Find the value of n ≤ 1,000,000 for which n/φ(n) is a maximum.
            */
            int upperlimit = 1000000;


            var sut = new E069TotientMaximum(upperlimit);
            Assert.Equal(510510, sut.GetNWithMaxTotient());

            /*
            Congratulations, the answer you gave to problem 69 is correct.

            You are the 30074th person to have solved this problem.
            */
        }
    }
}
