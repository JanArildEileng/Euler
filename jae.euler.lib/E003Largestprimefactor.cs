using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.math;

namespace jae.euler.lib
{
    public class E003Largestprimefactor
    {
        public long  Largest(long below)
        {

            List<long> primeList = Primes.GetPrimeFactorsInNumber(below);

            return primeList.Max();


        }


    }
}
