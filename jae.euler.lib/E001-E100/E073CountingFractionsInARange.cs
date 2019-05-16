using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jae.euler.lib
{
    public class E073CountingFractionsInARange
    {
        public long GetNumberOfFractionsBetween(int denominatorMax, int leftNumerator, int leftDenominator, int rightNumerator, int rightDenominator)
        {
            long numberOfFractionsBetween = 0;
            Fraction leftFraction = new Fraction { Numerator = leftNumerator, Denominator = leftDenominator };
            Fraction rightFraction = new Fraction { Numerator = rightNumerator, Denominator = rightDenominator };


            for (int denominator = 2; denominator <= denominatorMax; denominator++)
            {
                // finn  interval av numerator slik at   leftFraction < numeratorStart/denominator  &&     numeratorEnd/denominator < rightFraction

               long numeratorStart = (long)Math.Ceiling((double)(leftFraction.Numerator * 1.0* denominator / leftFraction.Denominator));
               long numeratorEnd = (rightFraction.Numerator * denominator / rightFraction.Denominator);

                if (numeratorEnd >= numeratorStart) { 

                    //border cases
                    if (denominator % rightDenominator == 0)
                    {
                        long div = denominator / rightDenominator;
                        if (rightNumerator * div == numeratorEnd) numeratorEnd--;
                    }

                    if (denominator % leftDenominator == 0)
                    {
                        long div = denominator / leftDenominator;
                        if (leftNumerator * div == numeratorStart) numeratorStart++;
                    }

                     numberOfFractionsBetween += GetNoneReducableInInterval(numeratorStart, numeratorEnd, denominator);
                }
            }
            return numberOfFractionsBetween;
        }


        //hvis Numerator har felles primetall med  denominator, kan brøken reduseres..
        private int GetNoneReducableInInterval(long numeratorStart, long numeratorEnd, int denominator)
        {
            int counter = 0;

            List<long> PrimeFactorsInDenominator = Primes.GetPrimeFactorsInNumber(denominator).ToList();

            for (long numerator = numeratorStart; numerator <= numeratorEnd; numerator++)
            {
               if ( !PrimeFactorsInDenominator.Any(p=> numerator % p==0))
                    counter++;
            }
            return counter;
        }


    }
}
