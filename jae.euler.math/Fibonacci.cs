using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.math
{
    public class Fibonacci
    {
        public IEnumerable<long> Iterator(long below)
        {
           (long n1, long n2) = next(1, 0);
            yield return n1;

            while (n2 <below )
            {
                yield return n2;
                (n1, n2) = next(n1, n2);
            }
        }

        (long n1,long n2) next(long n1,long n2)
        {
            return (n2, n2 + n1);
        }

    }
}
