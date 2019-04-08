using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E044Pentagonnumbers
    {
        public long GetMinimumD()
        {
            long MinimumD = long.MaxValue;
    
            var pentagonnumberdictionary = Pentagonnumber.Iterastor().Take(100000).ToDictionary(e => e); ;

            long n = 1;
            while (true)
            {
                //TODO...ikke sikker om dette er minium...hvordan kan det besvisses..?
                var currentMinimumD = GetCurrentMinimumD(n, pentagonnumberdictionary);
                if (currentMinimumD < MinimumD)
                {
                    return currentMinimumD;
                }
                n++;    
          
            }


            return MinimumD;
        }


        private long GetCurrentMinimumD(long n,Dictionary<long,long> pentagonnumberdictionary)
        {
            long nvalue = Pentagonnumber.GetNumber(n);
            for(long np=n-1;np>=1;np--)
            {
                long npvalue = Pentagonnumber.GetNumber(np);
                long sum = nvalue + npvalue;
                long diff = nvalue - npvalue;
                if (pentagonnumberdictionary.ContainsKey(sum) && pentagonnumberdictionary.ContainsKey(diff))
                    return (nvalue-npvalue);
            }

            return long.MaxValue;
        }

    }
}
