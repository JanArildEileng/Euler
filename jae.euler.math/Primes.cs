using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.math
{
     public class Primes
    {
        public static List<long> GetPrimeFactorsInNumber(long number)
        {
            List<long> primeList = new List<long>();

            var rest = number;
            var current = 2;

            while (current <= rest)
            {
                if (rest % current == 0)
                {
                    primeList.Add(current);
                    rest = rest / current;
                }
                else
                {
                    current++;
                }
            }

            return primeList;
        }

        public static List<long> GetPrimeFactorsBelowNumber(long number)
        {
            List<long> primeList = new List<long>();

       
            primeList.Add(2);
            primeList.Add(3);
            primeList.Add(5);


            for (long i=3;i< number;i+=2)
            {
                if (i % 3 == 0 || i % 5 == 0) continue;

                if (IsPrime(i, primeList))
                    primeList.Add(i);
            }

            return primeList;
        }


        public static bool IsPrime(long number, List<long> primliste)
        {
            long sq = (long)Math.Sqrt((double)number)+1;

            for (int i = 0; i < primliste.Count; i++)
            {
                if (number % primliste[i] == 0) return false;
                if (primliste[i] >= sq)
                    return true;
            }

            throw new Exception($"Primetest failed, number {number}  to bigfor list max={primliste[primliste.Count - 1]}");
        
        }


        public static bool IsPrime(long number)
        {    
            if (number % 2 == 0 ) return false;

            long sq = (long)Math.Sqrt((double)number);

            for (long i = 3; i <=sq; i += 2)
            {
                if (number % i == 0)
                    return false;           
            }

            return true;
        }
    }
}
