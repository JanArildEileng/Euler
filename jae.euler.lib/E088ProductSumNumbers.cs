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

            int minimalProduct = Recursive(numbers,k);


            return minimalProduct;
        }


        private int Recursive(int[] numbers,int k)
        {

            int sum = numbers.Sum()+k-numbers.Length;
            int product = numbers.Aggregate(1, (p, next) => p * next);
            if (sum == product)
                return sum;
            if (product > sum) return -1;


            numbers = numbers.OrderBy(e => e).ToArray();

            var uniq = numbers.Distinct().OrderBy(e => e).ToArray();
            //    int[] clone = (int[])sortedNumers.Clone();

            int step = 1;

            List<int> liste = new List<int>(uniq.Count());


            for (int i=0;i< numbers.Length;i++)
            {
                int e = numbers[i];
                if (liste.Contains(e)) continue;
                else liste.Add(e);
                int[] clone = (int[])numbers.Clone();          
                clone[i] = clone[i] + step;
                int a = Recursive(clone,k);
                if (a > 0) return a;
                if (a < 0)
                {
                    break; ;
                }


            }

            return 0;
        }


        private int[] Create(int[] uniq,int k)
        {
            int[] a = Enumerable.Repeat(1, k).ToArray();
            for (int i = 0; i < uniq.Length; i++)
                a[i] = uniq[i];
            return a;

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
