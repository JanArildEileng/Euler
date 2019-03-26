using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E014LongestCollatzsequence
    {
        public (long startingNumber, long length) LongestCollatzsequence(int below)
        {

            var longestCollatzsequence = (startingNumber: 0, length: 0);

         

            for(int startingNumber = 1; startingNumber < below; startingNumber++)
            {
      
                var collatzsequenceCount = new Collatz().Iterator(startingNumber).Count();
          

                if (collatzsequenceCount > longestCollatzsequence.length)
                {
                    longestCollatzsequence = (startingNumber: startingNumber, length: collatzsequenceCount);
                }
            }


            return longestCollatzsequence;
        }
    }
}
