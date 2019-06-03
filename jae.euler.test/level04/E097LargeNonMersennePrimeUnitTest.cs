using jae.euler.lib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace jae.euler.test.level04
{
    public class E097LargeNonMersennePrimeUnitTest
    {

      
        [Fact]
        public void Solution()
        {
            /*
              28433×2^7830457+1.
            Find the last ten digits of this prime number.
            */

            var sut = new E097LargeNonMersennePrime();
            Assert.Equal("8739992577", sut.GetLastTenDigits(28433, 7830457));

            /*
             * 
                Congratulations, the answer you gave to problem 97 is correct.
                You are the 39179st person to have solved this problem.
                This problem had a difficulty rating of 5%. 
             */
        }
    }
}
