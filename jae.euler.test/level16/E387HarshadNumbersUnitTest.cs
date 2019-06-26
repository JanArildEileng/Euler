using jae.euler.lib;
using Xunit;

namespace jae.euler.test.level16
{
    public class E387HarshadNumbersUnitTest
    {

        [Theory]
        [InlineData(2011)]
        public void Test_StrongRightTruncatableHarshadPrimes(long number)
        {
            var sut = new E387HarshadNumbers();      
            Assert.True(sut.IsStrongRightTruncatableHarshadPrimes(number));
        }

        [Fact]
        public void Test_1()
        {

            long max = 4;
            var sut = new E387HarshadNumbers();
            Assert.Equal(90619, sut.SumOfStrongRightTruncatableHarshadPrimes(max));

        }


        [Fact]
        public void Solution()
        {
            /*
                Find the sum of the strong, right truncatable Harshad primes less than 10^14.
            */

            long max = 14;

            var sut = new E387HarshadNumbers();
            Assert.Equal(696067597313468, sut.SumOfStrongRightTruncatableHarshadPrimes(max));

            /*
                Congratulations, the answer you gave to problem 387 is correct.
                You are the 3823rd person to have solved this problem.
                This problem had a difficulty rating of 10%.

            */
        }
    }
}
