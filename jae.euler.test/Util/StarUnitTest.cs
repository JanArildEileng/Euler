using jae.euler.math;
using jae.euler.math;
using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace jae.euler.test.util
{
    public class StarUnitTest
    {

        [Theory]
        [InlineData("Test",0,"Test")]
        public void TestStarNoneReplaceUnitTest1(string orgTekst, int hidingNumber, string resultTekst)
        {
            var res = Star.Hide(orgTekst, hidingNumber);
            Assert.Equal(resultTekst, res);
        }


        [Theory]
        [InlineData("Test",1,"Tes*" )]
        [InlineData("Test",2,"Te*t")]
        [InlineData("Test",4,"T*st")]
        [InlineData("Test",8,"*est")]
        public void TestStarSingleReplaceUnitTest1(string orgTekst, int hidingNumber,string resultTekst)
        {
            var res = Star.Hide(orgTekst, hidingNumber);
            Assert.Equal(resultTekst, res);
        }


        [Theory]
        [InlineData("Test", 3,"Te**")]
        [InlineData("Test", 5,"T*s*")]
        [InlineData("Test", 7,"T***")]
        [InlineData("Test", 9,"*es*")]
        [InlineData("Test",10,"*e*t")]
        [InlineData("Test",15,"****")]
        public void TestStarMultieplaceUnitTest1(string orgTekst, int hidingNumber, string resultTekst)
        {
            var res = Star.Hide(orgTekst, hidingNumber);
            Assert.Equal(resultTekst, res);
        }



    }


    public class Star
    {
        internal static string Hide(string tekst, int bitHidingPattern)
        {
            char[] charArray = tekst.ToCharArray();
            int MaxIndex = tekst.Length - 1;

            for (int index=0; index <= MaxIndex; index++)
            {
                int bitIndex = 1 << index;

                //reverse..
                if ( (bitIndex & bitHidingPattern) !=0)
                    charArray[MaxIndex - index] = '*';
            }

            return new string(charArray);
        }
    }
}
