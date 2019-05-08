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
        [Theory]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 2)]
        [InlineData(5, 4)]
        [InlineData(6, 2)]
        [InlineData(7, 6)]
        [InlineData(8, 4)]
        [InlineData(9, 6)]
        [InlineData(10,4)]

        public void Test_Totient(int n,int phi)
        {
            var sut = new E069TotientMaximum(10);
            Assert.Equal(phi, sut.Totient(n));
        }


        [Fact]
        public void Test_1()
        {
            /*
                 It can be seen that n=6 produces a maximum n/φ(n) for n ≤ 10.         
            */
            var sut = new E069TotientMaximum(10);
            Assert.Equal(6, sut.GetNWithMaxTotient(upperlimit: 10));
        }

        [Fact]
        public void Solution()
        {
            /*
            Find the value of n ≤ 1,000,000 for which n/φ(n) is a maximum.
            */
            int upperlimit = 1000000;


            var sut = new E069TotientMaximum(upperlimit);
            Assert.Equal(510510, sut.GetNWithMaxTotient(upperlimit: upperlimit));

            /*
            Congratulations, the answer you gave to problem 69 is correct.

            You are the 30074th person to have solved this problem.
            */
        }
    }
}
