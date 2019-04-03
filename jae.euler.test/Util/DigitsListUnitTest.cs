using jae.euler.lib.Palindrome;
using jae.euler.math;
using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace jae.euler.test.util
{
    public class DigitsListUnitTest
    {

        [Fact]
        public void TestConvertToDigitListe()
        {
            var digitsList = DigitsList.ConvertToDigitListe(12345);

            Assert.Equal(5, digitsList.Count);
            Assert.Equal(5, digitsList[0]); ;
            Assert.Equal(1, digitsList[4]); ;
        }

        [Fact]
        public void TestConvertToNumber()
        {
            List<int> liste=new List<int> { 5,4,3,2,1};

            var number = DigitsList.ConvertToNumber(liste);

            Assert.Equal(12345, number);
         }
    }
}
