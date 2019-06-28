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
        List<long> primeliste;

        public E357PrimeGeneratingIntegers(int Max)
        {
            this.Max = Max;
            primeliste=Primes.GetPrimeFactorsBelowNumber((long)Math.Sqrt(Max));
///            primeDictionary = Primes.GetPrimeFactorsBelowNumber((long)Math.Sqrt(Max)).ToDictionary(e=>e);
//            primeliste = Primes.GetPrimeFactorsBelowNumber(Max+1);

            primeDictionary = primeliste.ToDictionary(e => e);

            primeDictionary.Add(1, 1);

        }


        /*
          for every divisor d of n, d+n/d is prime.
         */    
        public bool IsPrimeGenerating(long number)
        {
            if (number % 2 == 1) return false;


/*
            for (long divisor1 = 2; divisor1 < number; divisor1++)
            {
                long divisor2 = number / divisor1;
                if (divisor1 > divisor2) return true;

                if (number % divisor1 == 0 )
                {
                  


                    if (!primeDictionary.ContainsKey(divisor1 + divisor2)) return false;
                }


            }

            return true;
*/

            List<long> divisors = Divisors.GetAllUniqueDivisorsIn(number);
          
            int len = divisors.Count();
            if (len % 2 == 1) return false;

            //if (len == 2)
            //    return !primeDictionary.ContainsKey(number);

             if (number==442)
            {
                var aa = 1;
            }

            //  List<long> liste = divisors.Select(d => d + number / d).Distinct().ToList();
            List<long> liste = divisors.Take(len).Select(d => d + number / d).Distinct().ToList();
            // List<long> liste = divisors.Take(len/2).ToList();

          //  return liste.All(d => Primes.IsPrime(d, primeliste));
     
          //  return liste.All(d => primeDictionary.ContainsKey(d));


                      return liste.All(d => primeDictionary.ContainsKey(d));
        }

        public long GetSumOfAllPositiveIntegers()
        {
            long sumOfAllPositiveIntegers = 0;

            Action<long> action = (i) =>
              {
                  sumOfAllPositiveIntegers += i;
              };




            sumOfAllPositiveIntegers = Recursive().Sum();

            return sumOfAllPositiveIntegers;
        }


        private List<long> Recursive()
        {
            int count = primeliste.Count;
            List<long> liste = new List<long>() {  };
          


            for (int i= 1; i < count;i++)
            {
                long prime = primeliste[i];
                long test =  prime-1;
                if (test > Max) continue;

                if (!primeDictionary.ContainsKey(test/2 + 2)) continue;

                if (IsPrimeGenerating(test))
                {
                    liste.Add(test);
                }
            }
          

            var l = liste.OrderBy(e => e);
            return liste;
        }





        public long GetSumOfAllPositiveIntegers_org()
        {
            long sumOfAllPositiveIntegers = 0;
         
            for (long i = 1; i < Max; i++)
            {
                if (IsPrimeGenerating(i))
                {

                    sumOfAllPositiveIntegers += i;
                }
            }
            return sumOfAllPositiveIntegers;
        }
    }
}
