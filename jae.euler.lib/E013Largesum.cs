using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E013Largesum
    {
        public string GetSum(string[] stringArray)
        {
   
            List<int> sumNumbers = stringArray[0].ToCharArray().Reverse().Select(c => Convert.ToInt32(c - '0')).ToList();

            //skip first, used in init above..
            foreach (var s in stringArray.Skip(1))
            {
                List<int> nextNumber = s.ToCharArray().Reverse().Select(c => Convert.ToInt32(c - '0')).ToList();
                sumNumbers = Sum(nextNumber, sumNumbers);
            }

            //lag string ut fra int array , snu tallene
            StringBuilder builder = new StringBuilder();
            sumNumbers.TakeLast(10).Reverse().ToList().ForEach(s => builder.Append(s.ToString() ));
            return builder.ToString();
            

        }

        private List<int> Sum(List<int> numbers1, List<int> numbers2)
        {
            List<int> sum = new List<int>();
            int rest = 0;
            int i=0;
            while(numbers1.Count > i || numbers2.Count > i || rest > 0) {
                int s = rest;
                s += numbers1.Count > i ? numbers1[i] : 0;
                s += numbers2.Count > i ? numbers2[i] : 0;

                sum.Add(s % 10);
                rest = s / 10;
                i++;
            }

            return sum;

        }

    }
}
