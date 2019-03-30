using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E023NonabundantsumsUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
              As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16,
              the smallest number that can be written as the sum of two abundant numbers is 24. 
            */

            Assert.True(Divisors.IsAbundantNumber(12));

            var sut = new E023Nonabundantsums();
            long nonabundantsumExpected = 276;
            long nonabundantsum = sut.GetNonabundantsum(to: 23);
            Assert.Equal(nonabundantsumExpected, nonabundantsum);

            //24 kan skrive som sum
            nonabundantsum = sut.GetNonabundantsum(to: 24);
            Assert.Equal(nonabundantsumExpected, nonabundantsum);



        }

        [Fact]
        public void Solution()
        {
            /*
              Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
            */

            var sut = new E023Nonabundantsums();
            long nonabundantsumExpected =   4179871;
            long nonabundantsum = sut.GetNonabundantsum(to: 28123);
            Assert.Equal(nonabundantsumExpected, nonabundantsum);



            /*
            Congratulations, the answer you gave to problem 23 is correct.

            You are the 91494th person to have solved this problem.
            */
        }
    }
}
