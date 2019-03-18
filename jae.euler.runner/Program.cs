using jae.euler.lib;
using System;

namespace jae.euler.runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Euler!");

            NewMethod();

        }

        private static void NewMethod()
        {
            var sut = new E2EvenFibonaccinumbers();

            var sum = sut.SumEven(below: 4000000);

            Console.WriteLine($"E2EvenFibonaccinumbers Sum  = { sum}");
            /*
              4613732
              Congratulations, the answer you gave to problem 2 is correct.
              You are the 666663rd person to have solved this problem.
            */
        }

        private static void RunE1Multiplesof3and5()
        {
            var e1Multiplesof3and5 = new E1Multiplesof3and5();
            var sum = e1Multiplesof3and5.Sum(below: 1000);
            Console.WriteLine($"E1Multiplesof3and5 Sum  = { sum}");
            // 233168
            //Congratulations, the answer you gave to problem 1 is correct.
            //You are the 833904th person to have solved this problem.


        }
    }
}
