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


    }
}
