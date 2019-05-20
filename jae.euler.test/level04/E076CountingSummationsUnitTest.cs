using jae.euler.lib;
using Xunit;

namespace jae.euler.test.level04
{
    public class E076CountingSummationsUnitTest
    {
        [Fact]
        public void Test_0()
        {
            /* It is possible to write five as a sum in exactly six different ways:

            4 + 1
            3 + 2
            3 + 1 + 1
            2 + 2 + 1
            2 + 1 + 1 + 1
            1 + 1 + 1 + 1 + 1 

             */
            var sut = new E076CountingSummations();
            Assert.Equal(6, sut.GetNumberOfDifferentWays(sum: 5));
            Assert.Equal(10, sut.GetNumberOfDifferentWays(sum: 6));
            Assert.Equal(14, sut.GetNumberOfDifferentWays(sum: 7));
            Assert.Equal(21, sut.GetNumberOfDifferentWays(sum: 8));

        }


        [Fact]
        public void Solution()
        {
            /*
                 How many different ways can one hundred be written as a sum of at least two positive integers?     
                 
            */

             var sut = new E076CountingSummations();
             Assert.Equal(190569291, sut.GetNumberOfDifferentWays(sum: 100));

            /*
            Congratulations, the answer you gave to problem 76 is correct.
            You are the 25052nd person to have solved this problem.
            This problem had a difficulty rating of 10%
            */
        }
    }
}
