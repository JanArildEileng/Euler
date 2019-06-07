using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{  
    public class E083PathSumFourWays
    {
        enum Direction { up = -1, down = 1 };
        int[,] matrix;
        int[,] minMatrix;
        int cols,rows;


    //    top left to the bottom right,

        public int GetMinimalPathSum(int[,] matrix)
        {
            this.matrix = matrix;
            rows = matrix.GetLength(0);
            cols = matrix.GetLength(1);
            minMatrix = new int[rows, cols];

            FillMinMatrix();

            //finn minste verdi i høyre kolonne
            int minimalPathSum = minMatrix[rows-1, cols - 1];

            return minimalPathSum;
        }



        private void FillMinMatrix2()
        {
            minMatrix[0, 0] = matrix[0, 0];

            for (int j = 0; j < cols; j++)
            {
                //for all column
                for (int i = 0; i < rows; i++)
                {
                    if ( i==0 && j>0)
                        minMatrix[j, i] = minMatrix[j-1, i]+ matrix[j, i]+1;
                    if (i>  0)
                        minMatrix[j, i] = minMatrix[j, i-1] + matrix[j, i]+1;

                }
            }
          
            Recalc(0, 0);

        }

            private void  FillMinMatrix()
        {
             minMatrix[0, 0] = matrix[0, 0];
             minMatrix[1, 0] = matrix[1, 0]+ matrix[0, 0];
             minMatrix[0, 1] = matrix[0, 1]+ matrix[0, 0];

            //for all row :
            for (int j = 0; j < cols; j++)
            {
                //for all column
                for (int i = 0; i < rows; i++)
                {
                    if ((i == 0 && j == 0) || (i == 1 && j == 0) || (i == 0 && j == 1)) continue;

                    if ( i==0)
                    {
                        minMatrix[i, j] = minMatrix[i, j - 1]+ matrix[i, j];
                    }
                    if (j == 0)
                    {
                        minMatrix[i, j] = minMatrix[i-1, j] + matrix[i, j];
                    }

                    if ( j >0 && i >0 )
                    {

                        int left = minMatrix[i, j - 1];
                        int up = minMatrix[i - 1, j];
                        minMatrix[i, j] = matrix[i, j] + (left < up ? left : up);
                    }

                    Recalc(i, j);
                }
            }



        }

        private void Recalc(int i, int j)
        {


            if ( j >0 &&   minMatrix[i, j - 1] > (minMatrix[i, j] + matrix[i, j - 1]))
            {
                minMatrix[i, j - 1] = minMatrix[i, j] + matrix[i, j - 1];
                Recalc(i, j - 1);
            }
            if (i >0 && minMatrix[i - 1, j] > (minMatrix[i, j] + matrix[i - 1, j]))
            {
                minMatrix[i - 1, j] = minMatrix[i, j] + matrix[i - 1, j];
                Recalc(i-1, j );
            }


            if ( (j < cols-1)  && minMatrix[i, j + 1] > (minMatrix[i, j] + matrix[i, j + 1]))
            {
                minMatrix[i, j + 1] = minMatrix[i, j] + matrix[i, j + 1];
                Recalc(i, j + 1);
            }


            if ((i < rows - 1) && minMatrix[i + 1, j] > (minMatrix[i, j] + matrix[i + 1, j]))
            {
                minMatrix[i + 1, j] = minMatrix[i, j] + matrix[i + 1, j];
                Recalc(i + 1, j);
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
