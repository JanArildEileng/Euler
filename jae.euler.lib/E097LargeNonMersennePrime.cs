using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E097LargeNonMersennePrime
    {
        public string GetLastTenDigits(long num, long exp)
        {
            long p = num;
            for(int i=0;i< exp; i++)
            {
                p *= 2;
                if ( p > 100000000000)
                {
                    p = p % 100000000000;
                }
            }

            long x =  p + 1;
            var s = x.ToString();
            s = s.Substring(s.Length - 10);
            return s;
        }
    }
}
