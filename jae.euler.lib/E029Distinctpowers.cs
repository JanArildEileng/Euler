using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.lib.Digits;
using jae.euler.lib.Extender;

namespace jae.euler.lib
{
    public class E029Distinctpowers
    {
        public int GetNumberOfDistinctTerms(int amax, int bmax)
        {
            /*   Consider all integer combinations of ab for 2 ≤ a ≤ 5 and 2 ≤ b ≤ 5:    */

            List<string> numberAsStringListe = new List<string>();

            for (var a = 2; a <= amax; a++)
            {
                List<int> digitlist = new List<int>() { a };

                for (var b = 2; b <= bmax; b++)
                {
                    digitlist = DigitsList.Product(digitlist, multiplier: a);
                    numberAsStringListe.Add(digitlist.StringFromArrayReverse());
                }
            }

            var numberOfDistinctTerms = numberAsStringListe.Distinct().Count();
            return numberOfDistinctTerms;
        }
    }
}
