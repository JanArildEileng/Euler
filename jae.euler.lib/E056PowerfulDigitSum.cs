using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E056PowerfulDigitSum
    {
        public long GetMaximumDigitalSum(int abelow, int bbelow)
        {
            long maximumDigitalSum = 1;

            for (int a = 1; a < abelow; a++)
            {
                List<int> aliste = DigitsList.ConvertToDigitListe(1);
                for (int b = 1; b < bbelow; b++)
                {
                    aliste = DigitsList.Product(aliste, a);

                    var digitalSum = aliste.Sum();
                    if (digitalSum > maximumDigitalSum)
                        maximumDigitalSum = digitalSum;

                }
            }
            return maximumDigitalSum;
        }
    }
}
