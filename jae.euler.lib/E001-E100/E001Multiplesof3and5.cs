using System;
using System.Collections.Generic;
using System.Linq;

namespace jae.euler.lib
{
    public class E001Multiplesof3and5
    {
        public int Sum(int below)
        {

           return  Enumerable
                .Range(1, count:below - 1)
                .Where(i => (i % 3 == 0) || (i % 5) == 0)
                .Sum();
        }
    }
}
