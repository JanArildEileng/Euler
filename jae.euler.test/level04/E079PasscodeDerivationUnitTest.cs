using jae.euler.lib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace jae.euler.test.level04
{
    public class E079PasscodeDerivationUnitTest
    {

      
        private int[] ReadTable()
        {
            int[] table = new int[50];

            int linenr = 0;
            foreach (var line in File.ReadAllLines(@"DataFiles\p079_keylog.txt"))
            {
                table[linenr++] = int.Parse(line);
            }

            return table;
        }
  

        [Fact]
        public void Solution()
        {
            /*
               determine the shortest possible secret passcode of unknown length.
            */

            var table = ReadTable();

            var sut = new E079PasscodeDerivation();
            Assert.Equal(73162890, sut.GetShortestPossiblePasscode(table));

            /*
                Congratulations, the answer you gave to problem 79 is correct.
                You are the 37238th person to have solved this problem.
                This problem had a difficulty rating of 5%. 
            */
        }
    }
}
