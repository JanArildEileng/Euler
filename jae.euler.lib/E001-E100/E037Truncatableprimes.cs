using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.util;

namespace jae.euler.lib
{
    public class E037Truncatableprimes
    {
        Dictionary<long, long> primemap;

        public E037Truncatableprimes(int max)
        {
            primemap = Primes.GetPrimeFactorsBelowNumber(max).ToDictionary(e => e);
        }

        public long GetSumOfTruncatableprime(int numberof)
        {
           return primemap
                .Values
                .Where(e => e > 7)
                .Where(e => IsTruncatableprime((int)e))
                .Sum();
        }

        public bool IsTruncatableprime(int number)
        {
            var digits = DigitsList.ConvertToDigitListe(number);

            for(int i=0;i< digits.Count;i++)
                if (!IsPrime(DigitsList.ConvertToNumber(digits.Skip(i).ToList()))) return false;

            for (int i = 1; i < digits.Count; i++)
                if (!IsPrime(DigitsList.ConvertToNumber(digits.SkipLast(i).ToList()))) return false;

            return true;
        }


        private bool IsPrime(int number)
        {
            if (primemap.ContainsKey(number)) return true;
            return false;
        }
      
    }
}
