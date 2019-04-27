using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;

namespace jae.euler.test.level03
{
    public class E058SpiralPrimesUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
             Starting with 1 and spiralling anticlockwise in the following way, a square spiral with side length 7 is formed.

37 36 35 34 33 32 31
38 17 16 15 14 13 30
39 18  5  4  3 12 29
40 19  6  1  2 11 28
41 20  7  8  9 10 27
42 21 22 23 24 25 26
43 44 45 46 47 48 49

 but what is more interesting is that 8 out of the 13 numbers lying along both diagonals are prime;
 that is, a ratio of 8/13 ≈ 62%.
              
            */
            var sut = new E058SpiralPrimes(100);

            var ratio = sut.GetRatio(sidelength: 7);
            Assert.Equal(8, ratio.Numerator);
            Assert.Equal(13, ratio.Denominator);

        }





        [Fact]
        public void Solution()
        {
            /*
              what is the side length of the square spiral for 
               which the ratio of primes along both diagonals first falls below 10%?
            */

            var sut = new E058SpiralPrimes(100000);

            Assert.Equal(26241, sut.GetLengthWhereRationBelow(percent:10));

            /*
               Congratulations, the answer you gave to problem 58 is correct.

                You are the 35111th person to have solved this problem.
            */
        }
    }


}
