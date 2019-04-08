using jae.euler.math;
using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;


namespace jae.euler.test.math
{
    public class HexagonalNumberUnitTest
    {
        /*
        1, 6, 15, 28, 45, ...
        */
        [Theory]
       
        [InlineData(1,1)]
        [InlineData(2, 6)]
        [InlineData(5, 45)]
        [InlineData(143, 40755)]

        public void TestHexagonalNumber(int n, int tn)
        {
            Assert.Equal(tn, HexagonalNumber.GetNumber(n));
        }

        [Theory]
        [InlineData(40755, 143)]
        [InlineData(45, 5)]
        public void TestHexagonalGetN(long n, int tn)
        {

            Assert.Equal(tn, HexagonalNumber.GetN(n));
        }


    }
}
