using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.math
{
    public class Pentagonnumber
    {
        /*
        Pn=n(3n−1)/2.
        */
        public static IEnumerable<long> Iterastor(long max)
        {
            long n = 1;
         
            while (true)
            {
                long value = n*(3*n-1) / 2;
                n++;
                if (value > max) yield  break;
                yield return value;
            }
        }

        public static IEnumerable<long> Iterastor()
        {
            long n = 1;

            while (true)
            {
                long value = n*(3 * n - 1) / 2;
                n++;
                yield return value;
            }
        }

        public static long GetNumber(long n)
        {
            return (n  * (3 * n - 1) / 2);
        }




    }
}
