using jae.euler.lib;
using System.Text.RegularExpressions;
using Xunit;

namespace jae.euler.test.level05
{
    public class E112BouncyNumbersUnitTest
    {

        [Theory]
        [InlineData(123456789,false)]
        [InlineData(98765431, false)]
        [InlineData(152852, true)]
        public void Test_IsBounching(int number,bool bounching)
        {
            var sut = new E112BouncyNumbers();
            Assert.Equal(bounching, sut.IsBounching(number));
        }




        [Fact]
        public void Test_Proportion_50()
        {
            var sut = new E112BouncyNumbers();
            Assert.Equal(538, sut.GetLeastNumber(proportion: 50));
        }

        [Fact]
        public void Test_Proportion_90()
        {
            var sut = new E112BouncyNumbers();
            Assert.Equal(21780, sut.GetLeastNumber(proportion: 90));
        }


        [Fact]
        public void Solution()
        {
            /*
             * Find the least number for which the proportion of bouncy numbers is exactly 99%.
               
            */

            var sut = new E112BouncyNumbers();
            Assert.Equal(1587000, sut.GetLeastNumber(proportion:99));

            /*
              Congratulations, the answer you gave to problem 112 is correct.
              You are the 21723rd person to have solved this problem.
              This problem had a difficulty rating of 15%.
             
            */
        }
    }
}
