using System.Collections.Generic;
using System.Linq;
using jae.euler.math;

namespace jae.euler.lib
{
    public class E003Largestprimefactor
    {
        public long  Largest(long below)
        {
            return Primes.GetPrimeFactorsInNumber(below).Max();
        }
    }
}
