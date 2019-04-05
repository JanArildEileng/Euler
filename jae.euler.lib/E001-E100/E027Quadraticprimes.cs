using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E027Quadraticprimes
    {
        public int GetproductOfCoefficients()
        {
            int product = 0;
            int maxLen = 0;
            for (int a = -1000; a <= 1000; a++)
            {
                for (int b = -1000; b <= 1000; b++)
                {
                    int numberOfPrimes = GetnumberOfPrimes(a, b);
                    if (numberOfPrimes > maxLen)
                    {
                        maxLen = numberOfPrimes;
                        product = a * b;
                    }
                }
            }

            return product;
        }



        public int GetnumberOfPrimes(int a, int b)
        {
            int n = 0;

            while (IsPrime(CalcAbsFormulaValue(a, b, n)))
            {
                n++;
            }

            return n;
        }


        private int CalcAbsFormulaValue(int a, int b, int n)
        {

            int result = n * n + a * n + b;
            return result > 0 ? result : -result; ;
        }

        private bool IsPrime(int value)
        {
            long sq = (long)Math.Sqrt((double)value) + 1;

            for (int i = 2; i <= sq; i++)
            {
                if (value % i == 0) return false;
            }
            return true; ;
        }


    }
}
