using jae.euler.lib;
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


            double x = Math.Sqrt(26);
            Console.WriteLine($"x= {x}");
            double a = Math.Truncate(x);
            double b = x - a;

            double sum = a + Recursive(b, 0);

           Console.WriteLine($"sum ={sum}  Diff={sum-x}");
            


            //        var sut = new E064OddPeriodSquareRoots();
            //       sut.GetPeriodsOfSquareRoot(19);



        }

        private static double Recursive(double b, int counter)
        {
           

            double x = 1.0 / b;
            double a = Math.Truncate(x);
            b = x - a;

            Console.WriteLine($"{counter,3}  a={a,2}  b={b}  ");
            counter++;
            if (counter > 30)
                return 1.0 / a;
            else
                return (1.0 / (a + Recursive(b, counter)));

        }
    }


   
}
