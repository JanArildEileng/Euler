using jae.euler.lib;
using System.Text.RegularExpressions;
using Xunit;

namespace jae.euler.test.level15
{
    public class E357PrimeGeneratingIntegersUnitTest
    {

        [Theory]
        [InlineData(2)]
        [InlineData(6)]
        [InlineData(10)]
        [InlineData(22)]
        [InlineData(30)]
        [InlineData(42)]
        [InlineData(58)]
        [InlineData(70)]
        [InlineData(78)]
        [InlineData(838)]
        [InlineData(862)]
        [InlineData(970)]
        [InlineData(442)]
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
        public void Test_100()
        {
            var sut = new E357PrimeGeneratingIntegers(Max: 100);
            Assert.Equal(400, sut.GetSumOfAllPositiveIntegers_org());

        }
        [Fact]
        public void Test_1000()
        {
            var sut = new E357PrimeGeneratingIntegers(Max: 1000);
            Assert.Equal(8426, sut.GetSumOfAllPositiveIntegers_org());

        }

        [Fact]
        public void Test_10000()
        {
            var sut = new E357PrimeGeneratingIntegers(Max: 10000);
            Assert.Equal(262614, sut.GetSumOfAllPositiveIntegers_org());
        }



        [Fact]
        public void Solution()
        {
            /*
              Find the sum of all positive integers n not exceeding 100 000 000
                such that for every divisor d of n, d+n/d is prime.
            */

            var sut = new E357PrimeGeneratingIntegers(Max: 100000000);
            Assert.Equal(-1, sut.GetSumOfAllPositiveIntegers());

            /*
           

            */
        }
    }
}
