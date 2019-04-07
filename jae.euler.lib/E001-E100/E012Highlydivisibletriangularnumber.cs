using jae.euler.math;
using System.Collections.Generic;
using System.Linq;

namespace jae.euler.lib
{
    public class E012Highlydivisibletriangularnumber
    {
        public long GetFirstWithNumbersOfDivisors(long above)
        {          
            foreach (var nextTriangularNumber in TriangleNumber.Iterastor())
            {
                var allUniqueDivisors = Divisors.GetAllUniqueDivisorsIn(nextTriangularNumber);
                if (allUniqueDivisors.Count > above) return nextTriangularNumber;
            }
            return -1;
        }
    }




}
