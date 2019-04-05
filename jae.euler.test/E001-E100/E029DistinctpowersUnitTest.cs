using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E029DistinctpowersUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
             Consider all integer combinations of ab for 2 ≤ a ≤ 5 and 2 ≤ b ≤ 5:   
                If they are then placed in numerical order, with any repeats removed, we get the following sequence of 15 distinct terms:
            */

            var sut = new E029Distinctpowers();

            Assert.Equal(15, sut.GetNumberOfDistinctTerms(amax:5,bmax:5));          
        }

        [Fact]
        public void Solution()
        {
            /*
                 ab for 2 ≤ a ≤ 100 and 2 ≤ b ≤ 100?
             */

            var sut = new E029Distinctpowers();

            Assert.Equal(9183, sut.GetNumberOfDistinctTerms(amax: 100, bmax: 100));


            /*
                Congratulations, the answer you gave to problem 29 is correct.

                You are the 92643rd person to have solved this problem.
            */
        }
    }
}
