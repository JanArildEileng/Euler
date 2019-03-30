
using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E021Amicablenumbers
    {
      
        public int GetSumOfAmicablenumbers(int from, int to)
        {
            int SumOfAmicablenumbers = 0;

            for (int i=from;i<to;i++)
            {
                if (AmicableNumbers.IsAmicablenumbers(i) )
                {
                    SumOfAmicablenumbers += i;
                }
            }

            return SumOfAmicablenumbers;
        }
    }
}
