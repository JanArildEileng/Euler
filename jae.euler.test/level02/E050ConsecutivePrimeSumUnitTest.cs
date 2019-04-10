using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;

namespace jae.euler.test.level02
{
    public class E050ConsecutivePrimeSumUnitTest
    {

        [Fact]
        public void Test1()
        {
         /*
            The prime 41, can be written as the sum of six consecutive primes:

            41 = 2 + 3 + 5 + 7 + 11 + 13
            This is the longest sum of consecutive primes that adds to a prime below one-hundred.

            The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.
         */
            var sut = new E050ConsecutivePrimeSum(below: 100);

            Assert.Equal(41, sut.GetConsecutivePrimeSum());

            sut = new E050ConsecutivePrimeSum(below: 1000);
            Assert.Equal(953, sut.GetConsecutivePrimeSum());

        }


        [Fact]
        public void Solution()
        {
            /*
                Which prime, below one-million, can be written as the sum of the most consecutive primes?  
             */

            var sut = new E050ConsecutivePrimeSum(1000000);
            Assert.Equal(997651, sut.GetConsecutivePrimeSum());

            /*
                Congratulations, the answer you gave to problem 50 is correct.
                You are the 54739th person to have solved this problem.
                Nice work, janei, you've just advanced to Level 2 . 
                47944 members (5.34%) have made it this far.
             */
        }
    }


}
