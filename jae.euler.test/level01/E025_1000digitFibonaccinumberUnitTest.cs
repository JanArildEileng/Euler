using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test.level01
{
    public class E025_1000digitFibonaccinumberUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
                The 12th term, F12, is the first term to contain three digits.
            */

            var sut = new E025_1000digitFibonaccinumber();

            Assert.Equal(12, sut.GetIndexOfFirstTerm(numberOfdigits: 3));
        }

        [Fact]
        public void Solution()
        {
            /*
             What is the index of the first term in the Fibonacci sequence to contain 1000 digits?
             */

            var sut = new E025_1000digitFibonaccinumber();

            Assert.Equal(4782, sut.GetIndexOfFirstTerm(numberOfdigits: 1000));

            /*
               Congratulations, the answer you gave to problem 25 is correct.

                You are the 137634th person to have solved this problem.
                Nice work, janei, you've just advanced to Level 1 . 
                106777 members (11.92%) have made it this far.
            */
        }
    }
}
