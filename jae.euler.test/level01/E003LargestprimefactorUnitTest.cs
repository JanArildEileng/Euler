using jae.euler.lib;
using System;
using Xunit;

namespace jae.euler.test.level01
{
    public class E003LargestprimefactorUnitTest
    {
        [Theory]
        [InlineData(3,3)]
        [InlineData(5, 5)]
        [InlineData(10, 5)]
        // The prime factors of 13195 are 5, 7, 13 and 29.
        [InlineData(13195, 29)]
        public void Test1(long number,long expectedlargestPrime)
        {
            var sut = new E003Largestprimefactor();

            var largestPrim = sut.Largest(number);
            Assert.Equal(expectedlargestPrime, largestPrim);
        }

        [Fact]
        public void Solution()
        {
            var sut = new E003Largestprimefactor();

            var max = sut.Largest(600851475143);
            Assert.Equal(6857, max);
/*
            Congratulations, the answer you gave to problem 3 is correct.

            You are the 476200th person to have solved this problem.
*/

        }


    }
}
