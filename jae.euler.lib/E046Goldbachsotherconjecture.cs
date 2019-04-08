using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E046Goldbachsotherconjecture
    {
        public long GetSmallestOddCompisteNotSum()
        {

            bool goldbachsotherconjecture = true;
            long i = 1;
            while (goldbachsotherconjecture)
            {
                i += 2;

                if (!Primes.IsPrime(i))
                {
                    bool thisgoldbachsotherconjecture = false;

                    long j = 1;
                    long rest = i - 2 * j * j;
                    while (!thisgoldbachsotherconjecture && rest > 0)
                    {
                        if (Primes.IsPrime(rest))
                        {
                            thisgoldbachsotherconjecture = true;
                        }
                        j++;
                        rest = i - 2 * j * j;
                    }

                    goldbachsotherconjecture = thisgoldbachsotherconjecture;
                }
            }
            return i;


        }
    }
}
