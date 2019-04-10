using jae.euler.lib;
using System;
using Xunit;
using System.Linq;

namespace jae.euler.test.level01
{
    public class E016PowerdigitsumUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
             2 ^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
                 
            */

            var sut = new E016Powerdigitsum();

            long expectedsumOfDigit = 26;
        

            var sumOfDigit = sut.GetSumOfDigits(exponent: 15);
            Assert.Equal(expectedsumOfDigit, sumOfDigit);
     
        }

        [Fact]
        public void Solution()
        {
            /*
                What is the sum of the digits of the number 2^1000?
            */

            var sut = new E016Powerdigitsum();
            long expectedsumOfDigit = 1366;


            var sumOfDigit = sut.GetSumOfDigits(exponent: 1000);
            Assert.Equal(expectedsumOfDigit, sumOfDigit);



            /*
                Congratulations, the answer you gave to problem 16 is correct.

                You are the 201814th person to have solved this problem.
            */

        }


    }
}
