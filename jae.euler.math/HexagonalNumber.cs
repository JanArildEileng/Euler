using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.math
{
    public class HexagonalNumber
    {
        /*
         * Hn=n(2n−1)	 	1, 6, 15, 28, 45, ...

        */

        public static long GetNumber(long n)
        {
            return (n*(2*n - 1));
        }


        public static long GetN(long c)
        {

            // (n*(2*n - 1)) =c
            // 2n2 -n -c=0    0=> a=2 b= -b
            long b = -1;
            long a = 2;

            var x = (-b + Math.Sqrt(1 + 4 * a * c)) / (2 * a);

            if (x >0 && GetNumber((long)x)==c)
            {
                return (long)x;
            }

             x = (-b - Math.Sqrt(1 + 4 * a * c)) / (2 * a);

            if (x > 0 && GetNumber((long)x) == c)
            {
                return (long)x;
            }

            return -1;

        }



    }
}
