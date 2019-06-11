using jae.euler.lib;
using System.Text.RegularExpressions;
using Xunit;

namespace jae.euler.test.level09
{
    public class E205DiceGameUnitTest
    {
        [Fact]
        public void Test_1()
        {
            var sut = new E205DiceGame();
        }
     

        [Fact]
        public void Solution()
        {
            /*
               What is the probability that Pyramidal Pete beats Cubic Colin? 
               Give your answer rounded to seven decimal places in the form 0.abcdefg
            */

            var sut = new E205DiceGame();
            Assert.Equal("0,5731441", sut.GetProbablitityPyramidalBeatsCubic());

            /*
             Congratulations, the answer you gave to problem 205 is correct.
             You are the 13152nd person to have solved this problem.
             This problem had a difficulty rating of 15%.

            */
        }
    }
}
