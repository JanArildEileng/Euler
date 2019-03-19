using jae.euler.lib;
using System;
using Xunit;

namespace jae.euler.test
{
    public class E006SumsquaredifferenceUnitTest
    {
        [Fact]
        public void Test1()
        {
            /*
            
           Sum of the squares of the first ten natural numbers is,  
           12 + 22 + ... + 102 = 385
           The square of the sum of the first ten natural numbers is,
           (1 + 2 + ... + 10)2 = 552 = 3025
            Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
             
             */

            var sut = new E6Sumsquaredifference();

            var diff = sut.DifferenceBetweenTheSumOfSquares(10);
            Assert.Equal(2640, diff);

        }

        [Fact]
        public void Solution()
        {
            /*
            
           Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
            */


            var sut = new E6Sumsquaredifference();


            var diff = sut.DifferenceBetweenTheSumOfSquares(100);
            Assert.Equal(25164150, diff);
            /*
                    Congratulations, the answer you gave to problem 6 is correct.

                    You are the 431615th person to have solved this problem.
            */

        }
    }
}
