using jae.euler.math;
using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E057SquareRootConvergents
    {

        public int GetNumeratorWithMoreDigitsThanDenominator(int upto)
        {
  
            return Enumerable.Range(1, upto)
                 .Where(iterationNumber => NumeratorHasMoreDigitsThanDenominator(iterationNumber))
                 .Count();

        }




        public bool NumeratorHasMoreDigitsThanDenominator(int iterationNumber)
        {
            /*
                 1 + 1/(2 + 1/2..)
                 1+ 1/seriesum 

              seriesum=t/n
              seriesum=2 +1/seriesum = 2+1/(t/n)=2+n/t=(2*t+n)/t

            */

            List<int> teller = new List<int> { 2 };
            List<int> nevner = new List<int> { 1 };
            
            //seriesum=t/n = 2

            while (iterationNumber > 1)
            {
                // (2*t+n)/t

                //2*t
                //       List<int> a = DigitsList.Product(teller, 2);
                
                //2*t+n
                var tmp2 = DigitsList.Sum(DigitsList.Product(teller, 2), nevner);
                // /t
                nevner = teller;
                teller = tmp2;

                iterationNumber--;
            }

            //1 + 1 / seriesum
            // 1 +1/(t/n) = (n+t)/t
            var tmp = teller;
            teller = DigitsList.Sum(nevner, teller);
            nevner = tmp;

            //finn all siffer i teller og nevner
            return (teller.Count > nevner.Count);
        }


        //ikke i bruk, men nyttig å å forstå...
        public Fraction GetSquareRootConvergents(int iterationNumber)
        {
            Fraction next = new Fraction { Denominator = 1, Numerator = 2 };

            while (iterationNumber > 1)
            {
                Fraction two = new Fraction { Denominator = 1, Numerator = 2 };
                next.Invert();
                next = Fraction.AddFraction(next, two);

                iterationNumber--;
            }

            next.Invert();

            Fraction one = new Fraction { Denominator = 1, Numerator = 1 };

            next = Fraction.AddFraction(next, one);



            return next;
        }



    }
}
