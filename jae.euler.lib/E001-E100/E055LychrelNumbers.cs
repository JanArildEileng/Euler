using jae.euler.math;
using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E055LychrelNumbers
    {
        public bool IsLychrelNumber(long number)
        {
            bool isPalindrome = false;
            int numberOfIteration = 0;
            List<int> digits = DigitsList.ConvertToDigitListe(number);

            while ( !isPalindrome && numberOfIteration<50)
            {
                digits = DigitsList.Sum(digits, DigitsList.ReverseCopy(digits));

                isPalindrome = Palindrome.IsPalindrome(digits);
                numberOfIteration++;
            }
            return !isPalindrome;
        }

        public int GetNumberOfLychrelNumber(int below)
        {
            return Enumerable.Range(0, below).Where(i => IsLychrelNumber(i)).Count();
        }
    }
}
