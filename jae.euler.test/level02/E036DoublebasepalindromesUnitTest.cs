using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test.level02
{
    public class E036DoublebasepalindromesUnitTest
    {
        /*
             The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.         
        */

        [Fact]
        public void Solution()
        {
            /*
              Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2. 
            */

            var sut = new E036Doublebasepalindromes();
            Assert.Equal(872187, sut.GetSumOfPalindromicBothBases(below:1000000));

            /*
                Congratulations, the answer you gave to problem 36 is correct.
                You are the 78908th person to have solved this problem.
            */
        }
    }

    
}
