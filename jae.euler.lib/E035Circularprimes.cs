using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.util;

namespace jae.euler.lib
{
    public class E035Circularprimes
    {
        Dictionary<long, long> primemap;

        public E035Circularprimes( int max)
        {
            List<long> liste = Primes.GetPrimeFactorsBelowNumber(max);
            primemap = liste.ToDictionary(e => e);
        }

        public int GetNumberOfCircularPrimes()
        {
         
            return primemap.Where(i=>  IsCircularPrimes((int)i.Key)).Count() ;
        }

        public bool IsCircularPrimes(int number)
        {
            var digits = DigitsList.ConvertToDigitListe(number);
            int antallShifts = digits.Count;


            for (int index=0;index< antallShifts; index++)
            {
                List<int> nyListe = new List<int>();
                for(int j=0;j< antallShifts;j++)
                {
                    int t = digits[(j + index) % antallShifts];
                    nyListe.Add(t);
                }


                int number2 = DigitsList.ConvertToNumber(nyListe);
                if (!IsPrime(number2)) return false;


            }
            return true;

        }

        private bool IsPrime(int number)
        {
            if (primemap.ContainsKey(number)) return true;
            return false;
        }
    }
}
