using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace jae.euler.test.level03
{
    public class E066DiophantineEquationUnitTest
    {
        [Fact]
        public void Test_MinimalSolution()
        {
            /*
                For example, when D=13, the minimal solution in x is 649^2 – 13×180^2 = 1.           
             * 
               */
            var sut = new E066DiophantineEquation();
            Assert.Equal(649, sut.GetXInMinimumSolution(D:13));

            Assert.Equal(31, sut.GetXInMinimumSolution(D: 60));
            Assert.Equal(649, sut.GetXInMinimumSolution(D: 61));


        }


        [Fact]
        public void Test_FindLargestXMinimalSolution()
        {
            /*
                  minimal solutions in x for D ≤ 7, the largest x is obtained when D=5.         
             * 
               */
            var sut = new E066DiophantineEquation();
            Assert.Equal(5, sut.GetDFromLargestXInMinimumSolution(DMax:7));
        }



      



        [Fact]
        public void Solution()
        {
            /*
            Find the smallest cube for which exactly five permutations of its digits are cube.
            */

            var sut = new E066DiophantineEquation();
            Assert.Equal(1, sut.GetDFromLargestXInMinimumSolution(DMax:1000));

            /*
              Congratulations, the answer you gave to problem 62 is correct.

             You are the 27159th person to have solved this problem.
            */
        }
    }
}
