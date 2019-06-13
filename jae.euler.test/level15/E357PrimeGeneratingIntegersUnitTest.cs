using jae.euler.lib;
using System.Text.RegularExpressions;
using Xunit;

namespace jae.euler.test.level15
{
    public class E357PrimeGeneratingIntegersUnitTest
    {
        [Fact]
        public void Test_30IsPrimeGenerating()
        {
            var sut = new E357PrimeGeneratingIntegers(Max: 30);
            Assert.True(sut.IsPrimeGenerating(30));

        }

        [Fact]
        public void Test_30Max()
        {
            var sut = new E357PrimeGeneratingIntegers(Max: 30);
            Assert.Equal(30, sut.GetSumOfAllPositiveIntegers());

        }



        [Fact]
        public void Solution()
        {
            /*
              Find the sum of all positive integers n not exceeding 100 000 000
                such that for every divisor d of n, d+n/d is prime.
            */

            var sut = new E357PrimeGeneratingIntegers(Max: 1000
                00000);
     //       Assert.Equal(-1, sut.GetSumOfAllPositiveIntegers());

            /*
           

            */
        }
    }
}
