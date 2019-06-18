using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace jae.euler.lib
{

    public static class PossibleValuesExtender
    {
        public static (int r,int c,IEnumerable<int> value) First(this PossibleValues[,] set)
        {
            for (int r = 0; r < set.GetLength(0); r++)
            {
                for (int c = 0; c < set.GetLength(1); c++)
                {
                    if (set[r, c] != null)
                        return (r,c,set[r, c].Values);
                }
            }
            return (-1,-1,null);
        }


      


    }
  





    public class SudokuBrett
    {
        public static int BRETTSIZE = 9;
        static int VALUENOTSET = 0;

        int[,] values;
        public SudokuBrett(int[][] initValues)
        {
            values = new int[BRETTSIZE, BRETTSIZE];
   
            Do((r, c) =>
            {
                values[r, c] = initValues[r][c];
            });
        }


        public SudokuBrett(SudokuBrett from)
        {
            values = new int[BRETTSIZE, BRETTSIZE];

            Do((r, c) =>
            {
                values[r, c] = from.values[r,c];
            });
        }




        private void Do(Action<int,int> action )
        {
            for (int r = 0; r < BRETTSIZE; r++)
            {
                for (int c = 0; c < BRETTSIZE; c++)
                {
                    action(r, c);
                }
            }
        } 


        public PossibleValues[,] InitPossibleValues()
        {
            PossibleValues[,] set = new PossibleValues[BRETTSIZE, BRETTSIZE];

            Do((r, c) =>
            {
                if (values[r, c] == VALUENOTSET)
                    set[r, c] = new PossibleValues();

            });
            return set;
        }

        public void RemoveUsedFromPossibleValues( PossibleValues[,] set)
        {
            Do((r, c) =>
            {
                if (set[r, c] != null)
                {
                    set[r, c].RemoveUsedValues(GetUsedRow(r));
                    set[r, c].RemoveUsedValues(GetUsedCol(c));
                    set[r, c].RemoveUsedValues(GetUsedBox(r, c));
                }
            });
        }



            public int GetTopLeftCornerValue()
        {
            return (100 * values[0, 0] + 10 * values[0, 1] + values[0, 2]);
        }

        public List<int> GetUsedRow(int r)
        {
            List<int> liste = new List<int>();
            for (int c = 0; c < BRETTSIZE; c++)
            {
                if (values[r, c] != VALUENOTSET)
                    liste.Add(values[r, c]);
            }
            return liste;
        }

        public List<int> GetUsedCol(int c)
        {
            List<int> liste = new List<int>();
            for (int r = 0; r < BRETTSIZE; r++)
            {
                if (values[r, c] != VALUENOTSET)
                    liste.Add(values[r, c]);
            }
            return liste;
        }

        public List<int> GetUsedBox(int r, int c)
        {
            List<int> list = new List<int>();

            int rowstart = (r / 3) * 3;
            int rowend = rowstart + 3;
            int colstart = (c / 3) * 3;
            int colend = colstart + 3;

            for (int i = rowstart; i < rowend; i++)
            {
                for (int j = colstart; j < colend; j++)
                {
                    if (values[i, j] != VALUENOTSET)
                        list.Add(values[i, j]);
                }
            }

            return list;
        }

        //sjekk for illegal settings
        public bool IsLegal(PossibleValues[,] set)
        {
            bool legal = true;

            Do((r, c) =>
            {
                if (values[r, c] == VALUENOTSET  && set[r, c].Count == 0)
                {
                    legal=false;
                }
            });

            if ( !legal) return legal;

            for(int r=0;r< BRETTSIZE;r++)
            {

             int [] counter = new int[10];
             int[] Ccounter = new int[10];

                for (int c = 0; c < BRETTSIZE; c++)
                {
                    if (values[r, c] != VALUENOTSET)
                        counter[values[r, c]]++;
                    if (values[c, r] != VALUENOTSET)
                        Ccounter[values[c, r]]++;
                }

                if (counter.Any(c => c > 1))
                    return false;
                if (Ccounter.Any(c => c > 1))
                    return false;
            }

                    return legal;
        }




        public SudokuBrett Validate()
        {
    
            for (int r = 0; r < BRETTSIZE; r++)
            {

                int[] counterColumn = new int[10];
                int[] counterRow = new int[10];

                for (int c = 0; c < BRETTSIZE; c++)
                {
                    if (values[c, r] == VALUENOTSET)
                        throw new Exception("Validate VALUENOTSET");

                    if (values[r, c] != VALUENOTSET)
                        counterRow[values[r, c]]++;
                    if (values[c, r] != VALUENOTSET)
                        counterColumn[values[c, r]]++;


                }

                if (counterRow.Any(c => c > 1))
                    throw new Exception("Validate counterRow");
                if (counterColumn.Any(c => c > 1))
                    throw new Exception("Validate counterColumn");
            }
           
            return this;
        }






















        public int UpdateFromPossibleValues(PossibleValues[,] set)
        {
            int count = 0;

            Do((r, c) =>
            {
                if (count > 0) return;
                if (!IsLegal(set))
                {
                    throw new Exception($"Illegal settings ");
                }

                if ( r==6 && c==2 && values[r, c] == VALUENOTSET && values[0, 0]==4 && values[0, 1]==7 && values[0, 2]==1)
                {
                    var A = 1;
                }


                if (values[r, c] == VALUENOTSET && set[r, c].Count == 1)
                {
                    values[r, c] = set[r, c].First;
                   // set[r, c].Clear();
                    set[r, c]=null;
                    count++;
                }

                if (!IsLegal(set))
                {
                    throw new Exception($"Illegal settings ");
                }

            });

            return count;
        }





        public int GetUnsolved()
        {
            int unsolved = 0;

            Do((r, c) =>
            {
                if (values[r, c] == VALUENOTSET)
                {
                    unsolved++;
                }
            });
            return unsolved;
        }

        public void SaveToFile(string filename)
        {
                var file = File.CreateText(filename);
                for (int r = 0; r < BRETTSIZE; r++)
                {
                    StringBuilder builder = new StringBuilder();
                    for (int c = 0; c < BRETTSIZE; c++)
                    {
                        builder.Append($"{values[r, c]}");
                    }
                    file.WriteLine(builder.ToString());
                }
                file.Close();
        }

        internal void GuessSet(int r, int c, int guessedValue)
        {
            values[r, c]= guessedValue;
        }
    }

    public class PossibleValues
    {
        HashSet<int> possible;
        private int t;

        public int Count =>  possible!=null?possible.Count:0;
        public int First => possible.First();
        public IEnumerable<int> Values => possible.ToList();

        public PossibleValues()
        {
            possible = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        public PossibleValues(int t)
        {
            possible = new HashSet<int>() {t }; 
        }

        public PossibleValues(List<int> liste)
        {
            possible = new HashSet<int>(liste);
        }


        public void RemoveUsedValues(IEnumerable<int> usedValuelist) {
            possible = possible.Except(usedValuelist).ToHashSet();

        }

        internal void Clear()
        {
            possible = new HashSet<int>() ;
        }
    
    }


    public struct HashStruct
    {
        internal int first;
        internal int second;
        internal int box;

        public PossibleValues set { get; set; }
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
        public int rowstart;
        public int rowend;
        public int colstart;
        public int colend;
        public CellBox(int i)
        {
            rowstart = (i / 3) * 3;
            rowend = rowstart + 3;
            colstart = (i % 3) * 3;
            colend = colstart + 3;
        }
    }


    public class E096SuDoku
    {
        public int SolveAll(List<SudokuBrett> sudokus)
        {
            return sudokus.Select(s => Solve(s,0)).Select(s=>s.Validate()).Select(s=>s.GetTopLeftCornerValue()).Sum();
        }


        public SudokuBrett Solve(SudokuBrett sudokuBrett,int level)
        {

            PossibleValues[,] set = sudokuBrett.InitPossibleValues();
            //iterative solve cells until solved, illegal or no progress...
            while (solveStep1(sudokuBrett, set) > 0)
            {

            }

            //if not solved, try..
            if (sudokuBrett.GetUnsolved()>0)
            {
                //find first posssible valueset..
                var first = set.First();

                var orginal = new SudokuBrett(sudokuBrett);
                foreach (var posssible in first.value)
                {
                    try
                    {
                        if (!sudokuBrett.IsLegal(set))
                        {
                            var a = 1;
                        }


                        sudokuBrett.GuessSet(first.r, first.c, posssible);
                        if (!sudokuBrett.IsLegal(set))
                        {
                            var a = 1;
                            sudokuBrett.SaveToFile($@"c:\tmp\sudoku_error_{level}_{first.r}_{first.c}_{posssible}.txt");
                        }



                        sudokuBrett =Solve(sudokuBrett,level+1);
                        sudokuBrett.SaveToFile($@"c:\tmp\sudoku_{level}_{first.r}_{first.c}_{posssible}.txt");
                        if (sudokuBrett.GetUnsolved() == 0)
                        {
                            if (level == 0) {
                              
                                if (!sudokuBrett.IsLegal(set))
                                {
                                   throw new Exception("Error in solution");
                                }

                            }
                            return sudokuBrett;
                        }  else
                        {
                            var a = 1;
                            throw new Exception("cantdo in solution");
                        }


                    }
                    catch (Exception exp)
                    {
                        sudokuBrett = orginal;
                       set = sudokuBrett.InitPossibleValues();
                    }
                }
            }

            if (level == 0)
            {
                sudokuBrett.SaveToFile(@"c:\tmp\sudoku.txt");
                if (!sudokuBrett.IsLegal(set))
                {
                    throw new Exception("Error in solution");
                }

            }

            return sudokuBrett;
        }



        private int solveStep1(SudokuBrett sudokuBrett, PossibleValues[,] set)
        {

            sudokuBrett.RemoveUsedFromPossibleValues(set);
    //        sudokuBrett.RemoveUsedFromPossibleValues(set);
            ReducePossibleValues(set);


            //find all included in 2's


            //if (Test1(set))
            //    return 1;
            //         ReducePossibleValues(set);
            //          Test1(set);

            //sjekk for illegal settings

            if (!sudokuBrett.IsLegal(set))
            {
                throw new Exception($"Illegal settings ");
            }

            int updated = sudokuBrett.UpdateFromPossibleValues(set);


            if ( updated==0)
            {
                var a = 1;
            }



            if (updated == 0 && sudokuBrett.GetUnsolved() > 0)
            {
             
                //if (Test1(set))
                //    return 1;

                
     

         //      RecursiveTry(sudoku);

        //        throw new Exception("Not solved");
            }

            return updated;
        }


        private bool ReducePossibleValues(PossibleValues[,] set)
        {

            for (int row = 0; row < 9; row++)
            {
                int[] teller = new int[10];
                for (int x = 0; x < 9; x++)
                {
                    if (set[row, x] != null)
                    {
                        foreach (int t in (set[row, x].Values))
                        {
                            teller[t]++;
                        }
                    }
                }

                if (teller.Any(i => i == 1))
                {
                    int t = 0;
                    while (teller[t] != 1) t++;
                    for (int x = 0; x < 9; x++)
                    {
                        if (set[row, x] != null && set[row, x].Values.Contains(t))
                        {
                            set[row, x] = new PossibleValues(t);
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
                        foreach (int t in (set[y, col].Values))
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
                        if (set[y, col] != null && set[y, col].Values.Contains(t))
                        {
                            set[y, col] = new PossibleValues(t);
                        }
                    }


                }


            } //row

            //box

            for (int box = 0; box < 9; box++)
            {
                var cellbox = new CellBox(box);
                int[] teller = new int[10];

                for (int row = cellbox.rowstart; row < cellbox.rowend; row++)
                {
                    for (int col = cellbox.colstart; col < cellbox.colend; col++)
                    {
                        if (set[row, col] != null)
                        {
                            foreach (int t in (set[row, col].Values))
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
                            if (set[row, col] != null && set[row, col].Values.Contains(t))
                            {
                                set[row, col] = new PossibleValues(t);
                            }

                        }
                    }




                }

            }


            return true;

        }





        private bool Test1(PossibleValues[,] set)
        {
            bool t = false;

            List<HashStruct> list = new List<HashStruct>();


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (set[i, j] != null && set[i, j].Count == 2)
                    {
                        int box = GetBox(i, j);
                        var h = new HashStruct { set = set[i, j], row = i, col = j, first = set[i, j].Values.ElementAt(0), second = set[i, j].Values.ElementAt(1), box = box };
                        list.Add(h);
                    }
                }
            }


            foreach (var g in list.GroupBy(l => l.row))
            {
                foreach (var g2 in g.GroupBy(h => h.first))
                {

                    if (g.Count() >= 3 && g2.Count() == 2 && g2.ElementAt(0).second == g2.ElementAt(1).second)
                    {
                        var copy = new PossibleValues(new List<int>  {
                            g2.ElementAt(0).first,
                            g2.ElementAt(0).second,

                        });
                       
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
                                    set[r, x].RemoveUsedValues(g2.ElementAt(i).set.Values);
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
                        var copy = new PossibleValues(new List<int>  {
                            g2.ElementAt(0).first,
                            g2.ElementAt(0).second,

                        });
                        //fjern alle andre fra row,col.box
                        for (int i = 0; i < 2; i++)
                        {
                            int r = g2.ElementAt(i).row;
                            int c = g2.ElementAt(i).col;
                            int box = GetBox(r, c);
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
                                    set[y, c].RemoveUsedValues(g2.ElementAt(i).set.Values);
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
                        var copy = new PossibleValues(new List<int>  {
                            g2.ElementAt(0).first,
                            g2.ElementAt(0).second,

                        });

                        if (g.Count() > 3)
                        {
                            var wwwwa = 1;
                        }

                        int box = GetBox(g2.ElementAt(0).row, g2.ElementAt(0).col);
                        var cellbox = new CellBox(box);

                        for (int row = cellbox.rowstart; row < cellbox.rowend; row++)
                        {
                            for (int col = cellbox.colstart; col < cellbox.colend; col++)
                            {
                                if (set[row, col] != null)
                                {
                                    if (set[row, col] != null)
                                        set[row, col].RemoveUsedValues(copy.Values);
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


        private int GetBox(int row, int col)
        {
            int rowstart = (row / 3);
            int colstart = (col / 3);
            int box = rowstart * 3 + colstart;
            return box;
        }





        //private void RecursiveTry(int[][] currentSudoku)
        //{
        //    //make copy first
        //    int[][] sudoku = new int[9][];

        //    for (int i = 0; i < 9; i++)
        //    {
        //        sudoku[i] = currentSudoku[i].ToArray();
        //    }

        //    HashSet<int>[,] set = InitHashSet(sudoku);


        //}

    }
}
