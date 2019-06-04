using jae.euler.lib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace jae.euler.test.level04
{
    public class E083PathSumFourWaysUnitTest
    {
     
        private int[,] ReadMatrix()
        {
            int[,] matrix = new int[80,80];

            int y = 0;
            foreach (var line in File.ReadAllLines(@"DataFiles\p082_matrix.txt"))
            {
                int x = 0;
                foreach(int number  in line.Split(',').Select(e => int.Parse(e)))
                {  
                    matrix[y, x++] = number;
                }
                y++;
            }

            return matrix;
        }
  

        [Fact]
        public void Test_1()
        {
            int[,] matrix =
            {
                {131,673,234,103,18 },
                {201,96,342,965,150 },
                {630,803,746,422,111},
                {537,699,497,121,956},
                {805,732,524,37,331}
            };

            var sut = new E083PathSumFourWays();
            Assert.Equal(2297, sut.GetMinimalPathSum(matrix));
        }



        [Fact]
        public void Solution()
        {
            /*
              Find the minimal path sum,
              from the top left to the bottom right by only moving left, right, up, and down.
            */

            var matrix = ReadMatrix();

            var sut = new E083PathSumFourWays();
            Assert.Equal(425185, sut.GetMinimalPathSum(matrix));

            /*
              Congratulations, the answer you gave to problem 83 is correct.
              You are the 15852nd person to have solved this problem.
              This problem had a difficulty rating of 25%. 
            */
        }
    }
}
