using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E048Selfpowers
    {
        const int MaxDigits = 10;
        public long GetLastTenDigits(int topower)
        {
            List<int> digitlist = new List<int>();

            for (int i = 1; i <= topower; i++)
            {
                List<int> liste = DigitsList.ConvertToDigitListe(i);

                for (int j = 2; j <= i; j++)
                {
                    liste = DigitsList.Product(liste, MaxDigits, i);
                }

                digitlist = DigitsList.Sum(digitlist, liste);
  
            }

           return DigitsList.ConvertToNumberLong(digitlist.Take(MaxDigits).ToList());
        }
    }
}
