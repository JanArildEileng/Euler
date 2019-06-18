using jae.euler.lib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace jae.euler.test.level04
{
    public class E096SuDokuUnitTest
    {

        private List<SudokuBrett> GetSuDokuBrettFromFile()
        {
            List<SudokuBrett> sudokoListe = new List<SudokuBrett>();
            var file = File.OpenText("DataFiles\\p096_sudoku.txt");
            for (int grid = 1; grid <= 50; grid++)
            {
                file.ReadLine();
           
                int[][] initValues = new int[9][];
                for (int i = 0; i < 9; i++)
                {
                    initValues[i] = file.ReadLine().ToCharArray().Select(c => c - '0').ToArray<int>();
                }

                sudokoListe.Add(new SudokuBrett(initValues));
            }

            return sudokoListe;
        }


        [Fact]
        public void Test_SukdoBrett()
        {
            var sudokuBrettListe = GetSuDokuBrettFromFile();
            Assert.Equal(50, sudokuBrettListe.Count());
        }


        [Fact]
        public void Test_First()
        {
            /*
                483 is the 3-digit number found in the top left corner of the solution grid above.
            */

           var sudokuBrettListe = GetSuDokuBrettFromFile();
           var sut = new E096SuDoku();
           Assert.Equal(483, sut.Solve(sudokuBrettListe[0]).GetTopLeftCornerValue());
        }


        [Fact]
        public void Test_Grid6()
        {
            /*
                483 is the 3-digit number found in the top left corner of the solution grid above.
            */

            var sudokuBrettListe = GetSuDokuBrettFromFile();
            var sut = new E096SuDoku();
            Assert.Equal(176, sut.Solve(sudokuBrettListe[5]).GetTopLeftCornerValue());

        }


        [Fact]
        public void Test_Grid25()
        {
            /*
                483 is the 3-digit number found in the top left corner of the solution grid above.
            */

            var sudokuBrettListe = GetSuDokuBrettFromFile();
            var sut = new E096SuDoku();
            Assert.Equal(361, sut.Solve(sudokuBrettListe[24]).GetTopLeftCornerValue());

        }

        [Fact]
        public void Test_Grid10()
        {
            /*
                483 is the 3-digit number found in the top left corner of the solution grid above.
            */

            var sudokuBrettListe = GetSuDokuBrettFromFile();
            var sut = new E096SuDoku();
            Assert.Equal(761, sut.Solve(sudokuBrettListe[9]).GetTopLeftCornerValue());

        }


        [Fact]
        public void Test_Grid50()
        {
            /*
                483 is the 3-digit number found in the top left corner of the solution grid above.
            */

            var sudokuBrettListe = GetSuDokuBrettFromFile();
            var sut = new E096SuDoku();
            Assert.Equal(351, sut.Solve(sudokuBrettListe[49]).GetTopLeftCornerValue());

        }


        [Fact]
        public void Solution()
        {
            /*
              By solving all fifty puzzles find the sum of the 3-digit numbers found in the top left corner of each solution grid; for example, 
              
            483 is the 3-digit number found in the top left corner of the solution grid above.
            */
            var sudokuBrettListe = GetSuDokuBrettFromFile();
            var sut = new E096SuDoku();
            Assert.Equal(24702, sut.SolveAll(sudokuBrettListe));


            /*
                Congratulations, the answer you gave to problem 96 is correct.
                You are the 14777th person to have solved this problem.
                This problem had a difficulty rating of 25%. 
            */
        }
    }
}
