using jae.euler.lib;
using System.Text.RegularExpressions;
using Xunit;

namespace jae.euler.test.level15
{
    public class E357PrimeGeneratingIntegersUnitTest
    {

        [Theory]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(22)]
        [InlineData(30)]
        [InlineData(42)]
        [InlineData(210)] //7
        [InlineData(2310)] //11
        [InlineData(30030)] //13


        [InlineData(1282)]
        public void Test_ISPrimeGenerating(int number)
        {
            var sut = new E357PrimeGeneratingIntegers(Max: number+1);
            Assert.True(sut.IsPrimeGenerating(number));

        }

        [Theory]
        [InlineData(8)]
        [InlineData(14)]
        [InlineData(26)]
        public void Test_IsNotPrimeGenerating(int number)
        {
            var sut = new E357PrimeGeneratingIntegers(Max: number + 1);
            Assert.False(sut.IsPrimeGenerating(number));

        }


        [Fact]
        public void Test_30Max()
        {
            var sut = new E357PrimeGeneratingIntegers(Max: 30);
            Assert.Equal(38, sut.GetSumOfAllPositiveIntegers());

        }



        [Fact]
        public void Solution()
        {
            /*
              Find the sum of all positive integers n not exceeding 100 000 000
                such that for every divisor d of n, d+n/d is prime.
            */

            var sut = new E357PrimeGeneratingIntegers(Max: 30000000);
            Assert.Equal(-1, sut.GetSumOfAllPositiveIntegers());

            /*
           

            */
        }
    }
}
