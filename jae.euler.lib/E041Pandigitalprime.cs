using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.math;

namespace jae.euler.lib
{
    public class E041Pandigitalprime
    {
        int LargestPandigitalPrime;

        public int GetLargestPandigitalPrime(int digits)
        {
            LargestPandigitalPrime = 0;
            int[] candidates = Enumerable.Range(1, digits).Reverse().ToArray();


            while (LargestPandigitalPrime==0)
            {
                int number = 0;
                RecurivePerm(number, candidates, 0);
                candidates = candidates.Skip(1).ToArray();
            }

            return LargestPandigitalPrime;
        }

        private bool RecurivePerm(int number,int[] availableNumberlist, int currentLevel)
        {
            if (availableNumberlist.Length == 1)
            {        
                if  (Primes.IsPrime(number * 10 + availableNumberlist[0]))
                {
                    LargestPandigitalPrime = number * 10 + availableNumberlist[0];
                    return true;
                }
                return false;
            }

            foreach (int nextAviableNumber in availableNumberlist)
            {
                 if (RecurivePerm(number * 10 + nextAviableNumber,availableNumberlist.Where(e => e != nextAviableNumber).ToArray(), currentLevel + 1))
                    return true;
            }
            return false;
        }
    
    }
}
