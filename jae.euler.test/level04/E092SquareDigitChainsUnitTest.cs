using jae.euler.lib;
using Xunit;

namespace jae.euler.test.level04
{
    public class E092SquareDigitChainsUnitTest
    {
        [Fact]
        public void Test_IsArrivaingAt()
        {
         
            var sut = new E092SquareDigitChains();

            Assert.False(sut.IsArrivingAt(44, 89));
            Assert.True(sut.IsArrivingAt(85, 89));

        }


        [Fact]
        public void Solution()
        {
            /*
                    How many starting numbers below ten million will arrive at 89?                 
            */

            var sut = new E092SquareDigitChains();
             Assert.Equal(8581146, sut.GetCount(below: 10000000, arrivat:89));

            /*
               Congratulations, the answer you gave to problem 92 is correct.
                You are the 37168th person to have solved this problem.
                This problem had a difficulty rating of 5%.
            */
        }
    }
}
