using jae.euler.math;
using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;


namespace jae.euler.test.math
{
    public class PentagonnumberUnitTest
    {
        /*
            1, 5, 12, 22, 35, 51, 70, 92, 117, 145, ....
        */
        [Theory]
       
        [InlineData(1,1)]
        [InlineData(2, 5)]
        [InlineData(8, 92)]
    
        public void TestTriangleNumber(int n, int tn)
        {

            var tabell= Pentagonnumber.Iterastor(100).ToArray();
            Assert.Equal(tn, tabell[n - 1]);
        }


        [Theory]
        [InlineData(40755, 165)]
        [InlineData(92, 8)]
        public void TestTriangleGetN(long n, int tn)
        {

            Assert.Equal(tn, Pentagonnumber.GetN(n));
        }

    }
}
