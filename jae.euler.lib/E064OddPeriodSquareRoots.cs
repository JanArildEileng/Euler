using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E064OddPeriodSquareRoots
    {
     
        public class PeriodParameters
        {
            public int an { get; set; }
            public int sub { get; set; }
            public double f { get; set; }
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


        public int GetPeriodsOfSquareRoot(int N)
        {
            int a0 = GetClosestIntegertToSquare(N);

            if (a0 * a0 == N) return 0;
 
            List<PeriodParameters> periodParameterList = new List<PeriodParameters>();

            var periodParameters = new PeriodParameters { an = a0,sub=-a0, f = 1.0 };
            periodParameterList.Add(periodParameters);

            while (periodParameterList.Count < 300)
            {
                periodParameters = CalcNextPeriodParameters(a0, N, periodParameters);
                periodParameterList.Add(periodParameters);

                var treff = periodParameterList.Where(r => r.an == periodParameters.an && r.sub == periodParameters.sub && Math.Abs(r.f- periodParameters.f) < 0.10).ToList();

                if (treff.Count() == 2)
                {
                    int index = periodParameterList.IndexOf(treff[0]);
                    int index2 = periodParameterList.Count()-1;

                    return index2 - index;
                }
            }
            throw new Exception($"Periode ikke funnet for {N}");
        }

        public PeriodParameters CalcNextPeriodParameters(int a0,int N, PeriodParameters tt)
        {
            int f2 = N - tt.sub * tt.sub;

            int an = 0;
            while(  - ( (an+1)*f2/tt.f)  +(-1)*tt.sub  >=-a0 )
            {
                an++;
            }

            int sub =(int) -((an) * f2 / tt.f) + (-1) * tt.sub;

            var nextPeriodParameters = new PeriodParameters { an = an, sub = sub, f=(f2/tt.f ) };
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

    }
}
