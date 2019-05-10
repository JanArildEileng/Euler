using jae.euler.lib;
using Xunit;
using jae.euler.math;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace jae.euler.test.level03
{
    public class E074DigitFactorialChainsUnitTest
    {

      

        [Fact]
        public void Test_SumFactorialOfItsDigits()
        {
            /* The number 145 is well known for the property that the sum of the factorial of its digits is equal to 145: */
            var sut = new E074DigitFactorialChains();
            Assert.Equal(145, sut.SumFactorialOfItsDigits(145));
        }

        [Fact]
        public void Test_ChainLoopLength()
        {
            /* The number 145 is well known for the property that the sum of the factorial of its digits is equal to 145: */
            var sut = new E074DigitFactorialChains();
            Assert.Equal(3, sut.ChainLoopLength(169));
            Assert.Equal(2, sut.ChainLoopLength(871));
            Assert.Equal(2, sut.ChainLoopLength(872));
            Assert.Equal(5, sut.ChainLoopLength(69));
            Assert.Equal(4, sut.ChainLoopLength(78));
            Assert.Equal(2, sut.ChainLoopLength(540));
            
        } 


        [Fact]
        public void Solution()
        {
            /*
           How many chains, with a starting number below one million, contain exactly sixty non-repeating terms?
            */

            var sut = new E074DigitFactorialChains();
            Assert.Equal(402, sut.GetNumberOfChains(length:60, below: 1000000));

            /*
              Congratulations, the answer you gave to problem 74 is correct.
              You are the 23314th person to have solved this problem.
              This problem had a difficulty rating of 15%
            */
        }
    }
}
