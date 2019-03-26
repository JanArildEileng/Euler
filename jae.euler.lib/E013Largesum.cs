using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.lib.Digits;

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
                sumNumbers = DigitsList.Sum(nextNumber, sumNumbers);
            }

            //lag string ut fra int array , snu tallene
            StringBuilder builder = new StringBuilder();
            sumNumbers.TakeLast(10).Reverse().ToList().ForEach(s => builder.Append(s.ToString() ));
            return builder.ToString();
            

        }

       

    }
}
