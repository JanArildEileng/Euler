using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E047DistinctprimesfactorsUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
            the first two consecutive numbers to have two distinct prime factors are:

             14 = 2 × 7
             15 = 3 × 5          
             the first three consecutive numbers to have three distinct prime factors are:

            644 = 2² × 7 × 23
            645 = 3 × 5 × 43
            646 = 2 × 17 × 19.

            */
            var sut = new E047Distinctprimesfactors();

            Assert.Equal(14, sut.GetFirstConsecutivenumberWith(primefactors:2,numberConsecutive:2));
            Assert.Equal(644, sut.GetFirstConsecutivenumberWith(primefactors: 3,numberConsecutive:3));

        }


        [Fact]
        public void Solution()
        {
            /*
           Find the first four consecutive integers to have four distinct prime factors each. What is the first of these numbers?             
             */

            var sut = new E047Distinctprimesfactors();

            Assert.Equal(134043, sut.GetFirstConsecutivenumberWith(primefactors: 4, numberConsecutive: 4));

            /*
                 Congratulations, the answer you gave to problem 47 is correct.

                    You are the 50779th person to have solved this problem.
             */
        }
    }


}
