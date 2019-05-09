using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E069TotientMaximum
    {
        long vSize;
        Totient totient;
        public E069TotientMaximum(int size)
        {
            vSize = size;
            totient = new Totient(1000000);
        }

        public int GetNWithMaxTotient()
        {
            double maxNtoPhi = Double.MinValue;
            int maxN = -1;

            for (int n = 2; n < vSize; n++)
            {
                long phi = totient.Calc(n);
                // n / φ(n)
                double nToPhi = 1.0 * n / phi;
                if (nToPhi > maxNtoPhi)
                {
                    maxNtoPhi = nToPhi;
                    maxN = n;
                 }
            }
            return maxN;
        }
        
    }
}
