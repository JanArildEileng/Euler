using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E021AmicablenumbersUnitTest
    {

        [Fact]
        public void TestIsAmicablenumbers()
        {
            /*
              For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110;
              therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.   
            */
            Assert.True(AmicableNumbers.IsAmicablenumbers(220));
            Assert.True(AmicableNumbers.IsAmicablenumbers(284));
            Assert.False(AmicableNumbers.IsAmicablenumbers(100));
            Assert.False(AmicableNumbers.IsAmicablenumbers(28));
        }

        [Fact]
        public void Solution()
        {
            /*
              Evaluate the sum of all the amicable numbers under 10000.
            */

            var sut = new E021Amicablenumbers();
            int sumOfAmicablenumbersExpected = 31626;
            int sumOfAmicablenumbers = sut.GetSumOfAmicablenumbers(from:1,to: 10000);
            Assert.Equal(sumOfAmicablenumbersExpected, sumOfAmicablenumbers);

            /*
              Congratulations, the answer you gave to problem 21 is correct.

            You are the 128981st person to have solved this problem.
            */
        }
    }
}
