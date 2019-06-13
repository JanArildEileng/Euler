using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E357PrimeGeneratingIntegers
    {
        public int Max { get; set; }
        Dictionary<long,long> primeDictionary;

        public E357PrimeGeneratingIntegers(int Max)
        {
            this.Max = Max;

            primeDictionary = Primes.GetPrimeFactorsBelowNumber((long)(Max+2)).ToDictionary(e=>e);

        }


        /*
          for every divisor d of n, d+n/d is prime.
         */    
        public bool IsPrimeGenerating(long number)
        {
            List<long> divisors = Divisors.GetAllUniqueDivisorsIn(number);
            List<long> liste = divisors.Select(d => d + number / d).Distinct().ToList();


            return liste.All(d => primeDictionary.ContainsKey(d));
        }

        public long GetSumOfAllPositiveIntegers()
        {
            long sumOfAllPositiveIntegers = 0;

            for (long i=1;i< Max;i++)
            {
                if (IsPrimeGenerating(i))
                    sumOfAllPositiveIntegers += i;

            }

            return sumOfAllPositiveIntegers;
        }
    }
}
