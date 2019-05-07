using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace jae.euler.lib
{
    public class E066DiophantineEquation
    {
        /* x^2 – Dy^2 = 1 */

        public BigInteger GetXInMinimumSolution(int D)
        {
            double SqrtD = Math.Sqrt(D);
            int q = (int)(SqrtD + 0.5);

            double P = 0;
            double Q = 1;

            BigInteger[] APrevious = { 0, 1 };
            BigInteger[] BPrevious = { -1, 0 };

            while (true)
            {
                P = q * Q - P;
                Q = (P * P - D) / Q;

                BigInteger A = q * APrevious[1] - APrevious[0];
                BigInteger B = q * BPrevious[1] - BPrevious[0];

                APrevious[0] = APrevious[1];
                APrevious[1] = A;
                BPrevious[0] = BPrevious[1];
                BPrevious[1] = B;

                double t = (P + SqrtD) / Q;

                if (t > 0)
                    q = (int)(0.5 + t);
                else
                    q = (int)(-0.5 + t);

                if (A * A - D * B * B == 1) return   A>0?A:-A;
            }


            throw new Exception("Not found");
        }


     

        public long GetDFromLargestXInMinimumSolution(int DMax)
        {
            long foundD = 0;
            BigInteger largestX = 0;


          for (int D=1;D<=DMax;D++)
          {
                if (IsSquare(D)) continue;
                BigInteger x =  GetXInMinimumSolution(D);
                if (x > largestX)
                {
                    largestX = x;
                    foundD = D;

                }
          }

            return foundD;
        }


       
        




        private bool IsSquare(long n)
        {
            long d = (long)Math.Sqrt(n);
            long d2 = (long)(d * d);
            return d2 == n;
        }

     
    }
}
