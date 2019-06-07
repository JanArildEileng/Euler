using jae.euler.lib;
using Xunit;

namespace jae.euler.test.level09
{
    public class E206ConcealedSquareUnitTest
    {

        //[Theory]
        //[InlineData(29, 1)]
        //[InlineData(34, 2)]
        //[InlineData(48, 3)]
        //[InlineData(50, 4)]
        //public void Test_1(int below, int expectedCount)
        //{
        //    var sut = new E206ConcealedSquare();
        
        //}


        [Fact]
        public void Solution()
        {
            /*
               Find the unique positive integer whose square has the form 1_2_3_4_5_6_7_8_9_0,
                where each “_” is a single digit.
            */

            var sut = new E206ConcealedSquare();
            Assert.Equal(-1, sut.Square());

            /*
             * 
            */
        }
    }
}
