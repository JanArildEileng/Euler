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


        public static long GetN(long c)
        {

            // n  * (3 * n - 1)/2 =c
            // 3n2 -n -2c=0    0=> a=3 b= -b
            long b = -1;
            long a = 3;

            var x = (-b + Math.Sqrt(1 + 4 * a * 2*c)) / (2 * a);

            if (x > 0 && GetNumber((long)x) == c)
            {
                return (long)x;
            }

            x = (-b - Math.Sqrt(1 + 4 * a * 2* c)) / (2 * a);

            if (x > 0 && GetNumber((long)x) == c)
            {
                return (long)x;
            }

            return -1;

        }






    }
}
