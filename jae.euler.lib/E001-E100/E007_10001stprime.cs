using jae.euler.math;
using System.Collections.Generic;

namespace jae.euler.lib
{
    public class E007_10001stprime
    {
        public long GetPrimeNumber(long primenr)
        {
            var listPrimeNumber = new List<long>();
            long current = 1;

            while (listPrimeNumber.Count < primenr)
            {
                current = GetNextPrime(current + 1, listPrimeNumber);
                listPrimeNumber.Add(current);
            }

            return current;
        }

        private long GetNextPrime(long next, List<long> listPrimeNumber)
        {
            while (!Primes.IsPrime(next, listPrimeNumber))
            {
                next++;
            }
            return next;
        }
    }
}
