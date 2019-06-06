using jae.euler.lib;
using Xunit;

namespace jae.euler.test.level04
{
    public class E087PrimePowerTriplesUnitTest
    {

        [Theory]
        [InlineData(29, 1)]
        [InlineData(34, 2)]
        [InlineData(48, 3)]
        [InlineData(50, 4)]
        public void Test_1(int below, int expectedCount)
        {
            var sut = new E087PrimePowerTriples();
            Assert.Equal(expectedCount, sut.GetCount(below));
        }


        [Fact]
        public void Solution()
        {
            /*
               How many numbers below fifty million
               can be expressed as the sum of a prime square, prime cube, and prime fourth power?
            */

            var sut = new E087PrimePowerTriples();
            Assert.Equal(1097343, sut.GetCount(below: 50000000));

            /*
                Congratulations, the answer you gave to problem 87 is correct.
                You are the 18246th person to have solved this problem.
                This problem had a difficulty rating of 20%.
            */
        }
    }
}
