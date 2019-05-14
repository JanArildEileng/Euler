using jae.euler.math;
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


        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(11, 11, 121)]
        [InlineData(1234, 4567, 5635678)]
        public void Test_Product_multiplier(int initValue, int multiplier, int expectedResult)
        {
          var digitsList = DigitsList.ConvertToDigitListe(initValue);
          var resultList=DigitsList.Product(digitsList, multiplier);
          var result = DigitsList.ConvertToNumber(resultList);
          Assert.Equal(expectedResult, result);
        }



        [Theory]
        [InlineData(1234, 4567, 5635678)]
        [InlineData(8569, 5723, 49040387)]
        public void Test_Product_List(int initValue, int multiplier, int expectedResult)
        {
            var digitsList1 = DigitsList.ConvertToDigitListe(initValue);
            var digitsList2 = DigitsList.ConvertToDigitListe(multiplier);

            var resultList = DigitsList.Product(digitsList1, digitsList2);
            var result = DigitsList.ConvertToNumber(resultList);
            Assert.Equal(expectedResult, result);
        }




    }
}
