using jae.euler.math;
using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jae.euler.lib
{
    public class E070TotientPermutation
    {
        private int vSize;
        List<long> primeFactors;
        Dictionary<long, long> primeDict;

        Totient totient;

        public E070TotientPermutation(int size)
        {
            primeFactors = Primes.GetPrimeFactorsBelowNumber((long)size);
            primeDict = primeFactors.ToDictionary(e => e);
            vSize = size;
            totient = new Totient(size);
        }


        public int GetNWithMinTotient()
        {

            double minNtoPhi = Double.MaxValue;
            int minN = -1;

            for(int n=2;n< vSize;n++)
            {
                long phi = totient.Calc(n);

                if (Permutation.IsPermuted(phi,n) )
                {
                    // n / φ(n)
                    double nToPhi = 1.0 * n / phi;
                    if (nToPhi < minNtoPhi)
                    {
                        minNtoPhi = nToPhi;
                        minN = n;
                    }
                }


            }
            return minN;

        }


       




     
    }
}
