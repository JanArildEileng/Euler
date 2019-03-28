using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.math

{
    public class AmicableNumbers
    {
/*
        Let d(n) be defined as the sum of proper divisors of n(numbers less than n which divide evenly into n).
        If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
*/ 
        public static  bool IsAmicablenumbers(int a)
        {
            Func<long, long> d = (n) => Divisors.GetProperDivisors(n).Sum();

            var b = d(a);
            return (b != a && a == d(b));
    
        }
    }
}
