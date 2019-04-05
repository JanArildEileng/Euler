using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E036Doublebasepalindromes
    {
        //public bool IsPalindromicBothBases(int number)
        //{
        //   if ( Palindrome.IsPalindrome(number))
        //    {
        //        if (Palindrome.IsPalindromeBase2(number))
        //            return true;

        //    }

        //    return false;
        //}

        public int GetSumOfPalindromicBothBases(int below)
        {
            return Enumerable
                .Range(1, below)
                .Where(i => Palindrome.IsPalindromicBothBases(i))
                .Sum();
        }
    }
}
