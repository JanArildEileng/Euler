using jae.euler.math;
using jae.euler.math;
using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace jae.euler.test.util
{
    public class PermutationUnitTest
    {

        [Theory]
        [InlineData(79180, 87109)]
        [InlineData(781396, 783169)]
        public void Test_Number(long number1, long number2)
        {
            Assert.True(Permutation.IsPermuted(number1, number2));
        }



    }


    
}
