using jae.euler.math;
using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jae.euler.lib
{
    public class E065ConvergentsOfE
    {
        public int GetSumOfDigits(int convergentNumber)
        {
            //    e =[2; 1,2,1,1,4,1,1,6,1,...,1,2k,1,...].


            var aseqvence = new Fraction { Numerator = 2, Denominator = 1 };

            if (convergentNumber>1)
            {
                var a = GetE(1, convergentNumber-1);
                aseqvence = Fraction.AddFraction(aseqvence, a);


            }

            aseqvence = Fraction.ReduceFraction(aseqvence);


            if (aseqvence.Numerator < 0)
                throw new Exception("Numerator <0");
            if (aseqvence.Denominator < 0)
                throw new Exception("Denominator <0");


            var digitsList = DigitsList.ConvertToDigitListe(aseqvence.Numerator);

    

            var sum = digitsList.Sum();


            return sum;



        }



        private Fraction GetE(int sequenceNumber,int max)
        {
            int i;
            if (sequenceNumber % 3 == 1 || sequenceNumber % 3 == 0) i = 1;
            else i = 2 * (1 + sequenceNumber / 3);

            if (sequenceNumber==max)
                return  new Fraction { Numerator = 1, Denominator = i };



            var iFrac=new Fraction { Numerator = i, Denominator = 1 };
            var rest = GetE(sequenceNumber +1, max);

            var sum = Fraction.AddFraction(iFrac, rest);

            sum.Invert();

            //if (sum.Numerator % 2 == 0 && sum.Denominator % 2 == 0)
            //{
            //    sum.Numerator /= 2;
            //    sum.Denominator /= 2;
            //}
            //if (sequenceNumber % 10 ==9)
            //{
            //           sum = Fraction.ReduceFraction(sum);

            //}



            return sum;
        }

    }
}
