using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jae.euler.math
{
    public class Divisors
    {
        public static  List<long> GetAllUniqueDivisorsIn(long number)
        {
            List<long> allDivisorsIn = new List<long> { 1 };
            List<long> PrimeFactorsInNumber = Primes.GetPrimeFactorsInNumber(number).ToList();

            //   allDivisorsIn.Add(1);

            for (int offset = 0; offset < PrimeFactorsInNumber.Count; offset++)
            {
                int to = allDivisorsIn.Count;
                //multi with everything found so fare...
                for (int i = 0; i < to; i++)
                {
                    allDivisorsIn.Add(allDivisorsIn[i] * PrimeFactorsInNumber[offset]);
                }


            }
            return allDivisorsIn.Distinct().OrderBy(e => e).ToList(); ;
        }


        // proper divisors of n(numbers less than n which divide evenly into n).
        public static List<long> GetProperDivisors(long number)
        {
            List<long> allDivisorsIn = new List<long> { 1 };
            List<long> PrimeFactorsInNumber = Primes.GetPrimeFactorsInNumber(number).ToList();

            //   allDivisorsIn.Add(1);

            for (int offset = 0; offset < PrimeFactorsInNumber.Count; offset++)
            {
                int to = allDivisorsIn.Count;
                //multi with everything found so fare...
                for (int i = 0; i < to; i++)
                {
                    allDivisorsIn.Add(allDivisorsIn[i] * PrimeFactorsInNumber[offset]);
                }


            }
            return allDivisorsIn.Distinct().Where(e=>e<number).OrderBy(e => e).ToList(); ;
        }



    }
}
