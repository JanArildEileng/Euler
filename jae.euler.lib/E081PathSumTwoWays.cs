using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E081PathSumTwoWays
    {

        int[,] minMatrix;

        public int GetMinimalPathSum(int[][] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix[0].GetLength(0);

            FillMinMatrix(matrix);


            int x = rows-1;
            int y = cols-1;
            int counter = minMatrix[y,x];


         
           


            return counter;
        }


        private void FillMinMatrix(int[][] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix[0].GetLength(0);

            minMatrix = new int[rows, cols];

            int y = 0;
            int x = 0;
            minMatrix[0, 0] = matrix[0][0];

            for (x = 1; x < cols; x++)
                minMatrix[y, x] = matrix[y][x] + minMatrix[y,x-1];
            x = 0;
            for (y = 1; y < rows; y++)
                minMatrix[y, x] = matrix[y][x]+ minMatrix[y-1,x];

            for(y=1;y<rows;y++)
            {
                for(x=1;x<cols;x++)
                {
                    minMatrix[y, x] = minMatrix[y - 1,x] < minMatrix[y,x - 1] ? minMatrix[y - 1,x] : minMatrix[y,x - 1];
                    minMatrix[y, x] += matrix[y][x];
                }
            }



        }

    }
}
