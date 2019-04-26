using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;

namespace jae.euler.test.level03
{
    public class E057SquareRootConvergentsUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
                1 + 1/2 = 3/2 = 1.5
                1 + 1/(2 + 1/2) = 7/5 = 1.4
                1 + 1/(2 + 1/(2 + 1/2)) = 17/12 = 1.41666...
                1 + 1/(2 + 1/(2 + 1/(2 + 1/2))) = 41/29 = 1.41379...
              
            */
            var sut = new E057SquareRootConvergents();

            Fraction r = sut.GetSquareRootConvergents(iterationNumber: 1);
            Assert.Equal(3, r.Numerator);
            Assert.Equal(2, r.Denominator);

            r = sut.GetSquareRootConvergents(iterationNumber: 2);
            Assert.Equal(7, r.Numerator);
            Assert.Equal(5, r.Denominator);

            r = sut.GetSquareRootConvergents(iterationNumber: 3);
            Assert.Equal(17, r.Numerator);
            Assert.Equal(12, r.Denominator);

            r = sut.GetSquareRootConvergents(iterationNumber: 4);
            Assert.Equal(41, r.Numerator);
            Assert.Equal(29, r.Denominator);

            r = sut.GetSquareRootConvergents(iterationNumber: 5);
            Assert.Equal(99, r.Numerator);
            Assert.Equal(70, r.Denominator);

            r = sut.GetSquareRootConvergents(iterationNumber: 6);
            Assert.Equal(239, r.Numerator);
            Assert.Equal(169, r.Denominator);

            r = sut.GetSquareRootConvergents(iterationNumber: 7);
            Assert.Equal(577, r.Numerator);
            Assert.Equal(408, r.Denominator);

            r = sut.GetSquareRootConvergents(iterationNumber: 8);
            Assert.Equal(1393, r.Numerator);
            Assert.Equal(985, r.Denominator);


        }



        [Fact]
        public void Test2()
        {
            /*
            * the eighth expansion, 1393/985,
              is the first example where the number of digits in the numerator exceeds the number of digits in the denominator..
              
            */
            var sut = new E057SquareRootConvergents();

            Assert.True(sut.NumeratorHasMoreDigitsThanDenominator(iterationNumber: 8));
            Assert.False(sut.NumeratorHasMoreDigitsThanDenominator(iterationNumber: 7));
            Assert.False(sut.NumeratorHasMoreDigitsThanDenominator(iterationNumber: 9));


        }




        [Fact]
        public void Solution()
        {
            /*
           In the first one-thousand expansions, how many fractions contain a numerator with more digits than denominator?
            */

            var sut = new E057SquareRootConvergents();
            Assert.Equal(153, sut.GetNumeratorWithMoreDigitsThanDenominator(upto: 1000));



            /*
               Congratulations, the answer you gave to problem 57 is correct.

            You are the 36239th person to have solved this problem.
            */
        }
    }


}
