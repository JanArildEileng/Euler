using jae.euler.lib.Primes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.lib.Palindrome;

namespace jae.euler.lib
{
    public class E4Largestpalindromeproduct
    {
        public long Largest(long below,long maxFactor)
        {
             
            long found = PalindromeHelper.PreviousPalindrome(below);

            while ( !isProduct(found, maxFactor) && found >0  )
            {
                found--;

                found = PalindromeHelper.PreviousPalindrome(found);
            }

            return found;
        }

        private bool isProduct(long found,long maxFactor)
        {

            for (var i= maxFactor-1; i > 1; i--)
            {
                if ( found % i ==0)
                {
                    var rest = found / i;
                    if (rest < maxFactor) return true;
                    else
                        return false;
                }

            }
 
            return false;
         }

      

    }
}
