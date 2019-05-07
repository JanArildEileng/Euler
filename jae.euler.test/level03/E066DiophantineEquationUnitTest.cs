using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

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
            Assert.Equal(1766319049, sut.GetXInMinimumSolution(D: 61));
            Assert.Equal(16916040084175685, sut.GetXInMinimumSolution(D: 454));
            //  9000987377460935993101449 821
            //16421658242965910275055840472270471049   661

      

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
            Find the value of D ≤ 1000 in minimal solutions of x for which the largest value of x is obtained.
            */

            var sut = new E066DiophantineEquation();
            Assert.Equal(661, sut.GetDFromLargestXInMinimumSolution(DMax:1000));

            /*
             Congratulations, the answer you gave to problem 66 is correct.

            You are the 16951st person to have solved this problem.

            This problem had a difficulty rating of 25%. The highest difficulty rating you had previously solved was 20%
            */
        }
    }
}
