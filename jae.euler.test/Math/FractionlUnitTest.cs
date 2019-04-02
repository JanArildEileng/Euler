using jae.euler.lib.Palindrome;
using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace jae.euler.test.math
{
    public class FractionlUnitTest
    {

        [Theory]
       
        [InlineData(2, 4,1,2)]
        [InlineData(26, 65, 2, 5)]
        public void TestReduceFraction(int numerator, int denominator, int expectedNumerator, int expectedDenominator)
        {
            var fracttion = Fraction.ReduceFraction(new Fraction { Numerator = numerator, Denominator = denominator });
            Assert.Equal(expectedNumerator, fracttion.Numerator);
            Assert.Equal(expectedDenominator, fracttion.Denominator);
        }

        [Fact]
        public void TestProduct()
        {
            List<Fraction> denominatorListe = new List<Fraction>
            {
                 new Fraction { Numerator = 16, Denominator = 64 },
                 new Fraction { Numerator = 26, Denominator = 65 },
                 new Fraction { Numerator = 19, Denominator = 95 },
                 new Fraction { Numerator = 49, Denominator = 98 }
            };

            var fraction = Fraction.Product(denominatorListe);
            Assert.Equal(1, fraction.Numerator);
            Assert.Equal(100, fraction.Denominator);
        }


        [Theory]
        [InlineData(2, 4, 1, 2, true)]
        [InlineData(26, 65, 2, 5,true)]
        [InlineData(5, 13, 2, 7, false)]
        public void TestIsReducedForm(int numerator, int denominator, int reducedNumerator, int reducedDenominator, bool IsReducedForm)
        {
            var fracttion =new Fraction { Numerator = numerator, Denominator = denominator };
            var fracttionReduced = new Fraction { Numerator = reducedNumerator, Denominator = reducedDenominator };
            Assert.Equal(IsReducedForm, fracttion.IsReducedForm(fracttionReduced));
        }


    }
}
