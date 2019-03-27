using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{
    public class E018MaximumpathsumI
    {
        public int GetMaximumpathsum(string[] stringarray)
        {
            int high =stringarray.Count();
            int[][] triangle = new int[high][];

            int row = 0;

            foreach (var str in stringarray)
            {
                string[] numbersstring = str.Split(new char[] { ' '});
                triangle[row++] = numbersstring.Select(n => int.Parse(n)).ToArray();
            }

            for(row=1;row< high;row++)
            {
                for(int col=0;col<=row;col++)
                {
                    //previous line
                    int max = GetMax(triangle, row, col);
                    triangle[row][col]+=max;
                }

            }

            return triangle[high-1].Max();

        }

        private int GetMax(int[][] triangle, int row, int col)
        {
            if (row < 1) return 0;
            if (col == 0) return triangle[row - 1][col];
            if (col == row) return triangle[row - 1][col-1];

            int a= triangle[row - 1][col - 1];
            int b = triangle[row - 1][col];

            return a > b ? a : b;
        }
    }
}
