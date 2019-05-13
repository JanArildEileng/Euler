using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace jae.euler.test.level03
{
    public class E065ConvergentsOfEUnitTest
    {

   

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 8)]
        [InlineData(4, 2)]
        [InlineData(5, 10)]
        [InlineData(6, 15)]
        [InlineData(7, 7)]
        [InlineData(8, 13)]
        [InlineData(9, 13)]
        [InlineData(10, 17)]

        public void Test_SumOfDigits(int convergentNumber, int expecteedSum)
        {
            var sut = new E065ConvergentsOfE();

            Assert.Equal(expecteedSum, sut.GetSumOfDigits(convergentNumber: convergentNumber));

        }


        [Fact]
        public void Test_One()
        {
            /*
             The sum of digits in the numerator of the 10th convergent is 1+4+5+7=17.   
            */
            var sut = new E065ConvergentsOfE();

            Assert.Equal(2, sut.GetSumOfDigits(convergentNumber: 45));

        }


        [Fact]
        public void Solution()
        {
            /*
               Find the sum of digits in the numerator of the 100th convergent of the continued fraction for e.
            */

            var sut = new E065ConvergentsOfE();

            Assert.Equal(1234, sut.GetSumOfDigits(convergentNumber: 100));

            /*
             Congratulations, the answer you gave to problem 64 is correct.

            You are the 19094th person to have solved this problem.
            */
        }
    }
}
