using System;
using System.Collections.Generic;
using System.Text;

namespace jae.euler.lib
{
    public class E015Latticepaths
    {
        public long GetRoutes(int row, int column)
        {
            long[,] grid = new long[row + 1, column + 1];

            grid[0, 0] = 1;

            for (int r = 0; r <= row; r++)
            {
                for (int c = 0; c <= column; c++)
                {
                    if (r == 0 || c == 0)
                    {
                        grid[r, c] = 1;
                    }
                    else
                    {
                        grid[r, c] = grid[r -1, c] + grid[r, c - 1];
                    }

                } //c


            } //r


            return grid[row , column];
        }
    }
}
