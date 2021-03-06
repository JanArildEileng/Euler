using jae.euler.math;
using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;


namespace jae.euler.test.math
{
    public class TriangleNumberUnitTest
    {
        /*
        1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
        */
        [Theory]
       
        [InlineData(1,1)]
        [InlineData(2, 3)]
        [InlineData(8, 36)]
        [InlineData(285, 40755)]

        public void TestTriangleNumber(int n, int tn)
        {

            var tabell= TriangleNumber.Iterastor(50755).ToArray();
            Assert.Equal(tn, tabell[n - 1]);
        }


 
        [Theory]
        [InlineData(40755, 285)]
        [InlineData(36, 8)]
        public void TestTriangleGetN(long n, int tn)
        {

            Assert.Equal(tn, TriangleNumber.GetN(n));
        }

    }
}
