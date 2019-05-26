using jae.euler.lib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace jae.euler.test.level04
{
    public class E099LargestExponentialUnitTest
    {

        private List<string> GetExpNumbersFromFile()
        {
            var filecontents = File.ReadAllLines("DataFiles\\p099_base_exp.txt");         
            return filecontents.ToList();
        }


        [Fact]
        public void Test_GetExpNumbersFromFile()
        {
            var lines = GetExpNumbersFromFile();
            Assert.Equal(1000, lines.Count());    
        }


        [Fact]
        public void Test_01()
        {
            /*
             *   
                632382,518061 > 519432,525806
             */
            var sut = new E099LargestExponential();
            var expNumbers = new List<string> { "519432,525806", "632382,518061" };
            Assert.Equal(2, sut.GetLineWithLargestNumber(expNumbers));
        }
      
        [Fact]
        public void Solution()
        {
            /*
               determine which line number has the greatest numerical value.
            */
            var expNumbers = GetExpNumbersFromFile();
            var sut = new E099LargestExponential();
            Assert.Equal(709, sut.GetLineWithLargestNumber(expNumbers));


            /*
                Congratulations, the answer you gave to problem 99 is correct.
                You are the 26931st person to have solved this problem.
                This problem had a difficulty rating of 10%. 
            */
        }
    }
}
