using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E032Pandigitalproducts
    {
        const int MAX = 987654321;

        public long GetSumOfAllPandigitalProucts()
        {
           
            List<long> pandigitalProucts = new List<long>();
            long sq = (long)Math.Sqrt((double)MAX) + 1;


            for (int multiplicand=1; multiplicand< sq; multiplicand++)
            {

                for (int multiplier = multiplicand; multiplier < MAX; multiplier++)
                {
                    long product = multiplicand * multiplier;
                    if (product > MAX) break;
                    if (IdentityIsPandig(multiplicand, multiplier, product)){

                        pandigitalProucts.Add(product);
                    }
                }

            }

            pandigitalProucts = pandigitalProucts.Distinct().ToList();
            long SumOfAllPandigitalProucts = pandigitalProucts.Sum();
            return SumOfAllPandigitalProucts;
        }










        public bool IdentityIsPandig(int multiplicand, int multiplier, long product)
        {
          
            StringBuilder builder = new StringBuilder();
            builder.Append(multiplicand);
            builder.Append(multiplier);
            builder.Append(product);
            var str = builder.ToString();

            if (str.Length > 9) return false;

            try
            {
                int value = int.Parse(str);
                return Pandigital.IsPandigita(value, 9);
            }
            catch (Exception)
            {

                throw;
            }


            return false;
        }

      
    }
}
