using jae.euler.lib;
using System.Text.RegularExpressions;
using Xunit;

namespace jae.euler.test.level06
{
    public class E145ReversibleNumbersUnitTest
    {

       



        [Fact]
        public void Test_1()
        {
            var sut = new E145ReversibleNumbers();
            Assert.Equal(120, sut.GetBelow(1000));
        }

      


        [Fact]
        public void Solution()
        {
            /*
            How many reversible numbers are there below one-billion (109)?
               
            */

            var sut = new E145ReversibleNumbers();
            Assert.Equal(608720, sut.GetBelow(1000000000));

            /*
            Congratulations, the answer you gave to problem 145 is correct.
            You are the 14660th person to have solved this problem.
            This problem had a difficulty rating of 20%.
             
            */
        }
    }
}
