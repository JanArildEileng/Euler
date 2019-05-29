using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E088ProductSumNumbers
    {
        public int GetMinimalProductSum(int k)
        {
            throw new NotImplementedException();
        }

        public int GetMinimalProduct(int k)
        {
            //   k=2: 4 = 2 × 2 = 2 + 2
            int[] numbers = Enumerable.Repeat(1, k).ToArray();

            int minimalProduct = Recursive(numbers);


            return minimalProduct;
        }


        private int Recursive(int[] numbers)
        {

            int sum = numbers.Sum();
            int product = numbers.Aggregate(1, (p, next) => p * next);
            if (sum == product) return sum;
            if (product > sum) return -1;


            var sortedNumers=numbers.OrderBy(e => e).ToArray();

            for(int i=0;i< sortedNumers.Length;i++)
            {
                int[] clone =(int[] ) sortedNumers.Clone();
                clone[i] = clone[i] + 1;
                int a = Recursive(clone);
                if (a > 0) return a;
                if (a < 0) break;


            }

            return 0;
        }


        private int? CalcProductSumNumber(IEnumerable<int> numbers)
        {
            int sum = numbers.Sum();
            int product= numbers.Aggregate(1, (p, next) =>p*next);

            if (sum == product)  return sum;

            return null;
        }
    }
}
