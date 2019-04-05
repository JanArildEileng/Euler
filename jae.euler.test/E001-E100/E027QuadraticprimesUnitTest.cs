using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E027QuadraticprimesUnitTest
    {

        [Fact]
        public void TestGetnumberofprimes()
        {
            /*
          The incredible formula n2−79n+1601 was discovered,
          which produces 80 primes for the consecutive values 0≤n≤79. 
          The product of the coefficients, −79 and 1601, is −126479.
            */

            var sut = new E027Quadraticprimes();

            Assert.Equal(40, sut.GetnumberOfPrimes(a: 1, b: 41));
            Assert.Equal(80, sut.GetnumberOfPrimes(a: -79, b: 1601));

        }

        [Fact]
        public void Solution()
        {
            /*
           n2+an+b, where |a|<1000 and |b|≤1000
           Find the product of the coefficients, a and b, for the quadratic expression that produces 
           the maximum number of primes for consecutive values of n, starting with n=0.
             */

            var sut = new E027Quadraticprimes();

            int product = sut.GetproductOfCoefficients();
            Assert.Equal(expected: -59231, actual: product);

            /*
               Congratulations, the answer you gave to problem 27 is correct.

                You are the 76937th person to have solved this problem.
            */
        }
    }
}
