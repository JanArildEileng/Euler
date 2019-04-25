using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;

namespace jae.euler.test.level03
{
    public class E055LychrelNumbersUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
            */
            var sut = new E055LychrelNumbers();
            Assert.False(sut.IsLychrelNumber(47));
            Assert.False(sut.IsLychrelNumber(349));
            Assert.True(sut.IsLychrelNumber(196));
        }

   

    



        [Fact]
        public void Solution()
        {
            /*
            How many Lychrel numbers are there below ten-thousand?          
        */

            var sut = new E055LychrelNumbers();
            Assert.Equal(249, sut.GetNumberOfLychrelNumber(below: 10000));



            /*
               Congratulations, the answer you gave to problem 55 is correct.

                You are the 47500th person to have solved this problem.
            */
        }
    }


}
