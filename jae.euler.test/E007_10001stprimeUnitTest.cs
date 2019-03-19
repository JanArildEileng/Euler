using jae.euler.lib;
using System;
using Xunit;

namespace jae.euler.test
{
    public class E007_10001stprimeUnitTest
    {
        [Fact]
        public void Test1()
        {
            /*
              By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.            
           */

            var sut = new E7_10001stprime();

            long expected = 13;
            var value = sut.GetPrimeNumber(6);
            Assert.Equal(expected, value);

        }

        [Fact]
        public void Solution()
        {
            /*
            
                What is the 10 001st prime number?
       */


            var sut = new E7_10001stprime();

            long expected = 104743;
            var value = sut.GetPrimeNumber(10001);
            Assert.Equal(expected, value);

            /*
                    Congratulations, the answer you gave to problem 7 is correct.

                        You are the 368949th person to have solved this problem.
            */

        }
    }
}
