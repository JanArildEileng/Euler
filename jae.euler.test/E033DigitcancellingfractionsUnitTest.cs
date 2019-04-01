using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E033DigitcancellingfractionsUnitTes
    {

        [Fact]
        public void Test1()
        {
            /*
              The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.
              We shall consider fractions like, 30/50 = 3/5, to be trivial examples.
              There are exactly four non-trivial examples of this type of fraction, 
              less than one in value, and containing two digits in the numerator and denominator.

            */

            var sut = new E033Digitcancellingfractions();


            Assert.Equal(1,sut.LowestCommonTerms(2,3));
            Assert.Equal(6, sut.LowestCommonTerms(2, 6));
            Assert.Equal(18, sut.LowestCommonTerms(6, 9));




            Assert.True(sut.IsDigitcancellingfractions(numerator: 49, denominator: 98));
            Assert.False(sut.IsDigitcancellingfractions(numerator: 48, denominator: 84));


        }

        [Fact]
        public void Solution()
        {
            /*
              If the product of these four fractions is given in its lowest common terms, find the value of the denominator.

             */

            var sut = new E033Digitcancellingfractions();
            var result = sut.GeLowestCommonTerms();
            Assert.Equal(1, result);
            /*
              Congratulations, the answer you gave to problem 32 is correct.
              you are the 62497th person to have solved this problem.
            */
        }
    }

   
}
