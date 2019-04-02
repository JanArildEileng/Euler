using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.math
{
    public class Factorial
    {
        public static long Factor(long number)
        {
            if (number < 2) return 1;
            return number * Factor(number - 1);
        }
    }
}
