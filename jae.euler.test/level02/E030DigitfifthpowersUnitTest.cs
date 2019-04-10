using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test.level02
{
    public class E030DigitfifthpowersUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
            Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:

            1634 = 14 + 64 + 34 + 44
            8208 = 84 + 24 + 04 + 84
            9474 = 94 + 44 + 74 + 44
             As 1 = 14 is not a sum it is not included.

            The sum of these numbers is 1634 + 8208 + 9474 = 19316.         
        */

            var sut = new E030Digitfifthpowers();

            Assert.Equal(19316, sut.GetSumOfPower(po:4));          
        }

        [Fact]
        public void Solution()
        {
            /*
                 ab for 2 ≤ a ≤ 100 and 2 ≤ b ≤ 100?
             */

            var sut = new E030Digitfifthpowers();
            Assert.Equal(443839, sut.GetSumOfPower(po: 5));



            /*
               Congratulations, the answer you gave to problem 30 is correct.

            You are the 97035th person to have solved this problem.
            */
        }
    }
}
