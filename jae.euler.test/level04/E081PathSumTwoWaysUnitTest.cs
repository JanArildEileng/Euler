using jae.euler.lib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace jae.euler.test.level04
{
    public class E081PathSumTwoWaysUnitTest
    {

        private int[][] ReadMatrix()
        {
            int[][] matrix = new int[80][];

            int i = 0;
            foreach (var line in File.ReadAllLines(@"DataFiles\p081_matrix.txt"))
            {
                matrix[i++] = line.Split(',').Select(e => int.Parse(e)).ToArray();
            }

            return matrix;
        }



        [Fact]
        public void Test_0()
        {
            int[][] matrix =
            {
                new int[] {131,673,234,103,18 },
                new int[] {201,96,342,965,150 },
                new int[] {630,803,746,422,111},
                new int[] {537,699,497,121,956},
                new int[] {805,732,524,37,331}
            };

            var sut = new E081PathSumTwoWays();
            Assert.Equal(2427, sut.GetMinimalPathSum(matrix));
         }


        [Fact]
        public void Solution()
        {
            /*
              Find the minimal path sum,
              from the top left to the bottom right by only moving right and down.
            */

            var matrix = ReadMatrix();

            var sut = new E081PathSumTwoWays();
            Assert.Equal(427337, sut.GetMinimalPathSum(matrix));

            /*
                Congratulations, the answer you gave to problem 81 is correct.
                You are the 30534th person to have solved this problem.
                This problem had a difficulty rating of 10%.
            */
        }
    }
}
