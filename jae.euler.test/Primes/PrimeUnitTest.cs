using jae.euler.lib.Palindrome;
using jae.euler.lib.Primes;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace jae.euler.test.Primes
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
            List<long> list = PrimeList.GetList(value);

            Assert.Equal(len, list.Count);
        }

        
    }
}
