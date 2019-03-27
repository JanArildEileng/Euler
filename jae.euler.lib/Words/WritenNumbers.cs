using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib.Words
{
    public class WritenNumbers
    {

        static public string from(int i)
        {
            int a;
            if ((i % 100) > 19) a = i % 10;
            else a = i % 20;
            string astr = "";

            switch (a)
            {
                case 0: astr = ""; break;
                case 1: astr = "one"; break;
                case 2: astr = "two"; break;
                case 3: astr = "three"; break;
                case 4: astr = "four"; break;
                case 5: astr = "five"; break;
                case 6: astr = "six"; break;
                case 7: astr = "seven"; break;
                case 8: astr = "eight"; break;
                case 9: astr = "nine"; break;
                case 10: astr = "ten"; break;
                case 11: astr = "eleven"; break;
                case 12: astr = "twelve"; break;
                case 13: astr = "Thirteen"; break;
                case 14: astr = "Fourteen"; break;
                case 15: astr = "Fifteen"; break;
                case 16: astr = "Sixteen"; break;
                case 17: astr = "Seventeen"; break;
                case 18: astr = "Eighteen"; break;
                case 19: astr = "Nineteen"; break;
            }


            int b = i % 100;
            string bstr = "";

            switch (b / 10)
            {
                case 0: bstr = ""; break;
                case 1: bstr = ""; break;
                case 2: bstr = "Twenty"; break;
                case 3: bstr = "Thirty"; break;
                case 4: bstr = "Forty"; break;
                case 5: bstr = "Fifty"; break;
                case 6: bstr = "Sixty"; break;
                case 7: bstr = "Seventy"; break;
                case 8: bstr = "Eighty"; break;
                case 9: bstr = "Ninety"; break;
            }


            int c = i % 1000;
            string cstr = "";

            switch (c / 100)
            {
                case 0: cstr = ""; break;
                case 1: cstr = "One hundred"; break;
                case 2: cstr = "Two hundred"; break;
                case 3: cstr = "Three hundred"; break;
                case 4: cstr = "Four hundred"; break;
                case 5: cstr = "Five hundred"; break;
                case 6: cstr = "Six hundred"; break;
                case 7: cstr = "Seven hundred"; break;
                case 8: cstr = "Eight hundred"; break;
                case 9: cstr = "Nine hundred"; break;
                case 10: cstr = "One thousand"; break;
            }




            StringBuilder builder = new StringBuilder();

            if (i == 1000)
            {
                builder.Append("One thousand");
            }

            if (cstr.Length > 0)
            {
                builder.Append(cstr);
                if (bstr.Length > 0 || astr.Length > 0) builder.Append(" and ");
            }



            if (bstr.Length > 0) builder.Append(bstr);
            if (bstr.Length > 0 && astr.Length > 0) builder.Append("-");



            builder.Append(astr);
            return builder.ToString().ToLower();
        }


        static public int LetterCount(string str)
        {
            int count = 0;
            foreach (var c in str)
            {
                if (Char.IsLetter(c))
                    count++;
            }
            return count;

        }
    }
}
