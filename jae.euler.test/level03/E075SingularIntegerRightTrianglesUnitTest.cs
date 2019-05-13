using jae.euler.lib;
using Xunit;

namespace jae.euler.test.level03
{
    public class E075SingularIntegerRightTrianglesUnitTest
    {
        [Fact]
        public void Test_48()
        {
            /* 12,24,30,36,40,48 */
            var sut = new E075SingularIntegerRightTriangles(1000);
            Assert.Equal(6, sut.GetNumberWithOneIntegerRightTriangles(maxLengde: 50));
        } 

        [Fact]
        public void Solution()
        {
            /*
          Given that L is the length of the wire, for how many values of L ≤ 1,500,000 can exactly one integer sided right angle triangle be formed?
            */

            var sut = new E075SingularIntegerRightTriangles(1000);
            Assert.Equal(161667, sut.GetNumberWithOneIntegerRightTriangles(maxLengde: 1500000));

            /*
             Congratulations, the answer you gave to problem 75 is correct.
             You are the 15476th person to have solved this problem.
             This problem had a difficulty rating of 25%. 
            */
        }
    }
}
