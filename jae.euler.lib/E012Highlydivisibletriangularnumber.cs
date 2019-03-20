using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E012Highlydivisibletriangularnumber
    {
        public long GetFirstWithOver(long divisors)
        {
            var t = new TriangularNumber();


            foreach (var tn in t.Sequence())
            {
                List<long> PrimeFactorsInNumber = Primes.GetPrimeFactorsInNumber(tn).ToList();
                List<long> ekstar = new List<long>() { 1, tn };
                ekstar.AddRange(PrimeFactorsInNumber);


                int max = PrimeFactorsInNumber.Count;


                for (int i=0;i<max-1;i++)
                {
                    long prod = PrimeFactorsInNumber[i];
                    for(int j=i+1;j<max;j++)
                    {
                        prod = prod * PrimeFactorsInNumber[j];
                        ekstar.Add(prod);
                    }

                    
                }


                var count =ekstar.Distinct().ToList().Count;

                if (count > divisors) return tn;


            }


            return 1;
        }



        private long getNumberOfDivisors(long number)
        {
            long numberOfDivisors = 1;
            if (number == 1) return numberOfDivisors;
            //seg selv og 1
            numberOfDivisors = 2;





            return numberOfDivisors;
        }





    }

    public class TriangularNumber
    {

        public IEnumerable<long> Sequence()
        {
            long n = 1;
            long sum = 0;


            while (true )
            {
                sum += n ;
                n++;
                yield return sum;
            }

        }


    }


}
