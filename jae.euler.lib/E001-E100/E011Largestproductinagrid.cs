using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E011Largestproductinagrid
    {
        public long GetLargestproduct(long[][] grid)
        {
            List<long> max = new List<long>(); ;

            max.Add(getMaxInRows(grid));
            max.Add(getMaxDown(grid));
            max.Add(getMaxrightDown(grid));
            max.Add(getMaxleftUp(grid));
            

            return max.Max(); ;
        }

        private long getMaxInRows(long[][] grid)
        {
            long max = 0;

            for (long row = 0; row < 20; row++)
            {
                for (long col = 0; col < 20-3; col++)
                {
                    long value = grid[row][col] * grid[row][col+1] * grid[row][col+2] * grid[row][col+3];
                    max = max > value ? max : value;
                }
            }
            return max;
        }


        private long getMaxDown(long[][] grid)
        {
            long max = 0;

            for (long col = 0; col < 20; col++)
            {
                for (long row = 0; row < 20 - 3; row++)
                {
                    long value = grid[row][col] * grid[row+1][col] * grid[row+2][col] * grid[row+3][col];
                    max = max > value ? max : value;
                }
            }
            return max;
        }


        private long getMaxrightDown(long[][] grid)
        {
            long max = 0;

            for (long col = 0; col < 20 - 3; col++)
            {
                for (long row = 0; row < 20 - 3; row++)
                {
                    long value = grid[row][col] * grid[row+1][col + 1] * grid[row+2][col + 2] * grid[row+3][col + 3];
                    max = max > value ? max : value;
                }
            }
            return max;
        }

        private long getMaxleftUp(long[][] grid)
        {
            long max = 0;

            for (long col = 3; col < 20; col++)
            {
                for (long row = 0; row < 20 - 3; row++)
                {
                    long value = grid[row][col] * grid[row +1][col - 1] * grid[row + 2][col - 2] * grid[row + 3][col - 3];
                    max = max > value ? max : value;
                }
            }
            return max;
        }







    }
}
