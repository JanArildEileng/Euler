using jae.euler.math;
using System.Collections.Generic;
using System.Linq;

namespace jae.euler.lib
{
    public class E012Highlydivisibletriangularnumber
    {
        public long GetFirstWithNumbersOfDivisors(long above)
        {
            var triangularNumber = new TriangularNumber();


            foreach (var nextTriangularNumber in triangularNumber.Iterastor())
            {
                var allUniqueDivisors = Divisors.GetAllUniqueDivisorsIn(nextTriangularNumber);
                if (allUniqueDivisors.Count > above) return nextTriangularNumber;
            }
            return -1;
        }


      




    }




}
