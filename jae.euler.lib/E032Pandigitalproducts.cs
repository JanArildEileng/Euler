using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E032Pandigitalproducts
    {
        List<long> pandigitalProucts;

        public long GetSumOfAllPandigitalProucts()
        {
            int[] candidates = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            pandigitalProucts = new List<long>();

            MultiplicandRecursive(multiplicand: 0,candidates:candidates, level:0 );

            return pandigitalProucts.Distinct().ToList().Sum(); 
        }

        private void MultiplicandRecursive(int multiplicand,int[] candidates, int level )
        {
            if (level > 4) return;

            for(int i=0;i< candidates.Length;i++)
            {
                int nextDigit = candidates[i];
                var nextCandidates = candidates.Where(e => e != nextDigit).ToArray();
                var nextmultiplicand = multiplicand * 10 + nextDigit;
                MultiplierRecursive(nextmultiplicand, multiplier:0, candidates: nextCandidates, level:level+1);
                MultiplicandRecursive(multiplicand: nextmultiplicand, candidates: nextCandidates, level: level + 1);
            }
        }

        private void MultiplierRecursive(int multiplicand,int multiplier, int[] candidates, int level)
        {
            if (level >4) return;

            //current product
            for (int i = 0; i < candidates.Length; i++)
            {
                int nextDigit = candidates[i];
                int nextmultiplier = 10 * multiplier + nextDigit;
  
                long product = multiplicand * nextmultiplier;
                if (IdentityIsPandig(multiplicand, nextmultiplier, product))
                {
                    pandigitalProucts.Add(product);
                }

                var nextCandidates = candidates.Where(e => e != nextDigit).ToArray();
                //recursive
                MultiplierRecursive(multiplicand: multiplicand, multiplier: nextmultiplier, candidates: nextCandidates, level: level + 1);
            }

        }



        public bool IdentityIsPandig(int multiplicand, int multiplier, long product)
        {
          
            StringBuilder builder = new StringBuilder();
            builder.Append(multiplicand);
            builder.Append(multiplier);
            builder.Append(product);
            var str = builder.ToString();

            if (str.Length > 9) return false;
            if (str.Length < 9) return false;



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
