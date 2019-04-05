using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E040Champernowneconstant
    {

        char[] Champernowneconstant;

        public E040Champernowneconstant(int maxDigits)
        {

            Champernowneconstant = CalcChampernowneconstant(maxDigits);
        }


        public int GetDigitNumber(int number)
        {
            return  Champernowneconstant[number]-'0';
        }


        private char[] CalcChampernowneconstant(int maxDigits)
        {

            StringBuilder builder = new StringBuilder();
            int totalStrLen = 0;

            //to algin array with number index
            builder.Append(".");

            for (int i=1; totalStrLen <= maxDigits;i++)
            {
                var str = i.ToString();
                totalStrLen += str.Length;
                builder.Append(str);
            }

            return builder.ToString().ToCharArray();
        }



    //    d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000
        public int  GetDigitNumberProduct()
        {
            int product = 1;
            for (int i = 1; i <= 1000000; i *= 10)
            {
                product *= GetDigitNumber(i);
            }

            return product;
        }
    }
}
