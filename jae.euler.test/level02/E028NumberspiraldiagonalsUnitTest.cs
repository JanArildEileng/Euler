using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test.level02
{
    public class E028NumberspiraldiagonalsUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
             Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:
             It can be verified that the sum of the numbers on the diagonals is 101.
            */

            var sut = new E028Numberspiraldiagonals();

            Assert.Equal(101, sut.GetSumDiagonal(size:5));          
        }

        [Fact]
        public void Solution()
        {
            /*
                 What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
             */

            var sut = new E028Numberspiraldiagonals();

            Assert.Equal(669171001, sut.GetSumDiagonal(size: 1001));

            /*
                Congratulations, the answer you gave to problem 28 is correct.
                You are the 96428th person to have solved this problem.
            */
        }
    }
}
