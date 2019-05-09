using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jae.euler.util
{
    public class Permutation
    {
        public static  bool IsPermuted(long number1, long number2)
        {

            char[] str1 = number1.ToString().ToCharArray();
            char[] str2 = number2.ToString().ToCharArray();

            if (str1.Length != str2.Length)
                return false;

            var l1 = str1.OrderBy(c => c).ToArray();
            var l2 = str2.OrderBy(c => c).ToArray();
            for (int i = 0; i < str1.Length; i++)
            {
                if (l1[i] != l2[i])
                    return false;
            }


            return true; ;
        }
    }
}
