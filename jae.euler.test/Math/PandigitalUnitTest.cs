using jae.euler.lib.Palindrome;
using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace jae.euler.test.math
{
    public class PandigitalUnitTest
    {

        [Theory]
        [InlineData(1,1)]
        [InlineData(21, 2)]
        [InlineData(312,3)]
        [InlineData(3412,4)]
        [InlineData(123456789, 9)]
        [InlineData(538419672, 9)]
        public void TestIsPandigital(int value,int max)
        {
            Assert.True(Pandigital.IsPandigita(value,max));
            Assert.True(Pandigital.IsPandigita(value, max));
            Assert.True(Pandigital.IsPandigita(value, max));
        }

        [Theory]
        [InlineData(13,2)]
        [InlineData(13, 3)]
        [InlineData(12223, 3)]
        [InlineData(12346, 5)]
        public void TestIsNotPandigital(int value, int max)
        {
            Assert.False(Pandigital.IsPandigita(value, max));
         
        }

    }
}
