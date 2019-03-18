using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E7_10001stprime
    {
        public object GetPrimeNumber(long primenr)
        {
            var listPrimeNumber = new List<long>();

            long prime = 2;

            listPrimeNumber.Add(prime);

            while (listPrimeNumber.Count < primenr)
            {
                prime = GetNextPrime(prime, listPrimeNumber);
                listPrimeNumber.Add(prime);
            }


            return prime;
        }

        private long GetNextPrime(long prime, List<long> listPrimeNumber)
        {
            var next = prime;

            while ( !IsPrime(next, listPrimeNumber))
            {
                next++;
            }
            return next;
        }

        private bool IsPrime(long next, List<long> listPrimeNumber)
        {
            for(int i=0;i< listPrimeNumber.Count;i++)
            {
                if (next % listPrimeNumber[i] == 0) return false;
            }

            return true;
        }
    }
}
