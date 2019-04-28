using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E052PermutedMultiples
    {

        public int  GetSmallest6Times()
        {
            int i = 1;
            while(i < int.MaxValue)
            {
                char[] str1 = i.ToString().ToCharArray().OrderBy(c => c).ToArray();
                bool permuted = true;
                int x = 1;

                while (permuted && x <6)
                {
                    x++;
                    char[] str2 = (i*x).ToString().ToCharArray().OrderBy(c => c).ToArray();
                    permuted = IsPermuted(str1, str2);
                }

                if (permuted)
                    return i;
 
                i++;
            }
            return -1;
        }



        private bool IsPermuted(char[] str1, char[] str2)
        {

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


        public bool IsPermuted(int number1, int number2)
        {

            char [] str1 = number1.ToString().ToCharArray();
            char[] str2 = number2.ToString().ToCharArray();

            if (str1.Length != str2.Length)
                return false;

            var l1= str1.OrderBy(c => c).ToArray();
            var l2 = str2.OrderBy(c => c).ToArray();
            for(int i=0;i< str1.Length;i++)
            {
                if (l1[i] != l2[i])
                    return false;
            }


            return true; ;
        }

      
    }
}
