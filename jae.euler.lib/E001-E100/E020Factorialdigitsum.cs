
using jae.euler.util;
using System.Collections.Generic;
using System.Linq;

namespace jae.euler.lib
{
    public class E020Factorialdigitsum
    {
        public int GetFactorialdigitsum(int factorial)
        {
            List<int> digits = new List<int>() { 1 };

            for (int i = 1; i <= factorial; i++)
            {
                digits = DigitsList.Product(digits, multiplier: i);
            }

            return digits.Sum(e => e);
        }
    }
}
