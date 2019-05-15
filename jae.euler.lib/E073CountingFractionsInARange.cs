using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E073CountingFractionsInARange
    {
        public long GetNumberOfFractionsBetween(int dmax, int leftNumerator, int leftDenominator, int rightNumerator, int rightDenominator)
        {
            long numberOfFractionsBetween = 0;
            Fraction leftFraction = new Fraction { Numerator = leftNumerator, Denominator = leftDenominator };
            Fraction rightFraction = new Fraction { Numerator = rightNumerator, Denominator = rightDenominator };


            for (int i = 2; i <= dmax; i++)
            {
                //   bestleft <  a/i   < rightFraction
                //    if (i == rightDenominator) continue;
                if (i == leftFraction.Denominator || i == rightFraction.Denominator) continue;


               long  a_min = (leftFraction.Numerator * i / leftFraction.Denominator);
               long  a_max = (rightFraction.Numerator * i / rightFraction.Denominator);

               for (long l= a_min+1;l<=a_max;l++ )
                {
                    numberOfFractionsBetween += 1;

                }

            }

         //   Fraction reduced = Fraction.ReduceFraction(bestLeft);
            return numberOfFractionsBetween;

        }
    }
}
