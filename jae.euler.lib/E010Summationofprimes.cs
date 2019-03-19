using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.math;

namespace jae.euler.lib
{
    public class E010Summationofprimes
    {
        public long GetSum(long below)
        {
           return Primes.GetPrimeFactorsBelowNumber(below).Sum();
        }
    }
}
