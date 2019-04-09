using jae.euler.math;
using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E034Digitfactorials
    {
        private long[] FactorialArray;

        public E034Digitfactorials()
        {
            //pre calc n! for n=0 til 9 ..
            FactorialArray = Enumerable
                .Range(0, 10)
                .Select(digit => Factorial.Factor(digit))
                .ToArray();
        }

        public long GetSumOfAllCuriousNumbers()
        {
            return Enumerable
             .Range(3, 2540161)
             .Where(i => IsCuriousNumber(i))
             .Sum();
        }

        /*
               145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
        */
        public bool IsCuriousNumber(int number)
        {
            return number == DigitsList
                .ConvertToDigitListe(number)
                .Select(digit => FactorialArray[digit])
                .Sum();
        }
    }
}
