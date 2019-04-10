using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test.level02
{
    public class E035CircularprimesUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
            The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
            There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
            */

            var sut = new E035Circularprimes(max:100);
            Assert.True(sut.IsCircularPrimes(37));
            Assert.False(sut.IsCircularPrimes(41));
            Assert.Equal(13, sut.GetNumberOfCircularPrimes());

            sut = new E035Circularprimes(max: 1000);
            Assert.True(sut.IsCircularPrimes(197));
        }

        [Fact]
        public void Solution()
        {
            /*
              How many circular primes are there below one million?      
            */

            var sut = new E035Circularprimes(1000000);
            Assert.Equal(55, sut.GetNumberOfCircularPrimes());

            /*
             Congratulations, the answer you gave to problem 35 is correct.

                You are the 74884th person to have solved this problem.
            */
        }
    }

    
}
