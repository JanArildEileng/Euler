using jae.euler.math;
using jae.euler.math;
using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace jae.euler.test.util
{
    public class RomanNumberUnitTest
    {

        
        [Theory]
        [InlineData(1,"I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        [InlineData(1900, "MCM")]
        [InlineData(1940, "MCMXL")]
        [InlineData(1944, "MCMXLIV")]
        [InlineData(3569, "MMMDLXIX")]
     //   [InlineData(2399, "MMCCCLXXXXIX")]
        [InlineData(2399, "MMCCCXCIX")]
        [InlineData(4595, "MMMMDXCV")]
        [InlineData(1824, "MDCCCXXIV")]
    

        public void TestToString(int number,string romanString)
        {
            Assert.Equal(romanString, RomanNumber.ToString(number));
        }


        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        [InlineData(1900, "MCM")]
        [InlineData(1940, "MCMXL")]
        [InlineData(1944, "MCMXLIV")]
        [InlineData(3569, "MMMDLXIX")]
        [InlineData(2399, "MMCCCXCIX")]
        [InlineData(1824, "MDCCCXXIV")]
        [InlineData(4595, "MMMMDXCV")]
        public void TestToInt(int number, string romanString)
        {
            Assert.Equal(number, RomanNumber.ToInt(romanString));
        }



    }


    
}
