using jae.euler.lib;
using System;
using Xunit;
using System.Linq;
using System.Text;

namespace jae.euler.test.level01
{
    public class E020FactorialdigitsumUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
               For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
                and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.     
            */
            var sut = new E020Factorialdigitsum();
            int digitsumExpected = 27;
            int digitsum = sut.GetFactorialdigitsum(10);
            Assert.Equal(digitsumExpected, digitsum);
        }

        [Fact]
        public void Solution()
        {
            /*
               Find the sum of the digits in the number 100!
            */

            var sut = new E020Factorialdigitsum();
            int digitsumExpected = 648;
            int digitsum = sut.GetFactorialdigitsum(100);
            Assert.Equal(digitsumExpected, digitsum);

            /*
              Congratulations, the answer you gave to problem 20 is correct.

                You are the 175886th person to have solved this problem.
            */
        }
    }
}
