using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.lib.Primes;

namespace jae.euler.lib
{
    public class E3Largestprimefactor
    {
        public long  Largest(long below)
        {

            List<long> primeList = PrimeList.GetList(below);

            return primeList.Max();


        }


    }
}
