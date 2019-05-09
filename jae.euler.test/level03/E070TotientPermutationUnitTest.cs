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
        [Theory]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 2)]
        [InlineData(5, 4)]
        [InlineData(6, 2)]
        [InlineData(7, 6)]
        [InlineData(8, 4)]
        [InlineData(9, 6)]
        [InlineData(10, 4)]

        public void Test_Totient(int n,int phi)
        {
            var sut = new E070TotientPermutation(10);
            Assert.Equal(phi, sut.Totient(n));
        }

        [Fact]
        public void Test_permutastion()
        {
  
            var sut = new E070TotientPermutation(100000);
            Assert.Equal(79180, sut.Totient(87109));
            Assert.Equal(781396, sut.Totient(783169));
        }

        [Fact]
        public void Test_GetNWithMinTotient()
        {
            var sut = new E070TotientPermutation(1000000);
            Assert.Equal(783169, sut.GetNWithMinTotient());
        }



        [Fact]
        public void Test_Ytelse()
        {
            int antall = 1000000;
            var sut = new E070TotientPermutation(antall);
           for(int i= 1; i< antall;i++)
            {
                sut.Totient(i);
            }      
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
