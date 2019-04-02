using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.math
{
    public class Fraction
    {
        public long Numerator { get; set; }
        public long Denominator { get; set; }

        public Boolean IsReducedForm(Fraction fraction)
        {
            if (Denominator % fraction.Denominator == 0)
            {
                long div = Denominator / fraction.Denominator;
                if (fraction.Numerator * div == Numerator)
                {
                    return true;
                }
            }

            return false;
        }

        public static Fraction ReduceFraction(Fraction fraction)
        {
            if (fraction.Denominator % fraction.Numerator == 0)
            {
                return new Fraction { Numerator = 1, Denominator = fraction.Denominator / fraction.Numerator};
            }

            List<long> PrimeFactorsInDenominator = Primes.GetPrimeFactorsInNumber(fraction.Denominator).ToList();
            List<long> PrimeFactorsInNumerator = Primes.GetPrimeFactorsInNumber(fraction.Numerator).ToList();

            List<long> ReducedDenominator = new List<long>();
            List<long> ReducedNumerator = new List<long>();

            var iterator1 = PrimeFactorsInDenominator.GetEnumerator();
            var iterator2 = PrimeFactorsInNumerator.GetEnumerator();

            bool more1 = iterator1.MoveNext();
            bool more2 = iterator2.MoveNext();

            while (more1 && more2)
            {

                if (iterator1.Current == iterator2.Current)
                {
                    more1 = iterator1.MoveNext();
                    more2 = iterator2.MoveNext();
                    continue;
                }

                if (iterator1.Current < iterator2.Current)
                {
                    ReducedDenominator.Add(iterator1.Current);
                    more1 = iterator1.MoveNext();
                    continue;
                }

                if (iterator1.Current > iterator2.Current)
                {
                    ReducedNumerator.Add(iterator2.Current);
                    more2 = iterator2.MoveNext();
                    continue;
                }
            }
            while (more1)
            {
                ReducedDenominator.Add(iterator1.Current);
                more1 = iterator1.MoveNext();
            }

            while (more2)
            {
                ReducedNumerator.Add(iterator2.Current);
                more2 = iterator2.MoveNext();
            }

            long Denominator = 1;
            for (int index = 0; index < ReducedDenominator.Count; index++)
            {
                Denominator *= ReducedDenominator[index];
            }

            long Numerators = 1;
            for (int index = 0; index < ReducedNumerator.Count; index++)
            {
                Numerators *= ReducedNumerator[index];
            }


            return new Fraction { Numerator = Numerators, Denominator = Denominator };
        }


        public static Fraction Product(List<Fraction> liste)
        {
            List<long> Numerators = liste.Select(e => e.Numerator).ToList();


            List<long> PrimeFactorsInNumber1 = Primes.GetPrimeFactorsInNumber(liste[0].Denominator).ToList();


            //     List<long> CommonPrimeFactors = new List<long>();

            List<long> combined = new List<long>();

            for (int index = 1; index < liste.Count; index++)
            {
                combined = new List<long>();

                List<long> PrimeFactorsInNumber2 = Primes.GetPrimeFactorsInNumber(liste[index].Denominator).ToList();


                var iterator1 = PrimeFactorsInNumber1.GetEnumerator();
                var iterator2 = PrimeFactorsInNumber2.GetEnumerator();

                bool more1 = iterator1.MoveNext();
                bool more2 = iterator2.MoveNext();

                while (more1 && more2)
                {

                    if (iterator1.Current == iterator2.Current)
                    {
                        combined.Add(iterator1.Current);
                        combined.Add(iterator2.Current);
                        more1 = iterator1.MoveNext();
                        more2 = iterator2.MoveNext();
                        continue;
                    }

                    if (iterator1.Current < iterator2.Current)
                    {
                        combined.Add(iterator1.Current);
                        more1 = iterator1.MoveNext();
                        continue;
                    }

                    if (iterator1.Current > iterator2.Current)
                    {
                        combined.Add(iterator2.Current);
                        more2 = iterator2.MoveNext();
                        continue;
                    }
                }
                while (more1)
                {
                    combined.Add(iterator1.Current);
                    more1 = iterator1.MoveNext();
                }

                while (more2)
                {
                    combined.Add(iterator2.Current);
                    more2 = iterator2.MoveNext();
                }

                PrimeFactorsInNumber1 = combined;
            } //



            long LowestCommonTerms = 1;
            for (int index = 0; index < combined.Count; index++)
            {
                LowestCommonTerms *= combined[index];
            }

            long CommonNumerators = 1;
            for (int index = 0; index < Numerators.Count; index++)
            {
                CommonNumerators *= Numerators[index];
            }


            var fraction = new Fraction { Numerator = CommonNumerators, Denominator = LowestCommonTerms };
            fraction = Fraction.ReduceFraction(fraction);
            return fraction;
        }
    }
}
