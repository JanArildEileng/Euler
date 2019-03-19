using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E9SpecialPythagoreantriplet
    {
        public long GetProductWhereSum(int sum)
        {
            for (long c = sum; c > 2; c--)
            {
                for (long b = sum - c; b > 1; b--)
                {
                    long a = sum - c - b;
                    if (a > 0 && Pythagorea.isPythagorea(a, b, c))
                    {
                        return a * b * c;
                    }
                }
            }

            return 0;
        }
    }
}
