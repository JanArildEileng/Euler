using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace jae.euler.lib
{

    public class E096SuDoku
    {
        public int GetTopLeftCorner(int[][] sudoku)
        {

            HashSet<int>[,] set = InitHashSet(sudoku);


            while (solveStep1(sudoku, set) > 0)
            {

            }


            return (100 * sudoku[0][0] + 10 * sudoku[0][1] + sudoku[0][2]);
        }

        public int GetSumTopLeftCorner(List<int[][]> sudokus)
        {
            int sumTopLeftCorner = 0;

            foreach (var sudoku in sudokus)
            {
                sumTopLeftCorner += GetTopLeftCorner(sudoku);
            }

            return sumTopLeftCorner;
        }



        private HashSet<int>[,] InitHashSet(int[][] sudoku)
        {
            HashSet<int>[,] set = new HashSet<int>[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i][j] == 0)
                        set[i, j] = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                }
            }
            return set;
        }


         private int solveStep1(int[][] sudoku, HashSet<int>[,] set)
        {
           

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (set[i, j] != null)
                    {
                        set[i, j] = set[i, j].Except(GetUsedRow(sudoku, i)).ToHashSet();
                        set[i, j] = set[i, j].Except(GetUsedCol(sudoku, j)).ToHashSet();
                        set[i, j] = set[i, j].Except(GetUseBox(sudoku, i, j)).ToHashSet();

                    }

                }
            }

            int count = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i][j] == 0 && set[i, j].Count == 1)
                    {
                        sudoku[i][j] = set[i, j].First();
                        set[i, j] = null;
                        count++;
                    }

                }
            }



            if (count == 0 && GetUnsolved(sudoku)>0)
            {

                var file = File.CreateText(@"c:\tmp\sudoku.txt");
                for (int row = 0; row < 9; row++)
                {
                    StringBuilder builder=new StringBuilder();
                    for(int col=0;col<9;col++)
                    {
                        builder.Append($"{sudoku[row][col]}");
                    }
                    file.WriteLine(builder.ToString());
                }
                file.Close();
                throw new Exception("Not solved");

            }


            


            return count;
        }

        private List<int> GetUsedRow(int[][] sudoku, int row)
        {
            return sudoku[row].Where(e => e != 0).ToList();

        }
        private List<int> GetUsedCol(int[][] sudoku, int col)
        {
            List<int> list = new List<int>();
            for (int row = 0; row < 9; row++)
            {
                if (sudoku[row][col] != 0)
                    list.Add(sudoku[row][col]);
            }

            return list;
        }

        private List<int> GetUseBox(int[][] sudoku, int row, int col)
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


        private int GetUnsolved(int[][] sudoku)
        {
            int unsolved = 0;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudoku[i][j] == 0)
                    {
                        unsolved++;
                    }
                }
            }
            return unsolved;
        }
    }
}
