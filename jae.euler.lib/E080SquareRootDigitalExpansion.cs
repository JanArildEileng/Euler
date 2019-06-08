using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using jae.euler.util;
using System.Numerics;

namespace jae.euler.lib
{
    public class E080SquareRootDigitalExpansion
    {
     
        //https://www.mathblog.dk/project-euler-80-digits-irrational-square-roots/

        private BigInteger Squareroot(int n, int digits)
        {
            BigInteger limit = BigInteger.Pow(10, digits + 1);
            BigInteger a = 5 * n;
            BigInteger b = 5;

            while (b < limit)
            {
                if (a >= b)
                {
                    a -= b;
                    b += 10;
                }
                else
                {
                    a *= 100;
                    b = (b / 10) * 100 + 5;
                }
            }

            return b / 100;
        }

       

        public int GetDigitalSumSquareRoot(int number)
        {
            string s = Squareroot(number, digits: 100).ToString();
            int totalSum =s.ToCharArray().Select(c => c - '0').Sum();

            return totalSum;
        }


        public int GetDigitalSumSquareRootAll()
        {           
            return  Enumerable.
                Range(1, 100).
                Except(new List<int> { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 }).
                Select(i => GetDigitalSumSquareRoot(i)).
                Sum(); 
        }
    }
}
