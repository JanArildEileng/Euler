using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E061CyclicalFigurateNumbers
    {

        //Triangle P3, n = n(n + 1) / 2
        public static Func<int, int> TriangleFunc = (n) => n * (n + 1) / 2;
        // Square P4, n = n2
        public static Func<int, int> SquareFunc = (n) => n * n;
        //Pentagonal P5, n = n(3n−1) / 2
        public static Func<int, int> PentagonalFunc = (n) => n * (3 * n - 1) / 2;
        //Hexagonal	 	P6,n=n(2n−1)
        public static Func<int, int> HexagonalFunc = (n) => n * (2 * n - 1);
        //Heptagonal	 	P7,n=n(5n−3)/2	
        public static Func<int, int> HeptagonalFunc = (n) => n * (5 * n - 3)/2;
        //Octagonal P8, n = n(3n−2)
        public static Func<int, int> OctagonalFunc = (n) => n * (3 * n - 2);

        public int GetSumCyclic4DigitsNumber()
        {        
            List<List<int>> candiates = new List<List<int>>()
            {
                E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.TriangleFunc).ToList(),
                E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.SquareFunc).ToList(),
                E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.PentagonalFunc).ToList(),
                E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.HexagonalFunc).ToList(),
                E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.HeptagonalFunc).ToList(),
                E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.OctagonalFunc).ToList()
            };

         

            for (int i = 0; i < candiates.Count; i++)
            {
                var current = candiates[i];
                var nextCandidates = candiates.ToList();
                nextCandidates.Remove(current);

                for (int p = 0; p < current.Count; p++)
                {
                    var polynumber = current[p];
                    List<int> founded = new List<int>() { polynumber };
                    var result = Recursive(nextCandidates, founded, polynumber);
                    if (result != null)
                    {
                        return result.Sum();
                    }
                }
            }


            throw new Exception("Not found solution");
        }
    

   


      //  Triangle P3, n = n(n + 1) / 2	 	1, 3, 6, 10, 15, .
        public static IEnumerable<int> Polygonal(Func<int, int> f)
        {
            int n = 1;
            int value=f(n);

            while (value <1000)
            {
                n++;
                value = f(n);
            }

            while (value < 10000)
            {
                yield return value;
                n++;
                value = f(n);
            }

        }

        public int GetSumCyclic4DigitsNumber3()
        {
            /*
          The ordered set of three 4-digit numbers: 8128, 2882, 8281, has three interesting properties.

          The set is cyclic, in that the last two digits of each number is the first two digits of the next number (including the last number with the first).
             Each polygonal type: triangle (P3,127=8128), square (P4,91=8281), and pentagonal (P5,44=2882),
          is represented by a different number in the set.
         This is the only set of 4-digit numbers with this property. 

          * 
            */

            List<int> triangleValues = E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.TriangleFunc).ToList();
            List<int> squareValues = E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.SquareFunc).ToList();
            List<int> pentagonalValues = E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.PentagonalFunc).ToList();


            List<List<int>> candiates = new List<List<int>>()
            {
                triangleValues,
                squareValues,
                pentagonalValues
            };


            List<int> result = null;

            for (int i = 0; i < candiates.Count; i++)
            {

                var current = candiates[i];
                var nextCandidates = candiates.ToList();
                nextCandidates.Remove(current);

                for (int p = 0; p < current.Count; p++)
                {
                    var polynumber = current[p];
                    List<int> founded = new List<int>() { polynumber };
                    result=Recursive(nextCandidates, founded, polynumber);
                    if ( result!=null)
                    {
                        return result.Sum();

                    }
                }
            }


            return 0;

        }

        private List<int> Recursive(List<List<int>> candiates, List<int> founded,int lastpolynumber)
        {
            if (candiates.Count==0)
            {
                if (CanConnect(lastpolynumber, founded[0]))
                {
                    return founded;
                } 
            }

            for (int i = 0; i < candiates.Count; i++)
            {
                var current = candiates[i];
             
                for (int p = 0; p < current.Count; p++)
                {
                    var polynumber = current[p];
                    if (CanConnect(lastpolynumber, polynumber))
                    {
                        //do recursive
                        var newFounded = founded.ToList();
                        newFounded.Add(polynumber);
                        var nextCandidates = candiates.ToList();
                        nextCandidates.Remove(current);
                        var re=Recursive(nextCandidates, newFounded, polynumber);
                        if (re != null) return re;
                    }
                }
            }

            return null;                
        }


        /*the last two digits of first number equals the first two digits of the second number */
        private bool CanConnect(int first, int second)
        {
            int last2 = first % 100;
            int first2 = second /100;
            return last2 == first2;
        }



    }
}
