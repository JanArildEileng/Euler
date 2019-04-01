using jae.euler.util;
using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E033Digitcancellingfractions
    {

        public int GeLowestCommonTerms()
        {
            for(int denominator=10; denominator<100; denominator++)
            {

                for (int numerator = 10; numerator < denominator; numerator++)
                {
                    int ahigh = numerator /10;
                    int alow = numerator % 10;

                    int bhigh = denominator / 10;
                    int blow = denominator % 10;

                    if (denominator==98 && numerator==49)
                    {
                        var t2 = 1;
                    }


                    if (blow == 0 || alow == 0) continue;
            
                    if (ahigh ==blow )
                    {
                        ahigh = blow = 0;
                    } else 

                    if (alow == bhigh)
                    {
                        alow = bhigh = 0;
                    }

                    int a = ahigh * 10 + alow;
                    int b = bhigh * 10 + blow;


                    if ( a!= numerator || b!= denominator)
                    {
                        if (denominator % b==0)
                        {
                            int div = denominator / b;
                            if ( a* div== numerator)
                            {
                                var t = 1;
                            }

                        }
              
                       
                    }



                }


            }


            return 1;
        }




        public bool IsDigitcancellingfractions(int numerator, int denominator)
        {

            List<int> numeratorDigits = DigitsList.ConvertToDigitListe(numerator);
            List<int> denominatorDigits = DigitsList.ConvertToDigitListe(denominator);




            throw new NotImplementedException();
        }


        public int LowestCommonTerms(int a, int b)
        {


            return 1;
        }

       
    }
}
