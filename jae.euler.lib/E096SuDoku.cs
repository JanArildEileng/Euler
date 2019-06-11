using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace jae.euler.lib
{

    public class E096SuDoku
    {
        public int GetTopLeftCorner(int[][] sudoku)
        {

            while (solveStep1(sudoku) >0)
            {

            }
          

            return (100*sudoku[0][0]+ 10*sudoku[0][1]+ sudoku[0][2]);
        }

        public int GetSumTopLeftCorner(List<int[][]> sudokus)
        {
            int sumTopLeftCorner = 0;

            foreach(var sudoku in sudokus)
            {
                sumTopLeftCorner += GetTopLeftCorner(sudoku);
            }

            return sumTopLeftCorner;
        }




        private int solveStep1(int[][] sudoku)
        {
            HashSet<int>[,] set = new HashSet<int>[9,9]; 
            for(int i=0;i<9;i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i][j] == 0)
                        set[i, j] = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (set[i, j]  !=null)
                    {
                        set[i, j] = set[i, j].Except(GetUsedRow(sudoku, i)).ToHashSet();
                        set[i, j] = set[i, j].Except(GetUsedCol(sudoku, j)).ToHashSet();
                        set[i, j] = set[i, j].Except(GetUseBox(sudoku,i, j)).ToHashSet();
                
                    }
                      
                }
            }

            int count=0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i][j] == 0 && set[i, j].Count==1)
                    {
                        sudoku[i][j] = set[i, j].First();
                        count++;
                    }
                       
                }
            }

           
            if (count==0)
            {

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (sudoku[i][j] == 0)
                        {

                            var a = 1;
                        }

                    }
                }


            }

                
           return count;
        }

        private List<int> GetUsedRow(int[][] sudoku,int row)
        {
            return sudoku[row].Where(e => e != 0).ToList();

        }
        private List<int> GetUsedCol(int[][] sudoku, int col)
        {
            List<int> list = new List<int>();
            for (int row=0;row<9;row++)
            {
                if (sudoku[row][col] != 0)
                    list.Add(sudoku[row][col]);
            }

            return list;
        }

        private List<int> GetUseBox(int[][] sudoku,int row, int col)
        {
            List<int> list = new List<int>();

            int rowstart = (row / 3) * 3;
            int rowend = rowstart + 3;
            int colstart = (col / 3) * 3;
            int colend = colstart + 3;


            for (int i = rowstart; i < rowend; i++)
            {

                for (int j = colstart; j < colend; j++)
                {
                    if (sudoku[i][j] != 0)
                        list.Add(sudoku[i][j]);
                }

            }

            return list;
        }


    }
}
