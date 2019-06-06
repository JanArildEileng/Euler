using jae.euler.lib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace jae.euler.test.level04
{
    public class E089RomanNumeralsUnitTest
    {
        /*
            M =1000
            D=  500
            C=  100
            L=   50
            X=   10
            V=    5
            I=    1
       */


        private string[] ReadFile()
        {
            string[] lines = File.ReadAllLines(@"DataFiles\p089_roman.txt");
      
            return lines;
        }


    

      
        
     



        [Fact]
        public void Test_1()
        {
           
            string[] lines = {
                "IIII"  // -> IV saves 2
                ,"XIIII"  // -> XIV saves 2
            }; 
            var sut = new E089RomanNumerals();
            Assert.Equal(4, sut.FindNumberCharactersSaved(lines));


         

        }



        [Fact]
        public void Solution()
        {
            /*
             Find the number of characters saved by writing each of these in their minimal form.
            */

            string[] lines = ReadFile();

            var sut = new E089RomanNumerals();
            Assert.Equal(743, sut.FindNumberCharactersSaved(lines));

            /*
             * 
             * Congratulations, the answer you gave to problem 89 is correct.
               You are the 18842nd person to have solved this problem.
               This problem had a difficulty rating of 20%. 
                You have earned 1 new award:
                As Easy As Pi: Solve problems 3, 14, 15, 92, 65, 35, 89, 79, 32, 38, and 46
            */
        }
    }
}
