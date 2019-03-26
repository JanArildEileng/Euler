using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.math
{
    public class Collatz
    {
        /*
            n → n/2 (n is even)
            n → 3n + 1 (n is odd)
        */


        public IEnumerable<long> Iterator(long startValue)
        {
            long n = startValue;
        
            yield return n;
            while (n != 1)
            {
                if ( n % 2 ==0)
                {
                    //even
                    n = n / 2;
                } else
                {
                    n = 3 * n + 1;
                }
                yield return n;
            }

            yield break;
        }

    }
}
