using jae.euler.math;
using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E033Digitcancellingfractions
    {
        public long GeLowestCommonTerms()
        {
            List<Fraction> denominatorListe = new List<Fraction>();

            for (int denominator=10; denominator<100; denominator++)
            {
                for (int numerator = 10; numerator < denominator; numerator++)
                {
                    Fraction fractionUnderTest = new Fraction { Numerator = numerator, Denominator = denominator };

                    (long high,long low) numeratorDigits = (fractionUnderTest.Numerator / 10, fractionUnderTest.Numerator % 10);
                    (long high, long low) denominatorDigits = (fractionUnderTest.Denominator / 10, fractionUnderTest.Denominator % 10);

                    if (denominatorDigits.low == 0 || numeratorDigits.low == 0) continue;

                    Fraction digitcancellingfraction = null;

                    if (numeratorDigits.high == denominatorDigits.low)
                    {
                        digitcancellingfraction = new Fraction { Numerator = numeratorDigits.low, Denominator = denominatorDigits.high };
                    }
                    else if (numeratorDigits.low == denominatorDigits.high)
                    {
                        digitcancellingfraction = new Fraction { Numerator = numeratorDigits.high, Denominator = denominatorDigits.low };
                    }

                    if (digitcancellingfraction != null)                
                    {
                        digitcancellingfraction = Fraction.ReduceFraction(digitcancellingfraction);

                        if (fractionUnderTest.IsReducedForm(digitcancellingfraction))
                        {
                            denominatorListe.Add(digitcancellingfraction);
                        }

                    } //if digitcancellingfraction

                }  //numerator loop
            } // denominator loop


            var fraction = Fraction.Product(denominatorListe);
            return fraction.Denominator;
        }     
    }
}
