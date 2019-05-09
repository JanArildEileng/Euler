using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jae.euler.math
{
    public class Totient
    {
        List<long> primeFactors;
        Dictionary<long, long> primeDict;

        public Totient(int size)
        {
            primeFactors = Primes.GetPrimeFactorsBelowNumber((long)size);
            primeDict = primeFactors.ToDictionary(e => e);
        }

        public long Calc(int n)
        {
            var oneFraction = new Fraction { Numerator = 1, Denominator = 1 };
            var hele = new Fraction { Numerator = n, Denominator = 1 };
            var prim = Primes.GetPrimeFactorsInNumber(primeFactors, primeDict, n);

            var primes = prim.Distinct();
            List<Fraction> fractionListe = new List<Fraction>(primes.Count());

            if (primes.Count() == 1)
            {
                int antall = prim.Count();
                for (int i = 1; i <= antall; i++)
                {
                    var fr2 = new Fraction { Numerator = prim[0], Denominator = 1 };
                    fractionListe.Add(fr2);
                }

                var fr = new Fraction { Numerator = -1, Denominator = prim[0] };
                var sumFracttion = Fraction.AddFraction(oneFraction, fr);
                fractionListe.Add(sumFracttion);

            }
            else
            {
                foreach (var prime in primes)
                {
                    var fr = new Fraction { Numerator = -1, Denominator = prime };
                    var sumFracttion = Fraction.AddFraction(oneFraction, fr);

                    fractionListe.Add(sumFracttion);
                }


                fractionListe.Add(hele);
            }
     
            long productDenominator = 1;
            long productNumerator = 1;

            fractionListe.ForEach(f => productDenominator *= f.Denominator);
            fractionListe.ForEach(f => productNumerator *= f.Numerator);

            long p = productNumerator / productDenominator;

            return p;
        }


        /* simple slow */
        public int CalcSlow(int n)
        {
            var primes = Primes.GetPrimeFactorsInNumber(n).Distinct();
            return Enumerable.Range(1, n - 1).Where(e => !primes.Any(p => e % p == 0)).Count();

        }

    }
}
