using jae.euler.lib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace jae.euler.test.level04
{
    public class E080SquareRootDigitalExpansionUnitTest
    {
        //løst vha:
        // https://www.mathblog.dk/project-euler-80-digits-irrational-square-roots/


        [Fact]
        public void Test_1()
        {
            /*
             * The square root of two is 1.41421356237309504880...,
             * and the digital sum of the first one hundred decimal digits is 475.
             */

              var sut = new E080SquareRootDigitalExpansion();
              Assert.Equal(475, sut.GetDigitalSumSquareRoot(2));
          }



          [Fact]
          public void Solution()
          {
              /*For the first one hundred natural numbers,
               * find the total of the digital sums of the first one hundred decimal digits 
               * for all the irrational square roots.
              */

            var sut = new E080SquareRootDigitalExpansion();
            Assert.Equal(40886, sut.GetDigitalSumSquareRootAll());

            /*
                Congratulations, the answer you gave to problem 80 is correct.
                You are the 17365th person to have solved this problem.
                This problem had a difficulty rating of 20%. 
            */
        }
    }
}
