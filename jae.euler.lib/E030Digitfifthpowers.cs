using jae.euler.lib.Digits;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E030Digitfifthpowers
    {
        public int GetSumOfPower(int po)
        {
            int sumOfPower = 0;

            //etter denne verdien vil n alltid være større en powerOfNumber
            int max = 9 * 9 * 9 * 9 * 9*6;
           
            int n = 2;

            while (n< max)
            {
                int powerOfNumber = DigitsList.ConvertToDigitListe(n).Select(d => pow(d, po)).Sum();

                if (powerOfNumber==n)
                {
                    sumOfPower += powerOfNumber;
                }
                n++;
            }

            return sumOfPower;
        }

        private int pow(int number,int pow)
        {
            int res = number;
            for (int i = 2; i <= pow; i++)
                res = res * number;
            return res;
        }

    }
}
