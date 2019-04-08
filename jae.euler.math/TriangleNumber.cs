using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.math
{
    public class TriangleNumber
    {
        /*
        tn = ½n(n+1); 
        */
        public static IEnumerable<long> Iterastor(long max)
        {
            long n = 1;
         
            while (true)
            {
                long value = n * (n + 1) / 2;
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
                long value = n * (n + 1) / 2;
                n++;
                yield return value;
            }
        }


        public static long GetNumber(long n)
        {
            return (n * ( n + 1))/2;
        }


        public static long GetN(long c)
        {

            //  (n * ( n + 1))/2 =c
            // n2 +n -2c=0    0=> a=1 b= 1
            long b = 1;
            long a = 1;

            var x = (-b + Math.Sqrt(1 + 4 * a * 2*c)) / (2 * a);

            if (x > 0 && GetNumber((long)x) == c)
            {
                return (long)x;
            }

            x = (-b - Math.Sqrt(1 + 4 * a * 2*c)) / (2 * a);

            if (x > 0 && GetNumber((long)x) == c)
            {
                return (long)x;
            }

            return -1;

        }

    }
}
