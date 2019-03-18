using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E6Sumsquaredifference
    {
        public long DifferenceBetweenTheSumOfSquares(long number)
        {
            var sum1 = SumOffthesquares(number);
            var sum2 = SqueareOfSum(number);

            return (sum2 - sum1);
        }

        private long SumOffthesquares(long number)
        {
            long total=0;
            for(long i=1;i<=number;i++)
            {
                total += i * i;
            }

            return total;
        }


        private long SqueareOfSum(long number)
        {
            long sum = 0;
            for (long i = 1; i <= number; i++)
            {
                sum += i ;
            }

            return sum*sum;
        }


    }
}
