using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E050ConsecutivePrimeSum
    {

        long[] ConsecutivePrimeFactors;
        Dictionary<long, long> PrimeFactorHash;
        int MaxPrimeFactorIndex;
        long MaxPrimeFactor;

        public E050ConsecutivePrimeSum(int below)
        {

            var l = Primes.GetPrimeFactorsBelowNumber(below);
            ConsecutivePrimeFactors = l.ToArray();
            PrimeFactorHash = l.ToDictionary(e => e);

            MaxPrimeFactorIndex = ConsecutivePrimeFactors.Length - 1;
            MaxPrimeFactor = ConsecutivePrimeFactors[MaxPrimeFactorIndex];

        }


        public long GetConsecutivePrimeSum()
        {
            (long sum, long count) longestConsecutivePrime = (0, 0);

            for (int i = 0; i < MaxPrimeFactorIndex - 1; i++)
            {
                long sum = ConsecutivePrimeFactors[i];
                long count = 1;
                for (int j = i + 1; j < MaxPrimeFactorIndex; j++)
                {
                    sum += ConsecutivePrimeFactors[j];
                    if (sum > MaxPrimeFactor) break;
                    count++;

                    if (PrimeFactorHash.ContainsKey(sum) && count > longestConsecutivePrime.count)
                    {
                        longestConsecutivePrime = (sum, count);
                    }
                }
            }

            return longestConsecutivePrime.sum;
        }

    }
}
