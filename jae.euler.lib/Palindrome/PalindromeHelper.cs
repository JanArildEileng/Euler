using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib.Palindrome
{
    public class PalindromeHelper
    {

        public static  long PreviousPalindrome(long number)
        {
            while (number > 0)
            {
                if (IsPalindrome(number)) return number;
                number--;
            }

            return number;
        }


        public static bool IsPalindrome(long number)
        {
            string s = number.ToString();
            int len = s.Length;

            for (int i = 0; i < len / 2; i++)
            {
                if (s[i] != s[len - i - 1]) return false;
            }

            return true;

        }
    }
}
