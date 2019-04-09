using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace jae.euler.test
{
    public class E042CodedtrianglenumbersUnitTest
    {

        [Fact]
        public void ReadDataFileTest()
        {
            var words = GetNamesFromFile();
            Assert.Equal(1786, words.Count);
            Assert.Equal("ABILITY", words[1]);

            Assert.Equal("YOUTH", words.Last());

        }

        private List<string> GetNamesFromFile()
        {
            /*
                Using words.txt (right click and 'Save Link/Target As...'),
                a 16K text file containing nearly two-thousand common English words,
            */

            var filecontents = File.ReadAllText("DataFiles\\p042_words.txt");
            var nameListe = filecontents.Split(new char[] { ',' });
            var names = nameListe.ToList().Select(e => e.Replace('\"', ' ').Replace('"', ' ').Trim()).ToList();
            return names;
        }


        [Fact]
        public void Test1()
        {
            /*
   The nth term of the sequence of triangle numbers is given by, tn = ½n(n+1); so the first ten triangle numbers are:

1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we form a word value. 
For example, the word value for SKY is 19 + 11 + 25 = 55 = t10. 
If the word value is a triangle number then we shall call the word a triangle word.      
*/

            var sut = new E042Codedtrianglenumbers(3);


            var names = GetNamesFromFile();

            Assert.True(sut.IsTriangleWord("SKY"));
            Assert.False(sut.IsTriangleWord("JAN"));
         

      
        }


        [Fact]
        public void Solution()
        {
            /*
              Using words.txt (right click and 'Save Link/Target As...'), a 16K text file containing nearly two-thousand common English words, 
              how many are triangle words?
            */

            var sut = new E042Codedtrianglenumbers(GetNamesFromFile().Select(n=>n.Length).Max());
        
            Assert.Equal(162, sut.GetNumberOfTriangleWords(GetNamesFromFile()));

            /*
              Congratulations, the answer you gave to problem 42 is correct.

                You are the 65953rd person to have solved this problem.
            */
        }
    }
}
