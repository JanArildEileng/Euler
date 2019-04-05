using jae.euler.lib.Digits;
using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E025_1000digitFibonaccinumber
    {
        public long GetIndexOfFirstTerm(int numberOfdigits)
        {

            List<int> fn1 = new List<int>() { 1 };
            List<int> fn2 = new List<int>() { 1 };
   
            int IndexOfTerm = 2;

            while (fn2.Count < numberOfdigits)
            {
                var fnext = DigitsList.Sum(fn1, fn2);
                fn1 = fn2;
                fn2 = fnext;
                IndexOfTerm++;
            }

            return IndexOfTerm;
        }
    }
}
