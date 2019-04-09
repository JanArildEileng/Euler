using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.util;

namespace jae.euler.lib
{
    public class E049PrimePermutations
    {
        long [] PrimeFactors;
        public E049PrimePermutations()
        {
            PrimeFactors = Primes.GetPrimeFactorsBelowNumber(10000).Where(e => e >= 1000).ToArray<long>(); ;
        } 
        public List<long> Get4DigitsPrimePermutations()
        {
            List<long> result = new List<long> ();

            for(int i=0;i< PrimeFactors.Length-2;i++)
            {
                for(int j=i+1;j< PrimeFactors.Length - 1;j++)
                {
                    long diff1 = PrimeFactors[j] - PrimeFactors[i];
                    if (diff1 > 4500) break;

                    for (int k=j+1;k < PrimeFactors.Length; k++)
                    {
                        long diff2 = PrimeFactors[k] - PrimeFactors[j];
                        if (diff2 > diff1) break;

                        if (diff2==diff1)
                        {
                            if (IsPermutations(PrimeFactors[i], PrimeFactors[j], PrimeFactors[k]))  {
                                long r = (PrimeFactors[i] * 10000+ PrimeFactors[j])*10000+ PrimeFactors[k];
                                result.Add(r);
                            }

                        }

                    }

                }

            }


            return result;
        }

        private bool IsPermutations(long n1,long n2,long n3)
        {
            var liste1 = DigitsList.ConvertToDigitListe(n1).OrderBy(e=>e).ToArray();
            var liste2 = DigitsList.ConvertToDigitListe(n2).OrderBy(e => e).ToArray();
            var liste3 = DigitsList.ConvertToDigitListe(n3).OrderBy(e => e).ToArray();

            for(int i=0;i<4;i++)
            {
                if (liste1[i] != liste2[i] || liste1[i] != liste3[i]) return false;
            }

            return true;
        }



    }
}
