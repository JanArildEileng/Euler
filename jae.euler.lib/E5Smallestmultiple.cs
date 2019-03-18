using jae.euler.lib.Primes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E5Smallestmultiple
    {
        public long SmallestNumberDividedByAllNumbers(long UpToNumber)
        {
            long[]  maxCountOfPrimNumber= new long[UpToNumber+1];


            for (int i = 2; i <= UpToNumber; i++)
            {
                var group = PrimeList.GetList(i).GroupBy(e => e);

                foreach(var g in group)
                {
                    if (maxCountOfPrimNumber[g.Key] < g.Count())
                        maxCountOfPrimNumber[g.Key] = g.Count();
                }
            }


            long smallestNumber = 1;
            for (int i = 2; i <= UpToNumber; i++)
            {
                for (int ii = 0; ii < maxCountOfPrimNumber[i]; ii++)
                    smallestNumber *= i;
            }

            return smallestNumber;

        }

    }
}
