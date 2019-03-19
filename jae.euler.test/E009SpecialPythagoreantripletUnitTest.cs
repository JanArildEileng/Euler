using jae.euler.lib;
using System;
using Xunit;

namespace jae.euler.test
{
    public class E009SpecialPythagoreantripletUnitTest
    {


        [Fact]
        public void Test1()
        {
            /*
            A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
           */

            var sut = new E9SpecialPythagoreantriplet();

            long expected = 3*4*5;
            var value = sut.GetProductWhereSum(3+4+5);
            Assert.Equal(expected, value);
        }

        [Fact]
        public void Solution()
        {
            /*
              here exists exactly one Pythagorean triplet for which a + b + c = 1000.
                Find the product abc.
            */

            var sut = new E9SpecialPythagoreantriplet();

            long expected = 31875000;
            var value = sut.GetProductWhereSum(1000);
            Assert.Equal(expected, value);

            /*
                Congratulations, the answer you gave to problem 9 is correct.

                You are the 313879th person to have solved this problem.
            */

        }
    }
}
