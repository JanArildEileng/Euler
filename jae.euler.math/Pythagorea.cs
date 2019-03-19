using System;

namespace jae.euler.math
{
    public class Pythagorea
    {
        public static bool isPythagorea(long a, long b, long c)
        {
            if (a > 0 && b > a && c > b)
                return ((a * a + b * b) == c * c);
            return false;
        }
    }
}
