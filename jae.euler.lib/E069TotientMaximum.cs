using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E069TotientMaximum
    {
        List<long> primeFactors;
        Dictionary<long, long> dict;

        public E069TotientMaximum(int size)
        {
             primeFactors = Primes.GetPrimeFactorsBelowNumber((long)size);
            dict = primeFactors.ToDictionary(p => p);

        }


        /*
           Ser ut som  Euler's Totient function, φ(n)  gir max, 
           når n er minste tall med maximalt antall prime-faktorer..

            
         */

        public int GetNWithMaxTotient(int upperlimit)
        {
   
            long product = 1;
      
            int i = 0;
            while (true)
            {
                if (product * primeFactors[i] <= upperlimit)
                {
                    product *= primeFactors[i];
                    i++;
                }
                else
                    return (int)product;
            }

        }




        /*
         *  Euler's Totient function, φ(n) [sometimes called the phi function], is used to determine the number of numbers less than n which are relatively prime to n.
         */


        public int Totient(int n)
        {
            var primes = Primes.GetPrimeFactorsInNumber(n).Distinct();
            return Enumerable.Range(1, n - 1).Where(e => !primes.Any(p => e % p == 0)).Count();

        }





        
    }
}
