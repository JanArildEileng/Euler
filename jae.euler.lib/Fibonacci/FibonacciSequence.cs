using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib.Fibonacci
{
    public class FibonacciSequence
    {
        public static  List<int> GenFibonacciSequence(int below)
        {
            var list = new List<int>();

            int a = 0;
            int b = 1;

            list.Add(b);

            var t = NextFibonacci(a, b);

            while (t.b < below)
            {
                list.Add(t.b);

                t = NextFibonacci(t.a, t.b);
            }

            return list;
        }

        private static (int a, int b) NextFibonacci(int a, int b)
        {
            return (b, a + b);
        }

    }

   


   

}
