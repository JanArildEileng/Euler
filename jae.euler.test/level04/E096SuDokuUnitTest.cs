using jae.euler.lib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace jae.euler.test.level04
{
    public class E096SuDokuUnitTest
    {
/*
        Grid 01
003020600
900305001
001806400
008102900
700000008
006708200
002609500
800203009
005010300
*/

        private List<int[][]> GetSudokusFromFile()
        {
            List<int[][]> sudokoListe = new List<int[][]>();
            var file= File.OpenText("DataFiles\\p096_sudoku.txt");
            for (int grid=1;grid<=50;grid++)
            {
                file.ReadLine();
                int[][] sudoko = new int[9][];

                for (int i=0;i<9;i++)
                {
                   var line=file.ReadLine();
                    sudoko[i] = line.ToCharArray().Select(c => c - '0').ToArray<int>();
                }

                sudokoListe.Add(sudoko);
            }

            return sudokoListe;
        }


        [Fact]
        public void Test_First()
        {
            /*
                483 is the 3-digit number found in the top left corner of the solution grid above.
            */

            var sudokus = GetSudokusFromFile();
            var sut = new E096SuDoku();
            Assert.Equal(483, sut.GetTopLeftCorner(sudokus[0]));

        }



        [Fact]
        public void Solution()
        {
            /*
              By solving all fifty puzzles find the sum of the 3-digit numbers found in the top left corner of each solution grid; for example, 
              
            483 is the 3-digit number found in the top left corner of the solution grid above.
            */
            var sudokus = GetSudokusFromFile();
            var sut = new E096SuDoku();
            Assert.Equal(-1, sut.GetSumTopLeftCorner(sudokus));


            /*
                
            */
        }
    }
}
