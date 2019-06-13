using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace jae.euler.lib
{

   
    public struct HashStruct {
        internal int first;
        internal int second;
        internal int box;

        public HashSet<int> set { get; set; }
        public int row { get; set; }
        public int col { get; set; }
      }


    public struct Cell
    {
        public int y { get; set; }
        public int x { get; set; }
    }


    public class CellBox
    {
        public int rowstart ;
        public int rowend;
        public int colstart;
        public int colend;
        public CellBox(int i)
        {
            rowstart = (i/3) *3;   
            rowend = rowstart + 3;
            colstart = (i % 3) * 3;
            colend = colstart + 3;
        }
    }


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

            //find all included in 2's


            //if (Test1(set))
            //    return 1;
           Test2(set);
            Test1(set);
            

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

                if (Test1(set))
                    return 1;

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

           

                RecursiveTry(sudoku);

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


        private bool Test2(HashSet<int>[,] set)
        {

            for(int row=0;row<9;row++)
            {
                int[] teller = new int[10];
                for(int x=0;x<9;x++)
                {
                    if (set[row, x] != null)
                    {
                        foreach(int t in (set[row, x]))
                        {
                            teller[t]++;
                        }
                    }
                }

                if ( teller.Any(i=>i==1)) {
                    int t = 0;
                    while (teller[t] != 1) t++;
                    for (int x = 0; x < 9; x++)
                    {
                        if (set[row, x] != null && set[row, x].Contains(t))
                        {
                            set[row, x] = new HashSet<int>() { t };
                        }
                    }


                }


            } //row

     

            for (int col = 0; col < 9; col++)
            {
                int[] teller = new int[10];
                for (int y = 0; y < 9; y++)
                {
                    if (set[y, col] != null)
                    {
                        foreach (int t in (set[y, col]))
                        {
                            teller[t]++;
                        }
                    }
                }

                if (teller.Any(i => i == 1))
                {
                    int t = 0;
                    while (teller[t] != 1) t++;
                    for (int y = 0; y < 9; y++)
                    {
                        if (set[y, col] != null && set[y, col].Contains(t))
                        {
                            set[y, col] = new HashSet<int>() { t };
                        }
                    }


                }


            } //row

            //box
       
            for (int box=0;box<9;box++)
            {
                var cellbox = new CellBox(box);
                int[] teller = new int[10];

                for (int row = cellbox.rowstart; row < cellbox.rowend; row++)
                {
                    for (int col = cellbox.colstart; col < cellbox.colend; col++)
                    {
                        if (set[row, col] != null)
                        {
                            foreach (int t in (set[row, col]))
                            {
                                teller[t]++;
                            }
                        }

                    }
                }

                if (teller.Any(i => i == 1))
                {
                    int t = 0;
                    while (teller[t] != 1) t++;

                    for (int row = cellbox.rowstart; row < cellbox.rowend; row++)
                    {
                        for (int col = cellbox.colstart; col < cellbox.colend; col++)
                        {
                            if (set[row, col] != null && set[row, col].Contains(t))
                            {
                                set[row, col] = new HashSet<int>() { t };
                            }

                        }
                    }

                  


                }

            }


                return true;

        }





        private bool Test1(HashSet<int>[,] set)
        {
            bool t = false;

            List<HashStruct> list = new List<HashStruct>();


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if ( set[i,j] != null && set[i, j].Count==2)
                    {
                        int box = GetBox(i, j);
                        var h = new HashStruct { set = set[i, j], row = i, col = j, first = set[i, j].ElementAt(0), second = set[i, j].ElementAt(1), box = box };
                        list.Add(h);
                    }
                }
            }


            foreach (var g in list.GroupBy(l => l.row))
            {
                foreach (var g2 in g.GroupBy(h => h.first))
                {

                    if (g.Count() >=3 &&  g2.Count() == 2 && g2.ElementAt(0).second == g2.ElementAt(1).second)
                    {
                        var copy = new HashSet<int>()
                        {
                            g2.ElementAt(0).first,
                            g2.ElementAt(0).second,

                        };
                        //fjern alle andre fra row,col.box
                        for (int i = 0; i < 2; i++)
                        {
                            int r = g2.ElementAt(i).row;
                            int c = g2.ElementAt(i).col;
                            int box = GetBox(r, c);
                            //fjern fra row
                            for (int x = 0; x < 9; x++)
                            {
                                if (r == 0 && x == 8)
                                {
                                    var d = 1;
                                }
                                if (set[r, x] != null)
                                    set[r, x] = set[r, x].Except(g2.ElementAt(i).set).ToHashSet();
                            }

                            ////fjern fra col
                            //for (int y = 0; y < 9; y++)
                            //{
                            //    if (set[y, c] != null)
                            //        set[y, c] = set[y, c].Except(g2.ElementAt(i).set).ToHashSet();
                            //}

                        }

                        for (int i = 0; i < 2; i++)
                        {
                            int r = g2.ElementAt(i).row;
                            int c = g2.ElementAt(i).col;
                            int box = GetBox(r, c);
                            //set[r, c] = g2.ElementAt(i).set;
                            set[r, c] = copy;
                            //                       t = true;
                        }

                    }

                }
            }






            foreach (var g in list.GroupBy(l => l.col))
            {
                foreach (var g2 in g.GroupBy(h => h.first))
                {

                    if (g.Count() >= 3 && g2.Count() == 2 && g2.ElementAt(0).second == g2.ElementAt(1).second)
                    {
                        var copy = new HashSet<int>()
                        {
                            g2.ElementAt(0).first,
                            g2.ElementAt(0).second,

                        };
                        //fjern alle andre fra row,col.box
                        for (int i=0;i<2;i++)
                        {
                            int r=g2.ElementAt(i).row;
                            int c = g2.ElementAt(i).col;
                            int box = GetBox(r,c);
                            //fjern fra row
                            //for(int x=0;x<9;x++)
                            //{
                            //   if (r==0 && x==8)
                            //    {
                            //        var d = 1;
                            //    }  
                            //   if (set[r, x] != null)
                            //           set[r, x] = set[r, x].Except(g2.ElementAt(i).set).ToHashSet();
                            //}
                          
                            //fjern fra col
                            for (int y = 0; y < 9; y++)
                            {
                                if (set[y, c] != null)
                                    set[y, c] = set[y, c].Except(g2.ElementAt(i).set).ToHashSet();
                            }
                          
                        }

                        for (int i = 0; i < 2; i++)
                        {
                            int r = g2.ElementAt(i).row;
                            int c = g2.ElementAt(i).col;
                            int box = GetBox(r, c);
                            //set[r, c] = g2.ElementAt(i).set;
                            set[r, c] = copy;
                             //                       t = true;
                        }

                    



                    }

                }
            }

            foreach (var g in list.GroupBy(l => l.box))
            {
                foreach (var g2 in g.GroupBy(h => h.first))
                {

                    if (g.Count() >= 3 && g2.Count() == 2 && g2.ElementAt(0).second == g2.ElementAt(1).second)
                    {
                        var a = 1;
                        var copy = new HashSet<int>()
                        {
                            g2.ElementAt(0).first,
                            g2.ElementAt(0).second,

                        };

                        if (  g.Count()>3)
                        {
                            var wwwwa = 1;
                        }

                        int box = GetBox(g2.ElementAt(0).row,g2.ElementAt(0).col);
                        var cellbox = new CellBox(box);

                        for (int row = cellbox.rowstart; row < cellbox.rowend; row++)
                        {
                            for (int col = cellbox.colstart; col < cellbox.colend; col++)
                            {
                                if (set[row, col] != null)
                                {
                                    if (set[row, col] != null)
                                        set[row, col] = set[row, col].Except(copy).ToHashSet();
                                }
                            }

                        }

                        //fjern alle andre fra row,col.box


                        for (int i = 0; i < 2; i++)
                        {
                            set[g2.ElementAt(i).row, g2.ElementAt(i).col] = copy;
                        }


                    }


                }
            }



            return t;
        }


        private int GetBox(int row,int col)
        {
            int rowstart = (row / 3) ;
            int colstart = (col / 3);
            int box = rowstart*3+ colstart;
            return box;
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


        private void RecursiveTry(int[][] currentSudoku)
        {
            //make copy first
            int[][] sudoku = new int[9][];

            for (int i = 0; i < 9; i++)
            {
                sudoku[i] = currentSudoku[i].ToArray();
            }

            HashSet<int>[,] set = InitHashSet(sudoku);


        }

    }
}
