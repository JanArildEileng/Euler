using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E076CountingSummations
    {
        int counter;

        public int GetNumberOfDifferentWays(int sum)
        {
            counter = 0;
            Recursive(rest: sum, level: 0);

            return counter;
        }



        private void Recursive(int rest,int level)
        {
            if (rest==0)
            {
                counter += 1;
                return;

            } else
            {
                for(int i= rest; i>=0;i--)
                {
                    Recursive(rest - i, level + 1);
                }

            }

        }
    }
}
