using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test.level02
{
    public class E037TruncatableprimesUnitTest
    {
     
        [Fact]
        public void Test1()
        {
            /*
                 The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. 
                 Similarly we can work from right to left: 3797, 379, 37, and 3.      
                 NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.
            */

            var sut = new E037Truncatableprimes(10000);
            Assert.False(sut.IsTruncatableprime(419));
            Assert.True(sut.IsTruncatableprime(3797));
            Assert.False(sut.IsTruncatableprime(3795));
            Assert.False(sut.IsTruncatableprime(4297));
        }


        [Fact]
        public void Solution()
        {
            /*
              Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
            */

            var sut = new E037Truncatableprimes(1000000);
            Assert.Equal(748317, sut.GetSumOfTruncatableprime(numberof:11));

            /*
                Congratulations, the answer you gave to problem 37 is correct.
                You are the 64873rd person to have solved this problem.
            */
        }
    }

    
}
