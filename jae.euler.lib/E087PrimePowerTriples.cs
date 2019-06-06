using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Linq;

namespace jae.euler.lib
{
    public class E087PrimePowerTriples
    {
        public int GetCount(long below)
        {
            List<long> powerTriples = new List<long>();
            List<long> primes = Primes.GetPrimeFactorsBelowNumber((long)Math.Sqrt(below));

            foreach (long p1 in primes)
            {
                long squarePrime = p1 * p1;
                long rest = below - squarePrime;

                foreach (long p2 in primes)
                {
                    long triplePrime = p2 * p2 * p2;
                    long rest2 = rest - triplePrime;
                    if (rest2 <= 0) break;

                    foreach (long p3 in primes)
                    {
                        long quadPrime = p3 * p3 * p3 * p3;
                        long rest3 = rest2 - quadPrime;
                        if (rest3 <= 0) break;

                        powerTriples.Add(squarePrime + triplePrime + quadPrime);
                    }
                }
            }

            return powerTriples.Distinct().Count();

        }
    }
}
