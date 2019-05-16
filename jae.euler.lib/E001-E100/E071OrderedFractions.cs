using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E071OrderedFractions
    {
        public long GetNumeratorLeftOf(int dmax, int rightNumerator, int rightDenominator)
        {
            Fraction rightFraction = new Fraction { Numerator = rightNumerator, Denominator = rightDenominator };
            Fraction bestLeft = new Fraction { Numerator = 1, Denominator = dmax };


            for (int i = 2; i <=dmax; i++){
                //   bestleft <  a/i   < rightFraction
                if (i == rightDenominator) continue;

                long a_min = (bestLeft.Numerator * i / bestLeft.Denominator);
                long a_max = (rightFraction.Numerator * i / rightFraction.Denominator);


                if ( a_max > a_min)
                {
                    if (i % rightDenominator==0)
                    {
                        long div = i / rightDenominator;
                        //ignore multiple of rightFraction;
                        if (rightNumerator * div == a_max) continue;
                    }

                    bestLeft = new Fraction { Numerator = a_max, Denominator = i };
                }
            }

            Fraction reduced = Fraction.ReduceFraction(bestLeft);
            return reduced.Numerator;

        }
    }
}
