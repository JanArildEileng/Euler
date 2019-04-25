using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.math
{
    public class Palindrome
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


        public static bool IsPalindrome(List<int> list) { 
            int len = list.Count;

            for (int i = 0; i < len / 2; i++)
            {
                if (list[i] != list[len - i - 1]) return false;
            }

            return true;

        }

   



        public static bool IsPalindromeBase2(long number)
        {
            StringBuilder builder = new StringBuilder();

            while ( number > 0)
            {
                if (number % 2 == 0)
                    builder.Append("0");
                else
                    builder.Append("1");

                number = number / 2;
            }

            string s = builder.ToString();
            int len = s.Length;


            for (int i = 0; i < len / 2; i++)
            {
                if (s[i] != s[len - i - 1]) return false;
            }

            return true;
        }


        public static bool IsPalindromicBothBases(long number)
        {
            if (Palindrome.IsPalindrome(number))
            {
                if (Palindrome.IsPalindromeBase2(number))
                    return true;

            }

            return false;
        }

    }
}
