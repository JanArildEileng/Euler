using jae.euler.math;
using System.Collections.Generic;
using System.Linq;

namespace jae.euler.lib
{
    public class E075SingularIntegerRightTriangles
    {
        List<long> primeFactors;
        Dictionary<long, long> primeDict;

        public E075SingularIntegerRightTriangles(int size)
        {
            primeFactors = Primes.GetPrimeFactorsBelowNumber((long)size);
            primeDict = primeFactors.ToDictionary(e => e);
        }

        public int GetNumberWithOneIntegerRightTriangles(int maxLengde)
        {
            Dictionary<long, long> lenDict=new Dictionary<long, long>();

            for (int n=1;n< 1000;n++ )
            {
                List<long> nPrimes=Primes.GetPrimeFactorsInNumber(primeFactors, primeDict, n);

                for (int m=n+1;m<1000;m++)
                {
                    //en og kun skal være par..
                    if ( (m+n) % 2 == 0) continue;

                    //m og n skal være coprime            
                    List<long> mPrimes = Primes.GetPrimeFactorsInNumber(primeFactors, primeDict, m);
                    if (nPrimes.Any(np => m % np == 0)) continue;

                    //Pythagorean triangles  :https://en.wikipedia.org/wiki/Integer_triangle
                    int a = m * m - n * n;
                    int b = 2 * m * n;
                    int c = m * m + n * n;
                    int lengde = a + b + c;

                    int step = lengde;
                    while (lengde <= maxLengde)
                    {
                        if (lenDict.ContainsKey(lengde))
                        {
                            lenDict[lengde] = lenDict[lengde] + 1;
                        } else
                        {
                            lenDict.Add(lengde, 1);
                        }
                        // hvis a,b,c er løsning , er også 2a,2b,2c løsing ,osv...
                        lengde += step;
                    }
                } // for m
            }  // for n

            //finn antall med bare en løsning/lengde
            return lenDict.Where(e => e.Value == 1).Count();
        }
    }
}
