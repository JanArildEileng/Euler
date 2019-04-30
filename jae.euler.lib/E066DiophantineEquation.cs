using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E066DiophantineEquation
    {
        /*
         x^2 – Dy^2 = 1
         */


        public long GetDFromLargestXInMinimumSolution(int DMax)
        {
            long foundD = 0;
            long largestX = 0;


          for (int D=1;D<=DMax;D++)
          {
                if (IsSquare(D)) continue;
                long x = GetXInMinimumSolution(D);
                if (x > largestX)
                {
                    largestX = x;
                    foundD = D;

                }
          }

            return foundD;
        }


        public long GetXInMinimumSolution(int D)
        {
            const long MaxX = 10000000;
            for (long y=2;y< MaxX;y++)
            {

                long r = D*y * y + 1;
                if (IsSquare(r))
                {
                    return (long)Math.Sqrt(r);
                }

            }

            return 0;
        //  throw new Exception($"  x above {MaxX} D={D}");
        }

        public long GetXInMinimumSolution2(int D)
        {
            const long MaxX = 100000000;

            long x = 2;
            while (true)
            {
                long r = x * x - 1;

                if (r % D == 0)
                {
                    long y2 = r / D;
                    if (IsSquare(y2))
                    {
                        return x;

                    }
                }
                x++;

                if (x > MaxX) throw new Exception($"  x above {MaxX} D={D}");
            }
        }




        private bool IsSquare(long n)
        {
            long d = (long)Math.Sqrt(n);
            long d2 = (long)(d * d);
            return d2 == n;
        }

     
    }
}
