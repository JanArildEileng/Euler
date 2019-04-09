using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E038Pandigitalmultiples
    {
        int MaxPandigital9DigitNumberProduct;

        public int LargestPandigital9DigitNumber()
        {
            MaxPandigital9DigitNumberProduct = 0;

            int[] candidates = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Recursive(0, 0, candidates);

            return MaxPandigital9DigitNumberProduct;
        }

        public bool Recursive(int number,int level, int[] candidates)
        {
            for (int index = 0; index < candidates.Length; index++)
            {
                int nextnumber = number * 10 + candidates[index];

                if (level < 3)
                {
                    if (Recursive(nextnumber, level + 1, candidates.Where(e => e != candidates[index]).ToArray()))
                        return true;
                }

                MaxPandigital9DigitNumberProduct =HasPandigital9DigitNumberProduct(nextnumber);
                if (MaxPandigital9DigitNumberProduct > 0)
                    return true;
            }
            return false;


        }

         public int HasPandigital9DigitNumberProduct(int number)
        {
            String concatenated = number.ToString();

            for (int n=2;n<=9;n++)
            {
                int product = n * number;
                concatenated += product;
                if (concatenated.Length == 9 && Pandigital.IsPandigita(int.Parse(concatenated), 9))
                    return ( int.Parse(concatenated));
                if (concatenated.Length > 9) return 0;

            }

            return 0;
        }
    }
}
