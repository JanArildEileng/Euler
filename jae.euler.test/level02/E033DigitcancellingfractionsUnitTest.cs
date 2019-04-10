using jae.euler.lib;
using Xunit;
using jae.euler.math;
using jae.euler.util;

namespace jae.euler.test.level02
{
    public class E033DigitcancellingfractionsUnitTes
    {
        /*
        The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.
        We shall consider fractions like, 30/50 = 3/5, to be trivial examples.
        There are exactly four non-trivial examples of this type of fraction, 
        less than one in value, and containing two digits in the numerator and denominator.

      */


        // [Fact]
        public void Test1()
        {
        }

        [Fact]
        public void Solution()
        {
            /*
              If the product of these four fractions is given in its lowest common terms, find the value of the denominator.
             */

            var sut = new E033Digitcancellingfractions();
            var result = sut.GeLowestCommonTerms();
            Assert.Equal(100, result);
            /*
                Congratulations, the answer you gave to problem 33 is correct.

                You are the 63134th person to have solved this problem.
            */
        }
    }

   
}
