using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.math;

namespace jae.euler.lib
{
    public class E042Codedtrianglenumbers
    {
        long[] triangleNumbers;

        public E042Codedtrianglenumbers(int wordMaxLength)
        {
            triangleNumbers = TriangleNumber.Iterastor(max: 26 * wordMaxLength).ToArray();
        }


        public int GetNumberOfTriangleWords(List<string> list)
        {
            return 
                list.Where(w => IsTriangleWord(w)).Count();    
        }

        public bool IsTriangleWord(string word)
        {
             var sum= word.ToCharArray().Select(c => c - 'A' + 1).Sum();
             return triangleNumbers.Contains(sum);        
        }
    }
}
