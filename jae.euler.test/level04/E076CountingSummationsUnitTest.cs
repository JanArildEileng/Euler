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


        }


        [Fact]
        public void Solution()
        {
            /*
                 How many different ways can one hundred be written as a sum of at least two positive integers?     
                 
            */

             var sut = new E076CountingSummations();
             Assert.Equal(6, sut.GetNumberOfDifferentWays(sum: 100));

            /*
       
            */
        }
    }
}
