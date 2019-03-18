using System;
using System.Collections.Generic;
using System.Linq;

namespace jae.euler.lib
{
    public class E1Multiplesof3and5
    {
        public int Sum(int below)
        {
            var list = new List<int>();

            for(int i=3;i< below;i++)
            {
                if ( i% 3==0) list.Add(i);
                else if (i % 5 == 0) list.Add(i);
            }


      //      list.ForEach(e => Console.WriteLine($"{ e} "));

            var sum = list.Sum();
            return sum;
        }
    }
}
