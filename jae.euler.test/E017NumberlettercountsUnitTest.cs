using jae.euler.lib;
using System;
using Xunit;
using System.Linq;
using System.Text;

namespace jae.euler.test
{
    public class E017NumberlettercountsUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
            If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
                
           NOTE: Do not count spaces or hyphens. 
           For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. 
           The use of "and" when writing out numbers is in compliance with British usage. 

            */

            var sut = new E017Numberlettercounts();




            int lettersusedExcepted = 19;
        

            var lettersused = sut.GetLettersused(from:1,to:5);
            Assert.Equal(lettersusedExcepted, lettersused);
     
        }

        [Fact]
        public void Solution()
        {
            /*
                If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
            */

            var sut = new E017Numberlettercounts();
            int lettersusedExcepted = 21124;


            var lettersused = sut.GetLettersused(from: 1, to: 1000);
            Assert.Equal(lettersusedExcepted, lettersused);



            /*
                Congratulations, the answer you gave to problem 17 is correct.

                You are the 133676th person to have solved this problem.
            */

        }


    }
}
