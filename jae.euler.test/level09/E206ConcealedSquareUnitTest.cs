using jae.euler.lib;
using System.Text.RegularExpressions;
using Xunit;

namespace jae.euler.test.level09
{
    public class E206ConcealedSquareUnitTest
    {
        [Fact]
        public void Test_Regex()
        {
            Regex regex = new Regex(@"1\d{1}2\d{1}3\d{1}4\d{1}5\d{1}6\d{1}7\d{1}8\d{1}9\d{1}0");
            Assert.Matches(regex, "1020304050607080900");
        }
     

        [Fact]
        public void Solution()
        {
            /*
               Find the unique positive integer whose square has the form 1_2_3_4_5_6_7_8_9_0,
                where each “_” is a single digit.
            */

            var sut = new E206ConcealedSquare();
            Assert.Equal(1389019170, sut.Square());

            /*
             Congratulations, the answer you gave to problem 206 is correct.
             You are the 21334th person to have solved this problem.
             This problem had a difficulty rating of 5%.
            */
        }
    }
}
