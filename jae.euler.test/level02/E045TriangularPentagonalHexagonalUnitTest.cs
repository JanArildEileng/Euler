using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test.level02
{
    public class E045TriangularPentagonalHexagonalUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
                    It can be verified that T285 = P165 = H143 = 40755.
             */
            var sut = new E045TriangularPentagonalHexagonal();
            Assert.Equal(40755, sut.GetNext(284));
        }


        [Fact]
        public void Solution()
        {
            /*
            Find the next triangle number that is also pentagonal and hexagonal.          */

            var sut = new E045TriangularPentagonalHexagonal();

            Assert.Equal(1533776805, sut.GetNext(286));

            /*
               Congratulations, the answer you gave to problem 45 is correct.
                You are the 62897th person to have solved this problem.
             */
        }
    }


}
