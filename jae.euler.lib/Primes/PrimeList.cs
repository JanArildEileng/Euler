using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib.Primes
{
    public class PrimeList
    {

        public static List<long> GetList(long below)
        {

            List<long> primeList = new List<long>();


            var rest = below;
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
    }
}
