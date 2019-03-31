using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E031Coinsums
    {
      
        public int GetNumberOfDifferentWays(int amountInpence, int[] penceCoinsvalues)
        {        
            return FindWaysRecursive(amountInpence, penceCoinsvalues, recursiveLevel: 0);
        }

        private int FindWaysRecursive(int amountInpence, int[] penceCoinsvalues, int recursiveLevel)
        {
            //hvis siste nivå , return 1;
            if (recursiveLevel== (penceCoinsvalues.Length-1))
            {
                 return 1;
            }
            int numberOfDifferentWays = 0;

            //hvor mange av neste verdi?
            int maxAntallCoinsDenneVerdi = amountInpence / penceCoinsvalues[recursiveLevel];

            for(int i = 0; i < maxAntallCoinsDenneVerdi; i++)
            {
                int restamout = amountInpence - i * penceCoinsvalues[recursiveLevel];
                numberOfDifferentWays+= FindWaysRecursive(restamout, penceCoinsvalues, recursiveLevel + 1);
            }

            //hvor mange med rest-verdien
            int modamount = amountInpence % penceCoinsvalues[recursiveLevel];
            numberOfDifferentWays += FindWaysRecursive(modamount, penceCoinsvalues, recursiveLevel + 1);

            return numberOfDifferentWays;
        }
    }
}
