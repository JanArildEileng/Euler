using jae.euler.lib;
using System;
using Xunit;

namespace jae.euler.test
{
    public class E003LargestprimefactorUnitTest

    {
        [Fact]
        public void Test1()
        {
            // The prime factors of 13195 are 5, 7, 13 and 29.

            var sut = new E3Largestprimefactor();

            var max = sut.Largest(3);
            Assert.Equal(3, max);

            max = sut.Largest(4);
            Assert.Equal(2, max);

            max = sut.Largest(5);
            Assert.Equal(5, max);

            max = sut.Largest(10);
            Assert.Equal(5, max);



            max = sut.Largest(13195);
            Assert.Equal(29, max);


        }

        [Fact]
        public void Solution()
        {
            var sut = new E3Largestprimefactor();

            var max = sut.Largest(600851475143);
            Assert.Equal(6857, max);
/*
            Congratulations, the answer you gave to problem 3 is correct.

            You are the 476200th person to have solved this problem.
*/

        }


    }
}
