using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E039IntegerrighttrianglesUnitTest
    {
     
        [Fact]
        public void Test1()
        {
            /*
             If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.

                {20,48,52}, {24,45,51}, {30,40,50}
            */

            var sut = new E039Integerrighttriangles();
            Assert.Equal(3,sut.GetNumberOfsolutions(120));

        }


        [Fact]
        public void Solution()
        {
            /*
                For which value of p ≤ 1000, is the number of solutions maximised?          
            */

            var sut = new E039Integerrighttriangles();
            Assert.Equal(840, sut.GetPerimeterWitMaxNumberOfsolutions(below:1001));

            /*
               Congratulations, the answer you gave to problem 39 is correct.

            You are the 64368th person to have solved this problem.
            */
        }
    }

    
}
