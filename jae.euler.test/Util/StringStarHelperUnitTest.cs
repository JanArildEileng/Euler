using jae.euler.math;
using jae.euler.math;
using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace jae.euler.test.util
{
    public class StringStarHelperUnitTest
    {

        [Fact]
        public void TestConvertToDigitListe()
        {
            var stringStar = new StringStarHelper("abc");

            foreach(string s in stringStar)
            {
                var x = s;
            }
           
        }

     
    }
}
