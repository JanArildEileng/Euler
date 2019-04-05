using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E039Integerrighttriangles
    {
        /*
          a+b+c=perimeter;
          a*a+b*b=c*c 
         */

        public int  GetNumberOfsolutions(int perimeter)
        {
            int numberOfsolutions = 0;
            //c kan max være 1/2 av perimeter , min 1/3
            for (int c=perimeter/2;c > perimeter/3; c--)
            {
                int cc = c * c;

                //b skal være >= minste 1/2 av perimeter
                int rest2 = (perimeter - c)/2;
                for (int b= c - 2 ; b>=rest2; b--)
                {
                    int a = perimeter - c - b;
  
                    int ab = a * a + b * b;
                    if ( ab==cc )
                    {

                        numberOfsolutions++;
                    }
                }
            }


            return numberOfsolutions;
        }

        public int GetPerimeterWitMaxNumberOfsolutions(int below)
        {
           int  PerimeterWitMaxNumberOfsolutions = 0;
           int MaxNumberOfsolutions = 0;

            for (int perimeter = 1; perimeter < below; perimeter++)
            {
                int numberOfsolutions = GetNumberOfsolutions(perimeter);
                if (numberOfsolutions> MaxNumberOfsolutions)
                {
                    MaxNumberOfsolutions = numberOfsolutions;
                    PerimeterWitMaxNumberOfsolutions = perimeter;
                }
            }

            return PerimeterWitMaxNumberOfsolutions;
        }
    }
}
