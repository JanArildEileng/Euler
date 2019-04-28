using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace jae.euler.test.level03
{
    public class E061CyclicalFigurateNumbersUnitTest
    {



        [Fact]
        public void Test_Polygonal()
        {
            /*
              */

            List<int> polygonalValues = E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.TriangleFunc).ToList();
            Assert.Equal(96, polygonalValues.Count);
            Assert.Equal(96, polygonalValues.Where(e=>e>=1000 && e<10000).Count());

            polygonalValues = E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.SquareFunc).ToList();
            Assert.Equal(68, polygonalValues.Count);
            Assert.Equal(68, polygonalValues.Where(e => e >= 1000 && e < 10000).Count());

            polygonalValues = E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.PentagonalFunc).ToList();
            Assert.Equal(56, polygonalValues.Count);
            Assert.Equal(56, polygonalValues.Where(e => e >= 1000 && e < 10000).Count());

            polygonalValues = E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.HexagonalFunc).ToList();
            Assert.Equal(48, polygonalValues.Count);
            Assert.Equal(48, polygonalValues.Where(e => e >= 1000 && e < 10000).Count());

            polygonalValues = E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.HeptagonalFunc).ToList();
            Assert.Equal(43, polygonalValues.Count);
            Assert.Equal(43, polygonalValues.Where(e => e >= 1000 && e < 10000).Count());

            polygonalValues = E061CyclicalFigurateNumbers.Polygonal(E061CyclicalFigurateNumbers.OctagonalFunc).ToList();
            Assert.Equal(40, polygonalValues.Count);
            Assert.Equal(40, polygonalValues.Where(e => e >= 1000 && e < 10000).Count());

        }


        [Fact]
        public void Test_3cyclicPolygonal()
        {
            /*
             The ordered set of three 4-digit numbers: 8128, 2882, 8281, has three interesting properties.

             The set is cyclic, in that the last two digits of each number is the first two digits of the next number (including the last number with the first).
                Each polygonal type: triangle (P3,127=8128), square (P4,91=8281), and pentagonal (P5,44=2882),
             is represented by a different number in the set.
            This is the only set of 4-digit numbers with this property. 
             
             * 
               */
            var sut = new E061CyclicalFigurateNumbers();
            int sum = 8128 + 2882 + 8281;

            Assert.Equal(sum, sut.GetSumCyclic4DigitsNumber3());


        }


        [Fact]
        public void Solution()
        {
            /*
             Find the sum of the only ordered set of six cyclic 4-digit numbers for which each polygonal
             type: triangle, square, pentagonal, hexagonal, heptagonal, and octagonal, 
             is represented by a different number in the set.
            */

            var sut = new E061CyclicalFigurateNumbers();

            Assert.Equal(28684, sut.GetSumCyclic4DigitsNumber());

            /*
              Congratulations, the answer you gave to problem 61 is correct.

                You are the 21999th person to have solved this problem.
            */
        }
    }


}
