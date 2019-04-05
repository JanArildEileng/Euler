using jae.euler.math;
using System.Collections.Generic;
using Xunit;


namespace jae.euler.test.PrimesTest
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

        
    }
}
