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


        public static int GetNumberOfIntegerRightTriangles(int length)
        {
            int numberOfIntegerRightTriangles = 0;
            for (long c = length / 2; c >= length / 3; c--)
            {
                for (long b = (length - c); b > (length - c) / 2; b--)
                {
                    long a = length - c - b;
                    if (Pythagorea.isPythagorea(a, b, c))
                    {
                        numberOfIntegerRightTriangles++;
                    }
                }
            }

            return numberOfIntegerRightTriangles;
        }
    }
}
