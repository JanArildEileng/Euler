using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E081PathSumTwoWays
    {
        public int GetMinimalPathSum(int[,] matrix)
        {
            return FillMinMatrix(matrix);
        }

        private int  FillMinMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] minMatrix = new int[rows, cols];

            int y = 0;
            int x = 0;
            minMatrix[0, 0] = matrix[0,0];

            //init minTopRow
            for (x = 1; x < cols; x++)
                minMatrix[0, x] = matrix[0,x] + minMatrix[0, x - 1];
            //initminLeftSide
            for (y = 1; y < rows; y++)
                minMatrix[y, 0] = matrix[y,0] + minMatrix[y - 1, 0];


            for (y = 1; y < rows; y++)
            {
                for (x = 1; x < cols; x++)
                {
                    minMatrix[y, x] = minMatrix[y - 1, x] < minMatrix[y, x - 1] ? minMatrix[y - 1, x] : minMatrix[y, x - 1];
                    minMatrix[y, x] += matrix[y,x];
                }
            }

            return minMatrix[rows - 1, cols - 1];
        }
    }
}
