using jae.euler.math;
using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace jae.euler.test.math
{
    public class PythagoreaUnitTest
    {
        [Theory]
        [InlineData(12, 1)]
        [InlineData(24, 1)]
        [InlineData(30, 1)]
        [InlineData(36, 1)]
        [InlineData(40, 1)]
        [InlineData(48, 1)]
        [InlineData(120, 3)]
        public void Test_GetNumberOfIntegerRightTriangles(int len,int expected)
        {
            /* The number 145 is well known for the property that the sum of the factorial of its digits is equal to 145: */
            Assert.Equal(expected, Pythagorea.GetNumberOfIntegerRightTriangles(len));
         }



    }

      
    
}
