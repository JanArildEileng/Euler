using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.util;

namespace jae.euler.lib
{
    public class E016Powerdigitsum
    {
        public long GetSumOfDigits(int exponent)
        {
    
            List<int> digits = new List<int>() { 1 };
            
            for(int i=0; i< exponent; i++)
            {
                digits = DigitsList.Product(digits, multiplier:2);
            }

            var sumOfDigit = digits.Sum(e => e);

            return sumOfDigit;

        }
    }
}
