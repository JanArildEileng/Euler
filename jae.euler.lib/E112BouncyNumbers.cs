using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E112BouncyNumbers
    {
        public int GetLeastNumber(int proportion)
        {
            int total = 0;
            int bouncy = 0;
            int current = 0;

            while(true)
            {
                current++;
                total++;
                if (IsBounching(current))
                {
                    bouncy++;
                }

                if (total * proportion == 100* bouncy)
                    return current;
            }
        }

        public bool IsBounching(int number)
        {
            char[] chars = number.ToString().ToCharArray();

            for (int i = 1; i < chars.Length; i++) { 
                if (chars[i - 1] < chars[i]) {
                    for (int j = 1; j < chars.Length; j++)
                        if (chars[j - 1] > chars[j])
                            return true;

                }
            }

            return false;
        }



    }
}
