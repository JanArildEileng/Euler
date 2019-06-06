using jae.euler.lib;
using Xunit;

namespace jae.euler.test.level04
{
    public class E085CountingRectanglesUnitTest
    {
          
        [Fact]
        public void Test_1()
        {
            /*
             it can be seen that a rectangular grid measuring 3 by 2 contains eighteen rectangles:
            */
            var sut = new E085CountingRectangles();
            Assert.Equal(18, sut.GetContainingRectangels(3,2));
        }

        [Fact]
        public void Test_2()
        {
            var sut = new E085CountingRectangles();
            Assert.Equal(19936225, sut.GetContainingRectangels(94, 94));
            Assert.Equal(20360400, sut.GetContainingRectangels(95, 94));       
        }

        [Fact]
        public void Solution()
        {
            /*
              Although there exists no rectangular grid that contains exactly two million rectangles,
              find the area of the grid with the nearest solution.
            */


            var sut = new E085CountingRectangles();
            Assert.Equal(2772, sut.GetAreaNearestSolution());

            /*
              Congratulations, the answer you gave to problem 85 is correct.
              You are the 21760th person to have solved this problem.
              This problem had a difficulty rating of 15%. 
            */
        }
    }
}
