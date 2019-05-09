using System.Linq;

namespace jae.euler.lib
{
    public class E006Sumsquaredifference
    {
        public long DifferenceBetweenTheSumOfSquares(long number)
        {
            var sum1 = SumOffthesquares(number);
            var sum2 = SqueareOfSum(number);
            return (sum2 - sum1);
        }

        private long SumOffthesquares(long number)
        {
            return Enumerable.Range(1,(int)number).Select(i => i * i).Sum();
        }

        private long SqueareOfSum(long number)
        {
            long sum = Enumerable.Range(1, (int)number).Sum(); 
            return sum*sum;
        }
    }
}
