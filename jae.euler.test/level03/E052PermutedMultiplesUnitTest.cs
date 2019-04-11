using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;

namespace jae.euler.test.level03
{
    public class E052PermutedMultiplesUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
                It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.
            */
            var sut = new E052PermutedMultiples();

            Assert.True(sut.IsPermuted(125874, 251748));
            Assert.False(sut.IsPermuted(125875, 251748));

        }


        [Fact]
        public void Solution()
        {
            /*
                Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits. 
            */

            var sut = new E052PermutedMultiples();
            Assert.Equal(142857, sut.GetSmallest6Times());

            /*
              Congratulations, the answer you gave to problem 52 is correct.

                You are the 57656th person to have solved this problem.
             */
        }
    }


}
