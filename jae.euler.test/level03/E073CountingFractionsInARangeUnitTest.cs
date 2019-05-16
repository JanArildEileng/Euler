using jae.euler.lib;
using Xunit;

namespace jae.euler.test.level03
{
    public class E073CountingFractionsInARangeUnitTest
    {

        [Fact]
        public void Test_1()
        {
            /*
               If we list the set of reduced proper fractions for d ≤ 8 in ascending order of size, we get:
               1/8, 1/7, 1/6, 1/5, 1/4, 2/7, 1/3, 3/8, 2/5, 3/7, 1/2, 4/7, 3/5, 5/8, 2/3, 5/7, 3/4, 4/5, 5/6, 6/7, 7/8
               It can be seen that there are 3 fractions between 1/3 and 1/2.             
             */

            var sut = new E073CountingFractionsInARange();
            Assert.Equal(3, sut.GetNumberOfFractionsBetween(denominatorMax: 8, leftNumerator: 1, leftDenominator: 3, rightNumerator: 1, rightDenominator: 2));
        }

        [Fact]
        public void Solution()
        {
            /*
               How many fractions lie between 1/3 and 1/2 
               in the sorted set of reduced proper fractions for d ≤ 12,000?
            */

            var sut = new E073CountingFractionsInARange();
            Assert.Equal(7295372, sut.GetNumberOfFractionsBetween(denominatorMax: 12000, leftNumerator: 1, leftDenominator: 3, rightNumerator: 1, rightDenominator: 2));

            /*
              Congratulations, the answer you gave to problem 73 is correct.
              You are the 21983rd person to have solved this problem.
              Nice work, janei, you've just advanced to Level 3 . 
              21724 members (2.39%) have made it this far.
            */
        }
    }
}
