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
            /*
                Using names.txt (right click and 'Save Link/Target As...'),
                a 46K text file containing over five-thousand first names, 
            */

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
            Assert.Equal(11, words.Select(w=>w.ToCharArray().Distinct().Count() ).Max());

            Assert.Equal("RESPONSIBILITY", words.OrderBy(w => w.ToCharArray().Distinct().Count()).Last());

          

            //Assert.Equal("RESPONSIBILITY", "RESPONSIBILITY".ToCharArray().Distinct().ToString());

            Assert.Equal("YOUTH", words.Last());

        }



        [Fact]
        public void Test_CARE()
        {
            /*
             *     CARE with 1, 2, 9, and 6 respectively, we form a square number: 1296 = 362.
             */
            var sut = new E098AnagramicSquares();
            var words = new List<string> { "ABOVE", "ABSENCE", "ABSOLUTELY", "ACADEMIC", "ACCEPT", "ACCESS", "ACCIDENT", "ACCOMPANY",
                 "RACE", "CARRER" ,"CARE","ADMINISTRATION"};
            Assert.Equal(9216, sut.GetLargestSqureNumber(words));

            //         Assert.Equal(9216, sut.GetSquareNumber("CARE", words));
        }




        [Fact]
        public void Test_GUEST()
        {
            /*
             *     CARE with 1, 2, 9, and 6 respectively, we form a square number: 1296 = 362.
             */
            var sut = new E098AnagramicSquares();
            var words = new List<string> { "GUEST", "ABSENCE", "SUGGEST", "ACADEMIC"};
            Assert.Equal(8311689, sut.GetLargestSqureNumber(words));

            words = new List<string> { "SUGGEST", "ACADEMIC","GUEST", "ABSENCE", };
            Assert.Equal(8311689, sut.GetLargestSqureNumber(words));




            //         Assert.Equal(9216, sut.GetSquareNumber("CARE", words));
        }
        


        [Fact]
        public void Test_AGREEMENT()
        {
            /*
             *     CARE with 1, 2, 9, and 6 respectively, we form a square number: 1296 = 362.
             */
            var sut = new E098AnagramicSquares();
            var words = new List<string> { "AGREEMENT", "ABSENCE", "GAME", "ACADEMIC" };
            Assert.Equal(152448409, sut.GetLargestSqureNumber(words));

           



            //         Assert.Equal(9216, sut.GetSquareNumber("CARE", words));
        }

        [Fact]
        public void Test_ADMINISTRATION()
        {
           
            var words = GetWordsFromFile();
            var sut = new E098AnagramicSquares();
  //          Assert.Equal(9216, sut.GetSquareNumber("ADMINISTRATION", words));
        }
        



        [Fact]
        public void Test_RESPONSIBILITY()
        {
            /*
             *     CARE with 1, 2, 9, and 6 respectively, we form a square number: 1296 = 362.
             */

            var sut = new E098AnagramicSquares();
        
        }

        [Fact]
        public void Solution()
        {
            /*
               What is the largest square number formed by any member of such a pair?
            */
            var words = GetWordsFromFile();
            var sut = new E098AnagramicSquares();
            Assert.Equal(-1, sut.GetLargestSqureNumber(words));
           // 46072905316

            /*
                Congratulations, the answer you gave to problem 77 is correct.
                You are the 16527th person to have solved this problem.
                This problem had a difficulty rating of 25%.
            */
        }
    }
}
