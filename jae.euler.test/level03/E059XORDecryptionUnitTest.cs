using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace jae.euler.test.level03
{
    public class E059XORDecryptionUnitTest
    {

        private List<int> GetNamesFromFile()
        {
            /*
                Using names.txt (right click and 'Save Link/Target As...'),
                a 46K text file containing over five-thousand first names, 
            */

            var filecontents = File.ReadAllText("DataFiles\\p059_cipher.txt");
            var charListe = filecontents.Split(new char[] { ',' });
            var cipherListe = charListe.Select(e=> int.Parse(e)).ToList();
            return cipherListe;
        }


        [Fact]
        public void Test1()
        {
            /*
                   For example, uppercase A = 65, asterisk (*) = 42, and lowercase k = 107.
            */
            var sut = new E059XORDecryption();

            Assert.Equal('k', sut.GetXor('A', '*'));

            List<int> cipherListe = GetNamesFromFile();
        }


        [Fact]
        public void Solution()
        {
            /*
              find the sum of the ASCII values in the original text.
            */

            List<int> cipherListe = GetNamesFromFile();

       

            var sut = new E059XORDecryption();
            Assert.Equal(129448, sut.GetSumAssicOfDekryptetText(cipherListe));


            /*
               Congratulations, the answer you gave to problem 59 is correct.

                You are the 36531st person to have solved this problem.
            */
        }
    }


}
