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

        public long[] GetReplacementPrimes(string numberString)
        {
            int maxPrime = StringToNumber.GetMaxNumber(numberString);
            int minPrime = StringToNumber.GetMinNumber(numberString);
            PrimeDictionary = Primes.GetPrimeFactorsBelowNumber(maxPrime).ToDictionary(e => e);


            List<long> replacementPrimes = new List<long>();


            char[] chararray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for(int i=0;i<=9;i++)
            {
                string s = numberString.Replace('*', chararray[i]);

                
                long number = long.Parse(s);

                if (number > minPrime && PrimeDictionary.ContainsKey(number))
                    replacementPrimes.Add(number); ;
            }

            return replacementPrimes.ToArray(); ;
        }

        public long GetSmallestReplacementPrimes(string numberString)
        {
            long[] replacementPrimes = GetReplacementPrimes(numberString);
            if (replacementPrimes.Length>0)
                return replacementPrimes[0];
            return -1;

        }

        public long GetSmallestReplacementPrimesWith(int startnumber,int maxNumber, int primevalfamily)
        {
            PrimeDictionary = Primes.GetPrimeFactorsBelowNumber(maxNumber).ToDictionary(e => e);

            int numberOfReplaceMentFound = 0;

            List<int> digits = DigitsList.ConvertToDigitListe(startnumber);

            while (numberOfReplaceMentFound< primevalfamily)
            {


            }


            throw new NotImplementedException();
        }
    }
}
