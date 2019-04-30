using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E063PowerfulDigitCounts
    {
     
        public int GetNumberIntegerWhichAreNthPoweres()
        {
            int numberIntegerWhichAreNthPoweres = 0;
            for(int x=1;x<10;x++)
            {
                List<int> powerNumber = new List<int> { x }; //larger than long

                int nthPower = 1;
                while (powerNumber.Count == nthPower)
                {
                    numberIntegerWhichAreNthPoweres++;
                    powerNumber = DigitsList.Product(powerNumber, x);
                    nthPower++;
                }
            }

           return numberIntegerWhichAreNthPoweres;
        }
    }
}
