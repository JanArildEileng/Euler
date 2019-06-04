using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{  
    public class E082PathSumThreeWays
    {
        enum Direction { up = -1, down = 1 };
        int[,] matrix;
        int[,] minMatrix;
        int cols,rows;    

        public int GetMinimalPathSum(int[,] matrix)
        {
            this.matrix = matrix;
            rows = matrix.GetLength(0);
            cols = matrix.GetLength(1);
            minMatrix = new int[rows, cols];

            FillMinMatrix();

            //finn minste verdi i høyre kolonne
            int minimalPathSum = minMatrix[0, cols - 1];

            for (int i = 0; i < rows; i++)
            {
                if (minMatrix[i, cols - 1] < minimalPathSum)
                    minimalPathSum = minMatrix[i, cols - 1];
            }

            return minimalPathSum;
        }

        private void  FillMinMatrix()
        {
            for (int j = 0; j < rows; j++)
                minMatrix[j, 0] = matrix[j, 0];
            //for all columns (>0) :

            for(int j=1;j<cols;j++)
            {
                //for all row in column:
                for(int i=0;i<rows;i++)
                {
                    minMatrix[i, j] = (new List<int> {
                         minMatrix[i, j - 1],
                         PathValue(i, j,Direction.up),
                         PathValue(i, j,Direction.down) }
                    ).Where(e => e > 0).Min() 
                    + matrix[i, j];
                }
            }
        }


        private int PathValue(int rad, int col, Direction direction)
        {
            int y = rad + (int)direction;
            if (y == rows || y<0) return -1;

            int path1 = minMatrix[y, col - 1] + matrix[y, col];
            int pathValue = PathValue(y, col, direction);
            if (pathValue < 0) return path1;
            else
            {
                int path2 = pathValue + +matrix[y, col];
                return path1 < path2 ? path1 : path2;
            }
        }       
    }
}
