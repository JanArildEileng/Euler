using jae.euler.math;
using System;
using System.Collections.Generic;
using System.Linq;

namespace jae.euler.runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int minshow = 0;

            var t = new TriangularNumber();

            int n = 0;
            foreach (var tn in t.Sequence())
            {
                List<long> PrimeFactorsInNumber = Primes.GetPrimeFactorsInNumber(tn).ToList();

                n++;

                if (PrimeFactorsInNumber.Count <= minshow) continue;

            //    PrimeFactorsInNumber.Insert(0, 1);
                Console.Write($"{n,3}  {tn,10} :");

                PrimeFactorsInNumber.Reverse();

                foreach (var a in PrimeFactorsInNumber)
                    Console.Write($"{a,4},");
                Console.WriteLine("");

                minshow = PrimeFactorsInNumber.Count;

                if (tn > 1000000000) break;
            }

        }
    }


    public class TriangularNumber
    {

        public IEnumerable<long> Sequence()
        {
            long n = 1;
            long sum = 0;


            while (true)
            {
                sum += n;
                n++;
                yield return sum;
            }

        }


    }
}
