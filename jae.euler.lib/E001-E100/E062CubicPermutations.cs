using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E062CubicPermutations
    {
        const int SIZE = 10000;
        public long GetSmallestCube(int numberOfpermutations)
        {
            var cubes = Enumerable.Range(1, SIZE).
                Select(n => (long)n * n * n).
                Select(value => new  { value = value, permutations = ConvertToSmallestPermutationString(value) }).
                ToList();

            return cubes.
                GroupBy(i => i.permutations).
                Where(g => g.Count() == numberOfpermutations).
                Select(g => g.Select(n => n.value).Min()).
                Min();
        }


        private string ConvertToSmallestPermutationString(long number)
        {
            return  new String(number.ToString().ToArray().OrderBy(c => c).ToArray());
        }


    }
}
