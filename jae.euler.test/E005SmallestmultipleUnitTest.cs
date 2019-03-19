using jae.euler.lib;
using System;
using Xunit;

namespace jae.euler.test
{
    public class E005SmallestmultipleUnitTest
    {
        [Fact]
        public void Test1()
        {
            /*
            
             2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
             
             */

            var sut = new E5Smallestmultiple();

            var min = sut.SmallestNumberDividedByAllNumbers(10);
            Assert.Equal(2520, min);

        }

        [Fact]
        public void Solution()
        {
            /*
            
            What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
            */


            var sut = new E5Smallestmultiple();

            var min = sut.SmallestNumberDividedByAllNumbers(20);
            Assert.Equal(232792560, min);
            /*
                     Congratulations, the answer you gave to problem 5 is correct.

                    You are the 428935th person to have solved this problem.
            */

        }
    }
}
