
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.math;

namespace jae.euler.lib
{
    public class E004Largestpalindromeproduct
    {
        public long Largest(long below,long maxFactor)
        {
             
            long found = Palindrome.PreviousPalindrome(below);

            while ( !isProduct(found, maxFactor) && found >0  )
            {
                found--;

                found = Palindrome.PreviousPalindrome(found);
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
