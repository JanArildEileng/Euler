using jae.euler.lib;
using System;

namespace jae.euler.runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Euler!");

            RunE1Multiplesof3and5();

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
