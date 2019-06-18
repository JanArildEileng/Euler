using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace jae.euler.lib
{
    public class E096SuDoku
    {
        public int SolveAll(List<SudokuBrett> sudokus)
        {
            return sudokus.Select(s => Solve(s)).Select(s => s.Validate()).Select(s => s.GetTopLeftCornerValue()).Sum();
        }

        public SudokuBrett Solve(SudokuBrett sudokuBrett)
        {
            PossibleValues[,] set = sudokuBrett.InitPossibleValues();
            IterativeSolveCells(sudokuBrett, set);

            if (sudokuBrett.GetUnsolved() == 0) //success, solution found
            {
                return sudokuBrett;
            }


            //if not solved, try..
            if (sudokuBrett.GetUnsolved() > 0)
            {
                //find first posssible valueset..
                var firstWithoutValue = set.FirstWithoutValue();

                var orginal = new SudokuBrett(sudokuBrett);
                foreach (var posssible in firstWithoutValue.value)
                {
                    try
                    {
                        sudokuBrett.GuessSet(firstWithoutValue.r, firstWithoutValue.c, posssible);
                        sudokuBrett = Solve(sudokuBrett);

                        if (sudokuBrett.GetUnsolved() == 0) //success, solution found
                        {
                            return sudokuBrett;
                        }
                        else
                        {
                            //didnt succesfully solved with this guessed number, try next...
                            sudokuBrett = orginal;
                        }
                    }
                    catch (Exception)
                    {
                        sudokuBrett = orginal;
                    }
                }

            }

            //no solution found
            return sudokuBrett;
        }


        private void IterativeSolveCells(SudokuBrett sudokuBrett, PossibleValues[,] set)
        {
            int updated = 1;

            while (updated>0)
            {
                sudokuBrett.RemoveUsedFromPossibleValues(set);
                set.ReducePossibleValues();

                if (!sudokuBrett.IsLegal(set))
                {
                    throw new Exception($"Illegal settings ");
                }

                updated = sudokuBrett.UpdateNextPossibleValues(set);
            }

            return;
        }

    }





    public static class PossibleValuesExtender
    {
        public static (int r, int c, IEnumerable<int> value) FirstWithoutValue(this PossibleValues[,] set)
        {
            for (int r = 0; r < set.GetLength(0); r++)
            {
                for (int c = 0; c < set.GetLength(1); c++)
                {
                    if (set[r, c] != null)
                        return (r, c, set[r, c].Values);
                }
            }
            return (-1, -1, null);
        }

        public static bool ReducePossibleValues(this PossibleValues[,] set)
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


    }


    public class SudokuBrett
    {
        static int BRETTSIZE = 9;
        static int VALUENOTSET = 0;

        int[,] values=new int[BRETTSIZE, BRETTSIZE];
        public SudokuBrett(int[][] initValues)
        {
            Do((r, c) =>
            {
                values[r, c] = initValues[r][c];
            });
        }


        public SudokuBrett(SudokuBrett from)
        {
            Do((r, c) =>
            {
                values[r, c] = from.values[r, c];
            });
        }


        private void Do(Action<int, int> action)
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

        public void RemoveUsedFromPossibleValues(PossibleValues[,] set)
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

        internal List<int> GetUsedRow(int r)
        {
            List<int> liste = new List<int>();
            for (int c = 0; c < BRETTSIZE; c++)
            {
                if (values[r, c] != VALUENOTSET)
                    liste.Add(values[r, c]);
            }
            return liste;
        }

        internal List<int> GetUsedCol(int c)
        {
            List<int> liste = new List<int>();
            for (int r = 0; r < BRETTSIZE; r++)
            {
                if (values[r, c] != VALUENOTSET)
                    liste.Add(values[r, c]);
            }
            return liste;
        }

        internal List<int> GetUsedBox(int r, int c)
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
                if (values[r, c] == VALUENOTSET && set[r, c].Count == 0)
                {
                    legal = false;
                }
            });

            if (!legal) return legal;

            for (int r = 0; r < BRETTSIZE; r++)
            {

                int[] counter = new int[10];
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

        public int UpdateNextPossibleValues(PossibleValues[,] set)
        {
            int count = 0;

            Do((r, c) =>
            {
                if (count > 0) return;
  
                if (values[r, c] == VALUENOTSET && set[r, c].Count == 1)
                {
                    values[r, c] = set[r, c].First;
                    set[r, c] = null;
                    count++;
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
            values[r, c] = guessedValue;
        }
    }

    public class PossibleValues
    {
        HashSet<int> possible;
    
        public int Count => possible != null ? possible.Count : 0;
        public int First => possible.First();
        public IEnumerable<int> Values => possible.ToList();

        public PossibleValues()
        {
            possible = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
        public PossibleValues(int t)
        {
            possible = new HashSet<int>() { t };
        }
        public PossibleValues(List<int> liste)
        {
            possible = new HashSet<int>(liste);
        }

        public void RemoveUsedValues(IEnumerable<int> usedValuelist)
        {
            possible = possible.Except(usedValuelist).ToHashSet();

        }      

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
}
