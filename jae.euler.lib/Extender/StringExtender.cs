using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib.Extender
{
    public static class StringExtender
    {
        public static long AlphabeticalValue(this string str) 
        {
            List<int> sumNumbers = str.ToUpper().ToCharArray().Select(c => Convert.ToInt32(c - 'A') + 1).ToList();

            return sumNumbers.Sum();
        }
      

    }
}
