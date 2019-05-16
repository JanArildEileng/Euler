using jae.euler.math;
using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jae.euler.lib
{

    class BigFraction
    {
        public List<int> Numerator { get; set; }
        public List<int> Denominator { get; set; }

        public static BigFraction AddFraction(BigFraction a,BigFraction b)
        {
            List<int> t1 = DigitsList.Product(a.Numerator, b.Denominator);
            List<int> t2 = DigitsList.Product(b.Numerator, a.Denominator);
            var num = DigitsList.Sum(t1, t2);
            var dem = DigitsList.Product(a.Denominator, b.Denominator);

            return new BigFraction { Numerator=num,Denominator=dem };
        }

        public void Invert()
        {
            var tmp = Numerator;
            Numerator = Denominator;
            Denominator = tmp;
        }


        public static BigFraction ReduceFraction(BigFraction a)
        {
         
            var num = a.Numerator;
            var dem = a.Denominator;

            return new BigFraction { Numerator = num, Denominator = dem };
        }
    }


    public class E065ConvergentsOfE
    {
        public int GetSumOfDigits(int convergentNumber)
        {
            //    e =[2; 1,2,1,1,4,1,1,6,1,...,1,2k,1,...].


            var aseqvence = new BigFraction { Numerator = new List<int> { 2}, Denominator = new List<int> { 1 } };

            if (convergentNumber>1)
            {
                var a = GetE(1, convergentNumber-1);
                aseqvence = BigFraction.AddFraction(aseqvence, a);


            }

            aseqvence = BigFraction.ReduceFraction(aseqvence);


            //if (aseqvence.Numerator < 0)
            //    throw new Exception("Numerator <0");
            //if (aseqvence.Denominator < 0)
            //    throw new Exception("Denominator <0");


            //   var digitsList = DigitsList.ConvertToDigitListe(aseqvence.Numerator);
            var digitsList = aseqvence.Numerator;



            var sum = digitsList.Sum();


            return sum;



        }



        private BigFraction GetE(int sequenceNumber,int max)
        {
            int i;
            if (sequenceNumber % 3 == 1 || sequenceNumber % 3 == 0) i = 1;
            else i = 2 * (1 + sequenceNumber / 3);

            if (sequenceNumber==max)
                return  new BigFraction { Numerator = new List<int> { 1 }, Denominator = new List<int> { i } };



            var iFrac=new BigFraction { Numerator = new List<int> { i }, Denominator = new List<int> { 1 } };
            var rest = GetE(sequenceNumber +1, max);

            var sum = BigFraction.AddFraction(iFrac, rest);

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
