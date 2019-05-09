using jae.euler.math;
using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace jae.euler.test.math
{
    public class TotientUnitTest
    {
        [Theory]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 2)]
        [InlineData(5, 4)]
        [InlineData(6, 2)]
        [InlineData(7, 6)]
        [InlineData(8, 4)]
        [InlineData(9, 6)]
        [InlineData(10, 4)]
        [InlineData(87109, 79180)]
     
        public void Test_Totient(int n, int phi)
        {
            var sut = new Totient(1000000);
            Assert.Equal(phi, sut.Calc(n));
        }

        [Fact]
        public void Test_Ytelse()
        {
            int antall = 10000;
            var sut = new Totient(antall);
            for (int i = 1; i < antall; i++)
            {
                sut.Calc(i);
            }
        }
    }
}
