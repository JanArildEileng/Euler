using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E058SpiralPrimes
    {
        /*
                Starting with 1 and spiralling anticlockwise in the following way, a square spiral with side length 7 is formed.

        37 36 35 34 33 32 31
        38 17 16 15 14 13 30
        39 18  5  4  3 12 29
        40 19  6  1  2 11 28
        41 20  7  8  9 10 27
        42 21 22 23 24 25 26
        43 44 45 46 47 48 49

         but what is more interesting is that 8 out of the 13 numbers lying along both diagonals are prime;
         that is, a ratio of 8/13 ≈ 62%.

                    */

        /*
         * digagonaltallene...
          1,3,5,7,9,13,17,21,25,31,37,43,49


         * 
         */
        List<long> primliste;

        public E058SpiralPrimes(int primelistemax)
        {
            primliste = Primes.GetPrimeFactorsBelowNumber(primelistemax);
        }




        public Fraction GetRatio(int sidelength)
        {
            long isPrime = 0;
            long start = 1;
            long step = 0;

            long len = 1;
            long counter = 0;
            long current = start;
            while ( len <= sidelength)
            {
                counter++;
                if ( counter % 4==1)
                {
                    step += 2;
                    len += 2;
                }
                current = current + step;
               
               if ( Primes.IsPrime(current, primliste))
                {
                    isPrime++;
                } 

            }

            return new Fraction { Numerator = isPrime, Denominator = counter };
        }




        public long GetLengthWhereRationBelow(int percent)
        {
            long antallPrimetallFunnet = 0;        
            long step = 0;
            long len = 1;
            long counter = 0;
            long current = 1;
            while (true)
            {
                counter++;

                //side komplett,sjekk ration
                if (counter % 4 == 1)
                {
                    if (counter>1 && antallPrimetallFunnet * 10 < counter)
                    {
                        break;
                    }
                    //øk steg og sidelengde
                    step += 2;
                    len += 2;
                }
                current += step;

                if (Primes.IsPrime(current, primliste))             
                    antallPrimetallFunnet++;

            }
            return len;
        }


       
    }
}
