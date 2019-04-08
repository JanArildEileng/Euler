using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E048Selfpowers
    {
        public long GetLastTenDigits(int topower)
        {
            List<int> digitlist = new List<int>();

            for (int i = 1; i <= topower; i++)
            {

            
                List<int> liste = DigitsList.ConvertToDigitListe(i);

                for (int j = 2; j <= i; j++)
                {
                    liste = DigitsList.Product(liste, i);
                }

                digitlist = DigitsList.Sum(digitlist, liste);
            }

            digitlist = digitlist.Take(10).ToList();
            long number = DigitsList.ConvertToNumberLong(digitlist);
            return number;
        }
    }
}
