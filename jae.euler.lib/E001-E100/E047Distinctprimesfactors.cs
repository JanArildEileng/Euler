using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.math;

namespace jae.euler.lib
{
    public class E047Distinctprimesfactors
    {

        long[] primes;

        public long GetFirstConsecutivenumberWith(int primefactors,int numberConsecutive)
        {
            primes = Primes.GetPrimeFactorsBelowNumber(200000).ToArray();
            long number = 1;

            while (true)
            {
                long distinctprimeFactorsInNumber = 0;
                for (int j=0;j< numberConsecutive;j++)
                {
                    distinctprimeFactorsInNumber = GetDistinctprimeFactorsInNumber(number + j, primefactors);
                    if (distinctprimeFactorsInNumber != primefactors)
                    {
                        number += j ;
                        break;
                    }
                }

                if (distinctprimeFactorsInNumber == primefactors)
                    return number;

                number++;
            }
        }


        public long GetDistinctprimeFactorsInNumber(long number, int maxprimefactors)
        {
            int primefactors = 0;
            long halv = number/2;

            int i = 0;
            while (primes[i]<= halv)
            {
                if (number % primes[i] == 0) primefactors++;
                if (primefactors > maxprimefactors) return -1;
                i++;
            }
          
            return primefactors;
        }

      
    }
}
