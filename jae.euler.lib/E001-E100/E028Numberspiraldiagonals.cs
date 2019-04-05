using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E028Numberspiraldiagonals
    {
        public int GetSumDiagonal(int size)
        {
            int sumDiagonals = 1;
            int counter = 1;
            int stepsize = 2;


            while (counter <size*size)
            {
                for(int i=0;i<4;i++)
                {
                    counter += stepsize;
                    sumDiagonals += counter;
                }
                stepsize += 2;
            }

            return sumDiagonals;

        }
    }
}
