using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;

namespace jae.euler.test
{
    public class E049PrimePermutationsUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
           The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases by 3330,
           is unusual in two ways: (i) each of the three terms are prime, and,
           (ii) each of the 4-digit numbers are permutations of one another.

            There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, exhibiting this property, but there is one other 4-digit increasing sequence.
            */
            var sut = new E049PrimePermutations();

            Assert.Equal(148748178147, sut.Get4DigitsPrimePermutations().ElementAt(0));

        }


        [Fact]
        public void Solution()
        {
            /*
                What 12-digit number do you form by concatenating the three terms in this sequence?  
             */

            var sut = new E049PrimePermutations();
            Assert.Equal(296962999629, sut.Get4DigitsPrimePermutations().ElementAt(1));

            /*
                Congratulations, the answer you gave to problem 49 is correct.

                you are the 50798th person to have solved this problem.
             */
        }
    }


}
