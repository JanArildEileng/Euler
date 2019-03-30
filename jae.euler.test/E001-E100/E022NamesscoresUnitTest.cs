using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace jae.euler.test
{
    public class E022NamesscoresUnitTest
    {

        [Fact]
        public void ReadDataFileTest()
        {
            var names = GetNamesFromFile();
            Assert.Equal(5163, names.Count);
            Assert.Equal(4, names[0].Length);

        }

        private List<string> GetNamesFromFile()
        {
            /*
                Using names.txt (right click and 'Save Link/Target As...'),
                a 46K text file containing over five-thousand first names, 
            */

            var filecontents = File.ReadAllText("DataFiles\\p022_names.txt");
            var nameListe = filecontents.Split(new char[] { ',' });
            var names = nameListe.ToList().Select(e => e.Replace('\"', ' ').Replace('"', ' ').Trim()).ToList();
            return names;
        }


        [Fact]
        public void Test1()
        {
            /*
       
              begin by sorting it into alphabetical order. 
             Then working out the alphabetical value for each name, 
               multiply this value by its alphabetical position in the list to obtain a name score.

             For example, when the list is sorted into alphabetical order,
             COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.
             So, COLIN would obtain a score of 938 × 53 = 49714.        
        */

            var sut = new E022Namesscores();


            var names = GetNamesFromFile();

            Assert.Equal(1, sut.GetNamesscores(new List<string>() { "A" }));
            Assert.Equal(3, sut.GetNamesscores(new List<string>() { "AB" }));
            Assert.Equal(53, sut.GetNamesscores(new List<string>() { "COLIN" }));

      
        }


        [Fact]
        public void Solution()
        {
            /*
              What is the total of all the name scores in the file?
            */

            var sut = new E022Namesscores();
            long Namesscores = sut.GetNamesscores(GetNamesFromFile());
            Assert.Equal(871198282, Namesscores);

            /*
                Congratulations, the answer you gave to problem 22 is correct.

                You are the 118849th person to have solved this problem.
            */
        }
    }
}
