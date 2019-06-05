using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E079PasscodeDerivation
    {
        public int GetShortestPossiblePasscode(int[] table)
        {
            int shortestPossiblePasscode = 0;
            HashSet<int>[] trailingNumbersSet = new HashSet<int>[10];
            for (int i = 0; i < 10; i++)
                trailingNumbersSet[i] = new HashSet<int>();

            HashSet<int> foundDigits = new HashSet<int>();


            for (int linenr = 0; linenr < table.Length; linenr++)
            {
                var digitsList = DigitsList.ConvertToDigitListe(table[linenr]);
                trailingNumbersSet[digitsList[2]].Add(digitsList[1]);
                trailingNumbersSet[digitsList[2]].Add(digitsList[0]);
                trailingNumbersSet[digitsList[1]].Add(digitsList[0]);

                foundDigits.Add(digitsList[0]);
                foundDigits.Add(digitsList[1]);
                foundDigits.Add(digitsList[2]);
            }

            var l = foundDigits.OrderBy(i => trailingNumbersSet[i].Count()).ToList();

            shortestPossiblePasscode=DigitsList.ConvertToNumber(l);

            return shortestPossiblePasscode;
        }




    }

/*
            319
            680
            180
            690
            129
            620
            762
            689
            762
            318
*/
}
