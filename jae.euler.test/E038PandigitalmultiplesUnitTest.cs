using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E038PandigitalmultiplesUnitTest
    {
     
        [Fact]
        public void Test1()
        {
            /*
              Take the number 192 and multiply it by each of 1, 2, and 3:

            192 × 1 = 192
            192 × 2 = 384
            192 × 3 = 576
            By concatenating each product we get the 1 to 9 pandigital, 192384576. We will call 192384576 the concatenated product of 192 and (1,2,3)

            The same can be achieved by starting with 9 and multiplying by 1, 2, 3, 4, and 5, giving the pandigital, 918273645, which is the concatenated product of 9 and (1,2,3,4,5).

            */

            var sut = new E038Pandigitalmultiples();
            Assert.True(sut.HasPandigital9DigitNumberProduct(9)>0);
            Assert.True(sut.HasPandigital9DigitNumberProduct(192)>0);
            Assert.False(sut.HasPandigital9DigitNumberProduct(193)>0);
        }


        [Fact]
        public void Solution()
        {
            /*
              What is the largest 1 to 9 pandigital 9-digit number that can be formed as the concatenated product of an integer with (1,2, ... , n) where n > 1?
            */

            var sut = new E038Pandigitalmultiples();
            Assert.Equal(932718654, sut.LargestPandigital9DigitNumber());

            /*
                Congratulations, the answer you gave to problem 38 is correct.

                You are the 55311th person to have solved this problem.
            */
        }
    }

    
}
