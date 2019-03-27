using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E008Largestproductinaseries
    {
        public long GetLagrestProduct(long nrSeq, string testString)
        {
            // var ToCharArray = testString.ToCharArray().Select(c=> Convert.ToInt32(c)).ToArray();

            long[] ToCharArray = new long[1000];

            for(int i=0;i< testString.Length;i++)
            {
                ToCharArray[i] = int.Parse(testString.Substring(i, 1));
            }
          
            



            long slutt = ToCharArray.Length - nrSeq + 1;
            long maxProduct = 0;

            for(int i=0; i< slutt;i++)
            {
                long product = 1;
                for(var j=0;j< nrSeq;j++)
                {
                    product *= ToCharArray[j+i];
                }
                if (product > maxProduct) maxProduct = product;

            }



            return maxProduct;
        }
    }
}
