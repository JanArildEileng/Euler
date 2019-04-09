using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E048SelfpowersUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
           The series, 11 + 22 + 33 + ... + 1010 = 10405071317.
            */
            var sut = new E048Selfpowers();

            Assert.Equal(405071317, sut.GetLastTenDigits(topower:10));

        }


        [Fact]
        public void Solution()
        {
            /*
                Find the last ten digits of the series, 11 + 22 + 33 + ... + 10001000.   
             */

            var sut = new E048Selfpowers();
            Assert.Equal(9110846700, sut.GetLastTenDigits(topower: 1000));

            /*
                Congratulations, the answer you gave to problem 48 is correct.
                You are the 100543rd person to have solved this problem.
             */
        }
    }


}
