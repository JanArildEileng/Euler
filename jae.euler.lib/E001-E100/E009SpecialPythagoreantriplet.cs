using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E009SpecialPythagoreantriplet
    {
        public long GetProductWhereSum(int sum)
        {
            for (long c = sum/2; c >=sum/3; c--)
            {
                for (long b = (sum - c); b > (sum - c)/2; b--)
                {
                    long a = sum - c - b;
                    if ( Pythagorea.isPythagorea(a, b, c))
                    {
                        return a * b * c;
                    }
                }
            }
            throw new Exception("NO product found");
        }
    }
}
