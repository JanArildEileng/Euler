using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test.level02
{
    public class E026ReciprocalcyclesUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
           It can be seen that 1/7 has a 6-digit recurring cycle.
            */

            var sut = new E026Reciprocalcycles();
            int denominator = sut.Getlongestrecurringcycledenominator(maxdenominator: 10);
            Assert.Equal(7, denominator);
        }

        [Fact]
        public void Solution()
        {
            /*
            Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
             */

            var sut = new E026Reciprocalcycles();
            int denominator = sut.Getlongestrecurringcycledenominator(maxdenominator: 1000);
            Assert.Equal(983, denominator);


            /*
               Congratulations, the answer you gave to problem 26 is correct.

                You are the 73827th person to have solved this problem.
            */
        }
    }
}
