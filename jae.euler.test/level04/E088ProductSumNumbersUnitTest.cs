using jae.euler.lib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace jae.euler.test.level04
{
    public class E088ProductSumNumbersUnitTest
    {

        /*
            k=2: 4 = 2 × 2 = 2 + 2
            k=3: 6 = 1 × 2 × 3 = 1 + 2 + 3
            k=4: 8 = 1 × 1 × 2 × 4 = 1 + 1 + 2 + 4
            k=5: 8 = 1 × 1 × 2 × 2 × 2 = 1 + 1 + 2 + 2 + 2
            k=6: 12 = 1 × 1 × 1 × 1 × 2 × 6 = 1 + 1 + 1 + 1 + 2 + 6
        */

        [Theory]
        [InlineData(2,4)]
        [InlineData(3, 6)]
        [InlineData(4, 8)]
        [InlineData(5, 8)]
        [InlineData(6, 12)]
        public void Test_GetMinimalProduct(int k, int expectedMinimalProductSum)
        {
            var sut = new E088ProductSumNumbers();
            Assert.Equal(expectedMinimalProductSum, sut.GetMinimalProduct(k: k));
        }



        [Theory]
        [InlineData(130, 4)]
        //[InlineData(200, 6)]
        //[InlineData(400, 8)]
        public void Test_GetMinimalProductMany(int k, int expectedMinimalProductSum)
        {
            var sut = new E088ProductSumNumbers();
            Assert.Equal(expectedMinimalProductSum, sut.GetMinimalProduct(k: k));
        }






        /*
          Hence for 2≤k≤6, the sum of all the minimal product-sum numbers is 4+6+8+12 = 30
          for 2≤k≤12 is { 4, 6, 8, 12, 15, 16 } , the sum is 61.

        */




        [Theory]
        [InlineData(6,30)]
     //   [InlineData(12, 61)]
        public void Test_GetMinimalProductSum(int k, int expectedMinimalProductSum)
        {
            var sut = new E088ProductSumNumbers();
            Assert.Equal(expectedMinimalProductSum, sut.GetMinimalProductSum(k: k));
        }


      
        [Fact]
        public void Solution()
        {
            /*
               What is the sum of all the minimal product-sum numbers for 2≤k≤12000?
            */

            var sut = new E088ProductSumNumbers();
            Assert.Equal(-1, sut.GetMinimalProductSum(k: 12000));


            /*
                
            */
        }
    }
}
