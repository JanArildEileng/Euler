using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.math
{
    public class Fibonacci
    {

        public IEnumerable<long> Iterastor(long max)
        {
            long n1 = 1;
            long n2 = 1;

            yield return n1;
            yield return n2;

            while (true)
            {
                long next = n1 + n2;
                n1 = n2;
                n2 = next;

                if (next > max) yield  break;
                yield return next;
            }
        }
    }
}
