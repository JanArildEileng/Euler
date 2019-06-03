using jae.euler.lib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace jae.euler.test.level04
{
    public class E098AnagramicSquaresUnitTest
    {

        private List<string> GetWordsFromFile()
        {
            var filecontents = File.ReadAllText("DataFiles\\p098_words.txt");
            var nameListe = filecontents.Split(new char[] { ',' });
            var names = nameListe.ToList().Select(e => e.Replace('\"', ' ').Replace('"', ' ').Trim()).ToList();
            return names;
        }


        [Fact]
        public void Test_FileRead()
        {
            var words = GetWordsFromFile();
            Assert.Equal(1786, words.Count());
            Assert.Equal(11, words.Select(w => w.ToCharArray().Distinct().Count()).Max());
            Assert.Equal("RESPONSIBILITY", words.OrderBy(w => w.ToCharArray().Distinct().Count()).Last());
            Assert.Equal("YOUTH", words.Last());
        }


        [Fact]
        public void Test_CARE()
        {
            /*
             *     CARE with 1, 2, 9, and 6 respectively, we form a square number: 1296 = 362.
                   the anagram, RACE, also forms a square number: 9216 = 962. 
             */
            var sut = new E098AnagramicSquares();
            var words = new List<string> { "ABOVE", "ABSENCE", "ABSOLUTELY", "ACADEMIC", "ACCEPT", "ACCESS", "ACCIDENT", "ACCOMPANY", "RACE", "CARRER", "CARE", "ADMINISTRATION" };
            Assert.Equal(9216, sut.GetLargestSqureNumber(words));
        }

        [Fact]
        public void Solution()
        {
            /*
               What is the largest square number formed by any member of such a pair?
            */
            var words = GetWordsFromFile();
            var sut = new E098AnagramicSquares();
            Assert.Equal(18769, sut.GetLargestSqureNumber(words));


            /*
                Congratulations, the answer you gave to problem 98 is correct.
                You are the 9674th person to have solved this problem.
                This problem had a difficulty rating of 35%. 
            */
        }
    }
}
