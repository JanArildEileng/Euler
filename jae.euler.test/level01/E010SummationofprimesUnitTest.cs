using jae.euler.lib;
using System;
using Xunit;

namespace jae.euler.test.level01
{
    public class E010SummationofprimesUnitTest
    {


        [Fact]
        public void Test1()
        {
            /*
            The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
           */

            var sut = new E010Summationofprimes();

            long expected = 17;
            var value = sut.GetSum(below:10);
            Assert.Equal(expected, value);
        }

        [Fact]
        public void Solution()
        {
            /*
             Find the sum of all the primes below two million.
            */

            var sut = new E010Summationofprimes();

            long expected = 142913828922;
            var value = sut.GetSum(below: 2000000);
            Assert.Equal(expected, value);


            /*
                Congratulations, the answer you gave to problem 10 is correct.
                You are the 287329th person to have solved this problem.
                You have earned 1 new award:
                Decathlete: Solve ten consecutive problems
            */

        }
    }
}
