using System;
using System.Collections.Generic;

namespace jae.euler.lib
{
    public class E099LargestExponential
    {
        public int GetLineWithLargestNumber(List<string> expNumbers)
        {
            int indexLargestNumber = -1;
            double largestNumber = 0.0; ;

            for(int i=0;i< expNumbers.Count;i++)
            {
                var currentNumber = ToLogValue(expNumbers[i].Split(new char[] { ',' }));
                if (currentNumber> largestNumber)
                {
                    indexLargestNumber = i;
                    largestNumber = currentNumber;
                }
            }

            return indexLargestNumber+1; //linenr =indx+1
        }


        private double  ToLogValue(string[] expNumber)
        {
            double a = double.Parse(expNumber[0]);
            double b = double.Parse(expNumber[1]);
            double c = b*Math.Log10(a);
            return c;
        }
    }
}
