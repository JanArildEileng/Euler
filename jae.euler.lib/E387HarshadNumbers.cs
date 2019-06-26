using jae.euler.math;
using System;
using System.Collections.Generic;
using System.IO;

namespace jae.euler.lib
{
    public class E387HarshadNumbers
    {
        List<long> prinmeListe;

        public bool IsStrongRightTruncatableHarshadPrimes(long number)
        {
            prinmeListe = Primes.GetPrimeFactorsBelowNumber((long)number);
            long rest = number / 10;

            if (IsRightTruncatableHarshadNumber(rest)
                && IsStrongHarshadNumber(rest)
                && Primes.IsPrime(number, prinmeListe)
                )
                return true;
            else
                return false;
        }


        public long SumOfStrongRightTruncatableHarshadPrimes(long max)
        {
            long sum = 0;

            prinmeListe = Primes.GetPrimeFactorsBelowNumber((long)Math.Sqrt(902200000800800));
            var file = File.CreateText(@"c:\temp\HarshadNumbers.txt");

            List<long> rightTruncatableHarshadNumbers = new List<long>();

            //finn rightTruncatableHarshadNumber melloem 10 og 100
            for (int n = 10; n < 100; n++)
            {
                if (IsRightTruncatableHarshadNumber(n))
                {
                    rightTruncatableHarshadNumbers.Add(n);
                }
            }

            for (int p = 1; p < max - 1; p++)
            {
                List<long> nextRightTruncatableHarshadNumbers = new List<long>();

                // 'left'-expand de kjente TruncatableHarshad nummerne
                foreach (var n in rightTruncatableHarshadNumbers)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        //left...
                        long t = n * 10 + i;

                        if (IsStrongHarshadNumber(n) && Primes.IsPrime(t, prinmeListe))
                        {
                            sum += t;
                            file.WriteLine(t.ToString());
                        }

                        //til neste 'runde'
                        if (IsRightTruncatableHarshadNumber(t))
                        {
                            nextRightTruncatableHarshadNumbers.Add(t);
                        }
                    }
                }

                rightTruncatableHarshadNumbers = nextRightTruncatableHarshadNumbers;
            }

            file.Close();
            return sum;
        }



        // A Harshad or Niven number is a number that is divisible by the sum of its digits.
        private bool IsStrongHarshadNumber(long number)
        {
            long sum = DigitSum(number);
            return (number % sum == 0 && Primes.IsPrime(number / sum, prinmeListe));
        }

        private bool IsHarshadNumber(long number)
        {
            long sum = DigitSum(number);
            return (number % sum == 0);
        }

        private long DigitSum(long number)
        {
            long n = number;
            long sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }


        private bool IsRightTruncatableHarshadNumber(long number)
        {
            while (IsHarshadNumber(number))
            {
                number /= 10;
                if (number < 10) return true;
            }
            return false;
        }
    }
}
