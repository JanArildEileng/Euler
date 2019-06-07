using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Linq;

namespace jae.euler.lib
{
    public class E077PrimeSummations
    {
        int Size;
        List<long> primliste;
        Dictionary<long, long> dictionary;

        public E077PrimeSummations(int size)
        {
            this.Size = size;
            primliste = Primes.GetPrimeFactorsBelowNumber(size);
            dictionary = primliste.ToDictionary(e=>e);
            primliste.Reverse(); 
        }

        //alle tall ( >1)  kan skrives som sum av 2 og 3

        public int GetNumberOfDifferentWays(long number,long maxPrime)
        {
            int counter = 0;

            var pliste = primliste.Where(p => p <= maxPrime);      

            foreach(var p in pliste)
            {
                var rest = number - p;
                if (rest < 2) continue;
                if (p == 2 && number % 2 != 0) continue;
                if (p == 2 && number % 2 == 0)
                {
                    counter++;
                    continue;
                }

                if (dictionary.ContainsKey(rest) && rest <= p)
                    counter++;                    
    
                if (rest > 3)
                    counter += GetNumberOfDifferentWays(rest,rest<p?rest:p );            
            }

            return counter;
        }

        public int GetFirstNumberWithMoreThanPrimeSummations(int moreThanWays)
        {

            for(int i=2;i<=Size;i++)
            {
                var numberOfDifferentWays = GetNumberOfDifferentWays(i,Size);
                if (numberOfDifferentWays > moreThanWays)
                {
                    return i;
                }
            }

            throw new Exception($"Didnt dont find {moreThanWays} in {Size }");
        }

    }
}
