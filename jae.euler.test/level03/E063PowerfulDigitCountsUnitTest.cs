using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace jae.euler.test.level03
{
    public class E063PowerfulDigitCountsUnitTest
    {      

        [Fact]
        public void Solution()
        {
            /*
            How many n-digit positive integers exist which are also an nth power?
            */

            var sut = new E063PowerfulDigitCounts();
            Assert.Equal(49, sut.GetNumberIntegerWhichAreNthPoweres());

            /*
              Congratulations, the answer you gave to problem 63 is correct.

              You are the 37859th person to have solved this problem.
            */
        }
    }
}
