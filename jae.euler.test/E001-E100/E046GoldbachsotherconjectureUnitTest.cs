using jae.euler.lib;
using Xunit;
using jae.euler.math;

namespace jae.euler.test
{
    public class E046GoldbachsotherconjectureUnitTest
    {

        [Fact]
        public void Test1()
        {
            /*
             It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.     
                */
            var sut = new E046Goldbachsotherconjecture();
      
        }


        [Fact]
        public void Solution()
        {
            /*
            What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?              
             */

            var sut = new E046Goldbachsotherconjecture();

            Assert.Equal(5777, sut.GetSmallestOddCompisteNotSum());

            /*
                 Congratulations, the answer you gave to problem 46 is correct.
                You are the 53826th person to have solved this problem.
             */
        }
    }


}
