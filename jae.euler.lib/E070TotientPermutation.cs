using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jae.euler.lib
{
    public class E070TotientPermutation
    {
        private int vSize;
        List<long> primeFactors;
        Dictionary<long, long> primeDict;

        public E070TotientPermutation(int size)
        {
            primeFactors = Primes.GetPrimeFactorsBelowNumber((long)size);
            primeDict = primeFactors.ToDictionary(e => e);
            vSize = size;
        }


        public int GetNWithMinTotient()
        {

            double min = Double.MaxValue;
            int nMin = -1;

            for(int n=2;n< vSize;n++)
            {
                long phi = Totient(n);

                if (IsPermuted(phi,n) )
                {
                    double t = 1.0 * n / phi;
                    if (t < min)
                    {
                        min = t;
                        nMin = n;
                    }
                }


            }
            return nMin;

        }


        public bool IsPermuted(long number1, long number2)
        {

            char[] str1 = number1.ToString().ToCharArray();
            char[] str2 = number2.ToString().ToCharArray();

            if (str1.Length != str2.Length)
                return false;

            var l1 = str1.OrderBy(c => c).ToArray();
            var l2 = str2.OrderBy(c => c).ToArray();
            for (int i = 0; i < str1.Length; i++)
            {
                if (l1[i] != l2[i])
                    return false;
            }


            return true; ;
        }




        public long Totient(int n)
        {
            var oneFraction = new Fraction { Numerator = 1, Denominator = 1 };
            var hele = new Fraction { Numerator = n, Denominator = 1 };
            var prim = Primes.GetPrimeFactorsInNumber(primeFactors, primeDict, n);

            var primes = prim.Distinct();
            List<Fraction> fractionListe = new List<Fraction>(primes.Count());

            if (primes.Count()==1)
            {
                int antall = prim.Count();
                for(int i=1;i<= antall;i++)
                {
                    var fr2 = new Fraction { Numerator = prim[0], Denominator =1 };
                    fractionListe.Add(fr2);
                }

                var fr = new Fraction { Numerator = -1, Denominator = prim[0] };
                var sumFracttion = Fraction.AddFraction(oneFraction, fr);
                fractionListe.Add(sumFracttion);

            } else
            {
                foreach (var prime in primes)
                {
                    var fr = new Fraction { Numerator = -1, Denominator = prime };
                    var sumFracttion = Fraction.AddFraction(oneFraction, fr);

                    fractionListe.Add(sumFracttion);
                }

              
                fractionListe.Add(hele);
            }
            //var fractionProduct = Fraction.Product(fractionListe);
            //Fraction reducedFraction = Fraction.ReduceFraction(fractionProduct);
            // if (reducedFraction.Denominator != 1) throw new Exception("Denominator not 1");

            //          return reducedFraction.Numerator;

            long commonDenominator = 1;
            long commonNumerator = 1;

            fractionListe.ForEach(f => commonDenominator *= f.Denominator);
            fractionListe.ForEach(f => commonNumerator *= f.Numerator);



            long p = commonNumerator / commonDenominator;

            return p;

            //            var fractionProduct = Fraction.Product(fractionListe);
            //      var fractionProduct= new Fraction { Numerator = commonNumerator, Denominator = commonDenominator};

            //      var fractionProduct= new Fraction { Numerator = commonNumerator, Denominator = commonDenominator};



      //      return 1;
     //       Fraction reducedFraction = Fraction.ReduceFraction(fractionProduct);

        //    if (reducedFraction.Denominator != 1) throw new Exception("Denominator not 1");

//            return reducedFraction.Numerator;

        }
    }
}
