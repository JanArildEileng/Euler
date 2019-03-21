using System.Collections.Generic;

namespace jae.euler.math
{
    public class TriangularNumber
    {
        public IEnumerable<long> Iterastor()
        {
            long n = 1;
            long sum = 0;

            while (true)
            {
                sum += n;
                n++;
                yield return sum;
            }
        }
    }
}
