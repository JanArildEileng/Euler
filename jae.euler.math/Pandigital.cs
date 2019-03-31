using System;
using System.Collections.Generic;
using System.Text;
using jae.euler.util;
using System.Linq;

namespace jae.euler.math
{
    public class Pandigital
    {
        public static bool IsPandigita(int value, int max)
        {
            int [] digitsArray = DigitsList.ConvertToDigitListe(value).OrderBy(e => e).ToArray();


            if (digitsArray.Length != max) return false;
            for(int i=1;i<= max; i++)
            {
                if (digitsArray[i-1]!=i)
                {
                    return false;
                }

            }

            return true; ;


        }
    }
}
