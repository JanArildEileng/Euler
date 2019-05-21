using jae.euler.lib;
using Xunit;

namespace jae.euler.test.level04
{
    public class E077PrimeSummationsUnitTest
    {
        /* 
                 It is possible to write ten as the sum of primes in exactly five different ways:
                   7 + 3
                   5 + 5
                   5 + 3 + 2
                   3 + 3 + 2 + 2
                   2 + 2 + 2 + 2 + 2
        */

        [Theory]
        [InlineData(5,1)]
        [InlineData(6, 2)]
        [InlineData(7, 2)]
        [InlineData(8, 3)]
        [InlineData(9, 4)]
        [InlineData(10, 5)]
        [InlineData(13, 7)]
        public void Test_0(int number, int expectedResult)
        {
            
            var sut = new E077PrimeSummations(number);
            Assert.Equal(expectedResult, sut.GetNumberOfDifferentWays(number, maxPrime: 10));
         }   

        [Fact]
        public void Test_1()
        {          
            var sut = new E077PrimeSummations(100);
            Assert.Equal(5006, sut.GetNumberOfDifferentWays(71,maxPrime:100));
        }


        [Fact]
        public void Solution()
        {
            /*
                What is the first value which can be written as the sum of primes in over five thousand different ways?     
            */

             var sut = new E077PrimeSummations(200);
             Assert.Equal(71, sut.GetFirstNumberWithMoreThanPrimeSummations(5000));

            /*
                Congratulations, the answer you gave to problem 77 is correct.
                You are the 16527th person to have solved this problem.
                This problem had a difficulty rating of 25%.
            */
        }
    }
}
