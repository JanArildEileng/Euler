using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E064OddPeriodSquareRoots
    {

        public class helrest
        {
            public int Hel { get; set; }
            public double Rest { get; set; }
        }


        public int GetNumberOfOddPeriodes(int N)
        {
            int numberOfOddPeriodes = 0;
            for (int i=1;i<=N;i++)
            {

                var periodeLength = GetPeriodsOfSquareRoot(i);
                if (periodeLength % 2 == 1) numberOfOddPeriodes++;

            }

            return numberOfOddPeriodes;
        }

        public int GetPeriodsOfSquareRoot(int number)
        {
            List<helrest> preb = new List<helrest>();

            int a0 = (int)Math.Sqrt(number);
            //   √=[4; (1, 3, 1, 8)] ,

            double b = Math.Sqrt(number) - a0;



            //     preb.Add(new helrest { Hel = a0, Rest = (int)(10000 * b) });
            preb.Add(new helrest { Hel = a0, Rest=0});



            if ( b <0.1)
            {
                var e = 1;
            }

            int periodeLength=f(b, preb)  ;

            double sum = preb[0].Hel;

            if (preb.Count() >1 )
                sum += 1.0/summer(preb, 1);


            if (Math.Abs(sum -Math.Sqrt(number))  >0.2 ) {

                throw new Exception("Difference");
            }
           




            return periodeLength;
        }



        private double summer (List<helrest> preb, int index)
        {

            if (index < (preb.Count - 1))
                return preb[index].Hel + 1.0 / summer(preb, index+1);
            else
                return preb[index].Hel;
        }



        public int f(double b, List<helrest> preb)
        {
            if (b < 0)
                throw new Exception("b er negtraiv");

            if (preb.Count() > 1 && b==0)
            {
                throw new Exception("aa");
            }

            if (b == 0) return 0;
            b = 1.0 / (b);


            int an = (int)b;
            double bb = b - an;
            var helrest = new helrest { Hel = an, Rest = bb };

          

           var treff= preb.Where(r => r.Hel == helrest.Hel &&
            ( ( r.Rest <= (helrest.Rest + 0.01) &&  r.Rest >= (helrest.Rest - 0.01))))
            .ToList();


            //if ( l.Count() >0)
            //{
            //    var ff = 1;
            //}


   
            if (treff.Count()==3)
            {
                int index = preb.IndexOf(treff[0]);
                int index2 = preb.IndexOf(treff[1], index+1);
                int index3 = preb.IndexOf(treff[2], index2 + 1);


                int periodeLength = index2 - index;
                int periodeLength2 = index3 - index2;

                if (periodeLength == periodeLength2)
                {
                    return periodeLength;
                }

            }

           preb.Add(helrest);


            if (preb.Count() > 100)
                throw new Exception("Overflow");

            return f(bb, preb);
        }




    }
}
