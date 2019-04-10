using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test.level02
{
    public class E040ChampernowneconstantUnitTest
    {
     
        [Fact]
        public void Test1()
        {
            /*
               An irrational decimal fraction is created by concatenating the positive integers:
               0.123456789101112131415161718192021...
               It can be seen that the 12th digit of the fractional part is 1.
            */

            var sut = new E040Champernowneconstant(20);
            Assert.Equal(1,sut.GetDigitNumber(12));
            Assert.Equal(4, sut.GetDigitNumber(19));


        }


        [Fact]
        public void Solution()
        {
            /*
              d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000       
            */

            var sut = new E040Champernowneconstant(1000000);
            Assert.Equal(210, sut.GetDigitNumberProduct());


            /*
              Congratulations, the answer you gave to problem 40 is correct.

             */
        }
    }

    
}
