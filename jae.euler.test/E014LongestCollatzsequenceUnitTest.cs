using jae.euler.lib;
using System;
using Xunit;
using System.Linq;

namespace jae.euler.test
{
    public class E014LongestCollatzsequenceUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
              Using the rule above and starting with 13, we generate the following sequence:

                13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1       
                 
            */

            var sut = new E014LongestCollatzsequence();

            int expectedlength = 20;
            int expectedStartingNumber = 9;


            var longeste = sut.LongestCollatzsequence(14);
            Assert.Equal(expectedlength, longeste.length);
            Assert.Equal(expectedStartingNumber, longeste.startingNumber);

        }

        [Fact]
        public void Solution()
        {
            /*
           Which starting number, under one million, produces the longest chain?      
            */

            var sut = new E014LongestCollatzsequence();

            var longeste = sut.LongestCollatzsequence(1000000);

            int expectedlength = 525;
            int expectedStartingNumber = 837799;
            Assert.Equal(expectedStartingNumber, longeste.startingNumber);

            Assert.Equal(expectedlength, longeste.length);

            


            /*
                Congratulations, the answer you gave to problem 14 is correct.

                You are the 199717th person to have solved this problem.
            */

        }


    }
}
