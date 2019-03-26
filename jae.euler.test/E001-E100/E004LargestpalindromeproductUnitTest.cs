using jae.euler.lib;
using System;
using Xunit;

namespace jae.euler.test
{
    public class E004LargestpalindromeproductUnitTest
    {
        [Fact]
        public void Test1()
        {
            /*
            A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
            */

            int below = 100 * 100;

            var sut = new E004Largestpalindromeproduct();

            var max = sut.Largest(below,100);
            Assert.Equal(9009, max);

        }

        [Fact]
        public void Solution()
        {
            /*
                Find the largest palindrome made from the product of two 3-digit numbers.
            */

            int below = 1000 * 1000;
            var sut = new E004Largestpalindromeproduct();

            var max = sut.Largest(below,1000);
            Assert.Equal(906609, max);
            /*
                      Congratulations, the answer you gave to problem 4 is correct.
                        You are the 422082nd person to have solved this problem.
            */

        }
    }
}
