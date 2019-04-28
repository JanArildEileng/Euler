using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.util;

namespace jae.euler.lib
{
    public class E051PrimeDigitReplacements
    {
        Dictionary<long, long> PrimeDictionary;
        int minPrime;
        char[] chararray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
       

        public long GetSmallestReplacementPrimesWith(int startnumber, int maxNumber, int primevalfamily)
        {
            PrimeDictionary = Primes.GetPrimeFactorsBelowNumber(maxNumber).ToDictionary(e => e);
            minPrime = startnumber;


            while (startnumber < maxNumber)
            {
                var str = startnumber.ToString();
                int max = 1 << str.Length;

                for (int hidingNumber = 1; hidingNumber < max; hidingNumber++)
                {
                    var str2 = Star.Hide(str, hidingNumber);
                    long[] re = GetReplacementPrimes(str2);

                    if (re.Length == primevalfamily)
                        return re[0];
                }

                startnumber++;
                while (startnumber % 2 == 0 || startnumber % 3 == 0)
                    startnumber++;
            }

            return -1;
        }

        private  long[] GetReplacementPrimes(string numberString)
        {
          //  int minPrime = StringToNumber.GetMinNumber(numberString);
 
            List<long> replacementPrimes = new List<long>();

           
            for(int i=0;i<=9;i++)
            {
                string s = numberString.Replace('*', chararray[i]);             
                long number = long.Parse(s);
                if (number > minPrime && PrimeDictionary.ContainsKey(number))
                        replacementPrimes.Add(number); ;
            }

            return replacementPrimes.ToArray(); ;
        }
       
    }
}
