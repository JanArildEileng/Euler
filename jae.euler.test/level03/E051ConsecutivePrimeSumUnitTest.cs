using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;

namespace jae.euler.test.level03
{
    public class E051PrimeDigitReplacementsUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
            By replacing the 1st digit of the 2-digit number *3,
            it turns out that six of the nine possible values: 13, 23, 43, 53, 73, and 83, are all prime.

            By replacing the 3rd and 4th digits of 56**3 with the same digit, 
            this 5-digit number is the first example having seven primes among the ten generated numbers,
            yielding the family: 56003, 56113, 56333, 56443, 56663, 56773, and 56993.
            Consequently 56003, being the first member of this family, is the smallest prime with this property.

            */
            var sut = new E051PrimeDigitReplacements();

           
           Assert.Equal(13, sut.GetSmallestReplacementPrimesWith(10,100, 6));
           Assert.Equal(56003, sut.GetSmallestReplacementPrimesWith(40000, 100000, 7));
          
        }


        [Fact]
        public void Solution()
        {
            /*
            Find the smallest prime which, by replacing part of the number (not necessarily adjacent digits) with the same digit,
            is part of an eight prime value family.          
            */

            var sut = new E051PrimeDigitReplacements();
            Assert.Equal(121313, sut.GetSmallestReplacementPrimesWith(56000, 1000000, 8));

            /*
               Congratulations, the answer you gave to problem 51 is correct.

                You are the 28970th person to have solved this problem.
             */
        }
    }


}
