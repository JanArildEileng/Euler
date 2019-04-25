using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;

namespace jae.euler.test.level03
{
    public class E056PowerfulDigitSumUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
            */
            var sut = new E056PowerfulDigitSum();
        }

   

    



        [Fact]
        public void Solution()
        {
            /*
            Considering natural numbers of the form, ab, where a, b < 100, what is the maximum digital sum?        
           */

            var sut = new E056PowerfulDigitSum();
            Assert.Equal(972, sut.GetMaximumDigitalSum(abelow: 100,bbelow:100));



            /*
               Congratulations, the answer you gave to problem 56 is correct.

                You are the 51494th person to have solved this problem.
            */
        }
    }


}
