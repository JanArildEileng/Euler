using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.util;

namespace jae.euler.lib
{
    public class E080SquareRootDigitalExpansion
    {
        public class PeriodParameters
        {
            public int an { get; set; }
            public int sub { get; set; }
            public double f { get; set; }
        }



        public int GetDigitalSumSquareRoot(int number)
        {
            //   GetPeriodsOfSquareRoot(number);
            NumeratorHasMoreDigitsThanDenominator(number);
            return 0;
        }

        public int GetDigitalSumSquareRoot()
        {
            int totalSum = 0;

            for(int i=1;i<=100;i++)
            {

                int sum = GetDigitalSumSquareRoot(i);
                totalSum += sum;
            }

            return totalSum;
        }

        public int GetPeriodsOfSquareRoot(int N)
        {
            int a0 = GetClosestIntegertToSquare(N);

            if (a0 * a0 == N) return 0;

            List<PeriodParameters> periodParameterList = new List<PeriodParameters>();

            var periodParameters = new PeriodParameters { an = a0, sub = -a0, f = 1.0 };
            periodParameterList.Add(periodParameters);

            while (periodParameterList.Count < 300)
            {
                periodParameters = CalcNextPeriodParameters(a0, N, periodParameters);
                periodParameterList.Add(periodParameters);

                var treff = periodParameterList.Where(r => r.an == periodParameters.an && r.sub == periodParameters.sub && Math.Abs(r.f - periodParameters.f) < 0.10).ToList();

                //if (treff.Count() == 2)
                //{
                //    int index = periodParameterList.IndexOf(treff[0]);
                //    int index2 = periodParameterList.Count() - 1;

                //    return index2 - index;
                //}
            }
            throw new Exception($"Periode ikke funnet for {N}");
        }

        public PeriodParameters CalcNextPeriodParameters(int a0, int N, PeriodParameters tt)
        {
            int f2 = N - tt.sub * tt.sub;

            int an = 0;
            while (-((an + 1) * f2 / tt.f) + (-1) * tt.sub >= -a0)
            {
                an++;
            }

            int sub = (int)-((an) * f2 / tt.f) + (-1) * tt.sub;

            var nextPeriodParameters = new PeriodParameters { an = an, sub = sub, f = (f2 / tt.f) };
            return nextPeriodParameters;
        }


        private int GetClosestIntegertToSquare(int N)
        {
            int a0 = 1;

            for (int i = 2; i < N; i++)
            {
                if (i * i <= N)
                {
                    a0 = i;
                }
                else
                    break;
            }
            return a0;
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
            return (teller.Count >100);
        }


    }
}
