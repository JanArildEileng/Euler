using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E048SelfpowersUnitTes
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

            Assert.Equal(10405071317, sut.GetLastTenDigits(topower: 1000));

            /*
                 Congratulations, the answer you gave to problem 47 is correct.

                    You are the 50779th person to have solved this problem.
             */
        }
    }


}
