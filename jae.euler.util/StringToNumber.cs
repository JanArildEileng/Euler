using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.util
{
    public class StringToNumber
    {

        public static int GetMaxNumber(string s)
        {
            int len = s.Length;
            int number = 1;
            for (int i = 1; i<=len; i++)
                number *= 10;
            return number;

        }

        public static int GetMinNumber(string s)
        {
            int len = s.Length;
            int number = 1;
            for (int i = 1; i < len; i++)
                number *= 10;
            return number;

        }
    }
}
