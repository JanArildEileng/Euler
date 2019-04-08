using jae.euler.math;
using System.Collections.Generic;
using Xunit;

namespace jae.euler.test.math
{
    public class PrimeUnitTest
    {

        [Theory]
        [InlineData(2,1)]
        [InlineData(3,1)]
        [InlineData(4,2)]
        [InlineData(2520, 7)]
        public void TestPrimeList(long value,int len)
        {
            List<long> list = Primes.GetPrimeFactorsInNumber(value);

            Assert.Equal(len, list.Count);
        }



        [Theory]
        [InlineData(7)]
        public void TestPrimeIsPrimet(long value)
        {
            List<long> list = Primes.GetPrimeFactorsInNumber(value);

            Assert.True(Primes.IsPrime(value));
        }


        [Theory]
        [InlineData(49)]
        public void TestPrimeIsNotPrimet(long value)
        {
            List<long> list = Primes.GetPrimeFactorsInNumber(value);

            Assert.False(Primes.IsPrime(value));
        }

    }
}
